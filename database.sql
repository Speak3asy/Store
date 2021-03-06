USE [master]
GO
/****** Object:  Database [market]    Script Date: 2016-02-21 12:16:08 ******/
CREATE DATABASE [market]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'market', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\market.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'market_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\market_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [market] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [market].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [market] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [market] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [market] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [market] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [market] SET ARITHABORT OFF 
GO
ALTER DATABASE [market] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [market] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [market] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [market] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [market] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [market] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [market] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [market] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [market] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [market] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [market] SET  DISABLE_BROKER 
GO
ALTER DATABASE [market] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [market] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [market] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [market] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [market] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [market] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [market] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [market] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [market] SET  MULTI_USER 
GO
ALTER DATABASE [market] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [market] SET DB_CHAINING OFF 
GO
ALTER DATABASE [market] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [market] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [market]
GO
/****** Object:  User [viko]    Script Date: 2016-02-21 12:16:08 ******/
CREATE USER [viko] FOR LOGIN [viko] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [viko]
GO
/****** Object:  StoredProcedure [dbo].[GiveMeBasket]    Script Date: 2016-02-21 12:16:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Arturas Radzevicius>
-- Create date: <2016-02-14>
-- Description:	<Select basket on given history basket id>
-- =============================================
CREATE PROCEDURE [dbo].[GiveMeBasket]--<Procedure_Name, sysname, ProcedureName>
	@numb INT 
	-- Add the parameters for the stored procedure here
	--<@Param1, sysname, @p1> <Datatype_For_Param1, , int> = <Default_Value_For_Param1, , 0>, 
	--<@Param2, sysname, @p2> <Datatype_For_Param2, , int> = <Default_Value_For_Param2, , 0>
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT        dbo.Basket.history_id, dbo.Products.name, dbo.Basket.product_id, dbo.Basket.quantity, dbo.Basket.price, dbo.Basket.quantity * dbo.Basket.price AS Total
FROM            dbo.Basket INNER JOIN
                         dbo.History ON dbo.Basket.history_id = dbo.History.id INNER JOIN
                         dbo.Products ON dbo.Basket.product_id = dbo.Products.id
						 WHERE dbo.Basket.history_id = @numb
END

GO
/****** Object:  Table [dbo].[Basket]    Script Date: 2016-02-21 12:16:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Basket](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[history_id] [int] NOT NULL,
	[product_id] [int] NOT NULL,
	[quantity] [float] NOT NULL,
	[price] [float] NOT NULL,
 CONSTRAINT [PK_Basket] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[History]    Script Date: 2016-02-21 12:16:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[History](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[sum] [float] NOT NULL,
	[date] [datetime] NOT NULL,
 CONSTRAINT [PK_History] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Products]    Script Date: 2016-02-21 12:16:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[cost] [float] NOT NULL,
	[quantity] [float] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[ViewBasket]    Script Date: 2016-02-21 12:16:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ViewBasket]
AS
SELECT        dbo.Basket.history_id, dbo.Products.name, dbo.Basket.product_id, dbo.Basket.quantity, dbo.Basket.price, dbo.Basket.quantity * dbo.Basket.price AS Total
FROM            dbo.Basket INNER JOIN
                         dbo.History ON dbo.Basket.history_id = dbo.History.id INNER JOIN
                         dbo.Products ON dbo.Basket.product_id = dbo.Products.id

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'All ever made purchases' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Basket'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'All purchase history' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'History'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'All market products' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products'
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
         Begin Table = "Basket"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "History"
            Begin Extent = 
               Top = 95
               Left = 358
               Bottom = 301
               Right = 640
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Products"
            Begin Extent = 
               Top = 15
               Left = 723
               Bottom = 145
               Right = 893
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
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewBasket'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewBasket'
GO
USE [master]
GO
ALTER DATABASE [market] SET  READ_WRITE 
GO
