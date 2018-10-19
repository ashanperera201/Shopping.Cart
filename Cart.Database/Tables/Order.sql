CREATE TABLE [dbo].[Orders]
(
	[Id] INT NOT NULL IDENTITY(1,1), 	
    [OrderDate] DATETIME NOT NULL, 
    [OrderNumber] NVARCHAR(50) NOT NULL, 
	CONSTRAINT [PK_Orders] PRIMARY KEY ([Id] ASC)
)
