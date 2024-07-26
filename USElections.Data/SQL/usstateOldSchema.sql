
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Truncate Table USStates
GO

DROP TABLE IF EXISTS [dbo].[UsStates]
GO

CREATE TABLE [dbo].[UsStates](
	[GID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](70) NOT NULL,
	[Electors] [int] NULL,
	[RegionId] [int] NOT NULL,
	[RegionName] [int] NULL,
	[StateId] [int] NOT NULL,
	[PathType] [nvarchar](10) NULL,
	[PathSuffix] [nvarchar](12) NULL,
	[IsTerritory] [bit] NULL,
	[StrokeWidth] decimal(18,0) NULL default 1,
	[TextLocationX] [decimal](18, 0) NULL,
	[TextLocationY] [decimal](18, 0) NULL,
	[Path] [text] NULL,
 CONSTRAINT [PK_UsStates] PRIMARY KEY CLUSTERED 
(
	[GID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[UsStates] ADD  CONSTRAINT [DEFAULT_UsStates_RegionId]  DEFAULT ((1)) FOR [RegionId]
GO
ALTER TABLE [dbo].[UsStates] ADD  CONSTRAINT [DEFAULT_UsStates_StateId]  DEFAULT ((1)) FOR [StateId]
GO
ALTER TABLE [dbo].[UsStates] ADD  DEFAULT ('path') FOR [PathType]
GO
ALTER TABLE [dbo].[UsStates] ADD  DEFAULT ('d') FOR [PathSuffix]
GO
ALTER TABLE [dbo].[UsStates] ADD  DEFAULT ((0)) FOR [IsTerritory]
GO
ALTER TABLE [dbo].[UsStates] ADD  DEFAULT ((0)) FOR [TextLocationX]
GO
ALTER TABLE [dbo].[UsStates] ADD  DEFAULT ((0)) FOR [TextLocationY]
GO
