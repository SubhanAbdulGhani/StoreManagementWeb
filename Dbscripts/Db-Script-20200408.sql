USE [master]
GO
/****** Object:  Database [Store Management System]    Script Date: 4/9/2020 7:42:05 AM ******/
CREATE DATABASE [Store Management System]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Store Management System', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Store Management System.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Store Management System_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Store Management System_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Store Management System].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Store Management System] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Store Management System] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Store Management System] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Store Management System] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Store Management System] SET ARITHABORT OFF 
GO
ALTER DATABASE [Store Management System] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Store Management System] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Store Management System] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Store Management System] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Store Management System] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Store Management System] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Store Management System] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Store Management System] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Store Management System] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Store Management System] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Store Management System] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Store Management System] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Store Management System] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Store Management System] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Store Management System] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Store Management System] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Store Management System] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Store Management System] SET RECOVERY FULL 
GO
ALTER DATABASE [Store Management System] SET  MULTI_USER 
GO
ALTER DATABASE [Store Management System] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Store Management System] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Store Management System] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Store Management System] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Store Management System] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Store Management System', N'ON'
GO
ALTER DATABASE [Store Management System] SET QUERY_STORE = OFF
GO
USE [Store Management System]
GO
ALTER DATABASE SCOPED CONFIGURATION SET ACCELERATED_PLAN_FORCING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET BATCH_MODE_ADAPTIVE_JOINS = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET BATCH_MODE_MEMORY_GRANT_FEEDBACK = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET BATCH_MODE_ON_ROWSTORE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET DEFERRED_COMPILATION_TV = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET ELEVATE_ONLINE = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET ELEVATE_RESUMABLE = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET GLOBAL_TEMPORARY_TABLE_AUTO_DROP = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET INTERLEAVED_EXECUTION_TVF = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET ISOLATE_SECURITY_POLICY_CARDINALITY = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LAST_QUERY_PLAN_STATS = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LIGHTWEIGHT_QUERY_PROFILING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET OPTIMIZE_FOR_AD_HOC_WORKLOADS = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET ROW_MODE_MEMORY_GRANT_FEEDBACK = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET TSQL_SCALAR_UDF_INLINING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET VERBOSE_TRUNCATION_WARNINGS = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET XTP_PROCEDURE_EXECUTION_STATISTICS = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET XTP_QUERY_EXECUTION_STATISTICS = OFF;
GO
USE [Store Management System]
GO
/****** Object:  Table [dbo].[BuyerAddress]    Script Date: 4/9/2020 7:42:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BuyerAddress](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Address] [varchar](200) NOT NULL,
	[City] [varchar](200) NOT NULL,
	[Phone] [varchar](200) NOT NULL,
	[Street] [varchar](200) NOT NULL,
	[BuyerMasterID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BuyerContact]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BuyerContact](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](200) NOT NULL,
	[Mobile] [varchar](200) NULL,
	[Email] [varchar](200) NULL,
	[Whatsapp] [varchar](200) NULL,
	[BuyerMasterID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BuyerMaster]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BuyerMaster](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [varchar](200) NOT NULL,
 CONSTRAINT [PK_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[inventory]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[inventory](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ProductID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[UpdatedBy] [varchar](200) NOT NULL,
	[UpdatedDate] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](200) NOT NULL,
	[Type] [varchar](200) NOT NULL,
	[Color] [varchar](200) NOT NULL,
	[ProductCategoryID] [int] NOT NULL,
 CONSTRAINT [PK_ProductID] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductCategory]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductCategory](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](200) NOT NULL,
 CONSTRAINT [PK_ProductCategory] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PurchaseContract]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurchaseContract](
	[PurchaseContractID] [int] IDENTITY(1,1) NOT NULL,
	[PurchaseContractDate] [datetime] NOT NULL,
	[PreparedBy] [varchar](200) NOT NULL,
	[SellerID] [int] NOT NULL,
	[ApprovedBy] [varchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PurchaseContractID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PurchaseContractDetail]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurchaseContractDetail](
	[PurchaseContractDetailID] [int] IDENTITY(1,10) NOT NULL,
	[Weight] [decimal](20, 0) NOT NULL,
	[Price] [decimal](20, 0) NOT NULL,
	[TotalAmount] [decimal](20, 0) NOT NULL,
	[PurchaseContractID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
 CONSTRAINT [PK_PurchaseContractDetail] PRIMARY KEY CLUSTERED 
(
	[PurchaseContractDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RawMaterial]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RawMaterial](
	[Type] [varchar](200) NOT NULL,
	[Color] [varchar](200) NOT NULL,
	[Name] [varchar](200) NOT NULL,
	[RawMaterialID] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_RawMaterial] PRIMARY KEY CLUSTERED 
(
	[RawMaterialID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalesContract]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalesContract](
	[SalesContractID] [int] IDENTITY(1,1) NOT NULL,
	[SaleContractDate] [datetime] NOT NULL,
	[PreparedBy] [varchar](200) NOT NULL,
	[BuyerID] [int] NOT NULL,
	[ApprovedBy] [varchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SalesContractID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalesContractDetail]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalesContractDetail](
	[SalesContractDetailID] [int] IDENTITY(1,1) NOT NULL,
	[Weight] [decimal](20, 0) NOT NULL,
	[Price] [decimal](20, 0) NOT NULL,
	[TotalAmount] [decimal](20, 0) NOT NULL,
	[SalesContractID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SalesContractDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SellerAddress]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SellerAddress](
	[Address] [varchar](200) NOT NULL,
	[City] [varchar](200) NOT NULL,
	[Phone] [varchar](200) NOT NULL,
	[Street] [varchar](200) NOT NULL,
	[SellerID] [int] NOT NULL,
	[SellerAddressID] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_SellerAddress] PRIMARY KEY CLUSTERED 
(
	[SellerAddressID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SellerContact]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SellerContact](
	[Name] [varchar](200) NOT NULL,
	[Mobile] [varchar](200) NULL,
	[Email] [varchar](200) NULL,
	[Whatsapp] [varchar](200) NULL,
	[SellerContactID] [int] IDENTITY(1,1) NOT NULL,
	[SellerID] [int] NOT NULL,
 CONSTRAINT [PK_sellerContact] PRIMARY KEY CLUSTERED 
(
	[SellerContactID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SellerMaster]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SellerMaster](
	[CompanyName] [varchar](200) NOT NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_SellerMaster] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usermaster]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usermaster](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](200) NOT NULL,
	[Password] [varchar](200) NOT NULL,
	[Status] [varchar](200) NOT NULL,
 CONSTRAINT [PK__UserMaster] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BuyerAddress]  WITH CHECK ADD FOREIGN KEY([BuyerMasterID])
REFERENCES [dbo].[BuyerMaster] ([ID])
GO
ALTER TABLE [dbo].[BuyerContact]  WITH CHECK ADD  CONSTRAINT [FK_BuyerContact] FOREIGN KEY([BuyerMasterID])
REFERENCES [dbo].[BuyerMaster] ([ID])
GO
ALTER TABLE [dbo].[BuyerContact] CHECK CONSTRAINT [FK_BuyerContact]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD FOREIGN KEY([ProductCategoryID])
REFERENCES [dbo].[ProductCategory] ([ID])
GO
ALTER TABLE [dbo].[PurchaseContract]  WITH CHECK ADD FOREIGN KEY([SellerID])
REFERENCES [dbo].[SellerMaster] ([ID])
GO
ALTER TABLE [dbo].[PurchaseContract]  WITH CHECK ADD  CONSTRAINT [FK_ApprovedBy_UserID] FOREIGN KEY([ApprovedBy])
REFERENCES [dbo].[Usermaster] ([UserName])
GO
ALTER TABLE [dbo].[PurchaseContract] CHECK CONSTRAINT [FK_ApprovedBy_UserID]
GO
ALTER TABLE [dbo].[PurchaseContractDetail]  WITH CHECK ADD FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[PurchaseContractDetail]  WITH CHECK ADD  CONSTRAINT [FK_PurchaseContractDetail] FOREIGN KEY([PurchaseContractID])
REFERENCES [dbo].[PurchaseContract] ([PurchaseContractID])
GO
ALTER TABLE [dbo].[PurchaseContractDetail] CHECK CONSTRAINT [FK_PurchaseContractDetail]
GO
ALTER TABLE [dbo].[SalesContract]  WITH CHECK ADD FOREIGN KEY([BuyerID])
REFERENCES [dbo].[BuyerMaster] ([ID])
GO
ALTER TABLE [dbo].[SalesContract]  WITH CHECK ADD  CONSTRAINT [FK_Approve] FOREIGN KEY([ApprovedBy])
REFERENCES [dbo].[Usermaster] ([UserName])
GO
ALTER TABLE [dbo].[SalesContract] CHECK CONSTRAINT [FK_Approve]
GO
ALTER TABLE [dbo].[SalesContractDetail]  WITH CHECK ADD FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[SalesContractDetail]  WITH CHECK ADD FOREIGN KEY([SalesContractID])
REFERENCES [dbo].[SalesContract] ([SalesContractID])
GO
ALTER TABLE [dbo].[SellerAddress]  WITH CHECK ADD FOREIGN KEY([SellerID])
REFERENCES [dbo].[SellerMaster] ([ID])
GO
ALTER TABLE [dbo].[SellerContact]  WITH CHECK ADD FOREIGN KEY([SellerID])
REFERENCES [dbo].[SellerMaster] ([ID])
GO
/****** Object:  StoredProcedure [dbo].[AddInventory]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[AddInventory](@ProductID int,@Quantity int,@UpdatedDate datetime,@UpdatedBy varchar(200))
as
begin
Insert into inventory(ProductID,Quantity,UpdatedDate,UpdatedBy) values(@ProductID,@Quantity,@UpdatedDate,@UpdatedBy)
end
GO
/****** Object:  StoredProcedure [dbo].[DeleteInventory]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[DeleteInventory](@ID int)
as
begin
Delete from inventory where ID = @ID
end
GO
/****** Object:  StoredProcedure [dbo].[GetBuyerByID]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetBuyerByID] (@ID int) 
as
begin
Select * from BuyerMaster where ID=@ID
end
GO
/****** Object:  StoredProcedure [dbo].[GetInventory]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetInventory]
as
begin
select * from inventory
end
GO
/****** Object:  StoredProcedure [dbo].[GetInventoryByID]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetInventoryByID](@ID int)
as
begin
Select * from inventory where ID = @ID
end
GO
/****** Object:  StoredProcedure [dbo].[spAddBuyerAddress]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spAddBuyerAddress] (@Address varchar(200), @City varchar(200), @Phone varchar(200), @Street varchar(200), @BuyerMasterID int)
as
begin
Insert into BuyerAddress(Address,City,Phone,Street,BuyerMasterID) values(@Address,@City,@Phone,@Street,@BuyerMasterID) 
end

GO
/****** Object:  StoredProcedure [dbo].[spAddBuyerContact]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spAddBuyerContact] (@Name varchar(200), @Mobile varchar(200),@Email varchar(200), @Whatsapp varchar(200), @BuyerMasterID int)
as
begin
Insert into BuyerContact (Name,Mobile,Email,Whatsapp,BuyerMasterID) values(@Name,@Mobile,@Email,@Whatsapp,@BuyerMasterID)
end

GO
/****** Object:  StoredProcedure [dbo].[spAddBuyerMaster]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spAddBuyerMaster] (@CompanyName varchar(200)) 
as
begin
Insert into BuyerMaster(CompanyName) values(@CompanyName)
end
GO
/****** Object:  StoredProcedure [dbo].[spAdddPurchaseContract]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spAdddPurchaseContract] (@PurchaseContractDate datetime, @PreparedBy varchar(200), @SellerID int, @ApprovedBy varchar(200))
as
begin
Insert into PurchaseContract(PurchaseContractDate,PreparedBy,SellerID,ApprovedBy) values(@PurchaseContractDate,@PreparedBy,@SellerID,@ApprovedBy); SELECT SCOPE_IDENTITY(); 
end
GO
/****** Object:  StoredProcedure [dbo].[spAddProductCategory]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spAddProductCategory] (@Name varchar(200)) 
as
begin
Insert into ProductCategory(Name) values (@Name)
end

GO
/****** Object:  StoredProcedure [dbo].[spAddProducts]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spAddProducts] (@Name varchar(200),@Type varchar(200),@Color varchar(200),@ProductCategoryID int)  
as
begin
Insert into Product(Name,Type,Color,ProductCategoryID) values(@Name,@Type,@Color,@ProductCategoryID)
end

GO
/****** Object:  StoredProcedure [dbo].[spAddPurchaseContract]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spAddPurchaseContract] (@PurchaseContractDate datetime, @PreparedBy varchar(200), @SellerID int, @ApprovedBy varchar(200))
as
begin
Insert into PurchaseContract(PurchaseContractDate,PreparedBy,SellerID,ApprovedBy) values(@PurchaseContractDate,@PreparedBy,@SellerID,@ApprovedBy); 
end
GO
/****** Object:  StoredProcedure [dbo].[spAddPurchaseContractDetail]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spAddPurchaseContractDetail] (@Weight decimal,@Price decimal, @TotalAmount decimal, @PurchaseContractID int, @ProductID int)
as 
begin
Insert into PurchaseContractDetail(Weight,Price,TotalAmount,PurchaseContractID,ProductID) values(@Weight,@Price,@TotalAmount,@PurchaseContractID,@ProductID)
end
GO
/****** Object:  StoredProcedure [dbo].[spAddRawMaterial]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[spAddRawMaterial] @Type varchar(200), @Color varchar(200), @Name varchar(200)
AS
BEGIN
INSERT INTO RawMaterial  
                        (Type,  
                         Color,  
                         Name)  
            VALUES     ( @Type,  
                         @Color,  
                         @Name)  
END  
GO
/****** Object:  StoredProcedure [dbo].[spAddSellerAddress]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spAddSellerAddress] (@Address varchar(200), @City varchar(200), @Phone varchar(200), @Street varchar(200), @SellerID int)
as
begin
Insert into SellerAddress(Address,City,Phone,Street,SellerID) values(@Address,@City,@Phone,@Street,@SellerID)
end
GO
/****** Object:  StoredProcedure [dbo].[spAddSellerContact]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spAddSellerContact] (@Name varchar(200),@Mobile varchar(200),@Email varchar(200),@Whatsapp varchar(200),@SellerID int)
as
begin
Insert into SellerContact(Name,Mobile,Email,Whatsapp,SellerID) values(@Name,@Mobile,@Email,@Whatsapp,@SellerID)
end
GO
/****** Object:  StoredProcedure [dbo].[spAddSellerMaster]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spAddSellerMaster] @CompanyName varchar(200)
AS
Begin
Insert into SellerMaster(CompanyName) values(@CompanyName)
End
GO
/****** Object:  StoredProcedure [dbo].[spAddUserMaster]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spAddUserMaster] (@UserName varchar(200), @Password varchar(200), @Status varchar(200))
as
begin
insert into UserMaster(UserName,Password,Status) values(@UserName,@Password,@Status)
end
GO
/****** Object:  StoredProcedure [dbo].[spDeleteBuyerAddress]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spDeleteBuyerAddress] ( @ID int)
as
begin
Delete from BuyerAddress where ID=@ID
end

GO
/****** Object:  StoredProcedure [dbo].[spDeleteBuyerContact]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spDeleteBuyerContact] (@BuyerMasterID int)
as
begin
Delete from BuyerContact where BuyerMasterID=@BuyerMasterID
end

GO
/****** Object:  StoredProcedure [dbo].[spDeleteBuyerMaster]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spDeleteBuyerMaster] (@ID int) 
as
begin
Delete from BuyerMaster where ID=@ID
end
GO
/****** Object:  StoredProcedure [dbo].[spDeleteProductCategory]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spDeleteProductCategory] (@ID int) 
as
begin
Delete from ProductCategory where ID = @ID
end

GO
/****** Object:  StoredProcedure [dbo].[spDeleteProducts]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spDeleteProducts] (@ProductID int)  
as
begin
Delete from  Product where ProductID = @ProductID
end

GO
/****** Object:  StoredProcedure [dbo].[spDeletePurchaseContract]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spDeletePurchaseContract] (@PurchaseContractID int)
as
begin
Delete from PurchaseContract where PurchaseContractID = @PurchaseContractID
end
GO
/****** Object:  StoredProcedure [dbo].[spDeletePurchaseContractDetail]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spDeletePurchaseContractDetail]  (@PurchaseContractID int)
as 
begin
Delete from PurchaseContractDetail where PurchaseContractID = @PurchaseContractID
end
GO
/****** Object:  StoredProcedure [dbo].[spDeleteRawMaterial]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spDeleteRawMaterial] @RawMaterialID int
AS
BEGIN
Delete From RawMaterial where RawMaterialID = @RawMaterialID
END
GO
/****** Object:  StoredProcedure [dbo].[spDeleteSalesContractDetail]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spDeleteSalesContractDetail] (@SalesContractDetailID int)
as 
begin
Delete from SalesContractDetail where SalesContractDetailID = @SalesContractDetailID
end
GO
/****** Object:  StoredProcedure [dbo].[spDeleteSellerAddress]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spDeleteSellerAddress] (@SellerID int)
as
begin
Delete from SellerAddress where SellerID =@SellerID
end
GO
/****** Object:  StoredProcedure [dbo].[spDeleteSellerContact]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spDeleteSellerContact] (@SellerID int)
as
begin
Delete from SellerContact where SellerID = @SellerID
end
GO
/****** Object:  StoredProcedure [dbo].[spDeleteSellerMaster]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spDeleteSellerMaster] @ID int
AS
Begin
Select * from SellerMaster 
where
@ID=ID
End
GO
/****** Object:  StoredProcedure [dbo].[spDeleteUserMaster]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spDeleteUserMaster] (@UserID int)
as
begin
delete from UserMaster where UserID=@UserID
end
GO
/****** Object:  StoredProcedure [dbo].[spDelSellerMaster]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spDelSellerMaster] @ID int
AS
Begin
Delete from SellerMaster 
where
@ID=ID
End
GO
/****** Object:  StoredProcedure [dbo].[spGetAddressByID]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spGetAddressByID] (@BuyerMasterID int)
as
begin
Select * from BuyerAddress where BuyerMasterID=@BuyerMasterID
end

GO
/****** Object:  StoredProcedure [dbo].[spGetBuyerAddress]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spGetBuyerAddress] 
as
begin
Select * from BuyerAddress
end

GO
/****** Object:  StoredProcedure [dbo].[spGetBuyerContact]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spGetBuyerContact]
as
begin
Select * from BuyerContact
end

GO
/****** Object:  StoredProcedure [dbo].[spGetBuyerContactByID]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spGetBuyerContactByID] (@BuyerMasterID int)
as
begin
Select * from BuyerContact where BuyerMasterID=@BuyerMasterID
end

GO
/****** Object:  StoredProcedure [dbo].[spGetBuyerMaster]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spGetBuyerMaster] 
as
begin
Select *  from BuyerMaster
end
GO
/****** Object:  StoredProcedure [dbo].[spGetContactByID]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spGetContactByID] (@SellerID int)
as
begin
Select * from SellerContact where SellerID = @SellerID
end
GO
/****** Object:  StoredProcedure [dbo].[spGetProductCategoryByID]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spGetProductCategoryByID] (@ID int) 
as
begin
Select * from ProductCategory where ID = @ID
end

GO
/****** Object:  StoredProcedure [dbo].[spGetProducts]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spGetProducts]  
as
begin
Select P.ProductID, P.Name,P.Type,P.Color,PC.Name as [Product Category] from Product P inner join ProductCategory PC on P.ProductCategoryID = PC.ID
end

GO
/****** Object:  StoredProcedure [dbo].[spGetPurchaseContract]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spGetPurchaseContract]
as
begin
Select SM.ID as [Seller ID],PC.PurchaseContractID,PC.PurchaseContractDate,PC.PreparedBy,PC.Approvedby,SM.CompanyName as [Seller Master] from PurchaseContract PC inner join SellerMaster SM on PC.SellerID = SM.ID
end
GO
/****** Object:  StoredProcedure [dbo].[spGetPurchaseContractByID]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spGetPurchaseContractByID] (@PurchaseContractID int)
as
begin
Select * from PurchaseContract where PurchaseContractID = @PurchaseContractID
end
GO
/****** Object:  StoredProcedure [dbo].[spGetPurchaseContractDetail]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spGetPurchaseContractDetail]
as 
begin
Select * from PurchaseContractDetail
end
GO
/****** Object:  StoredProcedure [dbo].[spGetPurchaseContractDetailByID]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spGetPurchaseContractDetailByID] (@PurchaseContractID int)
as 
begin
Select * from PurchaseContractDetail where PurchaseContractID = @PurchaseContractID
end
GO
/****** Object:  StoredProcedure [dbo].[spGetRawMaterial]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetRawMaterial]
AS 
BEGIN
Select * from RawMaterial
END
GO
/****** Object:  StoredProcedure [dbo].[spGetRawMaterialByID]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spGetRawMaterialByID] @RawMaterialID int
AS
Begin
Select * from RawMaterial 
where
RawMaterialID=@RawMaterialID
End
GO
/****** Object:  StoredProcedure [dbo].[spGetSalesContractDetail]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spGetSalesContractDetail] 
as 
begin
Select * from SalesContractDetail
end
GO
/****** Object:  StoredProcedure [dbo].[spGetSalesContractDetailByID]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spGetSalesContractDetailByID] (@SalesContractID int)
as 
begin
Select * from SalesContractDetail where SalesContractID = @SalesContractID
end
GO
/****** Object:  StoredProcedure [dbo].[spGetSellerAddress]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spGetSellerAddress]
as
begin
Select * from SellerAddress
end
GO
/****** Object:  StoredProcedure [dbo].[spGetSellerAddressByID]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spGetSellerAddressByID] (@SellerID int)
as
begin
Select * from SellerAddress where SellerID=@SellerID
end

GO
/****** Object:  StoredProcedure [dbo].[spGetSellerContact]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spGetSellerContact]
as
begin
Select * from SellerContact
end
GO
/****** Object:  StoredProcedure [dbo].[spGetSellerMaster]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spGetSellerMaster]
AS
Begin
Select * from SellerMaster 
End
GO
/****** Object:  StoredProcedure [dbo].[spGetSupplierByID]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spGetSupplierByID] @ID int
AS
Begin
Select * from SellerMaster
where 
ID=@ID
End
GO
/****** Object:  StoredProcedure [dbo].[spGetUserMaster]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spGetUserMaster]
as
Select * from UserMaster
go;
GO
/****** Object:  StoredProcedure [dbo].[spGetUserMasterByID]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spGetUserMasterByID] (@UserID int)
as
begin
Select * from UserMaster where UserID = @UserID
end
GO
/****** Object:  StoredProcedure [dbo].[spProductCategory]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spProductCategory] 
as
begin
Select * from ProductCategory 
end

GO
/****** Object:  StoredProcedure [dbo].[spUpdateBuyerAddress]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spUpdateBuyerAddress] (@Address varchar(200), @City varchar(200), @Phone varchar(200), @Street varchar(200), @ID int)
as
begin
Update BuyerAddress set Address=@Address, City=@City, Phone=@Phone, Street=@Street where ID=@ID 
end

GO
/****** Object:  StoredProcedure [dbo].[spUpdateBuyerContact]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spUpdateBuyerContact] (@Name varchar(200), @Mobile varchar(200),@Email varchar(200), @Whatsapp varchar(200), @ID int)
as
begin
Update BuyerContact set Name=@Name, Mobile=@Mobile, Email=@Email, Whatsapp=@Whatsapp where ID=@ID
end

GO
/****** Object:  StoredProcedure [dbo].[spUpdateBuyerMaster]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spUpdateBuyerMaster] (@CompanyName varchar(200),@ID int) 
as
begin
Update BuyerMaster set CompanyName=@CompanyName where ID=@ID
end
GO
/****** Object:  StoredProcedure [dbo].[spUpdateProductCategory]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spUpdateProductCategory] (@ID int, @Name varchar(200)) 
as
begin
Update ProductCategory set Name = @Name where ID = @ID
end

GO
/****** Object:  StoredProcedure [dbo].[spUpdateProducts]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spUpdateProducts] (@ProductID int,@Name varchar(200),@Type varchar(200),@Color varchar(200),@ProductCategoryID int)  
as
begin
Update Product set Name = @Name,Type = @Type,Color = @Color,ProductCategoryID = @ProductCategoryID where ProductID = @ProductID
end

GO
/****** Object:  StoredProcedure [dbo].[spUpdatePurchaseContract]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spUpdatePurchaseContract] (@PurchaseContractDate datetime, @PreparedBy varchar(200), @SellerID int, @PurchaseContractID int, @ApprovedBy varchar(200))
as
begin
Update PurchaseContract set PurchaseContractDate = @PurchaseContractDate, PreparedBy= @PreparedBy , SellerID = @SellerID, ApprovedBy = @ApprovedBy  where PurchaseContractID = @PurchaseContractID
end
GO
/****** Object:  StoredProcedure [dbo].[spUpdatePurchaseContractDetail]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spUpdatePurchaseContractDetail] (@Weight decimal,@Price decimal, @TotalAmount decimal, @PurchaseContractID int)
as 
begin
Update PurchaseContractDetail set Weight = @Weight, Price =@Price where PurchaseContractID = @PurchaseContractID
end
GO
/****** Object:  StoredProcedure [dbo].[spUpdateRawMaterial]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUpdateRawMaterial] @Type varchar(200),@Color varchar(200),@Name varchar(200),@RawMaterialID int
AS
BEGIN
Update RawMaterial
SET
Type = @Type,
Color = @Color,
Name = @Name
WHERE
RawMaterialID = @RawMaterialID
END
GO
/****** Object:  StoredProcedure [dbo].[spUpdateSellerAddress]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spUpdateSellerAddress] (@Address varchar(200), @City varchar(200), @Phone varchar(200),@Street varchar(200),@SellerID int)
as
begin
Update SellerAddress set Address=@Address,City=@City,Phone=@Phone,Street=@Street where SellerID=@SellerID
end
GO
/****** Object:  StoredProcedure [dbo].[spUpdateSellerContact]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spUpdateSellerContact] (@Name varchar(200),@Mobile varchar(200),@Email varchar(200),@Whatsapp varchar(200),@SellerID int)
as
begin
Update  SellerContact set Name=@Name, Mobile=@Mobile, Email=@Email, Whatsapp=@Whatsapp where SellerID = @SellerID
end
GO
/****** Object:  StoredProcedure [dbo].[spUpdateSellerMaster]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spUpdateSellerMaster] @CompanyName varchar(200), @ID int
AS
Begin
Update SellerMaster
set 
CompanyName=@CompanyName
where
ID=@ID
End
GO
/****** Object:  StoredProcedure [dbo].[spUpdateUserMaster]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spUpdateUserMaster] (@UserID int,@UserName varchar(200),@Password varchar(200),@Status varchar(200))
as
begin
update  UserMaster set UserName=@UserName,Password=@Password,Status=@Status where UserID=@UserID
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateInventory]    Script Date: 4/9/2020 7:42:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[UpdateInventory](@ID int,@ProductID int,@Quantity int,@UpdatedDate datetime,@UpdatedBy varchar(200))
as
begin
Update inventory set ProductID = @ProductID, Quantity = @Quantity, UpdatedDate = @UpdatedDate, UpdatedBy = @UpdatedBy where ID = @ID
end
GO
USE [master]
GO
ALTER DATABASE [Store Management System] SET  READ_WRITE 
GO
