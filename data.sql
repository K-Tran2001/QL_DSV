sql_QL_DiemSV.sql
USE [master]
GO
/****** Object:  Database [QL_DiemSV]    Script Date: 5/28/2022 1:56:13 PM ******/
CREATE DATABASE [QL_DiemSV]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QL_DiemSV', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QL_DiemSV.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QL_DiemSV_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QL_DiemSV_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QL_DiemSV] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QL_DiemSV].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QL_DiemSV] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QL_DiemSV] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QL_DiemSV] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QL_DiemSV] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QL_DiemSV] SET ARITHABORT OFF 
GO
ALTER DATABASE [QL_DiemSV] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QL_DiemSV] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QL_DiemSV] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QL_DiemSV] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QL_DiemSV] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QL_DiemSV] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QL_DiemSV] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QL_DiemSV] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QL_DiemSV] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QL_DiemSV] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QL_DiemSV] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QL_DiemSV] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QL_DiemSV] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QL_DiemSV] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QL_DiemSV] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QL_DiemSV] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QL_DiemSV] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QL_DiemSV] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QL_DiemSV] SET  MULTI_USER 
GO
ALTER DATABASE [QL_DiemSV] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QL_DiemSV] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QL_DiemSV] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QL_DiemSV] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QL_DiemSV] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QL_DiemSV]
GO
/****** Object:  Table [dbo].[CTDKHP]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTDKHP](
	[maSV] [nvarchar](50) NOT NULL,
	[maHP] [nvarchar](50) NOT NULL,
	[tgDK] [datetime] NULL,
 CONSTRAINT [pk_ctdkhp] PRIMARY KEY CLUSTERED 
(
	[maSV] ASC,
	[maHP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CTGIANGDAY]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTGIANGDAY](
	[maGV] [nvarchar](50) NOT NULL,
	[maHP] [nvarchar](50) NOT NULL,
	[tgHoc] [nvarchar](50) NULL,
 CONSTRAINT [fk_ctgd] PRIMARY KEY CLUSTERED 
(
	[maGV] ASC,
	[maHP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CTNOHP]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTNOHP](
	[maSV] [nvarchar](50) NULL,
	[maHP] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DataProvider]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DataProvider](
	[Provider] [nvarchar](50) NULL,
	[SV] [nvarchar](50) NULL,
	[DB] [nvarchar](50) NULL,
	[userName] [nvarchar](50) NULL,
	[pass] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DKHP]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DKHP](
	[maSV] [nvarchar](50) NULL,
	[maHK] [nvarchar](50) NULL,
	[tongTC] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GIAOVIEN]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GIAOVIEN](
	[maGV] [nvarchar](50) NOT NULL,
	[tenGV] [nvarchar](50) NULL,
	[ngaySinh] [datetime] NULL,
	[gioiTinh] [nvarchar](3) NULL,
	[diaChi] [nvarchar](50) NULL,
	[dienThoai] [nvarchar](10) NULL,
	[eMail] [nvarchar](50) NULL,
 CONSTRAINT [PK_GIAOVIEN] PRIMARY KEY CLUSTERED 
(
	[maGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HOCKY]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOCKY](
	[maHK] [nvarchar](50) NOT NULL,
	[tenHK] [nvarchar](50) NULL,
 CONSTRAINT [PK_HOCKY] PRIMARY KEY CLUSTERED 
(
	[maHK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HOCPHAN]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOCPHAN](
	[maHP] [nvarchar](50) NOT NULL,
	[tenHP] [nvarchar](50) NULL,
	[soTC] [int] NULL,
	[maHK] [nvarchar](50) NULL,
 CONSTRAINT [PK_HOCPHAN] PRIMARY KEY CLUSTERED 
(
	[maHP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KQHT_HK]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KQHT_HK](
	[maSV] [nvarchar](50) NOT NULL,
	[maHP] [nvarchar](50) NOT NULL,
	[lanThi] [int] NULL,
	[diemThi] [float] NULL,
	[diemQT] [float] NULL,
	[diemTB] [float] NULL,
	[xepLoai] [nvarchar](50) NULL,
	[trangThai] [nvarchar](50) NULL,
 CONSTRAINT [pk_kqht] PRIMARY KEY CLUSTERED 
(
	[maSV] ASC,
	[maHP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LOP]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOP](
	[maLop] [nvarchar](50) NOT NULL,
	[tenLop] [nvarchar](50) NULL,
	[ngayKhaiGiang] [datetime] NULL,
	[maCN] [nvarchar](50) NULL,
 CONSTRAINT [PK_LOP] PRIMARY KEY CLUSTERED 
(
	[maLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SINHVIEN]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SINHVIEN](
	[maSV] [nvarchar](50) NOT NULL,
	[tenSV] [nvarchar](50) NULL,
	[gioiTinh] [nvarchar](3) NULL,
	[ngaySinh] [datetime] NULL,
	[diaChi] [nvarchar](50) NULL,
	[dienThoai] [nvarchar](10) NULL,
	[maLop] [nvarchar](50) NULL,
 CONSTRAINT [PK_SINHVIEN] PRIMARY KEY CLUSTERED 
(
	[maSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[taiKhoan] [nvarchar](50) NOT NULL,
	[matKhau] [nvarchar](50) NULL,
	[tenTaiKhoan] [nvarchar](50) NULL,
	[loaiTaiKhoan] [nvarchar](50) NULL,
 CONSTRAINT [PK_TAIKHOAN] PRIMARY KEY CLUSTERED 
(
	[taiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[THONGBAO]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THONGBAO](
	[maSV] [nvarchar](50) NULL,
	[ndThongBao] [nvarchar](max) NULL,
	[tgThongBao] [datetime] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TTHETHONG]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TTHETHONG](
	[tinh] [nvarchar](50) NULL,
	[donViChuQuan] [nvarchar](50) NULL,
	[tenTruong] [nvarchar](50) NULL,
	[khoaHoc] [nvarchar](50) NULL,
	[nganhHoc] [nvarchar](50) NULL,
	[chuyenNganh] [nvarchar](50) NULL
) ON [PRIMARY]

GO
INSERT [dbo].[CTDKHP] ([maSV], [maHP], [tgDK]) VALUES (N'DTH195287', N'COS104', CAST(N'2022-04-16 20:50:09.350' AS DateTime))
INSERT [dbo].[CTDKHP] ([maSV], [maHP], [tgDK]) VALUES (N'DTH195287', N'COS106', CAST(N'2022-04-15 13:22:20.057' AS DateTime))
INSERT [dbo].[CTDKHP] ([maSV], [maHP], [tgDK]) VALUES (N'DTH195287', N'COS107', CAST(N'2022-04-15 13:22:20.053' AS DateTime))
INSERT [dbo].[CTDKHP] ([maSV], [maHP], [tgDK]) VALUES (N'DTH195287', N'COS302', CAST(N'2022-04-16 20:50:09.397' AS DateTime))
INSERT [dbo].[CTDKHP] ([maSV], [maHP], [tgDK]) VALUES (N'DTH195287', N'MAT105', CAST(N'2022-04-15 13:22:20.017' AS DateTime))
INSERT [dbo].[CTDKHP] ([maSV], [maHP], [tgDK]) VALUES (N'DTH195287', N'TACN', CAST(N'2022-05-14 11:21:48.097' AS DateTime))
INSERT [dbo].[CTDKHP] ([maSV], [maHP], [tgDK]) VALUES (N'DTH195289', N'COS104', CAST(N'2022-05-14 11:31:26.703' AS DateTime))
INSERT [dbo].[CTDKHP] ([maSV], [maHP], [tgDK]) VALUES (N'DTH195289', N'COS106', CAST(N'2022-05-14 11:31:26.930' AS DateTime))
INSERT [dbo].[CTDKHP] ([maSV], [maHP], [tgDK]) VALUES (N'DTH195289', N'COS107', CAST(N'2022-05-14 11:31:26.937' AS DateTime))
INSERT [dbo].[CTDKHP] ([maSV], [maHP], [tgDK]) VALUES (N'DTH195289', N'COS302', CAST(N'2022-05-14 11:31:26.947' AS DateTime))
INSERT [dbo].[CTDKHP] ([maSV], [maHP], [tgDK]) VALUES (N'DTH195289', N'COS304', CAST(N'2022-05-14 11:31:26.953' AS DateTime))
INSERT [dbo].[CTDKHP] ([maSV], [maHP], [tgDK]) VALUES (N'DTH195302', N'COS104', CAST(N'2022-04-12 15:08:29.503' AS DateTime))
INSERT [dbo].[CTDKHP] ([maSV], [maHP], [tgDK]) VALUES (N'DTH195302', N'COS106', CAST(N'2022-04-12 15:08:29.510' AS DateTime))
INSERT [dbo].[CTDKHP] ([maSV], [maHP], [tgDK]) VALUES (N'DTH195302', N'COS107', CAST(N'2022-04-12 15:08:29.513' AS DateTime))
INSERT [dbo].[CTDKHP] ([maSV], [maHP], [tgDK]) VALUES (N'DTH195302', N'COS302', CAST(N'2022-04-12 15:08:29.513' AS DateTime))
INSERT [dbo].[CTDKHP] ([maSV], [maHP], [tgDK]) VALUES (N'DTH195318', N'COS104', CAST(N'2022-04-20 08:07:22.357' AS DateTime))
INSERT [dbo].[CTDKHP] ([maSV], [maHP], [tgDK]) VALUES (N'DTH195318', N'COS107', CAST(N'2022-04-20 08:07:22.383' AS DateTime))
INSERT [dbo].[CTDKHP] ([maSV], [maHP], [tgDK]) VALUES (N'DTH195318', N'MAT105', CAST(N'2022-04-20 08:07:22.383' AS DateTime))
INSERT [dbo].[CTGIANGDAY] ([maGV], [maHP], [tgHoc]) VALUES (N'GV001', N'COS104', N'8h50-T2')
INSERT [dbo].[CTGIANGDAY] ([maGV], [maHP], [tgHoc]) VALUES (N'GV001', N'COS107', N'13h-T5')
INSERT [dbo].[CTGIANGDAY] ([maGV], [maHP], [tgHoc]) VALUES (N'GV001', N'TACN', N'T4-9h')
INSERT [dbo].[CTGIANGDAY] ([maGV], [maHP], [tgHoc]) VALUES (N'GV002', N'COS106', N'7h-T2')
INSERT [dbo].[CTGIANGDAY] ([maGV], [maHP], [tgHoc]) VALUES (N'GV004', N'COS302', N'7h-T4')
INSERT [dbo].[CTGIANGDAY] ([maGV], [maHP], [tgHoc]) VALUES (N'GV004', N'MAT105', N'T2-9h50')
INSERT [dbo].[CTGIANGDAY] ([maGV], [maHP], [tgHoc]) VALUES (N'GV009', N'COS106', N'T3-10h40')
INSERT [dbo].[CTNOHP] ([maSV], [maHP]) VALUES (N'DTH195287', N'MAT105')
INSERT [dbo].[CTNOHP] ([maSV], [maHP]) VALUES (N'DTH195287', N'COS106')
INSERT [dbo].[CTNOHP] ([maSV], [maHP]) VALUES (N'DTH195302', N'COS104')
INSERT [dbo].[CTNOHP] ([maSV], [maHP]) VALUES (N'DTH195302', N'COS106')
INSERT [dbo].[CTNOHP] ([maSV], [maHP]) VALUES (N'DTH195302', N'COS107')
INSERT [dbo].[CTNOHP] ([maSV], [maHP]) VALUES (N'DTH195302', N'COS302')
INSERT [dbo].[CTNOHP] ([maSV], [maHP]) VALUES (N'DTH195287', N'MAT105')
INSERT [dbo].[CTNOHP] ([maSV], [maHP]) VALUES (N'DTH195287', N'COS107')
INSERT [dbo].[CTNOHP] ([maSV], [maHP]) VALUES (N'DTH195287', N'COS106')
INSERT [dbo].[CTNOHP] ([maSV], [maHP]) VALUES (N'DTH195287', N'COS104')
INSERT [dbo].[CTNOHP] ([maSV], [maHP]) VALUES (N'DTH195287', N'COS302')
INSERT [dbo].[CTNOHP] ([maSV], [maHP]) VALUES (N'DTH195318', N'COS104')
INSERT [dbo].[CTNOHP] ([maSV], [maHP]) VALUES (N'DTH195318', N'COS107')
INSERT [dbo].[CTNOHP] ([maSV], [maHP]) VALUES (N'DTH195318', N'MAT105')
INSERT [dbo].[CTNOHP] ([maSV], [maHP]) VALUES (N'DTH195287', N'TACN')
INSERT [dbo].[CTNOHP] ([maSV], [maHP]) VALUES (N'DTH195289', N'COS104')
INSERT [dbo].[CTNOHP] ([maSV], [maHP]) VALUES (N'DTH195289', N'COS106')
INSERT [dbo].[CTNOHP] ([maSV], [maHP]) VALUES (N'DTH195289', N'COS107')
INSERT [dbo].[CTNOHP] ([maSV], [maHP]) VALUES (N'DTH195289', N'COS302')
INSERT [dbo].[CTNOHP] ([maSV], [maHP]) VALUES (N'DTH195289', N'COS304')
INSERT [dbo].[DataProvider] ([Provider], [SV], [DB], [userName], [pass]) VALUES (N'Demo', N'DESKTOP-KMNS09Q', N'QL_DiemSV', N'sa', N'sql2014')
INSERT [dbo].[DataProvider] ([Provider], [SV], [DB], [userName], [pass]) VALUES (N'Demo', N'DESKTOP-KMNS09Q', N'QL_DiemSV', N'sa', N'sql2014')
INSERT [dbo].[DKHP] ([maSV], [maHK], [tongTC]) VALUES (N'DTH195321', N'HK1', 0)
INSERT [dbo].[DKHP] ([maSV], [maHK], [tongTC]) VALUES (N'DTH195321', N'HK2', 0)
INSERT [dbo].[DKHP] ([maSV], [maHK], [tongTC]) VALUES (N'DTH195321', N'HK3', 0)
INSERT [dbo].[DKHP] ([maSV], [maHK], [tongTC]) VALUES (N'DTH195321', N'HK4', 0)
INSERT [dbo].[DKHP] ([maSV], [maHK], [tongTC]) VALUES (N'DTH195321', N'HK5', 0)
INSERT [dbo].[DKHP] ([maSV], [maHK], [tongTC]) VALUES (N'DTH195321', N'HK6', 0)
INSERT [dbo].[DKHP] ([maSV], [maHK], [tongTC]) VALUES (N'DTH195321', N'HK7', 0)
INSERT [dbo].[DKHP] ([maSV], [maHK], [tongTC]) VALUES (N'DTH195322', N'HK1', 0)
INSERT [dbo].[DKHP] ([maSV], [maHK], [tongTC]) VALUES (N'DTH195322', N'HK2', 0)
INSERT [dbo].[DKHP] ([maSV], [maHK], [tongTC]) VALUES (N'DTH195322', N'HK3', 0)
INSERT [dbo].[DKHP] ([maSV], [maHK], [tongTC]) VALUES (N'DTH195322', N'HK4', 0)
INSERT [dbo].[DKHP] ([maSV], [maHK], [tongTC]) VALUES (N'DTH195322', N'HK5', 0)
INSERT [dbo].[DKHP] ([maSV], [maHK], [tongTC]) VALUES (N'DTH195322', N'HK6', 0)
INSERT [dbo].[DKHP] ([maSV], [maHK], [tongTC]) VALUES (N'DTH195322', N'HK7', 0)
INSERT [dbo].[DKHP] ([maSV], [maHK], [tongTC]) VALUES (N'DTH195323', N'HK1', 0)
INSERT [dbo].[DKHP] ([maSV], [maHK], [tongTC]) VALUES (N'DTH195323', N'HK2', 0)
INSERT [dbo].[DKHP] ([maSV], [maHK], [tongTC]) VALUES (N'DTH195323', N'HK3', 0)
INSERT [dbo].[DKHP] ([maSV], [maHK], [tongTC]) VALUES (N'DTH195323', N'HK4', 0)
INSERT [dbo].[DKHP] ([maSV], [maHK], [tongTC]) VALUES (N'DTH195323', N'HK5', 0)
INSERT [dbo].[DKHP] ([maSV], [maHK], [tongTC]) VALUES (N'DTH195323', N'HK6', 0)
INSERT [dbo].[DKHP] ([maSV], [maHK], [tongTC]) VALUES (N'DTH195323', N'HK7', 0)
INSERT [dbo].[DKHP] ([maSV], [maHK], [tongTC]) VALUES (N'DTH195324', N'HK1', 0)
INSERT [dbo].[DKHP] ([maSV], [maHK], [tongTC]) VALUES (N'DTH195324', N'HK2', 0)
INSERT [dbo].[DKHP] ([maSV], [maHK], [tongTC]) VALUES (N'DTH195324', N'HK3', 0)
INSERT [dbo].[DKHP] ([maSV], [maHK], [tongTC]) VALUES (N'DTH195324', N'HK4', 0)
INSERT [dbo].[DKHP] ([maSV], [maHK], [tongTC]) VALUES (N'DTH195324', N'HK5', 0)
INSERT [dbo].[DKHP] ([maSV], [maHK], [tongTC]) VALUES (N'DTH195324', N'HK6', 0)
INSERT [dbo].[DKHP] ([maSV], [maHK], [tongTC]) VALUES (N'DTH195324', N'HK7', 0)
INSERT [dbo].[GIAOVIEN] ([maGV], [tenGV], [ngaySinh], [gioiTinh], [diaChi], [dienThoai], [eMail]) VALUES (N'GV001', N'H.C.T.Cu?ng', CAST(N'1980-01-01 00:00:00.000' AS DateTime), N'Nam', N'An Giang 2', N'0926374927', N'hctcuong@agu.edu.vn')
INSERT [dbo].[GIAOVIEN] ([maGV], [tenGV], [ngaySinh], [gioiTinh], [diaChi], [dienThoai], [eMail]) VALUES (N'GV002', N'N.T.M.Truy?n', CAST(N'1978-02-14 00:00:00.000' AS DateTime), N'Nam', N'AG', N'0362539013', N'ntmtruyen@agu.edu.vn')
INSERT [dbo].[GIAOVIEN] ([maGV], [tenGV], [ngaySinh], [gioiTinh], [diaChi], [dienThoai], [eMail]) VALUES (N'GV003', N'N.T.Du', CAST(N'1981-01-01 00:00:00.000' AS DateTime), N'Nam', N'M? Xuyên', N'0163829364', N'ntdu@agu.edu.vn')
INSERT [dbo].[GIAOVIEN] ([maGV], [tenGV], [ngaySinh], [gioiTinh], [diaChi], [dienThoai], [eMail]) VALUES (N'GV004', N'Lê Hoàng Anh', CAST(N'1985-01-01 00:00:00.000' AS DateTime), N'Nam', N'Long Xuyên', N'0278493274', N'lhanh@agu.sdu.vn')
INSERT [dbo].[GIAOVIEN] ([maGV], [tenGV], [ngaySinh], [gioiTinh], [diaChi], [dienThoai], [eMail]) VALUES (N'GV008', N'khoa tr?n van', CAST(N'2022-02-24 00:00:00.000' AS DateTime), N'N?', N'ag nabdafa', N'1234525', N'khoa@gmail.com')
INSERT [dbo].[GIAOVIEN] ([maGV], [tenGV], [ngaySinh], [gioiTinh], [diaChi], [dienThoai], [eMail]) VALUES (N'GV009', N'Lê Hoàng Anh', CAST(N'1985-01-01 00:00:00.000' AS DateTime), N'Nam', N'Long Xuyên', N'0278493274', N'lhanh@agu.sdu.vn')
INSERT [dbo].[GIAOVIEN] ([maGV], [tenGV], [ngaySinh], [gioiTinh], [diaChi], [dienThoai], [eMail]) VALUES (N'GV010', N'khavip12', CAST(N'2022-03-23 00:00:00.000' AS DateTime), N'Nam', N'Chau Doc', N'113242', N'kha@gmail.com')
INSERT [dbo].[HOCKY] ([maHK], [tenHK]) VALUES (N'HK1', N'Hoc kì 1')
INSERT [dbo].[HOCKY] ([maHK], [tenHK]) VALUES (N'HK2', N'Hoc kì 2')
INSERT [dbo].[HOCKY] ([maHK], [tenHK]) VALUES (N'HK3', N'Hoc kì 3')
INSERT [dbo].[HOCKY] ([maHK], [tenHK]) VALUES (N'HK4', N'Hoc kì 4')
INSERT [dbo].[HOCKY] ([maHK], [tenHK]) VALUES (N'HK5', N'Hoc kì 5')
INSERT [dbo].[HOCKY] ([maHK], [tenHK]) VALUES (N'HK6', N'Hoc kì 6')
INSERT [dbo].[HOCKY] ([maHK], [tenHK]) VALUES (N'HK7', N'Hoc kì 7')
INSERT [dbo].[HOCPHAN] ([maHP], [tenHP], [soTC], [maHK]) VALUES (N'COS104', N'GT Ngành CNTT', 10, N'HK1')
INSERT [dbo].[HOCPHAN] ([maHP], [tenHP], [soTC], [maHK]) VALUES (N'COS106', N'L?p trình can b?n', 4, N'HK1')
INSERT [dbo].[HOCPHAN] ([maHP], [tenHP], [soTC], [maHK]) VALUES (N'COS107', N'Nên T?ng CNTT', 2, N'HK1')
INSERT [dbo].[HOCPHAN] ([maHP], [tenHP], [soTC], [maHK]) VALUES (N'COS123', N'mon1', 4, N'HK2')
INSERT [dbo].[HOCPHAN] ([maHP], [tenHP], [soTC], [maHK]) VALUES (N'COS302', N'L?p Trình  JAVA', 5, N'HK1')
INSERT [dbo].[HOCPHAN] ([maHP], [tenHP], [soTC], [maHK]) VALUES (N'COS304', N'C?u trúc DL', 3, N'HK1')
INSERT [dbo].[HOCPHAN] ([maHP], [tenHP], [soTC], [maHK]) VALUES (N'COS456', N'mon2', 3, N'HK3')
INSERT [dbo].[HOCPHAN] ([maHP], [tenHP], [soTC], [maHK]) VALUES (N'COS890', N'mon3', 2, N'HK4')
INSERT [dbo].[HOCPHAN] ([maHP], [tenHP], [soTC], [maHK]) VALUES (N'MAT105', N'Toán A2', 3, N'HK2')
INSERT [dbo].[HOCPHAN] ([maHP], [tenHP], [soTC], [maHK]) VALUES (N'TACN', N'Tieng anh chuyen nganh', 2, N'HK2')
INSERT [dbo].[KQHT_HK] ([maSV], [maHP], [lanThi], [diemThi], [diemQT], [diemTB], [xepLoai], [trangThai]) VALUES (N'DTH195287', N'TACN', 0, 0, 0, 0, N'F', N'Chua thi')
INSERT [dbo].[KQHT_HK] ([maSV], [maHP], [lanThi], [diemThi], [diemQT], [diemTB], [xepLoai], [trangThai]) VALUES (N'DTH195289', N'COS104', 1, 8.5, 8, 8.2, N'B', N'Qua môn')
INSERT [dbo].[KQHT_HK] ([maSV], [maHP], [lanThi], [diemThi], [diemQT], [diemTB], [xepLoai], [trangThai]) VALUES (N'DTH195289', N'COS106', 1, 8.7, 9, 8.8, N'A', N'Qua môn')
INSERT [dbo].[KQHT_HK] ([maSV], [maHP], [lanThi], [diemThi], [diemQT], [diemTB], [xepLoai], [trangThai]) VALUES (N'DTH195289', N'COS107', 2, 9.9, 8, 9, N'A', N'Qua môn')
INSERT [dbo].[KQHT_HK] ([maSV], [maHP], [lanThi], [diemThi], [diemQT], [diemTB], [xepLoai], [trangThai]) VALUES (N'DTH195289', N'COS302', 1, 9.1, 7, 8, N'B', N'Qua môn')
INSERT [dbo].[KQHT_HK] ([maSV], [maHP], [lanThi], [diemThi], [diemQT], [diemTB], [xepLoai], [trangThai]) VALUES (N'DTH195289', N'COS304', 1, 8.8, 9.3, 9, N'A', N'Qua môn')
INSERT [dbo].[KQHT_HK] ([maSV], [maHP], [lanThi], [diemThi], [diemQT], [diemTB], [xepLoai], [trangThai]) VALUES (N'DTH195302', N'COS104', 1, 9.9, 8.7, 9.3, N'A', N'Qua môn')
INSERT [dbo].[KQHT_HK] ([maSV], [maHP], [lanThi], [diemThi], [diemQT], [diemTB], [xepLoai], [trangThai]) VALUES (N'DTH195302', N'COS107', 2, 8.8, 9.2, 9, N'A', N'Qua môn')
INSERT [dbo].[KQHT_HK] ([maSV], [maHP], [lanThi], [diemThi], [diemQT], [diemTB], [xepLoai], [trangThai]) VALUES (N'DTH195302', N'COS302', 1, 7.5, 9.9, 8.7, N'A', N'Qua môn')
INSERT [dbo].[KQHT_HK] ([maSV], [maHP], [lanThi], [diemThi], [diemQT], [diemTB], [xepLoai], [trangThai]) VALUES (N'DTH195318', N'COS104', 0, 9, 9, 9, N'A', N'Qua môn')
INSERT [dbo].[KQHT_HK] ([maSV], [maHP], [lanThi], [diemThi], [diemQT], [diemTB], [xepLoai], [trangThai]) VALUES (N'DTH195318', N'COS107', 1, 6, 8.8, 7.4, N'B', N'Qua môn')
INSERT [dbo].[KQHT_HK] ([maSV], [maHP], [lanThi], [diemThi], [diemQT], [diemTB], [xepLoai], [trangThai]) VALUES (N'DTH195318', N'MAT105', 1, 6.3, 9.9, 8.1, N'B', N'Qua môn')
INSERT [dbo].[LOP] ([maLop], [tenLop], [ngayKhaiGiang], [maCN]) VALUES (N'DH119TH', N'Tin h?c K19', CAST(N'2018-08-15 00:00:00.000' AS DateTime), N'GV001')
INSERT [dbo].[LOP] ([maLop], [tenLop], [ngayKhaiGiang], [maCN]) VALUES (N'DH19PM', N'Ph?n mêm K19', CAST(N'2022-05-04 09:17:00.000' AS DateTime), N'GV004')
INSERT [dbo].[LOP] ([maLop], [tenLop], [ngayKhaiGiang], [maCN]) VALUES (N'DH20PM', N'Ph?n m?m K20', CAST(N'2019-08-15 00:00:00.000' AS DateTime), N'GV002')
INSERT [dbo].[LOP] ([maLop], [tenLop], [ngayKhaiGiang], [maCN]) VALUES (N'DH20TH1', N'Tin H?c 1 K20', CAST(N'2019-08-15 00:00:00.000' AS DateTime), N'GV003')
INSERT [dbo].[LOP] ([maLop], [tenLop], [ngayKhaiGiang], [maCN]) VALUES (N'DH20TH2', N'Tin H?c 2 K20', CAST(N'2019-08-15 00:00:00.000' AS DateTime), N'GV004')
INSERT [dbo].[LOP] ([maLop], [tenLop], [ngayKhaiGiang], [maCN]) VALUES (N'DH21TA', N'Ti?ng Anh K21', CAST(N'2020-08-15 00:00:00.000' AS DateTime), N'GV008')
INSERT [dbo].[SINHVIEN] ([maSV], [tenSV], [gioiTinh], [ngaySinh], [diaChi], [dienThoai], [maLop]) VALUES (N'DTH195287', N'Tr?n Van Khoa', N'Nam', CAST(N'2000-01-01 00:00:00.000' AS DateTime), N'Ch? M?i', N'0123456789', N'DH119TH')
INSERT [dbo].[SINHVIEN] ([maSV], [tenSV], [gioiTinh], [ngaySinh], [diaChi], [dienThoai], [maLop]) VALUES (N'DTH195289', N'Nguy?n Th? An', N'N?', CAST(N'2001-01-01 00:00:00.000' AS DateTime), N'T?nh Biên', N'0123456789', N'DH20PM')
INSERT [dbo].[SINHVIEN] ([maSV], [tenSV], [gioiTinh], [ngaySinh], [diaChi], [dienThoai], [maLop]) VALUES (N'DTH195293', N'Hu?nh Th? Mai Châu', N'N?', CAST(N'2000-01-01 00:00:00.000' AS DateTime), N'An Giang', N'0123456789', N'DH119TH')
INSERT [dbo].[SINHVIEN] ([maSV], [tenSV], [gioiTinh], [ngaySinh], [diaChi], [dienThoai], [maLop]) VALUES (N'DTH195296', N'Tr?n Ð?ng H?u Duy', N'Nam', CAST(N'2000-01-01 00:00:00.000' AS DateTime), N'An Phú', N'0123456789', N'DH119TH')
INSERT [dbo].[SINHVIEN] ([maSV], [tenSV], [gioiTinh], [ngaySinh], [diaChi], [dienThoai], [maLop]) VALUES (N'DTH195299', N'Lê Tran Thu Huong', N'Nam', CAST(N'2000-01-01 00:00:00.000' AS DateTime), N'Sa Ðec', N'0123456789', N'DH119TH')
INSERT [dbo].[SINHVIEN] ([maSV], [tenSV], [gioiTinh], [ngaySinh], [diaChi], [dienThoai], [maLop]) VALUES (N'DTH195300', N'Thái Hoàng Khang', N'Nam', CAST(N'2000-01-01 00:00:00.000' AS DateTime), N'Cho M?i', N'0123456789', N'DH119TH')
INSERT [dbo].[SINHVIEN] ([maSV], [tenSV], [gioiTinh], [ngaySinh], [diaChi], [dienThoai], [maLop]) VALUES (N'DTH195301', N'Võ Duy Khang', N'Nam', CAST(N'2000-01-01 00:00:00.000' AS DateTime), N'C?u H?i', N'0123456789', N'DH119TH')
INSERT [dbo].[SINHVIEN] ([maSV], [tenSV], [gioiTinh], [ngaySinh], [diaChi], [dienThoai], [maLop]) VALUES (N'DTH195302', N'Phan Lê Duong Khang', N'Nam', CAST(N'2001-01-01 00:00:00.000' AS DateTime), N'M? Luông', N'0123456789', N'DH20TH2')
INSERT [dbo].[SINHVIEN] ([maSV], [tenSV], [gioiTinh], [ngaySinh], [diaChi], [dienThoai], [maLop]) VALUES (N'DTH195305', N'Hoàng Ng?c Lan ', N'N?', CAST(N'2000-01-01 00:00:00.000' AS DateTime), N'M? An', N'0123456789', N'DH119TH')
INSERT [dbo].[SINHVIEN] ([maSV], [tenSV], [gioiTinh], [ngaySinh], [diaChi], [dienThoai], [maLop]) VALUES (N'DTH195306', N'Hoàng Th? Ng?c Trâm', N'Nam', CAST(N'2000-01-24 00:00:00.000' AS DateTime), N'H?i An Ðông', N'0123456789', N'DH119TH')
INSERT [dbo].[SINHVIEN] ([maSV], [tenSV], [gioiTinh], [ngaySinh], [diaChi], [dienThoai], [maLop]) VALUES (N'DTH195307', N'Nguy?n Phúc Minh', N'Nam', CAST(N'2001-01-01 00:00:00.000' AS DateTime), N'Long Xuyên', N'0123456789', N'DH20TH1')
INSERT [dbo].[SINHVIEN] ([maSV], [tenSV], [gioiTinh], [ngaySinh], [diaChi], [dienThoai], [maLop]) VALUES (N'DTH195310', N'Lê Tr?n Thu Huong', N'N?', CAST(N'2002-01-01 00:00:00.000' AS DateTime), N'Sa Ðéc', N'0123456789', N'DH21TA')
INSERT [dbo].[SINHVIEN] ([maSV], [tenSV], [gioiTinh], [ngaySinh], [diaChi], [dienThoai], [maLop]) VALUES (N'DTH195311', N'Ðoàn Van Ti?t Phi Long', N'Nam', CAST(N'2001-01-01 00:00:00.000' AS DateTime), N'Long Xuyên', N'0123456789', N'DH20TH2')
INSERT [dbo].[SINHVIEN] ([maSV], [tenSV], [gioiTinh], [ngaySinh], [diaChi], [dienThoai], [maLop]) VALUES (N'DTH195312', N'Lê Van H?', N'Nam', CAST(N'2001-01-01 00:00:00.000' AS DateTime), N'An Giang', N'0123456789', N'DH20TH2')
INSERT [dbo].[SINHVIEN] ([maSV], [tenSV], [gioiTinh], [ngaySinh], [diaChi], [dienThoai], [maLop]) VALUES (N'DTH195315', N'Nguyen Truong Giang 2', N'Nam', CAST(N'2001-01-01 00:00:00.000' AS DateTime), N'Cho Moi', N'0123456789', N'DH20TH1')
INSERT [dbo].[SINHVIEN] ([maSV], [tenSV], [gioiTinh], [ngaySinh], [diaChi], [dienThoai], [maLop]) VALUES (N'DTH195316', N'Lê Th? Huy?n Trang', N'N?', CAST(N'2002-01-01 00:00:00.000' AS DateTime), N'C?u H?i', N'0123456789', N'DH21TA')
INSERT [dbo].[SINHVIEN] ([maSV], [tenSV], [gioiTinh], [ngaySinh], [diaChi], [dienThoai], [maLop]) VALUES (N'DTH195318', N'Tr?n Khánh Kha', N'Nam', CAST(N'2001-01-01 00:00:00.000' AS DateTime), N'An Phú', N'0123456789', N'DH20TH2')
INSERT [dbo].[SINHVIEN] ([maSV], [tenSV], [gioiTinh], [ngaySinh], [diaChi], [dienThoai], [maLop]) VALUES (N'DTH195319', N'Nguy?n Phúc Minh', N'N?', CAST(N'2001-01-01 00:00:00.000' AS DateTime), N'Long Xuyên', N'0123456789', N'DH20TH1')
INSERT [dbo].[SINHVIEN] ([maSV], [tenSV], [gioiTinh], [ngaySinh], [diaChi], [dienThoai], [maLop]) VALUES (N'DTH195320', N'Khoa Van Tran', N'Nam', CAST(N'2000-01-01 00:00:00.000' AS DateTime), N'AG', N'0123456789', N'DH119TH')
INSERT [dbo].[SINHVIEN] ([maSV], [tenSV], [gioiTinh], [ngaySinh], [diaChi], [dienThoai], [maLop]) VALUES (N'DTH195321', N'Tr?n Nhon Hòa', N'Nam', CAST(N'2000-01-01 00:00:00.000' AS DateTime), N'An Giang', N'0123456789', N'DH119TH')
INSERT [dbo].[SINHVIEN] ([maSV], [tenSV], [gioiTinh], [ngaySinh], [diaChi], [dienThoai], [maLop]) VALUES (N'DTH195322', N'Hu?nh Phúc Khang', N'Nam', CAST(N'2001-01-01 00:00:00.000' AS DateTime), N'Châu Ð?c', N'0123456789', N'DH20TH1')
INSERT [dbo].[SINHVIEN] ([maSV], [tenSV], [gioiTinh], [ngaySinh], [diaChi], [dienThoai], [maLop]) VALUES (N'DTH195323', N'Tr?n Van KKKKK', N'Nam', CAST(N'2022-05-18 20:44:13.630' AS DateTime), N'Cho Moi', N'0987654321', N'DH119TH')
INSERT [dbo].[SINHVIEN] ([maSV], [tenSV], [gioiTinh], [ngaySinh], [diaChi], [dienThoai], [maLop]) VALUES (N'DTH195324', N'nguyen van test', N'N?', CAST(N'2001-06-23 00:00:00.000' AS DateTime), N'chau doc', N'132', N'DH20TH2')
INSERT [dbo].[TAIKHOAN] ([taiKhoan], [matKhau], [tenTaiKhoan], [loaiTaiKhoan]) VALUES (N'AD', N'202cb962ac59075b964b07152d234b70', N'ADMIN', N'AD')
INSERT [dbo].[TAIKHOAN] ([taiKhoan], [matKhau], [tenTaiKhoan], [loaiTaiKhoan]) VALUES (N'AD2', N'202cb962ac59075b964b07152d234b70', N'ADMIN2', N'ad')
INSERT [dbo].[TAIKHOAN] ([taiKhoan], [matKhau], [tenTaiKhoan], [loaiTaiKhoan]) VALUES (N'DTH', N'202cb962ac59075b964b07152d234b70', N'Khoavip', N'VIP')
INSERT [dbo].[TAIKHOAN] ([taiKhoan], [matKhau], [tenTaiKhoan], [loaiTaiKhoan]) VALUES (N'DTH195287', N'202cb962ac59075b964b07152d234b70', N'Tr?n Van Khoa', N'SV')
INSERT [dbo].[TAIKHOAN] ([taiKhoan], [matKhau], [tenTaiKhoan], [loaiTaiKhoan]) VALUES (N'DTH195288', N'250cf8b51c773f3f8dc8b4be867a9a02', N'Tr?n Y Khoa', N'SV')
INSERT [dbo].[TAIKHOAN] ([taiKhoan], [matKhau], [tenTaiKhoan], [loaiTaiKhoan]) VALUES (N'DTH195289', N'202cb962ac59075b964b07152d234b70', N'Nguy?n Th? An', N'SV')
INSERT [dbo].[TAIKHOAN] ([taiKhoan], [matKhau], [tenTaiKhoan], [loaiTaiKhoan]) VALUES (N'DTH195293', N'202cb962ac59075b964b07152d234b70', N'Hu?nh Th? Mai Châu', N'SV')
INSERT [dbo].[TAIKHOAN] ([taiKhoan], [matKhau], [tenTaiKhoan], [loaiTaiKhoan]) VALUES (N'DTH195296', N'202cb962ac59075b964b07152d234b70', N'Tr?n Ð?ng H?u Duy', N'SV')
INSERT [dbo].[TAIKHOAN] ([taiKhoan], [matKhau], [tenTaiKhoan], [loaiTaiKhoan]) VALUES (N'DTH195300', N'202cb962ac59075b964b07152d234b70', N'Thái Hoàng Khang', N'SV')
INSERT [dbo].[TAIKHOAN] ([taiKhoan], [matKhau], [tenTaiKhoan], [loaiTaiKhoan]) VALUES (N'DTH195301', N'202cb962ac59075b964b07152d234b70', N'Võ Duy Khang', N'SV')
INSERT [dbo].[TAIKHOAN] ([taiKhoan], [matKhau], [tenTaiKhoan], [loaiTaiKhoan]) VALUES (N'DTH195302', N'202cb962ac59075b964b07152d234b70', N'Phan Lê Duong Khang', N'SV')
INSERT [dbo].[TAIKHOAN] ([taiKhoan], [matKhau], [tenTaiKhoan], [loaiTaiKhoan]) VALUES (N'DTH195305', N'202cb962ac59075b964b07152d234b70', N'Hoàng Lan2', N'SV')
INSERT [dbo].[TAIKHOAN] ([taiKhoan], [matKhau], [tenTaiKhoan], [loaiTaiKhoan]) VALUES (N'DTH195306', N'202cb962ac59075b964b07152d234b70', N'Hoàng Th? Ng?c Trâm', N'SV')
INSERT [dbo].[TAIKHOAN] ([taiKhoan], [matKhau], [tenTaiKhoan], [loaiTaiKhoan]) VALUES (N'DTH195310', N'202cb962ac59075b964b07152d234b70', N'Lê Tr?n Thu Huong', N'SV')
INSERT [dbo].[TAIKHOAN] ([taiKhoan], [matKhau], [tenTaiKhoan], [loaiTaiKhoan]) VALUES (N'DTH195311', N'202cb962ac59075b964b07152d234b70', N'Ðoàn Van Ti?t Phi Long', N'SV')
INSERT [dbo].[TAIKHOAN] ([taiKhoan], [matKhau], [tenTaiKhoan], [loaiTaiKhoan]) VALUES (N'DTH195312', N'202cb962ac59075b964b07152d234b70', N'Lê Van H?', N'SV')
INSERT [dbo].[TAIKHOAN] ([taiKhoan], [matKhau], [tenTaiKhoan], [loaiTaiKhoan]) VALUES (N'DTH195315', N'202cb962ac59075b964b07152d234b70', N'Nguyen Truong Giang 2', N'SV')
INSERT [dbo].[TAIKHOAN] ([taiKhoan], [matKhau], [tenTaiKhoan], [loaiTaiKhoan]) VALUES (N'DTH195316', N'202cb962ac59075b964b07152d234b70', N'Lê Th? Huy?n Trang', N'SV')
INSERT [dbo].[TAIKHOAN] ([taiKhoan], [matKhau], [tenTaiKhoan], [loaiTaiKhoan]) VALUES (N'DTH195318', N'202cb962ac59075b964b07152d234b70', N'Tr?n Khánh Kha', N'SV')
INSERT [dbo].[TAIKHOAN] ([taiKhoan], [matKhau], [tenTaiKhoan], [loaiTaiKhoan]) VALUES (N'DTH195321', N'202cb962ac59075b964b07152d234b70', N'Tr?n Nhon Hòa', N'VIP')
INSERT [dbo].[TAIKHOAN] ([taiKhoan], [matKhau], [tenTaiKhoan], [loaiTaiKhoan]) VALUES (N'DTH195322', N'202cb962ac59075b964b07152d234b70', N'Hu?nh Phúc Khang', N'SV')
INSERT [dbo].[TAIKHOAN] ([taiKhoan], [matKhau], [tenTaiKhoan], [loaiTaiKhoan]) VALUES (N'DTH195323', N'202cb962ac59075b964b07152d234b70', N'nam', N'SV')
INSERT [dbo].[TAIKHOAN] ([taiKhoan], [matKhau], [tenTaiKhoan], [loaiTaiKhoan]) VALUES (N'DTH195324', N'123', N'nguyen van test', N'SV')
INSERT [dbo].[TAIKHOAN] ([taiKhoan], [matKhau], [tenTaiKhoan], [loaiTaiKhoan]) VALUES (N'GV001', N'202cb962ac59075b964b07152d234b70', N'H.C.T.Cu?ng', N'GV')
INSERT [dbo].[TAIKHOAN] ([taiKhoan], [matKhau], [tenTaiKhoan], [loaiTaiKhoan]) VALUES (N'GV002', N'202cb962ac59075b964b07152d234b70', N'N.T.M.Truy?n', N'GV')
INSERT [dbo].[TAIKHOAN] ([taiKhoan], [matKhau], [tenTaiKhoan], [loaiTaiKhoan]) VALUES (N'GV003', N'202cb962ac59075b964b07152d234b70', N'N.T.Du', N'GV')
INSERT [dbo].[TAIKHOAN] ([taiKhoan], [matKhau], [tenTaiKhoan], [loaiTaiKhoan]) VALUES (N'GV004', N'202cb962ac59075b964b07152d234b70', N'Lê Hoàng Anh', N'GV')
INSERT [dbo].[TAIKHOAN] ([taiKhoan], [matKhau], [tenTaiKhoan], [loaiTaiKhoan]) VALUES (N'GV009', N'202cb962ac59075b964b07152d234b70', N'Lê Hoàng Anh', N'GV')
INSERT [dbo].[THONGBAO] ([maSV], [ndThongBao], [tgThongBao]) VALUES (N'DTH195287', N'SV Tr?n Van Khoa d? di?u ki?n nh?n HB khuyên skhichs h?c t?p-HK2-chi ti?t liên h? PCTSV s?...', CAST(N'2022-02-22 14:03:37.330' AS DateTime))
INSERT [dbo].[THONGBAO] ([maSV], [ndThongBao], [tgThongBao]) VALUES (N'DTH195287', N'SV Tr?n Van Khoa d? di?u ki?n nh?n HB Doãn T?i-chi ti?t liên h? PCTSV s?...', CAST(N'2022-02-22 14:08:50.393' AS DateTime))
INSERT [dbo].[TTHETHONG] ([tinh], [donViChuQuan], [tenTruong], [khoaHoc], [nganhHoc], [chuyenNganh]) VALUES (N'An Giang', N'S? Giáo D?c D?c Ðào T?o An Giang', N'Tru?ng Ð?i H?c An Giang', N'2019-2025', N'CNTT', N'CNTT')
ALTER TABLE [dbo].[CTDKHP]  WITH CHECK ADD  CONSTRAINT [FK_CTDKHP_HOCPHAN] FOREIGN KEY([maHP])
REFERENCES [dbo].[HOCPHAN] ([maHP])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CTDKHP] CHECK CONSTRAINT [FK_CTDKHP_HOCPHAN]
GO
ALTER TABLE [dbo].[CTDKHP]  WITH CHECK ADD  CONSTRAINT [FK_CTDKHP_SINHVIEN] FOREIGN KEY([maSV])
REFERENCES [dbo].[SINHVIEN] ([maSV])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CTDKHP] CHECK CONSTRAINT [FK_CTDKHP_SINHVIEN]
GO
ALTER TABLE [dbo].[CTGIANGDAY]  WITH CHECK ADD  CONSTRAINT [FK_CTGIANGDAY_GIAOVIEN] FOREIGN KEY([maGV])
REFERENCES [dbo].[GIAOVIEN] ([maGV])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CTGIANGDAY] CHECK CONSTRAINT [FK_CTGIANGDAY_GIAOVIEN]
GO
ALTER TABLE [dbo].[CTGIANGDAY]  WITH CHECK ADD  CONSTRAINT [FK_CTGIANGDAY_HOCPHAN] FOREIGN KEY([maHP])
REFERENCES [dbo].[HOCPHAN] ([maHP])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CTGIANGDAY] CHECK CONSTRAINT [FK_CTGIANGDAY_HOCPHAN]
GO
ALTER TABLE [dbo].[CTNOHP]  WITH CHECK ADD  CONSTRAINT [FK_CTNOHP_HOCPHAN] FOREIGN KEY([maHP])
REFERENCES [dbo].[HOCPHAN] ([maHP])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CTNOHP] CHECK CONSTRAINT [FK_CTNOHP_HOCPHAN]
GO
ALTER TABLE [dbo].[CTNOHP]  WITH CHECK ADD  CONSTRAINT [FK_CTNOHP_SINHVIEN] FOREIGN KEY([maSV])
REFERENCES [dbo].[SINHVIEN] ([maSV])
GO
ALTER TABLE [dbo].[CTNOHP] CHECK CONSTRAINT [FK_CTNOHP_SINHVIEN]
GO
ALTER TABLE [dbo].[DKHP]  WITH CHECK ADD  CONSTRAINT [FK_DKHP_HOCKY] FOREIGN KEY([maHK])
REFERENCES [dbo].[HOCKY] ([maHK])
GO
ALTER TABLE [dbo].[DKHP] CHECK CONSTRAINT [FK_DKHP_HOCKY]
GO
ALTER TABLE [dbo].[DKHP]  WITH CHECK ADD  CONSTRAINT [FK_DKHP_SINHVIEN] FOREIGN KEY([maSV])
REFERENCES [dbo].[SINHVIEN] ([maSV])
GO
ALTER TABLE [dbo].[DKHP] CHECK CONSTRAINT [FK_DKHP_SINHVIEN]
GO
ALTER TABLE [dbo].[HOCPHAN]  WITH CHECK ADD  CONSTRAINT [FK_HOCPHAN_HOCKY] FOREIGN KEY([maHK])
REFERENCES [dbo].[HOCKY] ([maHK])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HOCPHAN] CHECK CONSTRAINT [FK_HOCPHAN_HOCKY]
GO
ALTER TABLE [dbo].[KQHT_HK]  WITH CHECK ADD  CONSTRAINT [FK_KQHT_HK_HOCPHAN] FOREIGN KEY([maHP])
REFERENCES [dbo].[HOCPHAN] ([maHP])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[KQHT_HK] CHECK CONSTRAINT [FK_KQHT_HK_HOCPHAN]
GO
ALTER TABLE [dbo].[KQHT_HK]  WITH CHECK ADD  CONSTRAINT [FK_KQHT_HK_SINHVIEN] FOREIGN KEY([maSV])
REFERENCES [dbo].[SINHVIEN] ([maSV])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[KQHT_HK] CHECK CONSTRAINT [FK_KQHT_HK_SINHVIEN]
GO
ALTER TABLE [dbo].[LOP]  WITH CHECK ADD  CONSTRAINT [FK_LOP_GIAOVIEN] FOREIGN KEY([maCN])
REFERENCES [dbo].[GIAOVIEN] ([maGV])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LOP] CHECK CONSTRAINT [FK_LOP_GIAOVIEN]
GO
ALTER TABLE [dbo].[SINHVIEN]  WITH CHECK ADD  CONSTRAINT [FK_SINHVIEN_LOP] FOREIGN KEY([maLop])
REFERENCES [dbo].[LOP] ([maLop])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SINHVIEN] CHECK CONSTRAINT [FK_SINHVIEN_LOP]
GO
ALTER TABLE [dbo].[THONGBAO]  WITH CHECK ADD  CONSTRAINT [FK_THONGBAO_SINHVIEN] FOREIGN KEY([maSV])
REFERENCES [dbo].[SINHVIEN] ([maSV])
GO
ALTER TABLE [dbo].[THONGBAO] CHECK CONSTRAINT [FK_THONGBAO_SINHVIEN]
GO
/****** Object:  StoredProcedure [dbo].[CTDKHP_Delete]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[CTDKHP_Delete] @maSV nvarchar(50),@maHP nvarchar(50)
as begin
	delete from CTDKHP where maSV=@maSV and maHP=maHP
end


GO
/****** Object:  StoredProcedure [dbo].[CTDKHP_Insert]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[CTDKHP_Insert](
	@maSV nvarchar(50),
	@maHP nvarchar(50)
	
)
as begin
	insert into CTDKHP values(@maSV,@maHP,GETDATE())
end


GO
/****** Object:  StoredProcedure [dbo].[CTDKHP_SelectAll]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[CTDKHP_SelectAll]
as begin
	select dkhp.maSV,dkhp.maHP,hp.tenHP,dkhp.tgDK from CTDKHP dkhp inner join HOCPHAN  hp on dkhp.maHP=hp.maHP 
end

GO
/****** Object:  StoredProcedure [dbo].[CTDKHP_SelectBymaSV]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[CTDKHP_SelectBymaSV] @maSV nvarchar(50)
as begin
	select ct.maSV,ct.maHP,hp.tenHP,hp.soTC,ct.tgDK from CTDKHP ct inner join HOCPHAN hp on ct.maHP=hp.maHP where ct.maSV=@maSV
end

GO
/****** Object:  StoredProcedure [dbo].[CTDKHP_SelectBymaSV_maHK]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[CTDKHP_SelectBymaSV_maHK] @maSV nvarchar(50),@maHK nvarchar(50)
as begin
	--select * from CTDKHP  where maSV=@maSV and maHP in(Select maHP from HOCPHAN where maHK=@maHK)
	select dkhp.maSV,dkhp.maHP,hp.tenHP,hp.soTC,dkhp.tgDK from CTDKHP dkhp inner join HOCPHAN  hp on dkhp.maHP=hp.maHP where dkhp.maSV=@maSV and hp.maHK=@maHK
end
GO
/****** Object:  StoredProcedure [dbo].[CTGD_Delete]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[CTGD_Delete] @maGV nvarchar(50),@maHP nvarchar(50)
as begin
	delete from CTGIANGDAY where maGV=@maGV and maHP=@maHP
end


GO
/****** Object:  StoredProcedure [dbo].[CTGD_DeleteBymaGV]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[CTGD_DeleteBymaGV] @maGV nvarchar(50)
as begin
	delete from CTGIANGDAY where maGV=@maGV 
end

GO
/****** Object:  StoredProcedure [dbo].[CTGD_Insert]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[CTGD_Insert](
	@maGV nvarchar(50),
	@maHP nvarchar(50),
	@tgHoc nvarchar(50)
)as begin
	insert into CTGIANGDAY values(@maGV,@maHP,@tgHoc)
end

GO
/****** Object:  StoredProcedure [dbo].[CTGD_SelectAll]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[CTGD_SelectAll]
as begin
	select * from  CTGIANGDAY  
end


GO
/****** Object:  StoredProcedure [dbo].[CTGD_SelectbymaGV]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[CTGD_SelectbymaGV] @maGV nvarchar(50)
as begin
	select * from  CTGIANGDAY  where maGV=@maGV
end


GO
/****** Object:  StoredProcedure [dbo].[CTGD_Update]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[CTGD_Update](
	@maGV nvarchar(50),
	@maHP nvarchar(50),
	@tgHoc nvarchar(50)
)as begin
	update  CTGIANGDAY set tgHoc=@tgHoc where maGV=@maGV and maHP=@maHP
end

GO
/****** Object:  StoredProcedure [dbo].[DataProvider_Insert]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DataProvider_Insert](
	@SV nvarchar(50),
	@DB nvarchar(50),
	@user nvarchar(50),
	@pass nvarchar(50)
)
as
begin
	insert into DataProvider values('Demo',@SV,@DB,@user,@pass)
end
GO
/****** Object:  StoredProcedure [dbo].[DataProvider_SelectAll]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DataProvider_SelectAll]
as begin 
	select * from DataProvider
end
GO
/****** Object:  StoredProcedure [dbo].[DataProvider_Update]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DataProvider_Update](
	@SV nvarchar(50),
	@DB nvarchar(50),
	@user nvarchar(50),
	@pass nvarchar(50)
)as
begin
	update DataProvider set SV=@SV,DB=@DB,userName=@user,pass=@pass where Provider='Demo'
end
GO
/****** Object:  StoredProcedure [dbo].[DKHP_Delete]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DKHP_Delete]
@maSV nvarchar(50)
as begin 
	delete from DKHP where maSV=@maSV
end

GO
/****** Object:  StoredProcedure [dbo].[DKHP_Insert]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DKHP_Insert](
	@maSV nvarchar(50),
	@maHK nvarchar(50),
	@tongTC int
)as begin
	insert into DKHP values(@maSV,@maHK,@tongTC)
end


GO
/****** Object:  StoredProcedure [dbo].[DKHP_SelectAll]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DKHP_SelectAll]
as begin 
	select * from DKHP
end


GO
/****** Object:  StoredProcedure [dbo].[DKHP_SelectBymaSV]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DKHP_SelectBymaSV] @maSV nvarchar(50)
as begin 
	select * from DKHP where maSV=@maSV
end


GO
/****** Object:  StoredProcedure [dbo].[DKHP_SelectBymaSV_maHK]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DKHP_SelectBymaSV_maHK] @maSV nvarchar(50),@maHK nvarchar(50)
as begin 
	select * from DKHP where maSV=@maSV and maHK=@maHK
end

GO
/****** Object:  StoredProcedure [dbo].[DKHP_Update]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DKHP_Update](
	@maSV nvarchar(50),
	@maHK nvarchar(50),
	@tongTC int
)as begin
	update DKHP set tongTC=@tongTC where maSV=@maSV and maHK=@maHK
end

GO
/****** Object:  StoredProcedure [dbo].[DKHP_UpdatetongTC]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DKHP_UpdatetongTC](
	@maSV nvarchar(50),
	@maHK nvarchar(50),
	@tongTC int
)as begin
	update DKHP set tongTC=tongTC+@tongTC where maSV=@maSV and maHK=@maHK
end

GO
/****** Object:  StoredProcedure [dbo].[GV_Delete]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GV_Delete] @maGV nvarchar(50)
as begin 
	delete from GIAOVIEN where maGV=@maGV
end

GO
/****** Object:  StoredProcedure [dbo].[GV_Insert]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GV_Insert](
	@maGV nvarchar(50),
	@tenGV nvarchar(50),
	@ngaySinh datetime,
	@gioiTinh nvarchar(3),
	@diaChi nvarchar(50),
	@dienThoai nvarchar(50),
	@eMail nvarchar(50)
)as begin
	insert into GIAOVIEN values(@maGV,@tenGV,@ngaySinh,@gioiTinh,@diaChi,@dienThoai,@eMail)
end

GO
/****** Object:  StoredProcedure [dbo].[GV_SelectAll]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GV_SelectAll]
as begin
	select * from GIAOVIEN
end

GO
/****** Object:  StoredProcedure [dbo].[GV_SelectBymaGV]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GV_SelectBymaGV] @maGV nvarchar(50)
as begin
	select * from GIAOVIEN where maGV=@maGV
end

GO
/****** Object:  StoredProcedure [dbo].[GV_SelectmaLopBymaGV]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GV_SelectmaLopBymaGV] @maGV nvarchar(50)
as begin
select l.maLop,l.tenLop from GIAOVIEN gv inner join LOP l  on gv.maGV=l.maCN where gv.maGV=@maGV
end

GO
/****** Object:  StoredProcedure [dbo].[GV_Update]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GV_Update](
	@maGV nvarchar(50),
	@tenGV nvarchar(50),
	@ngaySinh datetime,
	@gioiTinh nvarchar(3),
	@diaChi nvarchar(50),
	@dienThoai nvarchar(50),
	@eMail nvarchar(50)
)as begin
	update  GIAOVIEN set tenGV=@tenGV,ngaySinh=@ngaySinh,gioiTinh=@gioiTinh,diaChi=@diaChi,dienThoai=@dienThoai,eMail=@eMail where maGV=@maGV
end

GO
/****** Object:  StoredProcedure [dbo].[hienthisv_diem]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[hienthisv_diem]
  as
  SELECT SinhVien.MaSV,TenSV,QueQuan,MaMH,DiemLan1
  from SinhVien join diem
  on Sinhvien.masv=diem.masv
GO
/****** Object:  StoredProcedure [dbo].[HK_Delete]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[HK_Delete] @maHK nvarchar(50)
as
begin 
	delete  from HOCKY where maHK=@maHK
end

GO
/****** Object:  StoredProcedure [dbo].[HK_Insert]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[HK_Insert] @maHK nvarchar(50),@tenHK nvarchar(50)
as
begin 
	insert into HOCKY values(@maHK,@tenHK)
end

GO
/****** Object:  StoredProcedure [dbo].[HK_SelectAll]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[HK_SelectAll]
as
begin
select * from HOCKY
end

GO
/****** Object:  StoredProcedure [dbo].[HK_Update]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[HK_Update] @maHK nvarchar(50),@tenHK nvarchar(50)
as
begin 
	update  HOCKY set tenHK=@tenHK where maHK=@maHK
end

GO
/****** Object:  StoredProcedure [dbo].[HP_Delete]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[HP_Delete] @maHP nvarchar(50)
as begin
	delete from HOCPHAN where maHP=@maHP
 end

GO
/****** Object:  StoredProcedure [dbo].[HP_Insert]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[HP_Insert](
	@maHP nvarchar(50),
	@tenHP nvarchar(50),
	@soTC int,
	@maHK nvarchar(50)
)as begin
	insert into HOCPHAN values(@maHP,@tenHP,@soTC,@maHK)
end


GO
/****** Object:  StoredProcedure [dbo].[HP_SelectAll]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[HP_SelectAll]
as begin
	select * from HOCPHAN
end


GO
/****** Object:  StoredProcedure [dbo].[HP_SelectBymaHK]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[HP_SelectBymaHK]( @maHK nvarchar(50))
as begin
	select * from HOCPHAN where maHK=@maHK
end


GO
/****** Object:  StoredProcedure [dbo].[HP_SelectBymaHP]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[HP_SelectBymaHP]( @maHP nvarchar(50))
as begin
	select * from HOCPHAN where maHP=@maHP
end

GO
/****** Object:  StoredProcedure [dbo].[HP_SelectmaHK]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[HP_SelectmaHK]( @maHP nvarchar(50))
as begin
	select maHK from HOCPHAN where maHP=@maHP
end

GO
/****** Object:  StoredProcedure [dbo].[HP_Update]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[HP_Update](
	@maHP nvarchar(50),
	@tenHP nvarchar(50),
	@soTC int,
	@maHK nvarchar(50)
)as begin
	update  HOCPHAN set tenHP=@tenHP,soTC=@soTC,maHK=@maHK where maHP=@maHP
end


GO
/****** Object:  StoredProcedure [dbo].[ins_Lop]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[ins_Lop]
          (
          @MALOP char(5),
          @TENLOP nvarchar(30),
          @MAKHOA CHAR(5),
          @MaHeDT CHAR(5),
          @MaKhoaHoc CHAR(5)
          )
          AS
          BEGIN
          insert into LOP
          
     
         values (@MALOP,@TENLOP,@MAKHOA,@MaHeDT,@MaKhoaHoc)
         END
GO
/****** Object:  StoredProcedure [dbo].[KQHT_Delete]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc  [dbo].[KQHT_Delete] (
	@maSV nvarchar(50),
	@maHP nvarchar(50)
)as begin
	delete from KQHT  where maSV=@maSV and maHP=@maHP
end


GO
/****** Object:  StoredProcedure [dbo].[KQHT_DeleteBymaSV]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc  [dbo].[KQHT_DeleteBymaSV] (
	@maSV nvarchar(50)
)as begin
	delete from KQHT  where maSV=@maSV 
end

GO
/****** Object:  StoredProcedure [dbo].[KQHT_HK_Delete]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc  [dbo].[KQHT_HK_Delete] (
	@maSV nvarchar(50),
	@maHP nvarchar(50)
)as begin
	delete from KQHT_HK  where maSV=@maSV and maHP=@maHP
end

GO
/****** Object:  StoredProcedure [dbo].[KQHT_HK_DeleteBymaSV]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc  [dbo].[KQHT_HK_DeleteBymaSV] (
	@maSV nvarchar(50)
)as begin
	delete from KQHT_HK  where maSV=@maSV 
end

GO
/****** Object:  StoredProcedure [dbo].[KQHT_HK_Insert]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc  [dbo].[KQHT_HK_Insert] (
	@maSV nvarchar(50),
	@maHP nvarchar(50),
	@lanThi int,
	@diemThi float,
	@diemQT float,
	@diemTB float,
	@xepLoai nvarchar(50),
	@trangThai nvarchar(50)
)as begin
	insert into KQHT_HK values (@maSV,@maHP,@lanThi,@diemThi,@diemQT,@diemTB,@xepLoai,@trangThai)
end

GO
/****** Object:  StoredProcedure [dbo].[KQHT_HK_SelectAll]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[KQHT_HK_SelectAll]
as begin 
select kq.maSV,hp.maHP,hp.tenHP,hp.soTC,kq.lanThi,kq.diemThi,kq.diemQT,kq.diemTB,kq.xepLoai,kq.trangThai from KQHT_HK kq  inner join HOCPHAN hp on kq.maHP=hp.maHP
end

GO
/****** Object:  StoredProcedure [dbo].[KQHT_HK_SelectBymaLop]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[KQHT_HK_SelectBymaLop] @maLop nvarchar(50)
as begin
	select kq.maSV,hp.maHP,hp.tenHP,hp.soTC,kq.lanThi,kq.diemThi,kq.diemQT,kq.diemTB,kq.xepLoai,kq.trangThai from (KQHT_HK kq  inner join HOCPHAN hp on kq.maHP=hp.maHP) inner join SINHVIEN sv on sv.maSV=kq.maSV where sv.maLop=@maLop
end

GO
/****** Object:  StoredProcedure [dbo].[KQHT_HK_SelectBymaLop_maHK]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[KQHT_HK_SelectBymaLop_maHK] @maLop nvarchar(50),@maHK nvarchar(50)
as begin
	select kq.maSV,hp.maHP,hp.tenHP,hp.soTC,kq.lanThi,kq.diemThi,kq.diemQT,kq.diemTB,kq.xepLoai,kq.trangThai from (KQHT_HK kq  inner join HOCPHAN hp on kq.maHP=hp.maHP) inner join SINHVIEN sv on sv.maSV=kq.maSV where sv.maLop=@maLop and hp.maHK=@maHK
end
GO
/****** Object:  StoredProcedure [dbo].[KQHT_HK_SelectBymaSV]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[KQHT_HK_SelectBymaSV] @maSV nvarchar(50)
as begin
	select kq.maSV,hp.maHP,hp.tenHP,hp.soTC,kq.lanThi,kq.diemThi,kq.diemQT,kq.diemTB,kq.xepLoai,kq.trangThai from KQHT_HK kq  inner join HOCPHAN hp on kq.maHP=hp.maHP where kq.maSV=@maSV
end

GO
/****** Object:  StoredProcedure [dbo].[KQHT_HK_SelectBymaSV_maHK]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[KQHT_HK_SelectBymaSV_maHK] @maSV nvarchar(50),@maHK nvarchar(50)
as begin 
	select kq.maSV,hp.maHP,hp.tenHP,hp.soTC,kq.lanThi,kq.diemThi,kq.diemQT,kq.diemTB,kq.xepLoai,kq.trangThai from KQHT_HK kq  inner join HOCPHAN hp on kq.maHP=hp.maHP where kq.maSV=@maSV and hp.maHK=@maHK
end

GO
/****** Object:  StoredProcedure [dbo].[KQHT_HK_Update]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc  [dbo].[KQHT_HK_Update] (
	@maSV nvarchar(50),
	@maHP nvarchar(50),
	@lanThi int,
	@diemThi float,
	@diemQT float,
	@diemTB float,
	@xepLoai nvarchar(50),
	@trangThai nvarchar(50)
)as begin
	update KQHT_HK set lanThi=@lanThi,diemThi=@diemThi,diemQT=@diemQT,diemTB=@diemTB,xepLoai=@xepLoai,trangThai=@trangThai where maSV=@maSV and maHP=@maHP
end


GO
/****** Object:  StoredProcedure [dbo].[KQHT_Insert]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc  [dbo].[KQHT_Insert] (
	@maSV nvarchar(50),
	@maHP nvarchar(50),
	@lanThi int,
	@diem float,
	@xepLoai nvarchar(50),
	@trangThai nvarchar(50)
)as begin
	insert into KQHT values (@maSV,@maHP,@lanThi,@diem,@xepLoai,@trangThai)
end


GO
/****** Object:  StoredProcedure [dbo].[KQHT_SelectAll]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[KQHT_SelectAll]
as begin 
	select * from KQHT
end

GO
/****** Object:  StoredProcedure [dbo].[KQHT_SelectBymaLop]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[KQHT_SelectBymaLop] @maLop nvarchar(50)
as begin
	select kq.maSV,sv.tenSV,kq.maHP,kq.lanThi,kq.diem,kq.xepLoai,kq.trangThai from KQHT kq inner join SINHVIEN sv on kq.maSV=sv.maSV where sv.maLop=@maLop
end


GO
/****** Object:  StoredProcedure [dbo].[KQHT_SelectBymaLop_maHK]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[KQHT_SelectBymaLop_maHK] @maLop nvarchar(50),@maHK nvarchar(50)
as begin
	select kq.maSV,sv.tenSV,kq.maHP,kq.lanThi,kq.diem,kq.xepLoai,kq.trangThai from (KQHT kq inner join SINHVIEN sv on kq.maSV=sv.maSV )inner join HOCPHAN hp on KQHT_HK.maHP = hp.maHP where sv.maLop=@maLop and hp.maHK=@maHK
end
GO
/****** Object:  StoredProcedure [dbo].[KQHT_SelectBymaSV]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[KQHT_SelectBymaSV] @maLop nvarchar(50)
as begin
	select * from KQHT where maSV=@maLop
end


GO
/****** Object:  StoredProcedure [dbo].[KQHT_SelectBymaSV_maHK]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[KQHT_SelectBymaSV_maHK] @maSV nvarchar(50),@maHK nvarchar(50)
as begin 
	select kq.maSV,hp.tenHP,hp.maHP,hp.soTC,kq.lanThi,kq.diem,kq.xepLoai,kq.trangThai from KQHT kq  inner join HOCPHAN hp on kq.maHP=hp.maHP where kq.maSV=@maSV and hp.maHK=@maHK
end

GO
/****** Object:  StoredProcedure [dbo].[KQHT_Update]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc  [dbo].[KQHT_Update] (
	@maSV nvarchar(50),
	@maHP nvarchar(50),
	@lanThi int,
	@diem float,
	@xepLoai nvarchar(50),
	@trangThai nvarchar(50)
)as begin
	update KQHT set lanThi=@lanThi,diem=@diem,xepLoai=@xepLoai,trangThai=@trangThai where maSV=@maSV and maHP=@maHP
end


GO
/****** Object:  StoredProcedure [dbo].[Lop_Delete]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Lop_Delete]
	@maLop nvarchar(50)
as begin
	delete from LOP where maLop=@maLop
end

GO
/****** Object:  StoredProcedure [dbo].[Lop_Insert]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Lop_Insert](
	@maLop nvarchar(50),
	@tenLop nvarchar(50),
	@ngayKhaiGiang nvarchar(50),
	@maCN nvarchar(50)
)
as begin
	insert into LOP values (@maLop,@tenLop,@ngayKhaiGiang,@maCN) 
end

GO
/****** Object:  StoredProcedure [dbo].[Lop_SelectAll]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Lop_SelectAll]
as
begin 
	select * from LOP
end
GO
/****** Object:  StoredProcedure [dbo].[LOP_SelectBymaLop]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LOP_SelectBymaLop] @maLop nvarchar(50)
as begin 
	select * from LOP where maLop=@maLop
end
GO
/****** Object:  StoredProcedure [dbo].[Lop_Update]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Lop_Update](
	@maLop nvarchar(50),
	@tenLop nvarchar(50),
	@ngayKhaiGiang nvarchar(50),
	@maCN nvarchar(50)
)
as begin
	update LOP set tenLop=@tenLop,ngayKhaiGiang=@ngayKhaiGiang,maCN=@maCN where maLop=@maLop
end

GO
/****** Object:  StoredProcedure [dbo].[nhapmoiSV]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[nhapmoiSV]
    @Masv char(15),
    @Tensv nvarchar(20),
    @gioitinh bit,
    @ngaysinh datetime,
    @quequan nvarchar(50),
    @malop char(5)
    as
    begin
      insert into sinhvien
      values(@Masv,@Tensv,@gioitinh,@ngaysinh,@quequan,@malop)
    end
GO
/****** Object:  StoredProcedure [dbo].[NOHP_Delete]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[NOHP_Delete] @maSV nvarchar(50),@maHP nvarchar(50)
as
begin
	delete from CTNOHP where maSV=@maSV and maHP=@maHP 
end

GO
/****** Object:  StoredProcedure [dbo].[NOHP_Insert]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[NOHP_Insert] @maSV nvarchar(50),@maHP nvarchar(50)
as
begin
	insert into CTNOHP values(@maSV,@maHP) 
end


GO
/****** Object:  StoredProcedure [dbo].[NOHP_SelectBymaSV]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[NOHP_SelectBymaSV] @maSV nvarchar(50)
as begin
	select * from CTNOHP where maSV=@maSV
end


GO
/****** Object:  StoredProcedure [dbo].[show_demsvcntt]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[show_demsvcntt]
as
     select count(*) as CNTT from SINHVIEN,KHOA,LOP
     where SINHVIEN.MALOP=LOP.MALOP and LOP.MAKHOA=KHOA.MAKHOA and TENKHOA=N'Công ngh? thông tin'

GO
/****** Object:  StoredProcedure [dbo].[show_demsvkhoa]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[show_demsvkhoa]
as
     select KHOA.MAKHOA, count(*) as SoLuong from SINHVIEN,LOP,KHOA
     where SINHVIEN.MALOP=LOP.MALOP and LOP.MAKHOA=KHOA.MAKHOA
     group by KHOA.MAKHOA

GO
/****** Object:  StoredProcedure [dbo].[show_diemsvmt3]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
   create proc [dbo].[show_diemsvmt3]
as
Select TenSV,TenLop,DiemLan1
   From SinhVien,Lop,KhoaHoc,Diem
   Where SinhVien.MaLop=Lop.MaLop And Lop.MaKhoaHoc=KhoaHoc.MaKhoaHoc And Diem.MaSV=SinhVien.MaSV And TenKhoaHoc='dai hoc khoa 2' And TenLop='may tinh 3'
   Order By DiemLan1 DESC 
GO
/****** Object:  StoredProcedure [dbo].[show_diemtbsvmt3]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
    create proc [dbo].[show_diemtbsvmt3]
as
Select SinhVien.MaSV,TenSV,Lop.TenLop, SUM(DiemLan1*SoTrinh)/SUM(SoTrinh) as DiemTrungBinh
   From SinhVien,Diem,MonHoc,Lop
   Where SinhVien.MaLop=Lop.MaLop And Diem.MaSV=SinhVien.MaSV And Diem.MaMH=MonHoc.MaMH
         And TenLop=N'MÁy Tính 3'
   Group By SinhVien.MaSV,TenSV,Lop.TenLop
GO
/****** Object:  StoredProcedure [dbo].[show_diemthapnhat]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[show_diemthapnhat]
as
     select MonHoc.MAMH,min(diemlan1) as [Min diem]
     from MonHoc inner join diem on MonHoc.MAMH=diem.MAMH
     group by MonHoc.MAMH
GO
/****** Object:  StoredProcedure [dbo].[show_LopAll]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[show_LopAll]
as
begin
	select * from Lop
end
GO
/****** Object:  StoredProcedure [dbo].[show_sv]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[show_sv]
as
  
Select MaSV,TenSV,NgaySinh,GioiTinh,TenLop
   From SinhVien,Lop
   Where SinhVien.MaLop=Lop.MaLop
GO
/****** Object:  StoredProcedure [dbo].[show_svba19]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[show_svba19]
as  
Select MaSV,TenSV,NgaySinh,QueQuan
   From SinhVien
   Where (TenSV like '%Ba') And (Year(getdate()) - Year(NgaySinh) >19)
GO
/****** Object:  StoredProcedure [dbo].[show_svcntt]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[show_svcntt]
as
 Select TenSV,TenLop,NgaySinh,QueQuan
   From (SinhVien Inner join Lop on SinhVien.MaLop=Lop.MaLop)
         Inner join Khoa on Khoa.MaKhoa=Lop.MaKhoa
   Where TenKhoa=N'Công ngh? thông tin'
GO
/****** Object:  StoredProcedure [dbo].[show_svhlmt3]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[show_svhlmt3]
as
Select TenSV,TenMH,DiemLan1,DiemLan2
   From SinhVien,Diem,MonHoc
   Where SinhVien.MaSV=Diem.MaSV And Diem.MaMH=MonHoc.MaMH And (DiemLan1<5) And (DiemLan2<5) And TenMH='M?ng máy tính'
GO
/****** Object:  StoredProcedure [dbo].[show_svthilai]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[show_svthilai]
as
Select TenSV,DiemLan1
   From SinhVien,Diem
   Where SinhVien.MaSV=Diem.MaSV And (DiemLan1<5)
GO
/****** Object:  StoredProcedure [dbo].[show_svthilaimmt]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[show_svthilaimmt]
as
Select TenSV,DiemLan1,TenMH
   From SinhVien,Diem,MonHoc
Where SinhVien.MaSV=Diem.MaSV And Diem.MaMH=MonHoc.MaMH And (DiemLan1<5) And TenMH='M?ng máy tính'
GO
/****** Object:  StoredProcedure [dbo].[show_top3sv]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[show_top3sv]
as
   Select Top 3 TenSV,TenLop,DiemLan1,TenMH
   From SinhVien,Diem,Lop,MonHoc
   Where TenLop='MÁy tính 3' and DiemLan1>=7 and TenMH='SQL'
         And SinhVien.MaLop=Lop.MaLop And Diem.MaSV=SinhVien.MaSV And Diem.MaMH=MonHoc.MaMH
GO
/****** Object:  StoredProcedure [dbo].[sp_delDIEM]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_delDIEM]
          @MASV char(15)
          as
            delete from DIEM
            where MASV=@MASV
GO
/****** Object:  StoredProcedure [dbo].[sp_delHEDT]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_delHEDT]
          @MaHeDT char(5)
          as
            delete from HEDT
            where MaHeDT=@MaHeDT
GO
/****** Object:  StoredProcedure [dbo].[sp_delKHOA]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  create procedure [dbo].[sp_delKHOA]
          @MAKHOA char(5)
          as
            delete from KHOA
            where MAKHOA=@MAKHOA
GO
/****** Object:  StoredProcedure [dbo].[sp_delKHOAHOC]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_delKHOAHOC]
          @MaKhoaHoc char(5)
          as
            delete from KHOAHOC
            where MaKhoaHoc=@MaKhoaHoc
GO
/****** Object:  StoredProcedure [dbo].[sp_delLOP]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_delLOP]
          @MALOP char(5)
          as
            delete from LOP
            where MALOP=@MALOP
GO
/****** Object:  StoredProcedure [dbo].[sp_delMONHOC]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_delMONHOC]
          @MAMH char(5)
          as
            delete from MonHoc
            where MAMH=@MAMH
GO
/****** Object:  StoredProcedure [dbo].[sp_delSINHVIEN]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_delSINHVIEN]
          @MASV char(15)
          as
            delete from SINHVIEN
            where MASV=@MASV
GO
/****** Object:  StoredProcedure [dbo].[sp_HEDT]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_HEDT]
          (
           @MaHeDT char(5),
           @TenHeDT nvarchar(40)
          )
          AS
          BEGIN
          insert into HEDT
          (
             MaHeDT,
             TenHeDT
             )
     
         values (@MaHeDT,@TenHeDT)
         END
GO
/****** Object:  StoredProcedure [dbo].[sp_insDIEM]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_insDIEM]
          (
          @MaSV char(15),
          @MaMH CHAR(5),
          @HocKy INT,
          @DiemLan1 INT,
          @DiemLan2 INT
          )
          AS
          BEGIN
          insert into DIEM
          (
             MASV,
             MAMH,
             HOCKY,
           DIEMLAN1,
             DIEmLAN2
             )
     
         values (@MaSV,@MaMH,@HocKy,@DiemLan1,@DiemLan2)
         END
GO
/****** Object:  StoredProcedure [dbo].[sp_insKHOA]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_insKHOA]
          (
            @MaKhoa char(5),
            @TenKhoa nvarchar(30),
            @DiaChi nvarchar(100),
            @DienThoai varchar(20)
          )
          AS
          BEGIN
          insert into KHOA
          (
             MaKhoa,
             TenKhoa,
             DiaChi,
           DienThoai
            )
     
         values (@MaKhoa,@TenKhoa,@DiaChi,@DienThoai)
         END
GO
/****** Object:  StoredProcedure [dbo].[sp_insKHOAHOC]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_insKHOAHOC]
          (
           @MaKhoaHoc char(5),
           @TenKhoaHoc nvarchar(20)
          )
          AS
          BEGIN
          insert into KHOAHOC
          (
             MaKhoaHoc,
             TenKhoaHoc
             )
     
         values (@MaKhoaHoc,@TenKhoaHoc)
         END
GO
/****** Object:  StoredProcedure [dbo].[sp_insLOP]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_insLOP]
          (
          @MALOP char(5),
          @TENLOP nvarchar(30),
          @MAKHOA CHAR(5),
          @MaHeDT CHAR(5),
          @MaKhoaHoc CHAR(5)
          )
          AS
          BEGIN
          insert into LOP
          
     
         values (@MALOP,@TENLOP,@MAKHOA,@MaHeDT,@MaKhoaHoc)
         END

GO
/****** Object:  StoredProcedure [dbo].[sp_insMONHOC]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_insMONHOC]
          (
          @MaMH char(5),
          @TenMH nvarchar(30),
          @SoTrinh INT
          )
          AS
          BEGIN
          insert into MONHOC
          (
             MAMH,
             TENMH,
             SOTRINH
           )
     
         values (@MAMH,@TENMH,@SOTRINH)
         END
GO
/****** Object:  StoredProcedure [dbo].[sp_insSINHVIEN]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_insSINHVIEN]
          (
          @MASV char(15),
          @TENSV nvarchar(20),
          @GIOITINH bit,
          @NGAYSINH DATETIME,
          @QueQuan nvarchar(50),
          @MALOP char(5)
          )
          AS
          BEGIN
          insert into SINHVIEN
          (
             MASV,
             TENSV,
             GIOITINH,
           NGAYSINH,
             QueQuan,
             MALOP
          )
           values (@MASV,@TENSV,@GIOITINH,@NGAYSINH,@QUEQUAN,@MALOP)
         END
GO
/****** Object:  StoredProcedure [dbo].[sp_showDIEM]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_showDIEM]
          as
            select * from DIEM
GO
/****** Object:  StoredProcedure [dbo].[sp_showHEDT]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_showHEDT]
          as
            select * from HEDT
GO
/****** Object:  StoredProcedure [dbo].[sp_showKHOA]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_showKHOA]
          as
            select * from KHOA
GO
/****** Object:  StoredProcedure [dbo].[sp_showKHOAHOC]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[sp_showKHOAHOC]
          as
            select * from KHOAHOC
GO
/****** Object:  StoredProcedure [dbo].[sp_showLOP]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_showLOP]
          as
            select * from LOP
GO
/****** Object:  StoredProcedure [dbo].[sp_showMONHOC]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_showMONHOC]
          as
            select * from MONHOC

GO
/****** Object:  StoredProcedure [dbo].[sp_showSINHVIEN]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_showSINHVIEN]
          as
            select * from SINHVIEN
  
GO
/****** Object:  StoredProcedure [dbo].[sp_updateDIEM]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_updateDIEM]
          (
           @MaSV char(15),
           @MaMH CHAR(5),
           @HocKy INT,
           @DiemLan1 INT,
           @DiemLan2 INT
          )
          as

          update DIEM
            set  
               MaSV=@MaSV,
               MaMH=@MaMH,
           HocKy=@HocKy,
               DiemLan1=@DiemLan1,
               DiemLan2=@DiemLan2
             where MaSV=@MaSV
GO
/****** Object:  StoredProcedure [dbo].[sp_updateHEDT]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_updateHEDT]
          (
            @MaHeDT char(5),
            @TenHeDT nvarchar(40)
          )
          as

          update HEDT
            set  
               MaHeDT=@MaHeDT,
               TenHeDT=@TenHeDT
            where MaHeDT=@MaHeDT
GO
/****** Object:  StoredProcedure [dbo].[sp_updateKHOA]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_updateKHOA]
          (
            @MaKhoa char(5),
            @TenKhoa nvarchar(30),
            @DiaChi nvarchar(100),
            @DienThoai varchar(20)
          )
          as

          update KHOA
            set  
               MaKhoa=@MaKhoa,
               TenKhoa=@TenKhoa,
           DiaChi=@DiaChi,
               DienThoai=@DienThoai
             where MaKhoa=@MaKhoa
GO
/****** Object:  StoredProcedure [dbo].[sp_updateKHOAHOC]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create procedure [dbo].[sp_updateKHOAHOC]
          (
            @MaKhoaHoc char(5),
            @TenKhoaHoc nvarchar(20)
          )
          as

          update KHOAHOC
            set  
               MaKhoaHoc=@MaKhoaHoc,
               TenKhoaHoc=@TenKhoaHoc
            where MaKhoaHoc=@MaKhoaHoc

GO
/****** Object:  StoredProcedure [dbo].[sp_updateLOP]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_updateLOP]
          (
           @MALOP char(5),
           @TENLOP nvarchar(30),
           @MAKHOA CHAR(5),
           @MaHeDT CHAR(5),
           @MaKhoaHoc CHAR(5)
          )
          as

          update LOP
            set  
               --MALOP=@MALOP,
               TENLOP=@TENLOP,
           MAKHOA=@MAKHOA,
               MaHeDT=@MaHeDT,
               MaKhoaHoc=@MaKhoaHoc
             where MALOP=@MALOP
GO
/****** Object:  StoredProcedure [dbo].[sp_updateSINHVIEN]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_updateSINHVIEN]
          (
           @MASV char(15),
           @TENSV nvarchar(20),
           @GIOITINH bit,
           @NGAYSINH DATETIME,
           @QUEQUAN nvarchar(50),
           @MALOP char(5)
          )
          as

          update SINHVIEN
            set  
               MASV=@MASV,
               TENSV=@TENSV,
           GIOITINH=@GIOITINH,
               NGAYSINH=@NGAYSINH,
               QUEQUAN=@QUEQUAN,
               MALOP=@MALOP
             where MASV=@MASV
GO
/****** Object:  StoredProcedure [dbo].[SV_Delete]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SV_Delete] @maSV nvarchar(50)
as
begin
	delete from SINHVIEN where maSV=@maSV
end

GO
/****** Object:  StoredProcedure [dbo].[SV_Insert]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SV_Insert] 
@maSV nvarchar(50),
@tenSV nvarchar(50),
@gioiTinh nvarchar(3),
@ngaySinh datetime,
@diaChi nvarchar(50),
@dienThoai nvarchar(10),
@maLop nvarchar(50)
as
begin 
	insert into SINHVIEN values(@maSV,@tenSV,@gioiTinh,@ngaySinh,@diaChi,@dienThoai,@maLop)
end

GO
/****** Object:  StoredProcedure [dbo].[SV_SelectAll]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SV_SelectAll] 
as
begin
	select * from SINHVIEN 
end

GO
/****** Object:  StoredProcedure [dbo].[SV_SelectBymaLop]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SV_SelectBymaLop]  @maLop nvarchar(50)
as
begin
	select * from SINHVIEN where maLop=@maLop
end

GO
/****** Object:  StoredProcedure [dbo].[SV_SelectBymaSV]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SV_SelectBymaSV] @maSV nvarchar(50)
as
begin
	select * from SINHVIEN  where maSV=@maSV
end

GO
/****** Object:  StoredProcedure [dbo].[SV_SelectmaLopBymaSV]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SV_SelectmaLopBymaSV] @maSV nvarchar(50)
as begin
select l.maLop,l.tenLop from SINHVIEN sv inner join LOP l  on sv.maLop=l.maLop where sv.maSV=@maSV
end
GO
/****** Object:  StoredProcedure [dbo].[SV_Update]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SV_Update] 
@maSV nvarchar(50),
@tenSV nvarchar(50),
@gioiTinh nvarchar(3),
@ngaySinh datetime,
@diaChi nvarchar(50),
@dienThoai nvarchar(10),
@maLop nvarchar(50)
as
begin 
	update SINHVIEN set tenSV=@tenSV,gioiTinh=@gioiTinh,ngaySinh=@ngaySinh,diaChi=@diaChi,dienThoai=@dienThoai,maLop=@maLop where maSV=@maSV
end

GO
/****** Object:  StoredProcedure [dbo].[TB_DeleteBymaSV_TG]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 CREATE proc [dbo].[TB_DeleteBymaSV_TG] @maSV nvarchar(50)
as begin
	delete from  THONGBAO where maSV=@maSV and DAY(tgThongBao)=DAY(GETDATE())
 end


GO
/****** Object:  StoredProcedure [dbo].[TB_DeleteByTG]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TB_DeleteByTG] @tg datetime
as begin
	delete from  THONGBAO where DAY(tgThongBao)=DAY(@tg)
 end

GO
/****** Object:  StoredProcedure [dbo].[TB_Insert]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TB_Insert] @maSV nvarchar(50),@nd nvarchar(MAX)
as begin
	insert into THONGBAO values(@maSV,@nd,GETDATE())
end

GO
/****** Object:  StoredProcedure [dbo].[TB_SelectBymaSV_TG]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TB_SelectBymaSV_TG] @maSV nvarchar(50)
as begin
	select * from THONGBAO where maSV=@maSV --and DAY(tgThongBao)=DAY(GETDATE())
end

GO
/****** Object:  StoredProcedure [dbo].[TK_Delete]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TK_Delete] @taiKhoan nvarchar(50)
as begin 
	delete from TAIKHOAN where taiKhoan=@taiKhoan
end

GO
/****** Object:  StoredProcedure [dbo].[TK_Insert]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TK_Insert](
	@taiKhoan nvarchar(50),
	@maKhau nvarchar(50),
	@tenTaiKhoan nvarchar(50),
	@loaiTaiKhoan nvarchar(50)
)as begin
	insert into TAIKHOAN values(@taiKhoan,@maKhau,@tenTaiKhoan,@loaiTaiKhoan)
end

GO
/****** Object:  StoredProcedure [dbo].[TK_SelectAll]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TK_SelectAll]
as begin
	select* from TAIKHOAN
end

GO
/****** Object:  StoredProcedure [dbo].[TK_SelectBytaiKhoan]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TK_SelectBytaiKhoan] @taiKhoan nvarchar(50)
as begin
	select* from TAIKHOAN where taiKhoan=@taiKhoan
end

GO
/****** Object:  StoredProcedure [dbo].[TK_Update]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TK_Update](
	@taiKhoan nvarchar(50),
	@maKhau nvarchar(50),
	@tenTaiKhoan nvarchar(50),
	@loaiTaiKhoan nvarchar(50)
)as begin
	update TAIKHOAN set matKhau=@maKhau, tenTaiKhoan=@tenTaiKhoan, loaiTaiKhoan=@loaiTaiKhoan where taiKhoan=@taiKhoan
end

GO
/****** Object:  StoredProcedure [dbo].[TK_UpdatemK]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TK_UpdatemK](
	@taiKhoan nvarchar(50),
	@maKhau nvarchar(50)
	
)as begin
	update TAIKHOAN set matKhau=@maKhau where taiKhoan=@taiKhoan
end


GO
/****** Object:  StoredProcedure [dbo].[TTHT_SelectAll]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TTHT_SelectAll]
as begin
	select * from TTHETHONG
end
GO
/****** Object:  StoredProcedure [dbo].[TTHT_Update]    Script Date: 5/28/2022 1:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TTHT_Update] (
	@tinh nvarchar(50), 
	@donViChuQuan nvarchar(50), 
	@tenTruong nvarchar(50), 
	@khoaHoc nvarchar(50), 
	@nganhHoc nvarchar(50), 
	@chuyenNganh nvarchar(50)
)
as begin
	update TTHETHONG set tinh=@tinh,donViChuQuan=@donViChuQuan,tenTruong=@tenTruong,
	khoaHoc=@khoaHoc,nganhHoc=@nganhHoc,chuyenNganh=@chuyenNganh
end
GO
USE [master]
GO
ALTER DATABASE [QL_DiemSV] SET  READ_WRITE 
GO