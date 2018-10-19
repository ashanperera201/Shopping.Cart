CREATE TABLE [dbo].[Product]
(
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Category] [nvarchar](max) NULL,
	[Size] [nvarchar](max) NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[Title] [nvarchar](max) NULL,
	[ArtDescription] [nvarchar](max) NULL,
	[ArtDating] [nvarchar](max) NULL,
	[ArtId] [nvarchar](max) NULL,
	[Artist] [nvarchar](max) NULL,
	[ArtistBirthDate] [datetime2](7) NOT NULL,
	[ArtistDeathDate] [datetime2](7) NOT NULL,
	[ArtistNationality] [nvarchar](max) NULL,
	CONSTRAINT [PK_Products] PRIMARY KEY ([Id])
)
