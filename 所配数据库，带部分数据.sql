USE [master]
GO
/****** Object:  Database [sale]    Script Date: 2016/2/17 11:43:32 ******/
CREATE DATABASE [sale]
 CONTAINMENT = NONE
 /*  注释中两行代码，是自动生成的，估计可以删除
 ON  PRIMARY 
( NAME = N'sale', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\sale.mdf' , SIZE = 3328KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'sale_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\sale.LDF' , SIZE = 4288KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
*/
GO

/*  下面也是导出架构时自动生成的，不用也不影响
ALTER DATABASE [sale] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [sale].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [sale] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [sale] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [sale] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [sale] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [sale] SET ARITHABORT OFF 
GO
ALTER DATABASE [sale] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [sale] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [sale] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [sale] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [sale] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [sale] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [sale] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [sale] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [sale] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [sale] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [sale] SET  DISABLE_BROKER 
GO
ALTER DATABASE [sale] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [sale] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [sale] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [sale] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [sale] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [sale] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [sale] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [sale] SET RECOVERY FULL 
GO
ALTER DATABASE [sale] SET  MULTI_USER 
GO
ALTER DATABASE [sale] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [sale] SET DB_CHAINING OFF 
GO
ALTER DATABASE [sale] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [sale] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
*/
USE [sale]
GO
/****** Object:  StoredProcedure [dbo].[stockcount]    Script Date: 2016/2/17 11:43:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Batch submitted through debugger: SQLQuery39.sql|15|0|C:\Documents and Settings\Administrator\Local Settings\Temp\2\~vsB6.sql
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[stockcount]
	 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
delete from F_STOCKS
	insert into F_STOCKS (货号,颜色,尺码,品牌,类型,季节,库存量) 
	SELECT                货号,颜色,尺码,品牌,类型,季节,SUM(进货数量)
FROM    dbo.F_INCOME  
WHERE     (dbo.F_INCOME.进货数量 > 0)
GROUP BY 货号,颜色,尺码,品牌,类型,季节

DECLARE 
@ID int,
@货号 nvarchar(50),
@颜色 int,
@尺码 int,
@销售 int,
@库存调整 int
DECLARE everyHuohao CURSOR  LOCAL SCROLL  FOR SELECT  ID,货号,颜色,尺码 FROM F_STOCKS
OPEN everyHuohao
fetch next from everyHuohao into @ID,@货号,@颜色,@尺码
while @@fetch_status<>-1
begin

select @销售= SUM(数量) from F_SALE WHERE F_SALE.货号=@货号 AND  F_SALE.颜色=@颜色 AND F_SALE.尺码=@尺码
select @库存调整=SUM(数量) from F_KCTZ WHERE F_KCTZ.货号=@货号 AND  F_KCTZ.颜色=@颜色 AND F_KCTZ.尺码=@尺码
 
 
IF(@销售 IS NULL)
SET @销售=0
IF(@库存调整 IS NULL) SET @库存调整=0


update F_STOCKS set 库存量=库存量-@销售+@库存调整 where ID=@ID
fetch next from everyHuohao into  @ID,@货号,@颜色,@尺码
end
close everyHuohao
deallocate everyHuohao
END

GO
/****** Object:  StoredProcedure [dbo].[StockCountByHuohao]    Script Date: 2016/2/17 11:43:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Batch submitted through debugger: SQLQuery10.sql|7|0|C:\Documents and Settings\zbtaadm\Local Settings\Temp\~vs127.sql
-- Batch submitted through debugger: SQLQuery20.sql|7|0|C:\Documents and Settings\zbtaadm\Local Settings\Temp\~vs89.sql
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[StockCountByHuohao] 

@huohao nvarchar(50),
@acolor int,
@asize int	
AS
BEGIN
DECLARE 
@进货  int,
@销售 int,
@库存调整 int
 
select @进货= SUM(进货数量) from F_INCOME WHERE 货号=@huohao AND 颜色=@acolor AND 尺码=@asize
select @销售= SUM(数量) from F_SALE    WHERE 货号=@huohao AND 颜色=@acolor AND 尺码=@asize
select @库存调整=SUM(数量) from F_KCTZ WHERE 货号=@huohao AND 颜色=@acolor AND 尺码=@asize

IF(@进货 IS NULL) set @进货=0
IF(@销售 IS NULL) set @销售=0
IF(@库存调整 IS NULL) set @库存调整=0
SELECT  @进货-@销售+@库存调整
RETURN
END

GO
/****** Object:  StoredProcedure [dbo].[updateProductALL]    Script Date: 2016/2/17 11:43:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[updateProductALL]
	-- Add the parameters for the stored procedure here
	@huohao nvarchar(50),
	@colorD int,
	@class int,
	@season int,
	@type int,
	@color int,
	@dprice decimal(9,2),
	@jprice decimal(9,2)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
 
	update F_INCOME set 品牌=@class,季节=@season,类型=@type,进货价=@jprice,吊牌价=@dprice where 货号=@huohao
	update F_INCOME set 颜色=@color where 货号=@huohao and 颜色=@colorD
	
	 
	update F_KCTZ set 颜色=@color where 货号=@huohao and 颜色=@colorD
	
	update F_SALE set 颜色=@color where 货号=@huohao and 颜色=@colorD
END

GO
/****** Object:  Table [dbo].[F_CLASS]    Script Date: 2016/2/17 11:43:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[F_CLASS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[品牌名称] [nvarchar](50) NOT NULL,
	[颜色货号锁定] [bit] NULL,
 CONSTRAINT [PK_F_CLASS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[F_INCOME]    Script Date: 2016/2/17 11:43:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[F_INCOME](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[进货批次] [nvarchar](50) NOT NULL,
	[品牌] [int] NOT NULL,
	[货号] [nvarchar](50) NOT NULL,
	[颜色] [int] NOT NULL,
	[尺码] [int] NOT NULL,
	[类型] [int] NOT NULL,
	[季节] [int] NOT NULL,
	[进货数量] [int] NOT NULL,
	[吊牌价] [decimal](18, 2) NOT NULL,
	[进货价] [decimal](18, 2) NOT NULL,
	[备注] [nvarchar](500) NULL,
	[录入人员] [int] NOT NULL,
	[录入时间] [datetime] NOT NULL,
 CONSTRAINT [PK_F_INCOME] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[F_KCTZ]    Script Date: 2016/2/17 11:43:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[F_KCTZ](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[调整日期] [datetime] NOT NULL,
	[货号] [nvarchar](50) NOT NULL,
	[颜色] [int] NOT NULL,
	[尺码] [int] NOT NULL,
	[数量] [int] NOT NULL,
	[对方] [nvarchar](50) NULL,
	[调整责任人] [int] NULL,
	[调整理由] [int] NOT NULL,
	[录入人员] [int] NOT NULL,
	[录入时间] [datetime] NOT NULL,
	[备注] [nvarchar](500) NULL,
 CONSTRAINT [PK_F_KCTZ] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[F_PEND]    Script Date: 2016/2/17 11:43:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[F_PEND](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[费用描述] [int] NOT NULL,
	[支出时间] [datetime] NOT NULL,
	[金额] [decimal](18, 2) NOT NULL,
	[录入时间] [datetime] NOT NULL,
	[录入人员] [int] NOT NULL,
	[备注] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_F_PEND] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[F_S_CLOTHTYPE]    Script Date: 2016/2/17 11:43:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[F_S_CLOTHTYPE](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[类别] [nvarchar](50) NOT NULL,
	[父类ID] [int] NOT NULL,
 CONSTRAINT [PK_F_CLOTHTYPE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[F_S_COLOR]    Script Date: 2016/2/17 11:43:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[F_S_COLOR](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[颜色] [nvarchar](50) NOT NULL,
	[颜色代码] [int] NOT NULL,
 CONSTRAINT [PK_F_COLOR] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[F_S_KCTZTYPE]    Script Date: 2016/2/17 11:43:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[F_S_KCTZTYPE](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[调整理由描述] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_F_S_BECAUSE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[F_S_PENDTYPE]    Script Date: 2016/2/17 11:43:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[F_S_PENDTYPE](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[支出理由] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_F_S_PENDTYPE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[F_S_SEASON]    Script Date: 2016/2/17 11:43:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[F_S_SEASON](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[季节名称] [nvarchar](50) NOT NULL,
	[季节年份] [int] NOT NULL,
 CONSTRAINT [PK_F_SEASON] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[F_S_SIZE]    Script Date: 2016/2/17 11:43:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[F_S_SIZE](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[尺寸] [nvarchar](50) NOT NULL,
	[描述] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_F_SIZE] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[F_S_USER]    Script Date: 2016/2/17 11:43:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[F_S_USER](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[名称] [nvarchar](50) NOT NULL,
	[类型] [nvarchar](50) NOT NULL,
	[权限] [nvarchar](50) NOT NULL,
	[密码] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_F_USER] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[F_SALE]    Script Date: 2016/2/17 11:43:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[F_SALE](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[销售日期] [datetime] NOT NULL,
	[货号] [nvarchar](50) NOT NULL,
	[颜色] [int] NOT NULL,
	[尺码] [int] NOT NULL,
	[数量] [int] NOT NULL,
	[开票价] [decimal](18, 2) NOT NULL,
	[活动优惠] [int] NOT NULL,
	[销售员] [int] NOT NULL,
	[录入人员] [int] NOT NULL,
	[录入时间] [datetime] NOT NULL,
	[备注] [nvarchar](500) NULL,
 CONSTRAINT [PK_F_SALE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[F_STOCKS]    Script Date: 2016/2/17 11:43:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[F_STOCKS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[货号] [nvarchar](50) NOT NULL,
	[颜色] [int] NOT NULL,
	[尺码] [int] NOT NULL,
	[类型] [int] NOT NULL,
	[品牌] [int] NOT NULL,
	[库存量] [int] NULL,
	[季节] [int] NULL,
 CONSTRAINT [PK_F_STOCKS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[F_VIP]    Script Date: 2016/2/17 11:43:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[F_VIP](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[优惠名称] [nvarchar](50) NOT NULL,
	[优惠描述] [nvarchar](500) NULL,
 CONSTRAINT [PK_F_VIP] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[ClorsByHuohao]    Script Date: 2016/2/17 11:43:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ClorsByHuohao]
AS
SELECT DISTINCT 
      dbo.F_INCOME.颜色 AS 颜色ID, dbo.F_INCOME.货号, dbo.F_S_COLOR.颜色
FROM dbo.F_INCOME INNER JOIN
      dbo.F_S_COLOR ON dbo.F_INCOME.颜色 = dbo.F_S_COLOR.ID
WHERE (dbo.F_INCOME.进货数量 > 0)

GO
/****** Object:  View [dbo].[FclassByHuohao]    Script Date: 2016/2/17 11:43:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[FclassByHuohao]
AS
SELECT DISTINCT 
      dbo.F_INCOME.品牌 AS 品牌ID, dbo.F_CLASS.品牌名称, dbo.F_INCOME.货号
FROM dbo.F_CLASS INNER JOIN
      dbo.F_INCOME ON dbo.F_CLASS.ID = dbo.F_INCOME.品牌
WHERE (dbo.F_INCOME.进货数量 > 0)

GO
/****** Object:  View [dbo].[FmainProductStock]    Script Date: 2016/2/17 11:43:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[FmainProductStock]
AS
SELECT DISTINCT 
      dbo.F_INCOME.货号, dbo.F_S_COLOR.颜色, dbo.F_S_SIZE.尺寸, 
      dbo.F_INCOME.颜色 AS 颜色ID, dbo.F_INCOME.尺码 AS 尺寸ID
FROM dbo.F_INCOME INNER JOIN
      dbo.F_S_COLOR ON dbo.F_INCOME.颜色 = dbo.F_S_COLOR.ID INNER JOIN
      dbo.F_S_SIZE ON dbo.F_INCOME.尺码 = dbo.F_S_SIZE.id
WHERE (dbo.F_INCOME.进货数量 > 0)

GO
/****** Object:  View [dbo].[FseasonByHuohao]    Script Date: 2016/2/17 11:43:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[FseasonByHuohao]
AS
SELECT DISTINCT 
      dbo.F_INCOME.季节 AS 季节ID, dbo.F_INCOME.货号, dbo.F_S_SEASON.季节名称, 
      dbo.F_S_SEASON.季节年份
FROM dbo.F_INCOME INNER JOIN
      dbo.F_S_SEASON ON dbo.F_INCOME.季节 = dbo.F_S_SEASON.ID
WHERE (dbo.F_INCOME.进货数量 > 0)

GO
/****** Object:  View [dbo].[FSizeByHuohao]    Script Date: 2016/2/17 11:43:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[FSizeByHuohao]
AS
SELECT DISTINCT 
      dbo.F_INCOME.尺码 AS 尺码ID, dbo.F_INCOME.货号, dbo.F_S_SIZE.尺寸
FROM dbo.F_INCOME INNER JOIN
      dbo.F_S_SIZE ON dbo.F_INCOME.尺码 = dbo.F_S_SIZE.id
WHERE (dbo.F_INCOME.进货数量 > 0)

GO
/****** Object:  View [dbo].[FtypeByHuohao]    Script Date: 2016/2/17 11:43:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[FtypeByHuohao]
AS
SELECT DISTINCT 
      dbo.F_INCOME.类型 AS 类型ID, dbo.F_INCOME.货号, 
      dbo.F_S_CLOTHTYPE.类别
FROM dbo.F_S_CLOTHTYPE INNER JOIN
      dbo.F_INCOME ON dbo.F_S_CLOTHTYPE.ID = dbo.F_INCOME.类型
WHERE (dbo.F_INCOME.进货数量 > 0)

GO
SET IDENTITY_INSERT [dbo].[F_CLASS] ON 

INSERT [dbo].[F_CLASS] ([ID], [品牌名称], [颜色货号锁定]) VALUES (1, N'碧可', 1)
INSERT [dbo].[F_CLASS] ([ID], [品牌名称], [颜色货号锁定]) VALUES (2, N'宠爱', 0)
INSERT [dbo].[F_CLASS] ([ID], [品牌名称], [颜色货号锁定]) VALUES (3, N'夕紫荷', 0)
INSERT [dbo].[F_CLASS] ([ID], [品牌名称], [颜色货号锁定]) VALUES (4, N'其他', 0)
SET IDENTITY_INSERT [dbo].[F_CLASS] OFF
SET IDENTITY_INSERT [dbo].[F_INCOME] ON 

INSERT [dbo].[F_INCOME] ([ID], [进货批次], [品牌], [货号], [颜色], [尺码], [类型], [季节], [进货数量], [吊牌价], [进货价], [备注], [录入人员], [录入时间]) VALUES (82, N'2012', 1, N'H265', 4, 2, 5, 5, 1, CAST(333.00 AS Decimal(18, 2)), CAST(33.00 AS Decimal(18, 2)), N'', 1, CAST(0x0000A00000CE0FEB AS DateTime))
INSERT [dbo].[F_INCOME] ([ID], [进货批次], [品牌], [货号], [颜色], [尺码], [类型], [季节], [进货数量], [吊牌价], [进货价], [备注], [录入人员], [录入时间]) VALUES (83, N'2012', 2, N'V123', 5, 3, 9, 3, 1, CAST(1030.00 AS Decimal(18, 2)), CAST(403.00 AS Decimal(18, 2)), N'', 1, CAST(0x0000A00100297DE9 AS DateTime))
INSERT [dbo].[F_INCOME] ([ID], [进货批次], [品牌], [货号], [颜色], [尺码], [类型], [季节], [进货数量], [吊牌价], [进货价], [备注], [录入人员], [录入时间]) VALUES (85, N'20120226', 1, N'HG1234', 1, 1, 8, 3, 1, CAST(3.00 AS Decimal(18, 2)), CAST(3.00 AS Decimal(18, 2)), N'', 1, CAST(0x0000A003001CD473 AS DateTime))
INSERT [dbo].[F_INCOME] ([ID], [进货批次], [品牌], [货号], [颜色], [尺码], [类型], [季节], [进货数量], [吊牌价], [进货价], [备注], [录入人员], [录入时间]) VALUES (86, N'20120226', 1, N'HG1234', 1, 5, 8, 3, 1, CAST(3.00 AS Decimal(18, 2)), CAST(3.00 AS Decimal(18, 2)), N'', 1, CAST(0x0000A003001CD478 AS DateTime))
INSERT [dbo].[F_INCOME] ([ID], [进货批次], [品牌], [货号], [颜色], [尺码], [类型], [季节], [进货数量], [吊牌价], [进货价], [备注], [录入人员], [录入时间]) VALUES (87, N'20120226', 1, N'HG1234', 1, 4, 8, 3, 1, CAST(3.00 AS Decimal(18, 2)), CAST(3.00 AS Decimal(18, 2)), N'', 1, CAST(0x0000A003001CD47D AS DateTime))
INSERT [dbo].[F_INCOME] ([ID], [进货批次], [品牌], [货号], [颜色], [尺码], [类型], [季节], [进货数量], [吊牌价], [进货价], [备注], [录入人员], [录入时间]) VALUES (88, N'20120226', 1, N'HG1234', 1, 3, 8, 3, 1, CAST(3.00 AS Decimal(18, 2)), CAST(3.00 AS Decimal(18, 2)), N'', 1, CAST(0x0000A003001CD481 AS DateTime))
INSERT [dbo].[F_INCOME] ([ID], [进货批次], [品牌], [货号], [颜色], [尺码], [类型], [季节], [进货数量], [吊牌价], [进货价], [备注], [录入人员], [录入时间]) VALUES (89, N'20120226', 1, N'HG1234', 1, 2, 8, 3, 1, CAST(3.00 AS Decimal(18, 2)), CAST(3.00 AS Decimal(18, 2)), N'', 1, CAST(0x0000A003001CD481 AS DateTime))
SET IDENTITY_INSERT [dbo].[F_INCOME] OFF
SET IDENTITY_INSERT [dbo].[F_KCTZ] ON 

INSERT [dbo].[F_KCTZ] ([ID], [调整日期], [货号], [颜色], [尺码], [数量], [对方], [调整责任人], [调整理由], [录入人员], [录入时间], [备注]) VALUES (38, CAST(0x0000A00300000000 AS DateTime), N'V123', 5, 3, -1, NULL, 1, 1, 1, CAST(0x0000A0030020AE04 AS DateTime), NULL)
INSERT [dbo].[F_KCTZ] ([ID], [调整日期], [货号], [颜色], [尺码], [数量], [对方], [调整责任人], [调整理由], [录入人员], [录入时间], [备注]) VALUES (39, CAST(0x0000A00300000000 AS DateTime), N'H265', 4, 2, 0, NULL, 1, 1, 1, CAST(0x0000A0030020B9BC AS DateTime), N'清除于2012-2-26byadmin,原数量【-1】，原备注【】')
INSERT [dbo].[F_KCTZ] ([ID], [调整日期], [货号], [颜色], [尺码], [数量], [对方], [调整责任人], [调整理由], [录入人员], [录入时间], [备注]) VALUES (40, CAST(0x0000A00300000000 AS DateTime), N'HG1234', 1, 2, 0, NULL, 1, 1, 1, CAST(0x0000A0030020C1F0 AS DateTime), N'清除于2012-2-26byadmin,原数量【1】，原备注【】')
SET IDENTITY_INSERT [dbo].[F_KCTZ] OFF
SET IDENTITY_INSERT [dbo].[F_S_CLOTHTYPE] ON 

INSERT [dbo].[F_S_CLOTHTYPE] ([ID], [类别], [父类ID]) VALUES (1, N'所有类别', 1)
INSERT [dbo].[F_S_CLOTHTYPE] ([ID], [类别], [父类ID]) VALUES (2, N'裙子', 1)
INSERT [dbo].[F_S_CLOTHTYPE] ([ID], [类别], [父类ID]) VALUES (3, N'裤子', 1)
INSERT [dbo].[F_S_CLOTHTYPE] ([ID], [类别], [父类ID]) VALUES (4, N'鞋子', 1)
INSERT [dbo].[F_S_CLOTHTYPE] ([ID], [类别], [父类ID]) VALUES (5, N'羽绒服', 20)
INSERT [dbo].[F_S_CLOTHTYPE] ([ID], [类别], [父类ID]) VALUES (6, N'牛仔裤', 3)
INSERT [dbo].[F_S_CLOTHTYPE] ([ID], [类别], [父类ID]) VALUES (7, N'西装', 20)
INSERT [dbo].[F_S_CLOTHTYPE] ([ID], [类别], [父类ID]) VALUES (8, N'连衣裙', 2)
INSERT [dbo].[F_S_CLOTHTYPE] ([ID], [类别], [父类ID]) VALUES (9, N'半身裙', 2)
INSERT [dbo].[F_S_CLOTHTYPE] ([ID], [类别], [父类ID]) VALUES (10, N'吊带裙', 2)
INSERT [dbo].[F_S_CLOTHTYPE] ([ID], [类别], [父类ID]) VALUES (11, N'针织衫', 20)
INSERT [dbo].[F_S_CLOTHTYPE] ([ID], [类别], [父类ID]) VALUES (12, N'毛衣', 20)
INSERT [dbo].[F_S_CLOTHTYPE] ([ID], [类别], [父类ID]) VALUES (13, N'短裤', 3)
INSERT [dbo].[F_S_CLOTHTYPE] ([ID], [类别], [父类ID]) VALUES (14, N'外套', 20)
INSERT [dbo].[F_S_CLOTHTYPE] ([ID], [类别], [父类ID]) VALUES (15, N'围巾', 23)
INSERT [dbo].[F_S_CLOTHTYPE] ([ID], [类别], [父类ID]) VALUES (17, N'帽子', 23)
INSERT [dbo].[F_S_CLOTHTYPE] ([ID], [类别], [父类ID]) VALUES (18, N'背心', 20)
INSERT [dbo].[F_S_CLOTHTYPE] ([ID], [类别], [父类ID]) VALUES (19, N'小衫', 20)
INSERT [dbo].[F_S_CLOTHTYPE] ([ID], [类别], [父类ID]) VALUES (20, N'上衣', 1)
INSERT [dbo].[F_S_CLOTHTYPE] ([ID], [类别], [父类ID]) VALUES (21, N'西裤', 3)
INSERT [dbo].[F_S_CLOTHTYPE] ([ID], [类别], [父类ID]) VALUES (22, N'休闲裤', 3)
INSERT [dbo].[F_S_CLOTHTYPE] ([ID], [类别], [父类ID]) VALUES (23, N'小件', 1)
INSERT [dbo].[F_S_CLOTHTYPE] ([ID], [类别], [父类ID]) VALUES (26, N'皮鞋', 4)
INSERT [dbo].[F_S_CLOTHTYPE] ([ID], [类别], [父类ID]) VALUES (27, N'凉鞋', 4)
INSERT [dbo].[F_S_CLOTHTYPE] ([ID], [类别], [父类ID]) VALUES (28, N'运动鞋', 4)
INSERT [dbo].[F_S_CLOTHTYPE] ([ID], [类别], [父类ID]) VALUES (29, N'休闲鞋', 4)
INSERT [dbo].[F_S_CLOTHTYPE] ([ID], [类别], [父类ID]) VALUES (30, N'披肩', 23)
SET IDENTITY_INSERT [dbo].[F_S_CLOTHTYPE] OFF
SET IDENTITY_INSERT [dbo].[F_S_COLOR] ON 

INSERT [dbo].[F_S_COLOR] ([ID], [颜色], [颜色代码]) VALUES (1, N'红色', -65536)
INSERT [dbo].[F_S_COLOR] ([ID], [颜色], [颜色代码]) VALUES (2, N'绿色', -16711936)
INSERT [dbo].[F_S_COLOR] ([ID], [颜色], [颜色代码]) VALUES (3, N'蓝色', -12150808)
INSERT [dbo].[F_S_COLOR] ([ID], [颜色], [颜色代码]) VALUES (4, N'白色', -1)
INSERT [dbo].[F_S_COLOR] ([ID], [颜色], [颜色代码]) VALUES (5, N'黑色', -16777216)
INSERT [dbo].[F_S_COLOR] ([ID], [颜色], [颜色代码]) VALUES (6, N'灰色', -8355712)
INSERT [dbo].[F_S_COLOR] ([ID], [颜色], [颜色代码]) VALUES (7, N'驼色', -16777056)
INSERT [dbo].[F_S_COLOR] ([ID], [颜色], [颜色代码]) VALUES (8, N'米色', -560)
INSERT [dbo].[F_S_COLOR] ([ID], [颜色], [颜色代码]) VALUES (9, N'咖啡色', -32768)
INSERT [dbo].[F_S_COLOR] ([ID], [颜色], [颜色代码]) VALUES (10, N'花色', -1)
SET IDENTITY_INSERT [dbo].[F_S_COLOR] OFF
SET IDENTITY_INSERT [dbo].[F_S_KCTZTYPE] ON 

INSERT [dbo].[F_S_KCTZTYPE] ([ID], [调整理由描述]) VALUES (1, N'盘亏')
INSERT [dbo].[F_S_KCTZTYPE] ([ID], [调整理由描述]) VALUES (2, N'盘盈')
INSERT [dbo].[F_S_KCTZTYPE] ([ID], [调整理由描述]) VALUES (3, N'赠送')
INSERT [dbo].[F_S_KCTZTYPE] ([ID], [调整理由描述]) VALUES (4, N'内销')
INSERT [dbo].[F_S_KCTZTYPE] ([ID], [调整理由描述]) VALUES (5, N'内销退货')
INSERT [dbo].[F_S_KCTZTYPE] ([ID], [调整理由描述]) VALUES (6, N'返厂')
INSERT [dbo].[F_S_KCTZTYPE] ([ID], [调整理由描述]) VALUES (7, N'快递')
INSERT [dbo].[F_S_KCTZTYPE] ([ID], [调整理由描述]) VALUES (8, N'代理商取货')
INSERT [dbo].[F_S_KCTZTYPE] ([ID], [调整理由描述]) VALUES (9, N'代理商返回')
INSERT [dbo].[F_S_KCTZTYPE] ([ID], [调整理由描述]) VALUES (11, N'其它情况（请在备注中说明）')
SET IDENTITY_INSERT [dbo].[F_S_KCTZTYPE] OFF
SET IDENTITY_INSERT [dbo].[F_S_PENDTYPE] ON 

INSERT [dbo].[F_S_PENDTYPE] ([ID], [支出理由]) VALUES (1, N'投资')
INSERT [dbo].[F_S_PENDTYPE] ([ID], [支出理由]) VALUES (2, N'水电支出')
INSERT [dbo].[F_S_PENDTYPE] ([ID], [支出理由]) VALUES (3, N'人员工资')
INSERT [dbo].[F_S_PENDTYPE] ([ID], [支出理由]) VALUES (4, N'提取现金')
INSERT [dbo].[F_S_PENDTYPE] ([ID], [支出理由]) VALUES (5, N'购买物品')
INSERT [dbo].[F_S_PENDTYPE] ([ID], [支出理由]) VALUES (6, N'厂家返现')
SET IDENTITY_INSERT [dbo].[F_S_PENDTYPE] OFF
SET IDENTITY_INSERT [dbo].[F_S_SEASON] ON 

INSERT [dbo].[F_S_SEASON] ([ID], [季节名称], [季节年份]) VALUES (1, N'2011春款', 2011)
INSERT [dbo].[F_S_SEASON] ([ID], [季节名称], [季节年份]) VALUES (2, N'2011夏款', 2011)
INSERT [dbo].[F_S_SEASON] ([ID], [季节名称], [季节年份]) VALUES (3, N'2011秋款', 2011)
INSERT [dbo].[F_S_SEASON] ([ID], [季节名称], [季节年份]) VALUES (4, N'2011冬款', 2011)
INSERT [dbo].[F_S_SEASON] ([ID], [季节名称], [季节年份]) VALUES (5, N'2012春款', 2012)
INSERT [dbo].[F_S_SEASON] ([ID], [季节名称], [季节年份]) VALUES (6, N'2012夏款', 2012)
SET IDENTITY_INSERT [dbo].[F_S_SEASON] OFF
SET IDENTITY_INSERT [dbo].[F_S_SIZE] ON 

INSERT [dbo].[F_S_SIZE] ([id], [尺寸], [描述]) VALUES (1, N'S', N'160')
INSERT [dbo].[F_S_SIZE] ([id], [尺寸], [描述]) VALUES (2, N'M', N'165')
INSERT [dbo].[F_S_SIZE] ([id], [尺寸], [描述]) VALUES (3, N'L', N'170')
INSERT [dbo].[F_S_SIZE] ([id], [尺寸], [描述]) VALUES (4, N'XL', N'175')
INSERT [dbo].[F_S_SIZE] ([id], [尺寸], [描述]) VALUES (5, N'XXL', N'180')
INSERT [dbo].[F_S_SIZE] ([id], [尺寸], [描述]) VALUES (6, N'XXXL', N'185')
SET IDENTITY_INSERT [dbo].[F_S_SIZE] OFF
SET IDENTITY_INSERT [dbo].[F_S_USER] ON 

INSERT [dbo].[F_S_USER] ([id], [名称], [类型], [权限], [密码]) VALUES (1, N'admin', N'admin', N'admin', N'blowblow')
INSERT [dbo].[F_S_USER] ([id], [名称], [类型], [权限], [密码]) VALUES (2, N'王威', N'common', N'common', N'bk2012')
INSERT [dbo].[F_S_USER] ([id], [名称], [类型], [权限], [密码]) VALUES (4, N'小朱', N'common', N'common', N'be2011')
SET IDENTITY_INSERT [dbo].[F_S_USER] OFF
SET IDENTITY_INSERT [dbo].[F_SALE] ON 

INSERT [dbo].[F_SALE] ([ID], [销售日期], [货号], [颜色], [尺码], [数量], [开票价], [活动优惠], [销售员], [录入人员], [录入时间], [备注]) VALUES (83, CAST(0x0000A00300000000 AS DateTime), N'HG1234', 1, 3, 1, CAST(0.00 AS Decimal(18, 2)), 1, 2, 1, CAST(0x0000A003001DC4B4 AS DateTime), NULL)
INSERT [dbo].[F_SALE] ([ID], [销售日期], [货号], [颜色], [尺码], [数量], [开票价], [活动优惠], [销售员], [录入人员], [录入时间], [备注]) VALUES (84, CAST(0x0000A00300000000 AS DateTime), N'H265', 4, 2, 0, CAST(0.00 AS Decimal(18, 2)), 1, 2, 1, CAST(0x0000A003001DCCE8 AS DateTime), N'清除于2012-2-26byadmin,原数量【1】，原备注【】')
INSERT [dbo].[F_SALE] ([ID], [销售日期], [货号], [颜色], [尺码], [数量], [开票价], [活动优惠], [销售员], [录入人员], [录入时间], [备注]) VALUES (85, CAST(0x0000A00300000000 AS DateTime), N'HG1234', 1, 1, 1, CAST(0.00 AS Decimal(18, 2)), 1, 2, 1, CAST(0x0000A003001DD3F0 AS DateTime), NULL)
INSERT [dbo].[F_SALE] ([ID], [销售日期], [货号], [颜色], [尺码], [数量], [开票价], [活动优惠], [销售员], [录入人员], [录入时间], [备注]) VALUES (87, CAST(0x0000A00300000000 AS DateTime), N'HG1234', 1, 3, -1, CAST(0.00 AS Decimal(18, 2)), 1, 2, 1, CAST(0x0000A00300000000 AS DateTime), N'退货ID:[83],售货日为:2012-2-26原备注:')
SET IDENTITY_INSERT [dbo].[F_SALE] OFF
SET IDENTITY_INSERT [dbo].[F_STOCKS] ON 

INSERT [dbo].[F_STOCKS] ([ID], [货号], [颜色], [尺码], [类型], [品牌], [库存量], [季节]) VALUES (1809, N'H265', 4, 2, 5, 1, 1, 5)
INSERT [dbo].[F_STOCKS] ([ID], [货号], [颜色], [尺码], [类型], [品牌], [库存量], [季节]) VALUES (1810, N'HG1234', 1, 1, 8, 1, 0, 3)
INSERT [dbo].[F_STOCKS] ([ID], [货号], [颜色], [尺码], [类型], [品牌], [库存量], [季节]) VALUES (1811, N'HG1234', 1, 2, 8, 1, 1, 3)
INSERT [dbo].[F_STOCKS] ([ID], [货号], [颜色], [尺码], [类型], [品牌], [库存量], [季节]) VALUES (1812, N'HG1234', 1, 3, 8, 1, 1, 3)
INSERT [dbo].[F_STOCKS] ([ID], [货号], [颜色], [尺码], [类型], [品牌], [库存量], [季节]) VALUES (1813, N'HG1234', 1, 4, 8, 1, 1, 3)
INSERT [dbo].[F_STOCKS] ([ID], [货号], [颜色], [尺码], [类型], [品牌], [库存量], [季节]) VALUES (1814, N'HG1234', 1, 5, 8, 1, 1, 3)
INSERT [dbo].[F_STOCKS] ([ID], [货号], [颜色], [尺码], [类型], [品牌], [库存量], [季节]) VALUES (1815, N'V123', 5, 3, 9, 2, 0, 3)
SET IDENTITY_INSERT [dbo].[F_STOCKS] OFF
SET IDENTITY_INSERT [dbo].[F_VIP] ON 

INSERT [dbo].[F_VIP] ([ID], [优惠名称], [优惠描述]) VALUES (1, N'三折', N'三折')
INSERT [dbo].[F_VIP] ([ID], [优惠名称], [优惠描述]) VALUES (2, N'五折', N'五折')
INSERT [dbo].[F_VIP] ([ID], [优惠名称], [优惠描述]) VALUES (3, N'六折', N'六折')
INSERT [dbo].[F_VIP] ([ID], [优惠名称], [优惠描述]) VALUES (4, N'七折', N'七折')
INSERT [dbo].[F_VIP] ([ID], [优惠名称], [优惠描述]) VALUES (5, N'八折', N'八折')
INSERT [dbo].[F_VIP] ([ID], [优惠名称], [优惠描述]) VALUES (6, N'九折', N'九折')
INSERT [dbo].[F_VIP] ([ID], [优惠名称], [优惠描述]) VALUES (7, N'满三百减一百', N'满三百减一百')
INSERT [dbo].[F_VIP] ([ID], [优惠名称], [优惠描述]) VALUES (8, N'原价', N'原价')
INSERT [dbo].[F_VIP] ([ID], [优惠名称], [优惠描述]) VALUES (9, N'其它优惠(备注中标明)', N'其它优惠(备注中标明)')
SET IDENTITY_INSERT [dbo].[F_VIP] OFF
ALTER TABLE [dbo].[F_INCOME]  WITH CHECK ADD  CONSTRAINT [FK_F_INCOME_F_CLASS] FOREIGN KEY([品牌])
REFERENCES [dbo].[F_CLASS] ([ID])
GO
ALTER TABLE [dbo].[F_INCOME] CHECK CONSTRAINT [FK_F_INCOME_F_CLASS]
GO
ALTER TABLE [dbo].[F_INCOME]  WITH CHECK ADD  CONSTRAINT [FK_F_INCOME_F_S_CLOTHTYPE] FOREIGN KEY([类型])
REFERENCES [dbo].[F_S_CLOTHTYPE] ([ID])
GO
ALTER TABLE [dbo].[F_INCOME] CHECK CONSTRAINT [FK_F_INCOME_F_S_CLOTHTYPE]
GO
ALTER TABLE [dbo].[F_INCOME]  WITH CHECK ADD  CONSTRAINT [FK_F_INCOME_F_S_COLOR] FOREIGN KEY([颜色])
REFERENCES [dbo].[F_S_COLOR] ([ID])
GO
ALTER TABLE [dbo].[F_INCOME] CHECK CONSTRAINT [FK_F_INCOME_F_S_COLOR]
GO
ALTER TABLE [dbo].[F_INCOME]  WITH CHECK ADD  CONSTRAINT [FK_F_INCOME_F_S_SEASON] FOREIGN KEY([季节])
REFERENCES [dbo].[F_S_SEASON] ([ID])
GO
ALTER TABLE [dbo].[F_INCOME] CHECK CONSTRAINT [FK_F_INCOME_F_S_SEASON]
GO
ALTER TABLE [dbo].[F_INCOME]  WITH CHECK ADD  CONSTRAINT [FK_F_INCOME_F_S_SIZE] FOREIGN KEY([尺码])
REFERENCES [dbo].[F_S_SIZE] ([id])
GO
ALTER TABLE [dbo].[F_INCOME] CHECK CONSTRAINT [FK_F_INCOME_F_S_SIZE]
GO
ALTER TABLE [dbo].[F_INCOME]  WITH CHECK ADD  CONSTRAINT [FK_F_INCOME_F_S_USER] FOREIGN KEY([录入人员])
REFERENCES [dbo].[F_S_USER] ([id])
GO
ALTER TABLE [dbo].[F_INCOME] CHECK CONSTRAINT [FK_F_INCOME_F_S_USER]
GO
ALTER TABLE [dbo].[F_KCTZ]  WITH CHECK ADD  CONSTRAINT [FK_F_KCTZ_F_S_COLOR] FOREIGN KEY([颜色])
REFERENCES [dbo].[F_S_COLOR] ([ID])
GO
ALTER TABLE [dbo].[F_KCTZ] CHECK CONSTRAINT [FK_F_KCTZ_F_S_COLOR]
GO
ALTER TABLE [dbo].[F_KCTZ]  WITH CHECK ADD  CONSTRAINT [FK_F_KCTZ_F_S_KCTZTYPE] FOREIGN KEY([调整理由])
REFERENCES [dbo].[F_S_KCTZTYPE] ([ID])
GO
ALTER TABLE [dbo].[F_KCTZ] CHECK CONSTRAINT [FK_F_KCTZ_F_S_KCTZTYPE]
GO
ALTER TABLE [dbo].[F_KCTZ]  WITH CHECK ADD  CONSTRAINT [FK_F_KCTZ_F_S_SIZE] FOREIGN KEY([尺码])
REFERENCES [dbo].[F_S_SIZE] ([id])
GO
ALTER TABLE [dbo].[F_KCTZ] CHECK CONSTRAINT [FK_F_KCTZ_F_S_SIZE]
GO
ALTER TABLE [dbo].[F_KCTZ]  WITH CHECK ADD  CONSTRAINT [FK_F_KCTZ_F_S_USER] FOREIGN KEY([录入人员])
REFERENCES [dbo].[F_S_USER] ([id])
GO
ALTER TABLE [dbo].[F_KCTZ] CHECK CONSTRAINT [FK_F_KCTZ_F_S_USER]
GO
ALTER TABLE [dbo].[F_PEND]  WITH CHECK ADD  CONSTRAINT [FK_F_PEND_F_S_PENDTYPE] FOREIGN KEY([费用描述])
REFERENCES [dbo].[F_S_PENDTYPE] ([ID])
GO
ALTER TABLE [dbo].[F_PEND] CHECK CONSTRAINT [FK_F_PEND_F_S_PENDTYPE]
GO
ALTER TABLE [dbo].[F_PEND]  WITH CHECK ADD  CONSTRAINT [FK_F_PEND_F_S_USER] FOREIGN KEY([录入人员])
REFERENCES [dbo].[F_S_USER] ([id])
GO
ALTER TABLE [dbo].[F_PEND] CHECK CONSTRAINT [FK_F_PEND_F_S_USER]
GO
ALTER TABLE [dbo].[F_SALE]  WITH CHECK ADD  CONSTRAINT [FK_F_SALE_F_S_COLOR] FOREIGN KEY([颜色])
REFERENCES [dbo].[F_S_COLOR] ([ID])
GO
ALTER TABLE [dbo].[F_SALE] CHECK CONSTRAINT [FK_F_SALE_F_S_COLOR]
GO
ALTER TABLE [dbo].[F_SALE]  WITH CHECK ADD  CONSTRAINT [FK_F_SALE_F_S_SIZE] FOREIGN KEY([尺码])
REFERENCES [dbo].[F_S_SIZE] ([id])
GO
ALTER TABLE [dbo].[F_SALE] CHECK CONSTRAINT [FK_F_SALE_F_S_SIZE]
GO
ALTER TABLE [dbo].[F_SALE]  WITH CHECK ADD  CONSTRAINT [FK_F_SALE_F_S_USER] FOREIGN KEY([录入人员])
REFERENCES [dbo].[F_S_USER] ([id])
GO
ALTER TABLE [dbo].[F_SALE] CHECK CONSTRAINT [FK_F_SALE_F_S_USER]
GO
ALTER TABLE [dbo].[F_SALE]  WITH CHECK ADD  CONSTRAINT [FK_F_SALE_F_VIP] FOREIGN KEY([活动优惠])
REFERENCES [dbo].[F_VIP] ([ID])
GO
ALTER TABLE [dbo].[F_SALE] CHECK CONSTRAINT [FK_F_SALE_F_VIP]
GO
ALTER TABLE [dbo].[F_STOCKS]  WITH CHECK ADD  CONSTRAINT [FK_F_STOCKS_F_CLASS] FOREIGN KEY([品牌])
REFERENCES [dbo].[F_CLASS] ([ID])
GO
ALTER TABLE [dbo].[F_STOCKS] CHECK CONSTRAINT [FK_F_STOCKS_F_CLASS]
GO
ALTER TABLE [dbo].[F_STOCKS]  WITH CHECK ADD  CONSTRAINT [FK_F_STOCKS_F_S_CLOTHTYPE] FOREIGN KEY([类型])
REFERENCES [dbo].[F_S_CLOTHTYPE] ([ID])
GO
ALTER TABLE [dbo].[F_STOCKS] CHECK CONSTRAINT [FK_F_STOCKS_F_S_CLOTHTYPE]
GO
ALTER TABLE [dbo].[F_STOCKS]  WITH CHECK ADD  CONSTRAINT [FK_F_STOCKS_F_S_COLOR] FOREIGN KEY([颜色])
REFERENCES [dbo].[F_S_COLOR] ([ID])
GO
ALTER TABLE [dbo].[F_STOCKS] CHECK CONSTRAINT [FK_F_STOCKS_F_S_COLOR]
GO
ALTER TABLE [dbo].[F_STOCKS]  WITH CHECK ADD  CONSTRAINT [FK_F_STOCKS_F_S_SIZE1] FOREIGN KEY([尺码])
REFERENCES [dbo].[F_S_SIZE] ([id])
GO
ALTER TABLE [dbo].[F_STOCKS] CHECK CONSTRAINT [FK_F_STOCKS_F_S_SIZE1]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "F_INCOME"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 116
               Right = 173
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "F_S_COLOR"
            Begin Extent = 
               Top = 6
               Left = 211
               Bottom = 102
               Right = 346
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ClorsByHuohao'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ClorsByHuohao'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "F_CLASS"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 102
               Right = 191
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "F_INCOME"
            Begin Extent = 
               Top = 6
               Left = 229
               Bottom = 285
               Right = 364
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'FclassByHuohao'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'FclassByHuohao'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "F_INCOME"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 321
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 10
         End
         Begin Table = "F_S_COLOR"
            Begin Extent = 
               Top = 13
               Left = 475
               Bottom = 249
               Right = 635
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "F_S_SIZE"
            Begin Extent = 
               Top = 204
               Left = 677
               Bottom = 300
               Right = 812
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'FmainProductStock'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'FmainProductStock'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "F_INCOME"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 234
               Right = 171
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "F_S_SEASON"
            Begin Extent = 
               Top = 6
               Left = 211
               Bottom = 102
               Right = 346
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'FseasonByHuohao'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'FseasonByHuohao'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "F_INCOME"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 116
               Right = 173
            End
            DisplayFlags = 280
            TopColumn = 9
         End
         Begin Table = "F_S_SIZE"
            Begin Extent = 
               Top = 6
               Left = 211
               Bottom = 102
               Right = 346
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'FSizeByHuohao'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'FSizeByHuohao'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "F_S_CLOTHTYPE"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 224
               Right = 173
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "F_INCOME"
            Begin Extent = 
               Top = 6
               Left = 211
               Bottom = 264
               Right = 346
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'FtypeByHuohao'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'FtypeByHuohao'
GO
USE [master]
GO
ALTER DATABASE [sale] SET  READ_WRITE 
GO
