USE [master]
GO
/****** Object:  Database [QuanLyTHPT]    Script Date: 6/27/2021 11:51:48 PM ******/
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
/****** Object:  User [abc]    Script Date: 6/27/2021 11:51:48 PM ******/
CREATE USER [abc] FOR LOGIN [abc] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [abc]
GO
/****** Object:  UserDefinedFunction [dbo].[TKD]    Script Date: 6/27/2021 11:51:48 PM ******/
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
/****** Object:  UserDefinedFunction [dbo].[TKD2]    Script Date: 6/27/2021 11:51:48 PM ******/
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
/****** Object:  UserDefinedFunction [dbo].[TKD3]    Script Date: 6/27/2021 11:51:48 PM ******/
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
/****** Object:  UserDefinedFunction [dbo].[TKHK]    Script Date: 6/27/2021 11:51:48 PM ******/
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
/****** Object:  UserDefinedFunction [dbo].[TKHK2]    Script Date: 6/27/2021 11:51:48 PM ******/
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
/****** Object:  UserDefinedFunction [dbo].[TKHK3]    Script Date: 6/27/2021 11:51:48 PM ******/
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
/****** Object:  Table [dbo].[dangnhap]    Script Date: 6/27/2021 11:51:48 PM ******/
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
/****** Object:  Table [dbo].[diem]    Script Date: 6/27/2021 11:51:48 PM ******/
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
/****** Object:  Table [dbo].[giaovien]    Script Date: 6/27/2021 11:51:48 PM ******/
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
/****** Object:  Table [dbo].[hocsinh]    Script Date: 6/27/2021 11:51:48 PM ******/
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
/****** Object:  Table [dbo].[lop]    Script Date: 6/27/2021 11:51:48 PM ******/
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
/****** Object:  Table [dbo].[mon]    Script Date: 6/27/2021 11:51:48 PM ******/
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
