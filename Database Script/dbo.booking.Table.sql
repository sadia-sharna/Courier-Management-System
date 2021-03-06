USE [Courier Management System]
GO
/****** Object:  Table [dbo].[booking]    Script Date: 10-Dec-18 2:20:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[booking](
	[bID] [int] IDENTITY(1,1) NOT NULL,
	[bOriginFirstName] [varchar](50) NULL,
	[bOriginLastName] [varchar](50) NULL,
	[bOriginAddress] [varchar](50) NULL,
	[bOriginPhoneNo] [varchar](50) NULL,
	[bDestFirstName] [varchar](50) NULL,
	[bDestLastName] [varchar](50) NULL,
	[bDestAddress] [varchar](50) NULL,
	[bDestPhoneNo] [varchar](50) NULL,
	[bWeight] [float] NULL,
	[bDescription] [varchar](50) NULL,
	[bTye] [varchar](20) NULL,
	[bCost] [float] NULL,
	[id] [bigint] NULL,
	[dID] [int] NULL,
	[bOriginArea] [varchar](50) NULL,
	[bDestArea] [varchar](50) NULL,
	[bOriginCost] [float] NULL,
	[bDestCost] [float] NULL,
	[status] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[bID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[booking]  WITH CHECK ADD  CONSTRAINT [FK_userID] FOREIGN KEY([id])
REFERENCES [dbo].[siteuser] ([id])
GO
ALTER TABLE [dbo].[booking] CHECK CONSTRAINT [FK_userID]
GO
