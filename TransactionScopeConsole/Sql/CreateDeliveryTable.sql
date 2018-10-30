

USE [TransactionScopeDemo]
GO

/****** Object:  Table [dbo].[Delivery]    Script Date: 30/10/2018 5:08:05 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Delivery](
	[DeliveryId] [int] IDENTITY(1,1) NOT NULL,
	[SiteId] [int] NOT NULL,
	[DeliveryDate] [datetime] NOT NULL,
	[Content] [varchar](50) NULL,
 CONSTRAINT [PK_Delivery] PRIMARY KEY CLUSTERED 
(
	[DeliveryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


