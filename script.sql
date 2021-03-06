USE [master]
GO
/****** Object:  Database [librarydb]    Script Date: 5/4/2022 9:30:53 AM ******/
CREATE DATABASE [librarydb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'librarydb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\librarydb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'librarydb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\librarydb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [librarydb] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [librarydb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [librarydb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [librarydb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [librarydb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [librarydb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [librarydb] SET ARITHABORT OFF 
GO
ALTER DATABASE [librarydb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [librarydb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [librarydb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [librarydb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [librarydb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [librarydb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [librarydb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [librarydb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [librarydb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [librarydb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [librarydb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [librarydb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [librarydb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [librarydb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [librarydb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [librarydb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [librarydb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [librarydb] SET RECOVERY FULL 
GO
ALTER DATABASE [librarydb] SET  MULTI_USER 
GO
ALTER DATABASE [librarydb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [librarydb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [librarydb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [librarydb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [librarydb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [librarydb] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'librarydb', N'ON'
GO
ALTER DATABASE [librarydb] SET QUERY_STORE = OFF
GO
USE [librarydb]
GO
/****** Object:  User [libadmin]    Script Date: 5/4/2022 9:30:54 AM ******/
CREATE USER [libadmin] FOR LOGIN [libadmin] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [libadmin]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [libadmin]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [libadmin]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [libadmin]
GO
ALTER ROLE [db_datareader] ADD MEMBER [libadmin]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [libadmin]
GO
USE [librarydb]
GO
/****** Object:  Sequence [dbo].[mediaseq]    Script Date: 5/4/2022 9:30:54 AM ******/
CREATE SEQUENCE [dbo].[mediaseq] 
 AS [bigint]
 START WITH 1
 INCREMENT BY 1
 MINVALUE 1
 MAXVALUE 10000
 CACHE  1 
GO
USE [librarydb]
GO
/****** Object:  Sequence [dbo].[pubseq]    Script Date: 5/4/2022 9:30:54 AM ******/
CREATE SEQUENCE [dbo].[pubseq] 
 AS [bigint]
 START WITH 1
 INCREMENT BY 1
 MINVALUE 1
 MAXVALUE 10000
 CACHE  1 
GO
USE [librarydb]
GO
/****** Object:  Sequence [dbo].[rolseq]    Script Date: 5/4/2022 9:30:54 AM ******/
CREATE SEQUENCE [dbo].[rolseq] 
 AS [bigint]
 START WITH 1
 INCREMENT BY 1
 MINVALUE 1
 MAXVALUE 10000
 CACHE  1 
GO
USE [librarydb]
GO
/****** Object:  Sequence [dbo].[transeq]    Script Date: 5/4/2022 9:30:54 AM ******/
CREATE SEQUENCE [dbo].[transeq] 
 AS [bigint]
 START WITH 1
 INCREMENT BY 1
 MINVALUE 1
 MAXVALUE 10000
 CACHE  1 
GO
USE [librarydb]
GO
/****** Object:  Sequence [dbo].[userseq]    Script Date: 5/4/2022 9:30:54 AM ******/
CREATE SEQUENCE [dbo].[userseq] 
 AS [bigint]
 START WITH 1
 INCREMENT BY 1
 MINVALUE 1
 MAXVALUE 10000
 CACHE  1 
GO
/****** Object:  Table [dbo].[medialist]    Script Date: 5/4/2022 9:30:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[medialist](
	[mediaid] [numeric](18, 0) NOT NULL,
	[medianame] [varchar](50) NULL,
	[mediatype] [varchar](50) NULL,
	[mediagenre] [varchar](50) NULL,
	[mediaauthor] [varchar](50) NULL,
	[numberofcopies] [numeric](18, 0) NULL,
	[publisherid] [numeric](18, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[mediaid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[publisher]    Script Date: 5/4/2022 9:30:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[publisher](
	[publisherid] [numeric](18, 0) NOT NULL,
	[publishername] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[publisherid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rolelist]    Script Date: 5/4/2022 9:30:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rolelist](
	[roleid] [numeric](18, 0) NOT NULL,
	[rolename] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[roleid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[transactionlist]    Script Date: 5/4/2022 9:30:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[transactionlist](
	[transactionid] [numeric](18, 0) NOT NULL,
	[mediaid] [numeric](18, 0) NULL,
	[userid] [numeric](18, 0) NULL,
	[mediaqty] [numeric](18, 0) NULL,
	[transactiondate] [date] NULL,
	[transactiontype] [char](2) NULL,
	[transactionstatus] [char](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[transactionid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[userlist]    Script Date: 5/4/2022 9:30:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[userlist](
	[userid] [numeric](18, 0) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[psswd] [varchar](50) NOT NULL,
	[firstname] [varchar](50) NOT NULL,
	[lastname] [varchar](50) NOT NULL,
	[emailid] [varchar](50) NULL,
	[streetaddress] [varchar](50) NULL,
	[city] [varchar](50) NULL,
	[pincode] [varchar](10) NULL,
	[roleid] [numeric](18, 0) NULL,
	[lstatus] [char](1) NULL,
	[accountstatus] [char](10) NULL,
	[phoneno] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[userid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[medialist] ADD  CONSTRAINT [mediaseqid]  DEFAULT (NEXT VALUE FOR [mediaseq]) FOR [mediaid]
GO
ALTER TABLE [dbo].[publisher] ADD  CONSTRAINT [pubseqid]  DEFAULT (NEXT VALUE FOR [pubseq]) FOR [publisherid]
GO
ALTER TABLE [dbo].[rolelist] ADD  CONSTRAINT [roleseqid]  DEFAULT (NEXT VALUE FOR [rolseq]) FOR [roleid]
GO
ALTER TABLE [dbo].[transactionlist] ADD  CONSTRAINT [transeqid]  DEFAULT (NEXT VALUE FOR [transeq]) FOR [transactionid]
GO
ALTER TABLE [dbo].[userlist] ADD  CONSTRAINT [userseqid]  DEFAULT (NEXT VALUE FOR [userseq]) FOR [userid]
GO
ALTER TABLE [dbo].[transactionlist]  WITH CHECK ADD FOREIGN KEY([mediaid])
REFERENCES [dbo].[medialist] ([mediaid])
GO
ALTER TABLE [dbo].[transactionlist]  WITH CHECK ADD FOREIGN KEY([userid])
REFERENCES [dbo].[userlist] ([userid])
GO
ALTER TABLE [dbo].[userlist]  WITH CHECK ADD FOREIGN KEY([roleid])
REFERENCES [dbo].[rolelist] ([roleid])
GO
/****** Object:  StoredProcedure [dbo].[mediainsert]    Script Date: 5/4/2022 9:30:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[mediainsert] @medianame varchar(50),@mediatype varchar(50),@mediagenre varchar(50),@mediaauthor varchar(50),@numberofcopies integer
as 
BEGIN 
	IF(SELECT COUNT(*) FROM medialist where medianame=@medianame) < 1
	BEGIN 
		INSERT INTO medialist(medianame,mediatype,mediagenre,mediaauthor,numberofcopies) values(@medianame,@mediatype,@mediagenre,@mediaauthor,@numberofcopies)
	END 
END
GO
/****** Object:  StoredProcedure [dbo].[roledelete]    Script Date: 5/4/2022 9:30:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[roledelete] @rolename varchar(50), @RETURNVAL INTEGER OUTPUT
as 
BEGIN 
	SET NOCOUNT ON;
	IF(SELECT COUNT(*) FROM userlist where roleid in (select roleid from rolelist where rolename=@rolename)) < 1
	BEGIN 
		DELETE ROLELIST where rolename=@rolename
		SET @RETURNVAL=1;
		RETURN @RETURNVAL;
	END 
	ELSE 
	BEGIN
	   SET @RETURNVAL= 0;
	   RETURN @RETURNVAL;
	END 
END
GO
/****** Object:  StoredProcedure [dbo].[roleinsert]    Script Date: 5/4/2022 9:30:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[roleinsert] @rolename varchar(50)
as 
BEGIN 
	IF(SELECT COUNT(*) FROM rolelist where rolename=@rolename) < 1
	BEGIN 
		INSERT INTO ROLELIST(rolename) values(@rolename)
	END 
END
GO
/****** Object:  StoredProcedure [dbo].[traninsert]    Script Date: 5/4/2022 9:30:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[traninsert] @mediaid integer,@userid integer,@mediaqty integer,@transactiontype char(2),@transactionstatus char(1)
as 
BEGIN 
	BEGIN 
		INSERT INTO transactionlist(mediaid,userid,mediaqty,transactiondate,transactiontype,transactionstatus) values(@mediaid,@userid,@mediaqty,getdate(),@transactiontype,@transactionstatus)
		IF(SELECT count(*) from medialist where mediaid=@mediaid) >= 1
		BEGIN
		UPDATE MEDIALIST set numberofcopies=numberofcopies -1 where mediaid=@mediaid
		END
	END 
END
GO
/****** Object:  StoredProcedure [dbo].[tranupdate]    Script Date: 5/4/2022 9:30:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[tranupdate] @userid integer,@returnval integer output
as 
BEGIN
  SET NOCOUNT ON;
  IF(SELECT count(*) from transactionlist where userid=@userid and transactiontype='CI') >= 1
  BEGIN 
	UPDATE MEDIALIST set numberofcopies=numberofcopies +1 where mediaid in (select mediaid from transactionlist where userid=@userid and transactiontype='CI');
	UPDATE TRANSACTIONLIST set transactionstatus='C',transactiontype='CO' where userid=@userid and transactionstatus='P';
	set @returnval=1;
	RETURN @returnval;
  END 
  ELSE 
  begin
   set @returnval=0;
   return @returnval;
  end 
END
GO
/****** Object:  StoredProcedure [dbo].[USERDELETE]    Script Date: 5/4/2022 9:30:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USERDELETE] @usrname varchar(50), @returnval INTEGER output
as
BEGIN 
 SET NOCOUNT ON;
  IF(SELECT count(*) from userlist where username=@usrname) >= 1
  BEGIN 
    DELETE TRANSACTIONLIST where userid in (select userid from userlist where username=@usrname);
    DELETE USERLIST WHERE username=@usrname;
	set @returnval=1;
	RETURN @returnval;
  END 
 ELSE 
  begin
   set @returnval=0;
   return @returnval;
  end 
END 
GO
/****** Object:  StoredProcedure [dbo].[userinsert]    Script Date: 5/4/2022 9:30:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[userinsert] @usrname varchar(50),@psswd varchar(50),@firstname varchar(50),@lastname varchar(50),@emailid varchar(50),@streetaddress varchar(50),@city varchar(50),@pincode char(10),@phoneno numeric,@roleid numeric,@lstatus char(1),@accountstatus char(10)
as 
BEGIN
INSERT INTO USERLIST (username,psswd,firstname,lastname,emailid,streetaddress,city,pincode,phoneno,roleid,lstatus,accountstatus)
VALUES(@usrname,@psswd,@firstname,@lastname,@emailid,@streetaddress,@city,@pincode,@phoneno,@roleid,@lstatus,@accountstatus)
END
GO
/****** Object:  StoredProcedure [dbo].[userupdate]    Script Date: 5/4/2022 9:30:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[userupdate] @usrname varchar(50),@lastname varchar(50),@emailid varchar(50),@streetaddress varchar(50),@city varchar(50),@pincode char(10),@phoneno varchar(50),@returnval integer output
as 
BEGIN
  SET NOCOUNT ON;
  IF(SELECT count(*) from userlist where username=@usrname) >= 1
  BEGIN 
    UPDATE USERLIST SET lastname=@lastname,emailid=@emailid,streetaddress=@streetaddress,city=@city,pincode=@pincode,phoneno=@phoneno WHERE username=@usrname;
	set @returnval=1;
	RETURN @returnval;
  END 
  ELSE 
  begin
   set @returnval=0;
   return @returnval;
  end 
END
GO
USE [master]
GO
ALTER DATABASE [librarydb] SET  READ_WRITE 
GO
