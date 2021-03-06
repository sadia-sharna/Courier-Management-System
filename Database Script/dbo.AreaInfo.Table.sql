USE [Courier Management System]
GO
/****** Object:  Table [dbo].[AreaInfo]    Script Date: 10-Dec-18 2:20:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AreaInfo](
	[aAreaID] [int] IDENTITY(1,1) NOT NULL,
	[aAreaName] [varchar](50) NOT NULL,
	[aCost] [float] NULL,
 CONSTRAINT [PK_AreaInfo] PRIMARY KEY CLUSTERED 
(
	[aAreaName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
