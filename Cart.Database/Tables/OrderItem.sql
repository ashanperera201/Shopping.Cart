CREATE TABLE [dbo].[OrderItem]
(
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NULL,
	[Quantity] [int] NOT NULL,
	[UnitPrice] [decimal](18, 2) NOT NULL,
	[OrderId] [int] NULL,

	CONSTRAINT [PK_OrderItem] PRIMARY KEY  ([Id]),
	CONSTRAINT [FK_OrderItem_Orders_OrderId] FOREIGN KEY([OrderId]) REFERENCES [dbo].[Orders] ([Id])
)
