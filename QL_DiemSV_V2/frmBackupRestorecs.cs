using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace QL_DiemSV_V2
{
    public partial class frmBackupRestorecs : Form
    {
        public frmBackupRestorecs()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        Writelog wl;
        public void serverName(string str)
        {
            con = new SqlConnection("Data Source=" + str + ";Database=Master;data source=.; uid=sa; pwd=sql2014;");
            con.Open();
            cmd = new SqlCommand("select *  from sysservers  where srvproduct='SQL Server'", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cboSevername.Items.Add(dr[2]);
            }
            dr.Close();
        }
        public void Createconnection()
        {
            con = new SqlConnection("Data Source=" + (cboSevername.SelectedItem.ToString()) + ";Database=Master;data source=.; uid=sa; pwd=sql2014;");
            con.Open();
            cbodatabaseanme.Items.Clear();
            cmd = new SqlCommand("select * from sysdatabases", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbodatabaseanme.Items.Add(dr[0]);
            }
            dr.Close();
        }
        public void query(string que)
        {
            // ERROR: Not supported in C#: OnErrorStatement
            cmd = new SqlCommand(que, con);
            cmd.ExecuteNonQuery();
        }
        public void blank(string str)
        {
            if (string.IsNullOrEmpty(cboSevername.Text) | string.IsNullOrEmpty(cboSevername.Text))
            {
                // label3.Visible = true;
                MessageBox.Show("Server Name & Database can not be Blank");
                return;
            }
            else
            {
                if (str == "backup")
                {
                    saveFileDialog1.FileName = cbodatabaseanme.Text+"-"+DateTime.Now.ToString("yyyy-MM-dd--HH--mm-ss")+".bak";
                    saveFileDialog1.ShowDialog();
                    string s = "";
                    
                    s = saveFileDialog1.FileName;
                    query("Backup database " + cbodatabaseanme.Text + " to disk='" + s + "'");
                    label3.Visible = true;
                    label3.Text = "Database BackUp has been created successful";
                }
            }
        }
        private void ibtnBrowse1_Click(object sender, EventArgs e)
        {
           
        }

        private void ibtnBrowse2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "backup files (*.bak)|*.bak";
            dlg.Title = "Database restore";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtPath2.Text = dlg.FileName;
                ibtnRestore.Enabled = true;
            }
        }

        private void ibtnBackup_Click(object sender, EventArgs e)
        {
            blank("backup");
            MessageBox.Show("QT Backup dữ liệu đã hoàn tất", "Thong báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            wl = new Writelog("AD", "", "Backup", "");
        }

        private void ibtnRestore_Click(object sender, EventArgs e)
        {
            pg.Value = 0;
            try
            {
                Server server = new Server(new ServerConnection(".", "sa", "sql2014"));
                Restore restore = new Restore() { Database = "QLSV_DIEMSV", Action = RestoreActionType.Database, ReplaceDatabase = true, NoRecovery=false };
                restore.Devices.AddDevice(txtPath2.Text, DeviceType.File);
                restore.PercentComplete += Restore_PercentComplete;
                restore.Complete += Restore_Complete;
                restore.SqlRestoreAsync(server);
                MessageBox.Show("QT Restore dữ liệu đã hoàn tất", "Thong báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                wl = new Writelog("AD", "", "Restore", "");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Restore_Complete(object sender, ServerMessageEventArgs e)
        {
            if (e.Error != null)
            {
                labpercent.Invoke((MethodInvoker)delegate
                {
                    labpercent.Text = e.Error.Message;
                });
            }
        }

        private void Restore_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            pg.Invoke((MethodInvoker)delegate{
                pg.Value = e.Percent;
                pg.Update();
            });
            pg.Invoke((MethodInvoker)delegate {
                labpercent.Text = $"{e.Percent}%";
            });
        }

        private void frmBackupRestorecs_Load(object sender, EventArgs e)
        {
            serverName(".");
        }

        private void cboSevername_SelectedIndexChanged(object sender, EventArgs e)
        {
            Createconnection();
        }
    }
}
