USE [GraphQL]
GO
/****** Object:  Table [dbo].[Rate]    Script Date: 1/10/2020 11:05:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rate](
	[ID] [int] NOT NULL,
	[DateToExpire] [datetime] NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedById] [int] NULL,
	[ModifiedByID] [int] NULL,
	[ModifiedOn] [datetime] NULL,
 CONSTRAINT [PK_Rate] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Rate] ([ID], [rDateToExpire], [CreatedOn], [CreatedById], [ModifiedByID], [ModifiedOn]) VALUES (1, CAST(N'2012-01-01T00:00:00.000' AS DateTime), NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Rate] ([ID], [rDateToExpire], [CreatedOn], [CreatedById], [ModifiedByID], [ModifiedOn]) VALUES (2, CAST(N'2019-03-01T23:00:00.000' AS DateTime), NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Rate] ([ID], [rDateToExpire], [CreatedOn], [CreatedById], [ModifiedByID], [ModifiedOn]) VALUES (3, CAST(N'2019-03-01T23:59:00.000' AS DateTime), NULL, NULL, NULL, NULL)
GO
