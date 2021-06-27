USE [master]
GO
/****** Object:  Database [QuanLyTHPT]    Script Date: 6/28/2021 12:43:41 AM ******/
CREATE DATABASE [QuanLyTHPT]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyTHPT', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER2706\MSSQL\DATA\QuanLyTHPT.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLyTHPT_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER2706\MSSQL\DATA\QuanLyTHPT_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLyTHPT] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyTHPT].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyTHPT] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyTHPT] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyTHPT] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyTHPT] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyTHPT] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyTHPT] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyTHPT] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyTHPT] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyTHPT] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyTHPT] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyTHPT] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyTHPT] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyTHPT] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyTHPT] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyTHPT] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyTHPT] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyTHPT] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyTHPT] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyTHPT] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyTHPT] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyTHPT] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyTHPT] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyTHPT] SET RECOVERY FULL 
GO
ALTER DATABASE [QuanLyTHPT] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyTHPT] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyTHPT] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyTHPT] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyTHPT] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QuanLyTHPT] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QuanLyTHPT', N'ON'
GO
USE [QuanLyTHPT]
GO
/****** Object:  User [abc]    Script Date: 6/28/2021 12:43:42 AM ******/
CREATE USER [abc] FOR LOGIN [abc] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [abc]
GO
/****** Object:  UserDefinedFunction [dbo].[TKD]    Script Date: 6/28/2021 12:43:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[TKD](@mamon varchar(50))
returns @ThongKeDiem table
(	Gioi float,
	Kha float,
	TB float)
as 
begin 
declare @tonghs float, @gioi float, @kha float, @tb float, @ptg float, @ptk float, @pttb float
set @tonghs = (select count(h.mahs) 
				from hocsinh h
				where mahs like 'K2%')
set @gioi = ( select count(h.mahs)
				from hocsinh h , diem d ,mon m 
				where h.mahs = d.mahs
				and m.mamon = d.mamon
				and m.mamon = @mamon
				and h.mahs like 'K2%'
				and d.diemtb >= 8)
set @kha = ( select count(h.mahs)
				from hocsinh h , diem d ,mon m
				where h.mahs = d.mahs
				and m.mamon = d.mamon
				and m.mamon = @mamon
				and h.mahs like 'K2%'
				and d.diemtb < 8 and d.diemtb >=6.5)
set @tb = ( select count(h.mahs)
				from hocsinh h , diem d , mon m
				where h.mahs = d.mahs
				and m.mamon = d.mamon
				and m.mamon = @mamon
				and h.mahs like 'K2%'
				and d.diemtb < 6.5 )
set @ptg = @gioi/@tonghs *100
set @ptk = @kha/@tonghs * 100
set @pttb = @tb/@tonghs * 100
insert into @ThongKeDiem
select Gioi = @ptg, Kha = @ptk, TB = @pttb
return
end
GO
/****** Object:  UserDefinedFunction [dbo].[TKD2]    Script Date: 6/28/2021 12:43:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create function [dbo].[TKD2](@mamon varchar(50))
returns @ThongKeDiem table
(	Gioi float,
	Kha float,
	TB float)
as 
begin 
declare @tonghs float, @gioi float, @kha float, @tb float, @ptg float, @ptk float, @pttb float
set @tonghs = (select count(h.mahs) 
				from hocsinh h
				where mahs like 'K3%')
set @gioi = ( select count(h.mahs)
				from hocsinh h , diem d ,mon m 
				where h.mahs = d.mahs
				and m.mamon = d.mamon
				and m.mamon = @mamon
				and h.mahs like 'K3%'
				and d.diemtb > 8)
set @kha = ( select count(h.mahs)
				from hocsinh h , diem d ,mon m
				where h.mahs = d.mahs
				and m.mamon = d.mamon
				and m.mamon = @mamon
				and h.mahs like 'K3%'
				and d.diemtb < 8 and d.diemtb >6.5)
set @tb = ( select count(h.mahs)
				from hocsinh h , diem d , mon m
				where h.mahs = d.mahs
				and m.mamon = d.mamon
				and m.mamon = @mamon
				and h.mahs like 'K3%'
				and d.diemtb < 6.5 )
set @ptg = @gioi/@tonghs *100
set @ptk = @kha/@tonghs * 100
set @pttb = @tb/@tonghs * 100
insert into @ThongKeDiem
select Gioi = @ptg, Kha = @ptk, TB = @pttb
return
end
GO
/****** Object:  UserDefinedFunction [dbo].[TKD3]    Script Date: 6/28/2021 12:43:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create function [dbo].[TKD3](@mamon varchar(50))
returns @ThongKeDiem table
(	Gioi float,
	Kha float,
	TB float)
as 
begin 
declare @tonghs float, @gioi float, @kha float, @tb float, @ptg float, @ptk float, @pttb float
set @tonghs = (select count(h.mahs) 
				from hocsinh h
				where mahs like 'K1%')
set @gioi = ( select count(h.mahs)
				from hocsinh h , diem d ,mon m 
				where h.mahs = d.mahs
				and m.mamon = d.mamon
				and m.mamon = @mamon
				and h.mahs like 'K1%'
				and d.diemtb > 8)
set @kha = ( select count(h.mahs)
				from hocsinh h , diem d ,mon m
				where h.mahs = d.mahs
				and m.mamon = d.mamon
				and m.mamon = @mamon
				and h.mahs like 'K1%'
				and d.diemtb < 8 and d.diemtb >6.5)
set @tb = ( select count(h.mahs)
				from hocsinh h , diem d , mon m
				where h.mahs = d.mahs
				and m.mamon = d.mamon
				and m.mamon = @mamon
				and h.mahs like 'K1%'
				and d.diemtb < 6.5 )
set @ptg = @gioi/@tonghs *100
set @ptk = @kha/@tonghs * 100
set @pttb = @tb/@tonghs * 100
insert into @ThongKeDiem
select Gioi = @ptg, Kha = @ptk, TB = @pttb
return
end
GO
/****** Object:  UserDefinedFunction [dbo].[TKHK]    Script Date: 6/28/2021 12:43:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[TKHK](@mamon varchar(50))
returns @Thongkehanhkiem table
(	Tot float,
	Kha float,
	TB float)
as 
begin 
declare @tonghs float, @tot float, @kha float, @tb float, @ptt float, @ptk float, @pttb float
set @tonghs = (select count(h.mahs) 
				from hocsinh h
				where mahs like 'K2%')
set @tot = ( select count(mahs)
				from hocsinh 
				where hanhkiem = 'tot'
				and mahs like 'K2%')
set @kha = (  select count(mahs)
				from hocsinh 
				where hanhkiem = 'kha'
				and mahs like 'K2%')
set @tb = ( select count(mahs)
				from hocsinh 
				where hanhkiem = 'tb'
				and mahs like 'K2%' )
set @ptt = @tot/@tonghs *100
set @ptk = @kha/@tonghs * 100
set @pttb = @tb/@tonghs * 100
insert into @Thongkehanhkiem
select Gioi = @ptt, Kha = @ptk, TB = @pttb
return
end
GO
/****** Object:  UserDefinedFunction [dbo].[TKHK2]    Script Date: 6/28/2021 12:43:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[TKHK2](@mamon varchar(50))
returns @Thongkehanhkiem table
(	Tot float,
	Kha float,
	TB float)
as 
begin 
declare @tonghs float, @tot float, @kha float, @tb float, @ptt float, @ptk float, @pttb float
set @tonghs = (select count(h.mahs) 
				from hocsinh h
				where mahs like 'K3%')
set @tot = ( select count(mahs)
				from hocsinh 
				where hanhkiem = 'tot'
				and mahs like 'K3%')
set @kha = (  select count(mahs)
				from hocsinh 
				where hanhkiem = 'kha'
				and mahs like 'K3%')
set @tb = ( select count(mahs)
				from hocsinh 
				where hanhkiem = 'tb'
				and mahs like 'K3%' )
set @ptt = @tot/@tonghs *100
set @ptk = @kha/@tonghs * 100
set @pttb = @tb/@tonghs * 100
insert into @Thongkehanhkiem
select Gioi = @ptt, Kha = @ptk, TB = @pttb
return
end
GO
/****** Object:  UserDefinedFunction [dbo].[TKHK3]    Script Date: 6/28/2021 12:43:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[TKHK3](@mamon varchar(50))
returns @Thongkehanhkiem table
(	Tot float,
	Kha float,
	TB float)
as 
begin 
declare @tonghs float, @tot float, @kha float, @tb float, @ptt float, @ptk float, @pttb float
set @tonghs = (select count(h.mahs) 
				from hocsinh h
				where mahs like 'K1%')
set @tot = ( select count(mahs)
				from hocsinh 
				where hanhkiem = 'tot'
				and mahs like 'K1%')
set @kha = (  select count(mahs)
				from hocsinh 
				where hanhkiem = 'kha'
				and mahs like 'K1%')
set @tb = ( select count(mahs)
				from hocsinh 
				where hanhkiem = 'tb'
				and mahs like 'K1%' )
set @ptt = @tot/@tonghs *100
set @ptk = @kha/@tonghs * 100
set @pttb = @tb/@tonghs * 100
insert into @Thongkehanhkiem
select Gioi = @ptt, Kha = @ptk, TB = @pttb
return
end
GO
/****** Object:  Table [dbo].[dangnhap]    Script Date: 6/28/2021 12:43:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dangnhap](
	[taikhoan] [nvarchar](255) NOT NULL,
	[matkhau] [nvarchar](255) NULL,
	[ten] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[taikhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[diem]    Script Date: 6/28/2021 12:43:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[diem](
	[mahs] [char](10) NULL,
	[mamon] [char](10) NULL,
	[diemtb] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[giaovien]    Script Date: 6/28/2021 12:43:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[giaovien](
	[magv] [char](10) NOT NULL,
	[tengv] [varchar](255) NULL,
	[ngaysinh] [date] NULL,
	[gioitinh] [char](3) NULL,
	[mamon] [char](10) NULL,
	[luong] [int] NULL,
	[chunhiem] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[magv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hocsinh]    Script Date: 6/28/2021 12:43:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hocsinh](
	[mahs] [char](10) NOT NULL,
	[tenhs] [varchar](255) NULL,
	[ngaysinh] [date] NULL,
	[noisinh] [varchar](255) NULL,
	[malop] [char](10) NULL,
	[gt] [char](3) NULL,
	[hanhkiem] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[mahs] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[lop]    Script Date: 6/28/2021 12:43:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lop](
	[malop] [char](10) NOT NULL,
	[tenlop] [varchar](255) NULL,
	[siso] [int] NULL,
	[magv] [char](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[malop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[mon]    Script Date: 6/28/2021 12:43:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[mon](
	[mamon] [char](10) NOT NULL,
	[tenmon] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[mamon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[dangnhap] ([taikhoan], [matkhau], [ten]) VALUES (N'1', N'1', N'Lê Thanh Nam ')
INSERT [dbo].[dangnhap] ([taikhoan], [matkhau], [ten]) VALUES (N'admin1', N'1', N'Hoàng Lê Minh')
INSERT [dbo].[dangnhap] ([taikhoan], [matkhau], [ten]) VALUES (N'admin2', N'654321', N'Christiano Ronaldo')
GO
INSERT [dbo].[diem] ([mahs], [mamon], [diemtb]) VALUES (N'K2001     ', N'MM01      ', 8.2)
INSERT [dbo].[diem] ([mahs], [mamon], [diemtb]) VALUES (N'K2001     ', N'MM02      ', 8.3)
INSERT [dbo].[diem] ([mahs], [mamon], [diemtb]) VALUES (N'K2001     ', N'MM03      ', 7.8)
INSERT [dbo].[diem] ([mahs], [mamon], [diemtb]) VALUES (N'K2001     ', N'MM04      ', 8.8)
INSERT [dbo].[diem] ([mahs], [mamon], [diemtb]) VALUES (N'K2001     ', N'MM05      ', 9)
INSERT [dbo].[diem] ([mahs], [mamon], [diemtb]) VALUES (N'K2001     ', N'MM06      ', 8.2)
INSERT [dbo].[diem] ([mahs], [mamon], [diemtb]) VALUES (N'K2001     ', N'MM07      ', 8.2)
INSERT [dbo].[diem] ([mahs], [mamon], [diemtb]) VALUES (N'K2001     ', N'MM08      ', 7.2)
INSERT [dbo].[diem] ([mahs], [mamon], [diemtb]) VALUES (N'K2001     ', N'MM09      ', 8.6)
INSERT [dbo].[diem] ([mahs], [mamon], [diemtb]) VALUES (N'K2001     ', N'MM10      ', 8.6)
INSERT [dbo].[diem] ([mahs], [mamon], [diemtb]) VALUES (N'K2002     ', N'MM01      ', 8.2)
INSERT [dbo].[diem] ([mahs], [mamon], [diemtb]) VALUES (N'K2002     ', N'MM02      ', 8.3)
INSERT [dbo].[diem] ([mahs], [mamon], [diemtb]) VALUES (N'K2002     ', N'MM03      ', 8.3)
INSERT [dbo].[diem] ([mahs], [mamon], [diemtb]) VALUES (N'K2002     ', N'MM04      ', 9.2)
INSERT [dbo].[diem] ([mahs], [mamon], [diemtb]) VALUES (N'K2002     ', N'MM05      ', 8.8)
INSERT [dbo].[diem] ([mahs], [mamon], [diemtb]) VALUES (N'K2002     ', N'MM06      ', 8.9)
INSERT [dbo].[diem] ([mahs], [mamon], [diemtb]) VALUES (N'K2002     ', N'MM07      ', 9)
INSERT [dbo].[diem] ([mahs], [mamon], [diemtb]) VALUES (N'K2002     ', N'MM08      ', 8.6)
INSERT [dbo].[diem] ([mahs], [mamon], [diemtb]) VALUES (N'K2002     ', N'MM09      ', 8.5)
INSERT [dbo].[diem] ([mahs], [mamon], [diemtb]) VALUES (N'K2002     ', N'MM10      ', 9)
INSERT [dbo].[diem] ([mahs], [mamon], [diemtb]) VALUES (N'K2003     ', N'MM01      ', 8.1)
INSERT [dbo].[diem] ([mahs], [mamon], [diemtb]) VALUES (N'K2003     ', N'MM02      ', 8.5)
INSERT [dbo].[diem] ([mahs], [mamon], [diemtb]) VALUES (N'K2004     ', N'MM01      ', 7.5)
INSERT [dbo].[diem] ([mahs], [mamon], [diemtb]) VALUES (N'K2005     ', N'MM01      ', 7.7)
INSERT [dbo].[diem] ([mahs], [mamon], [diemtb]) VALUES (N'K2006     ', N'MM01      ', 5)
INSERT [dbo].[diem] ([mahs], [mamon], [diemtb]) VALUES (N'K2007     ', N'MM01      ', 7.9)
INSERT [dbo].[diem] ([mahs], [mamon], [diemtb]) VALUES (N'K2008     ', N'MM01      ', 9)
INSERT [dbo].[diem] ([mahs], [mamon], [diemtb]) VALUES (N'K2009     ', N'MM01      ', 8.5)
INSERT [dbo].[diem] ([mahs], [mamon], [diemtb]) VALUES (N'K2010     ', N'MM01      ', 8.3)
INSERT [dbo].[diem] ([mahs], [mamon], [diemtb]) VALUES (N'K2003     ', N'MM03      ', 7.6)
INSERT [dbo].[diem] ([mahs], [mamon], [diemtb]) VALUES (N'K2004     ', N'MM02      ', 8.7)
INSERT [dbo].[diem] ([mahs], [mamon], [diemtb]) VALUES (N'K2005     ', N'MM02      ', 9)
INSERT [dbo].[diem] ([mahs], [mamon], [diemtb]) VALUES (N'K2006     ', N'MM02      ', 5.5)
INSERT [dbo].[diem] ([mahs], [mamon], [diemtb]) VALUES (N'K2007     ', N'MM02      ', 6.5)
INSERT [dbo].[diem] ([mahs], [mamon], [diemtb]) VALUES (N'K2008     ', N'MM02      ', 8.5)
INSERT [dbo].[diem] ([mahs], [mamon], [diemtb]) VALUES (N'K2009     ', N'MM02      ', 9.2)
INSERT [dbo].[diem] ([mahs], [mamon], [diemtb]) VALUES (N'K2010     ', N'MM02      ', 7.8)
INSERT [dbo].[diem] ([mahs], [mamon], [diemtb]) VALUES (NULL, NULL, NULL)
GO
INSERT [dbo].[giaovien] ([magv], [tengv], [ngaysinh], [gioitinh], [mamon], [luong], [chunhiem]) VALUES (N'GV01      ', N'Hoàng Lê Minh', CAST(N'1980-06-25' AS Date), N'Nam', N'MM01      ', 15000000, 1)
INSERT [dbo].[giaovien] ([magv], [tengv], [ngaysinh], [gioitinh], [mamon], [luong], [chunhiem]) VALUES (N'GV02      ', N'Nguyen Van Thuan', CAST(N'1983-05-15' AS Date), N'Nam', N'MM01      ', 15000000, 1)
INSERT [dbo].[giaovien] ([magv], [tengv], [ngaysinh], [gioitinh], [mamon], [luong], [chunhiem]) VALUES (N'GV03      ', N'Nguyen Thi Thu Thuy', CAST(N'1990-01-01' AS Date), N'Nu ', N'MM01      ', 14000000, 1)
INSERT [dbo].[giaovien] ([magv], [tengv], [ngaysinh], [gioitinh], [mamon], [luong], [chunhiem]) VALUES (N'GV04      ', N'Le Thanh Nam', CAST(N'1986-06-27' AS Date), N'Nam', N'MM01      ', 14000000, 1)
INSERT [dbo].[giaovien] ([magv], [tengv], [ngaysinh], [gioitinh], [mamon], [luong], [chunhiem]) VALUES (N'GV05      ', N'Nguyen Tu Uyen', CAST(N'1986-02-10' AS Date), N'Nu ', N'MM01      ', 14000000, 1)
INSERT [dbo].[giaovien] ([magv], [tengv], [ngaysinh], [gioitinh], [mamon], [luong], [chunhiem]) VALUES (N'GV06      ', N'Nguyen Kim Anh', CAST(N'1979-12-02' AS Date), N'Nu ', N'MM02      ', 14000000, 1)
INSERT [dbo].[giaovien] ([magv], [tengv], [ngaysinh], [gioitinh], [mamon], [luong], [chunhiem]) VALUES (N'GV07      ', N'Le Thu Hang', CAST(N'1976-11-02' AS Date), N'Nu ', N'MM02      ', 14000000, 1)
INSERT [dbo].[giaovien] ([magv], [tengv], [ngaysinh], [gioitinh], [mamon], [luong], [chunhiem]) VALUES (N'GV08      ', N'Le Hai Hau', CAST(N'1976-04-02' AS Date), N'Nu ', N'MM02      ', 15000000, 1)
INSERT [dbo].[giaovien] ([magv], [tengv], [ngaysinh], [gioitinh], [mamon], [luong], [chunhiem]) VALUES (N'GV09      ', N'Tran Hai Loan', CAST(N'1977-08-08' AS Date), N'Nu ', N'MM02      ', 15000000, 1)
INSERT [dbo].[giaovien] ([magv], [tengv], [ngaysinh], [gioitinh], [mamon], [luong], [chunhiem]) VALUES (N'GV10      ', N'Nguyen Thi Tu', CAST(N'1980-12-01' AS Date), N'Nu ', N'MM02      ', 15000000, 1)
INSERT [dbo].[giaovien] ([magv], [tengv], [ngaysinh], [gioitinh], [mamon], [luong], [chunhiem]) VALUES (N'GV11      ', N'Tran Thanh Loan', CAST(N'1980-01-05' AS Date), N'Nu ', N'MM03      ', 15000000, 1)
INSERT [dbo].[giaovien] ([magv], [tengv], [ngaysinh], [gioitinh], [mamon], [luong], [chunhiem]) VALUES (N'GV12      ', N'Le Hai Loan', CAST(N'1981-05-03' AS Date), N'Nu ', N'MM03      ', 14000000, 1)
INSERT [dbo].[giaovien] ([magv], [tengv], [ngaysinh], [gioitinh], [mamon], [luong], [chunhiem]) VALUES (N'GV13      ', N'Nguyen Thi Xuyen', CAST(N'1980-06-24' AS Date), N'Nu ', N'MM03      ', 12000000, 1)
INSERT [dbo].[giaovien] ([magv], [tengv], [ngaysinh], [gioitinh], [mamon], [luong], [chunhiem]) VALUES (N'GV14      ', N'Hoang Thai Hau', CAST(N'1981-10-30' AS Date), N'Nu ', N'MM03      ', 12000000, 1)
INSERT [dbo].[giaovien] ([magv], [tengv], [ngaysinh], [gioitinh], [mamon], [luong], [chunhiem]) VALUES (N'GV15      ', N'Vu Hai Ninh', CAST(N'1979-03-24' AS Date), N'Nam', N'MM04      ', 12000000, 1)
INSERT [dbo].[giaovien] ([magv], [tengv], [ngaysinh], [gioitinh], [mamon], [luong], [chunhiem]) VALUES (N'GV16      ', N'Thai Viet Hoang', CAST(N'1979-04-27' AS Date), N'Nam', N'MM04      ', 12000000, 1)
INSERT [dbo].[giaovien] ([magv], [tengv], [ngaysinh], [gioitinh], [mamon], [luong], [chunhiem]) VALUES (N'GV17      ', N'Nguyen Thi Hau', CAST(N'1976-03-27' AS Date), N'Nu ', N'MM04      ', 14000000, 1)
INSERT [dbo].[giaovien] ([magv], [tengv], [ngaysinh], [gioitinh], [mamon], [luong], [chunhiem]) VALUES (N'GV18      ', N'Tran Van Son', CAST(N'1976-05-30' AS Date), N'Nam', N'MM04      ', 15000000, 1)
INSERT [dbo].[giaovien] ([magv], [tengv], [ngaysinh], [gioitinh], [mamon], [luong], [chunhiem]) VALUES (N'GV19      ', N'Nguyen Minh Hang', CAST(N'1975-02-27' AS Date), N'Nu ', N'MM05      ', 12000000, 1)
INSERT [dbo].[giaovien] ([magv], [tengv], [ngaysinh], [gioitinh], [mamon], [luong], [chunhiem]) VALUES (N'GV20      ', N'Le Nguyen Minh Tu', CAST(N'1979-10-25' AS Date), N'Nu ', N'MM05      ', 12000000, 1)
INSERT [dbo].[giaovien] ([magv], [tengv], [ngaysinh], [gioitinh], [mamon], [luong], [chunhiem]) VALUES (N'GV21      ', N'Ton Quynh Mai', CAST(N'1980-11-25' AS Date), N'Nu ', N'MM05      ', 12000000, 1)
INSERT [dbo].[giaovien] ([magv], [tengv], [ngaysinh], [gioitinh], [mamon], [luong], [chunhiem]) VALUES (N'GV22      ', N'Nguyen Van Manh', CAST(N'1980-12-10' AS Date), N'Nam', N'MM06      ', 12000000, 1)
INSERT [dbo].[giaovien] ([magv], [tengv], [ngaysinh], [gioitinh], [mamon], [luong], [chunhiem]) VALUES (N'GV23      ', N'Hoang Van Truong', CAST(N'1980-02-11' AS Date), N'Nam', N'MM06      ', 14000000, 1)
INSERT [dbo].[giaovien] ([magv], [tengv], [ngaysinh], [gioitinh], [mamon], [luong], [chunhiem]) VALUES (N'GV24      ', N'Nguyen Thi Xuyen', CAST(N'1979-04-25' AS Date), N'Nu ', N'MM07      ', 15000000, 1)
INSERT [dbo].[giaovien] ([magv], [tengv], [ngaysinh], [gioitinh], [mamon], [luong], [chunhiem]) VALUES (N'GV25      ', N'Nguyen Mai Quynh', CAST(N'1979-05-07' AS Date), N'Nu ', N'MM07      ', 15000000, 1)
INSERT [dbo].[giaovien] ([magv], [tengv], [ngaysinh], [gioitinh], [mamon], [luong], [chunhiem]) VALUES (N'GV26      ', N'Nguyen Thi Van', CAST(N'1975-05-14' AS Date), N'Nu ', N'MM08      ', 15000000, 1)
INSERT [dbo].[giaovien] ([magv], [tengv], [ngaysinh], [gioitinh], [mamon], [luong], [chunhiem]) VALUES (N'GV27      ', N'Thai Hoang Linh', CAST(N'1980-12-12' AS Date), N'Nu ', N'MM08      ', 15000000, 1)
INSERT [dbo].[giaovien] ([magv], [tengv], [ngaysinh], [gioitinh], [mamon], [luong], [chunhiem]) VALUES (N'GV28      ', N'Nguyen Thi Lan', CAST(N'1978-11-12' AS Date), N'Nu ', N'MM09      ', 15000000, 1)
INSERT [dbo].[giaovien] ([magv], [tengv], [ngaysinh], [gioitinh], [mamon], [luong], [chunhiem]) VALUES (N'GV29      ', N'Nguyen Thi Loan', CAST(N'1978-01-05' AS Date), N'Nu ', N'MM09      ', 15000000, 1)
INSERT [dbo].[giaovien] ([magv], [tengv], [ngaysinh], [gioitinh], [mamon], [luong], [chunhiem]) VALUES (N'GV30      ', N'Tran Van Vi ', CAST(N'1980-12-04' AS Date), N'Nam', N'MM10      ', 15000000, 1)
INSERT [dbo].[giaovien] ([magv], [tengv], [ngaysinh], [gioitinh], [mamon], [luong], [chunhiem]) VALUES (N'GV31      ', N'Do Hoang Anh', CAST(N'1979-05-07' AS Date), N'Nam', N'MM10      ', 15000000, 0)
INSERT [dbo].[giaovien] ([magv], [tengv], [ngaysinh], [gioitinh], [mamon], [luong], [chunhiem]) VALUES (N'GV32      ', N'Tran Anh Linh', CAST(N'1985-06-12' AS Date), N'Nu ', N'MM10      ', 15000000, 0)
GO
INSERT [dbo].[hocsinh] ([mahs], [tenhs], [ngaysinh], [noisinh], [malop], [gt], [hanhkiem]) VALUES (N'K1001     ', N'Tran Van Lai', CAST(N'2001-07-04' AS Date), N'Ha Noi', N'A1K1      ', N'Nam', N'tot')
INSERT [dbo].[hocsinh] ([mahs], [tenhs], [ngaysinh], [noisinh], [malop], [gt], [hanhkiem]) VALUES (N'K1002     ', N'Nguyen Tuan Tu', CAST(N'2001-07-16' AS Date), N'Bac Giang', N'A1K1      ', N'Nam', N'Tot')
INSERT [dbo].[hocsinh] ([mahs], [tenhs], [ngaysinh], [noisinh], [malop], [gt], [hanhkiem]) VALUES (N'K1003     ', N'Tran Thu Trang', CAST(N'2001-04-09' AS Date), N'Ha Noi', N'A1K1      ', N'Nu ', N'Tot')
INSERT [dbo].[hocsinh] ([mahs], [tenhs], [ngaysinh], [noisinh], [malop], [gt], [hanhkiem]) VALUES (N'K1004     ', N'Tran Duc Bo', CAST(N'2001-01-25' AS Date), N'Ha Noi', N'A1K1      ', N'Nam', N'Kha ')
INSERT [dbo].[hocsinh] ([mahs], [tenhs], [ngaysinh], [noisinh], [malop], [gt], [hanhkiem]) VALUES (N'K2001     ', N'Nguyen Hoang Anh', CAST(N'2002-12-01' AS Date), N'Ha Nam', N'A1K2      ', N'Nam', N'tot')
INSERT [dbo].[hocsinh] ([mahs], [tenhs], [ngaysinh], [noisinh], [malop], [gt], [hanhkiem]) VALUES (N'K2002     ', N'Hoang Van Manh', CAST(N'2002-11-01' AS Date), N'Ha Nam', N'A1K2      ', N'Nam', N'tot')
INSERT [dbo].[hocsinh] ([mahs], [tenhs], [ngaysinh], [noisinh], [malop], [gt], [hanhkiem]) VALUES (N'K2003     ', N'Le Hoang Linh', CAST(N'2002-05-06' AS Date), N'Ha Noi', N'A1K2      ', N'Nu ', N'tot')
INSERT [dbo].[hocsinh] ([mahs], [tenhs], [ngaysinh], [noisinh], [malop], [gt], [hanhkiem]) VALUES (N'K2004     ', N'Le Kim Anh', CAST(N'2002-05-27' AS Date), N'Ha Noi', N'A1K2      ', N'Nu ', N'tot')
INSERT [dbo].[hocsinh] ([mahs], [tenhs], [ngaysinh], [noisinh], [malop], [gt], [hanhkiem]) VALUES (N'K2005     ', N'Hoang Viet Anh', CAST(N'2002-08-30' AS Date), N'Bac Ninh', N'A1K2      ', N'Nam', N'kha')
INSERT [dbo].[hocsinh] ([mahs], [tenhs], [ngaysinh], [noisinh], [malop], [gt], [hanhkiem]) VALUES (N'K2006     ', N'Tran Van Bach ', CAST(N'2002-07-07' AS Date), N'Bac Ninh', N'A2K2      ', N'Nam', N'kha')
INSERT [dbo].[hocsinh] ([mahs], [tenhs], [ngaysinh], [noisinh], [malop], [gt], [hanhkiem]) VALUES (N'K2007     ', N'Nguyen Hoang Bach', CAST(N'2002-01-02' AS Date), N'Ha Noi', N'A2K2      ', N'Nam', N'kha')
INSERT [dbo].[hocsinh] ([mahs], [tenhs], [ngaysinh], [noisinh], [malop], [gt], [hanhkiem]) VALUES (N'K2008     ', N'Le Thi Minh', CAST(N'2002-09-12' AS Date), N'Ha Noi', N'A2K2      ', N'Nu ', N'tot')
INSERT [dbo].[hocsinh] ([mahs], [tenhs], [ngaysinh], [noisinh], [malop], [gt], [hanhkiem]) VALUES (N'K2009     ', N'Vu Anh Linh', CAST(N'2002-09-01' AS Date), N'Ha Noi', N'A2K2      ', N'Nu ', N'tot')
INSERT [dbo].[hocsinh] ([mahs], [tenhs], [ngaysinh], [noisinh], [malop], [gt], [hanhkiem]) VALUES (N'K2010     ', N'Kieu Minh Huyen', CAST(N'2002-04-01' AS Date), N'Ha Noi', N'A2K2      ', N'Nu ', N'tot')
INSERT [dbo].[hocsinh] ([mahs], [tenhs], [ngaysinh], [noisinh], [malop], [gt], [hanhkiem]) VALUES (N'K3001     ', N'Le Mai Anh ', CAST(N'2003-10-06' AS Date), N'Ha Noi ', N'A1K3      ', N'Nu ', N'tot')
INSERT [dbo].[hocsinh] ([mahs], [tenhs], [ngaysinh], [noisinh], [malop], [gt], [hanhkiem]) VALUES (N'K3002     ', N'Le Minh Khoa ', CAST(N'2003-02-15' AS Date), N'Ha Noi ', N'A1K3      ', N'Nam', N'tot')
INSERT [dbo].[hocsinh] ([mahs], [tenhs], [ngaysinh], [noisinh], [malop], [gt], [hanhkiem]) VALUES (N'K3003     ', N'Le Minh Anh', CAST(N'2003-01-05' AS Date), N'Ha Noi', N'A1K3      ', N'Nu ', N'tot')
INSERT [dbo].[hocsinh] ([mahs], [tenhs], [ngaysinh], [noisinh], [malop], [gt], [hanhkiem]) VALUES (N'K3004     ', N'Nguyen Tuan Minh', CAST(N'2003-10-15' AS Date), N'Ha Noi', N'A1K3      ', N'Nam', N'kha')
INSERT [dbo].[hocsinh] ([mahs], [tenhs], [ngaysinh], [noisinh], [malop], [gt], [hanhkiem]) VALUES (N'K3005     ', N'Vu Thai Son', CAST(N'2003-12-24' AS Date), N'Bac Ninh', N'A1K3      ', N'Nam', N'kha')
INSERT [dbo].[hocsinh] ([mahs], [tenhs], [ngaysinh], [noisinh], [malop], [gt], [hanhkiem]) VALUES (N'K3006     ', N'Hoang Thai Linh', CAST(N'2003-11-12' AS Date), N'Bac Ninh', N'A1K3      ', N'Nu ', N'tot')
INSERT [dbo].[hocsinh] ([mahs], [tenhs], [ngaysinh], [noisinh], [malop], [gt], [hanhkiem]) VALUES (N'K3007     ', N'Hoang Van Thai', CAST(N'2003-05-14' AS Date), N'Bac Ninh', N'A1K3      ', N'Nam', N'tot')
INSERT [dbo].[hocsinh] ([mahs], [tenhs], [ngaysinh], [noisinh], [malop], [gt], [hanhkiem]) VALUES (N'K3008     ', N'Nguyen Viet Hoang', CAST(N'2003-06-27' AS Date), N'Thai Nguyen', N'A2K3      ', N'Nam', N'tot')
INSERT [dbo].[hocsinh] ([mahs], [tenhs], [ngaysinh], [noisinh], [malop], [gt], [hanhkiem]) VALUES (N'K3009     ', N'Thai Viet Anh', CAST(N'2003-10-12' AS Date), N'Bac Giang', N'A2K3      ', N'Nam', N'tot')
INSERT [dbo].[hocsinh] ([mahs], [tenhs], [ngaysinh], [noisinh], [malop], [gt], [hanhkiem]) VALUES (N'K3010     ', N'Nguyen Phuong Linh', CAST(N'2003-11-11' AS Date), N'Ha Noi', N'A2K3      ', N'Nu ', N'tot')
INSERT [dbo].[hocsinh] ([mahs], [tenhs], [ngaysinh], [noisinh], [malop], [gt], [hanhkiem]) VALUES (N'K3011     ', N'Nguyen Hoang Linh', CAST(N'2003-12-12' AS Date), N'Thai Nguyen', N'A2K3      ', N'Nu ', N'tot')
INSERT [dbo].[hocsinh] ([mahs], [tenhs], [ngaysinh], [noisinh], [malop], [gt], [hanhkiem]) VALUES (N'K3012     ', N'Nguyen Hai Anh', CAST(N'2003-08-15' AS Date), N'Ha Noi', N'A2K3      ', N'Nu ', N'tot')
INSERT [dbo].[hocsinh] ([mahs], [tenhs], [ngaysinh], [noisinh], [malop], [gt], [hanhkiem]) VALUES (N'K3013     ', N'Nguyen Hai Long', CAST(N'2003-07-30' AS Date), N'Ha Noi', N'A2K3      ', N'Nam', N'tot')
INSERT [dbo].[hocsinh] ([mahs], [tenhs], [ngaysinh], [noisinh], [malop], [gt], [hanhkiem]) VALUES (N'K3014     ', N'Hoang Le Minh ', CAST(N'2003-06-25' AS Date), N'Ha Noi', N'A3K3      ', N'Nam', N'tot')
INSERT [dbo].[hocsinh] ([mahs], [tenhs], [ngaysinh], [noisinh], [malop], [gt], [hanhkiem]) VALUES (N'K3015     ', N'Tran Van Dung', CAST(N'2003-07-05' AS Date), N'Ha Noi', N'A3K3      ', N'Nam', N'tot')
INSERT [dbo].[hocsinh] ([mahs], [tenhs], [ngaysinh], [noisinh], [malop], [gt], [hanhkiem]) VALUES (N'K3016     ', N'Tran Van Son', CAST(N'2003-09-05' AS Date), N'Thai Binh', N'A3K3      ', N'Nam', N'tot')
INSERT [dbo].[hocsinh] ([mahs], [tenhs], [ngaysinh], [noisinh], [malop], [gt], [hanhkiem]) VALUES (N'K3017     ', N'Hoang Linh Phuong', CAST(N'2003-04-04' AS Date), N'Moscow', N'A4K3      ', N'Nu ', N'tot')
INSERT [dbo].[hocsinh] ([mahs], [tenhs], [ngaysinh], [noisinh], [malop], [gt], [hanhkiem]) VALUES (N'K3018     ', N'Hoang Linh Anh', CAST(N'2003-04-04' AS Date), N'Moscow', N'A4K3      ', N'Nu ', N'kha')
INSERT [dbo].[hocsinh] ([mahs], [tenhs], [ngaysinh], [noisinh], [malop], [gt], [hanhkiem]) VALUES (N'K3019     ', N'Nguyen Van Minh', CAST(N'2003-05-05' AS Date), N'Ha Noi', N'A4K3      ', N'Nam', N'kha')
INSERT [dbo].[hocsinh] ([mahs], [tenhs], [ngaysinh], [noisinh], [malop], [gt], [hanhkiem]) VALUES (N'K3020     ', N'Le Hoang Long', CAST(N'2003-06-05' AS Date), N'Ha Noi ', N'A4K3      ', N'Nam', N'kha')
GO
INSERT [dbo].[lop] ([malop], [tenlop], [siso], [magv]) VALUES (N'A1K1      ', N'12A1', 44, N'GV01      ')
INSERT [dbo].[lop] ([malop], [tenlop], [siso], [magv]) VALUES (N'A1K2      ', N'11A1', 35, N'GV02      ')
INSERT [dbo].[lop] ([malop], [tenlop], [siso], [magv]) VALUES (N'A1K3      ', N'10A1', 40, N'GV03      ')
INSERT [dbo].[lop] ([malop], [tenlop], [siso], [magv]) VALUES (N'A2K1      ', N'12A2', 50, N'GV04      ')
INSERT [dbo].[lop] ([malop], [tenlop], [siso], [magv]) VALUES (N'A2K2      ', N'11A2', 45, N'GV05      ')
INSERT [dbo].[lop] ([malop], [tenlop], [siso], [magv]) VALUES (N'A2K3      ', N'10A2', 35, N'GV06      ')
INSERT [dbo].[lop] ([malop], [tenlop], [siso], [magv]) VALUES (N'A3K1      ', N'12A3', 45, N'GV07      ')
INSERT [dbo].[lop] ([malop], [tenlop], [siso], [magv]) VALUES (N'A3K2      ', N'11A3', 45, N'GV08      ')
INSERT [dbo].[lop] ([malop], [tenlop], [siso], [magv]) VALUES (N'A3K3      ', N'10A3', 44, N'GV09      ')
INSERT [dbo].[lop] ([malop], [tenlop], [siso], [magv]) VALUES (N'A4K1      ', N'12A4', 46, N'GV10      ')
INSERT [dbo].[lop] ([malop], [tenlop], [siso], [magv]) VALUES (N'A4K2      ', N'11A4', 44, N'GV11      ')
INSERT [dbo].[lop] ([malop], [tenlop], [siso], [magv]) VALUES (N'A4K3      ', N'10A4', 41, N'GV12      ')
INSERT [dbo].[lop] ([malop], [tenlop], [siso], [magv]) VALUES (N'A5K1      ', N'12A5', 44, N'GV13      ')
INSERT [dbo].[lop] ([malop], [tenlop], [siso], [magv]) VALUES (N'A5K2      ', N'11A5', 39, N'GV14      ')
INSERT [dbo].[lop] ([malop], [tenlop], [siso], [magv]) VALUES (N'A5K3      ', N'10A5', 39, N'GV15      ')
INSERT [dbo].[lop] ([malop], [tenlop], [siso], [magv]) VALUES (N'B10K1     ', N'12B10', 49, N'GV16      ')
INSERT [dbo].[lop] ([malop], [tenlop], [siso], [magv]) VALUES (N'B10K2     ', N'11B10', 46, N'GV17      ')
INSERT [dbo].[lop] ([malop], [tenlop], [siso], [magv]) VALUES (N'B10K3     ', N'10B10', 47, N'GV18      ')
INSERT [dbo].[lop] ([malop], [tenlop], [siso], [magv]) VALUES (N'B6K1      ', N'12B6', 39, N'GV19      ')
INSERT [dbo].[lop] ([malop], [tenlop], [siso], [magv]) VALUES (N'B6K2      ', N'11B6', 45, N'GV20      ')
INSERT [dbo].[lop] ([malop], [tenlop], [siso], [magv]) VALUES (N'B6K3      ', N'10B6', 40, N'GV21      ')
INSERT [dbo].[lop] ([malop], [tenlop], [siso], [magv]) VALUES (N'B7K1      ', N'12B7', 49, N'GV22      ')
INSERT [dbo].[lop] ([malop], [tenlop], [siso], [magv]) VALUES (N'B7K2      ', N'11B7', 46, N'GV23      ')
INSERT [dbo].[lop] ([malop], [tenlop], [siso], [magv]) VALUES (N'B7K3      ', N'10B7', 37, N'GV24      ')
INSERT [dbo].[lop] ([malop], [tenlop], [siso], [magv]) VALUES (N'B8K1      ', N'12B8', 45, N'GV25      ')
INSERT [dbo].[lop] ([malop], [tenlop], [siso], [magv]) VALUES (N'B8K2      ', N'11B8', 44, N'GV26      ')
INSERT [dbo].[lop] ([malop], [tenlop], [siso], [magv]) VALUES (N'B8K3      ', N'10B8', 50, N'GV27      ')
INSERT [dbo].[lop] ([malop], [tenlop], [siso], [magv]) VALUES (N'B9K1      ', N'12B9', 51, N'GV28      ')
INSERT [dbo].[lop] ([malop], [tenlop], [siso], [magv]) VALUES (N'B9K2      ', N'11B9', 44, N'GV29      ')
INSERT [dbo].[lop] ([malop], [tenlop], [siso], [magv]) VALUES (N'B9K3      ', N'10B9', 45, N'GV30      ')
GO
INSERT [dbo].[mon] ([mamon], [tenmon]) VALUES (N'MM01      ', N'Toan')
INSERT [dbo].[mon] ([mamon], [tenmon]) VALUES (N'MM02      ', N'Ngu Van')
INSERT [dbo].[mon] ([mamon], [tenmon]) VALUES (N'MM03      ', N'Ngoai Ngu')
INSERT [dbo].[mon] ([mamon], [tenmon]) VALUES (N'MM04      ', N'Vat Ly')
INSERT [dbo].[mon] ([mamon], [tenmon]) VALUES (N'MM05      ', N'Hoa Hoc')
INSERT [dbo].[mon] ([mamon], [tenmon]) VALUES (N'MM06      ', N'The Duc')
INSERT [dbo].[mon] ([mamon], [tenmon]) VALUES (N'MM07      ', N'Quoc Phong')
INSERT [dbo].[mon] ([mamon], [tenmon]) VALUES (N'MM08      ', N'GDCD')
INSERT [dbo].[mon] ([mamon], [tenmon]) VALUES (N'MM09      ', N'Lich Su')
INSERT [dbo].[mon] ([mamon], [tenmon]) VALUES (N'MM10      ', N'Sinh Hoc')
GO
ALTER TABLE [dbo].[diem]  WITH CHECK ADD FOREIGN KEY([mahs])
REFERENCES [dbo].[hocsinh] ([mahs])
GO
ALTER TABLE [dbo].[diem]  WITH CHECK ADD FOREIGN KEY([mamon])
REFERENCES [dbo].[mon] ([mamon])
GO
ALTER TABLE [dbo].[giaovien]  WITH CHECK ADD FOREIGN KEY([mamon])
REFERENCES [dbo].[mon] ([mamon])
GO
ALTER TABLE [dbo].[hocsinh]  WITH CHECK ADD FOREIGN KEY([malop])
REFERENCES [dbo].[lop] ([malop])
GO
ALTER TABLE [dbo].[lop]  WITH CHECK ADD FOREIGN KEY([magv])
REFERENCES [dbo].[giaovien] ([magv])
GO
ALTER TABLE [dbo].[giaovien]  WITH CHECK ADD CHECK  (([gioitinh]='Nu' OR [gioitinh]='Nam'))
GO
ALTER TABLE [dbo].[hocsinh]  WITH CHECK ADD CHECK  (([gt]='Nu' OR [gt]='Nam'))
GO
USE [master]
GO
ALTER DATABASE [QuanLyTHPT] SET  READ_WRITE 
GO
