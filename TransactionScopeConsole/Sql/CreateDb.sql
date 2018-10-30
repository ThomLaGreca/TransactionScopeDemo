
/****** Object:  Database [TransactionScopeDemo]    Script Date: 30/10/2018 5:07:19 PM ******/
CREATE DATABASE [TransactionScopeDemo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TransactionScopeDemo', FILENAME = N'D:\SQL\MSSQL13.MSSQLSERVER\MSSQL\DATA\TransactionScopeDemo.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TransactionScopeDemo_log', FILENAME = N'D:\SQL\MSSQL13.MSSQLSERVER\MSSQL\DATA\TransactionScopeDemo_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

ALTER DATABASE [TransactionScopeDemo] SET COMPATIBILITY_LEVEL = 130
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TransactionScopeDemo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [TransactionScopeDemo] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [TransactionScopeDemo] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [TransactionScopeDemo] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [TransactionScopeDemo] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [TransactionScopeDemo] SET ARITHABORT OFF 
GO

ALTER DATABASE [TransactionScopeDemo] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [TransactionScopeDemo] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [TransactionScopeDemo] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [TransactionScopeDemo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [TransactionScopeDemo] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [TransactionScopeDemo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [TransactionScopeDemo] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [TransactionScopeDemo] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [TransactionScopeDemo] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [TransactionScopeDemo] SET  DISABLE_BROKER 
GO

ALTER DATABASE [TransactionScopeDemo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [TransactionScopeDemo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [TransactionScopeDemo] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [TransactionScopeDemo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [TransactionScopeDemo] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [TransactionScopeDemo] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [TransactionScopeDemo] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [TransactionScopeDemo] SET RECOVERY FULL 
GO

ALTER DATABASE [TransactionScopeDemo] SET  MULTI_USER 
GO

ALTER DATABASE [TransactionScopeDemo] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [TransactionScopeDemo] SET DB_CHAINING OFF 
GO

ALTER DATABASE [TransactionScopeDemo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [TransactionScopeDemo] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [TransactionScopeDemo] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [TransactionScopeDemo] SET QUERY_STORE = OFF
GO

USE [TransactionScopeDemo]
GO

ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO

ALTER DATABASE [TransactionScopeDemo] SET  READ_WRITE 
GO

