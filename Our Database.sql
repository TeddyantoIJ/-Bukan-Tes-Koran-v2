USE [master]
GO
/****** Object:  Database [BTK]    Script Date: 27/07/2020 20:17:15 ******/
CREATE DATABASE [BTK]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BTK', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\BTK.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BTK_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\BTK_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [BTK] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BTK].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BTK] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BTK] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BTK] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BTK] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BTK] SET ARITHABORT OFF 
GO
ALTER DATABASE [BTK] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BTK] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BTK] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BTK] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BTK] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BTK] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BTK] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BTK] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BTK] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BTK] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BTK] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BTK] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BTK] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BTK] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BTK] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BTK] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BTK] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BTK] SET RECOVERY FULL 
GO
ALTER DATABASE [BTK] SET  MULTI_USER 
GO
ALTER DATABASE [BTK] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BTK] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BTK] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BTK] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BTK] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BTK] SET QUERY_STORE = OFF
GO
USE [BTK]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [BTK]
GO
/****** Object:  Table [dbo].[Configuration]    Script Date: 27/07/2020 20:17:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Configuration](
	[bahasa] [int] NULL,
	[suara] [int] NULL,
	[musik] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Score]    Script Date: 27/07/2020 20:17:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Score](
	[nama] [varchar](25) NULL,
	[nilai_benar] [int] NULL,
	[kecepatan] [float] NULL,
	[ketepatan] [float] NULL,
	[total_Soal] [int] NULL,
	[tanggal] [date] NULL,
	[waktu] [time](7) NULL,
	[waktu_main] [int] NULL,
	[operasi] [char](1) NULL
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[sp_cekSetting]    Script Date: 27/07/2020 20:17:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_cekSetting]
as
begin
	select * from [Configuration]
end
GO
/****** Object:  StoredProcedure [dbo].[sp_deleteScore]    Script Date: 27/07/2020 20:17:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_deleteScore]
as
begin
		drop table Score
		CREATE TABLE [dbo].[Score](
		[nama] [varchar](25) NULL,
		[nilai_benar] [int] NULL,
		[kecepatan] [float] NULL,
		[ketepatan] [float] NULL,
		[total_Soal] [int] NULL,
		[tanggal] [date] NULL,
		[waktu] [time](7) NULL,
		[waktu_main] [int] NULL,
		[operasi] [char](1) NULL
		)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_getAllScoreIndonesia]    Script Date: 27/07/2020 20:17:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_getAllScoreIndonesia]
as
begin
	select ROW_NUMBER() over(order by tanggal) No, nama as Nama, nilai_benar as Benar, kecepatan as Kecepatan,
	ketepatan as Ketepatan, total_soal as Soal, tanggal As Tanggal, waktu as Waktu, waktu_main as Periode, operasi as Operasi from (select * from Score c) base
end
GO
/****** Object:  StoredProcedure [dbo].[sp_getAllScoreIndonesiaBy]    Script Date: 27/07/2020 20:17:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_getAllScoreIndonesiaBy]
	@operasi char(1)
as
begin
	select ROW_NUMBER() over(order by tanggal) No, nama as Nama, nilai_benar as Benar, kecepatan as Kecepatan,
	ketepatan as Ketepatan, total_soal as Soal, tanggal As Tanggal, waktu as Waktu, waktu_main as Periode, operasi as Operasi from (select * from Score c where operasi = @operasi) base
end
GO
/****** Object:  StoredProcedure [dbo].[sp_insertData]    Script Date: 27/07/2020 20:17:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_insertData]
	@nama varchar(25),
	@nilai_benar int,
	@kecepatan varchar(4),
	@ketepatan varchar(4),
	@total_Soal int,
	@tanggal date,
	@waktu time,
	@waktu_main int,
	@operasi char(1)
as
begin
	insert into Score values(@nama,@nilai_benar,@kecepatan,@ketepatan,@total_Soal,@tanggal,@waktu,@waktu_main,@operasi)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_setHighscrore]    Script Date: 27/07/2020 20:17:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_setHighscrore]
	@operasi char(1),
	@waktu_main int
as
begin
	SELECT TOP (1) [nama]
      ,[nilai_benar]
  FROM [BTK].[dbo].[Score]
  where operasi = @operasi and waktu_main = @waktu_main
  order by nilai_benar desc 
end


  
GO
/****** Object:  StoredProcedure [dbo].[sp_updateSettingSuara]    Script Date: 27/07/2020 20:17:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_updateSettingSuara]
		@suara int,
		@musik int
as
begin
	update Configuration
	set suara = @suara, musik = @musik
end
GO
USE [master]
GO
ALTER DATABASE [BTK] SET  READ_WRITE 
GO
