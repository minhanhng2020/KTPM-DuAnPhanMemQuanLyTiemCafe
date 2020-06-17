﻿IF DB_ID('CoffeeShop') IS NULL 
	CREATE DATABASE CoffeeShop
GO

USE CoffeeShop
GO

--======================================================
CREATE TABLE [dbo].[Users](
	[UserName] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL, 
	[Type] [int] NOT NULL,
	PRIMARY KEY (UserName)	
	)
GO

--======================================================
INSERT INTO [dbo].[Users] ([UserName], [Password], [Type]) VALUES 
	('admin', '123', 1),
	('user1', '111', 2)
GO

--======================================================
CREATE TABLE [dbo].[Supplier](
	[id] [varchar](20) NOT NULL,
	[name] [nvarchar](100) NOT NULL, 
	[address] [nvarchar](200)  NOT NULL,
	PRIMARY KEY (id)	
	)
GO

--======================================================
CREATE TABLE [dbo].[ProductCategory](
	[id] [int] IDENTITY(1,1),
	[name] [nvarchar](100) NOT NULL, 	
	PRIMARY KEY (id)	
	)
GO

--======================================================
CREATE TABLE [dbo].[Product](
	[id] [varchar](10) NOT NULL,
	[name] [nvarchar](100) NOT NULL, 
	[purchasePrice] [float]  NOT NULL DEFAULT 0, 
	[sellingPrice] [float]  NOT NULL DEFAULT 0, 
	[categoryId][int]NOT NULL,	
	[supplierId][varchar](20) NOT NULL,
	PRIMARY KEY (id)	
	)
GO

--======================================================
ALTER TABLE Product ADD CONSTRAINT FK_SUPPLIER_PRODUCT FOREIGN KEY (supplierId) REFERENCES Supplier(id)
ALTER TABLE Product ADD CONSTRAINT FK_PRODUCTCATEGORY_PRODUCT FOREIGN KEY (categoryId) REFERENCES ProductCategory(id)

--======================================================

INSERT INTO [dbo].[ProductCategory] ([name]) VALUES 
	(N'Nước Ngọt'), --1
	(N'Nước Khoáng Đóng Chai'), --2
	(N'Nước Tinh Khiết'), --3
	(N'Trà'), --4
	(N'Trà Sữa'), --5
	(N'Sinh Tố'), --6
	(N'Kem'), --7
	(N'Thức Ăn Vặt'), --8
	(N'Bia'), --9
	(N'Rượu') --10
GO

--======================================================
INSERT INTO [dbo].[Supplier] ([id], [name], [address]) VALUES 
	('Pepsico', N'Suntory Pepsico', N'Lầu 5, Cao Ốc Sheraton, 88 Đồng Khởi, Q. 1, Tp. Hồ Chí Minh'),
	('Heineken', N'Công ty TNHH Nhà Máy Bia HEINEKEN Việt Nam', N'Tầng 18 & 19, Tòa Nhà Vietcombank, Số 5 Công Trường Mê Linh, P. Bến Nghé, Quận 1, Tp. Hồ Chí Minh'),
	('Sapporo', N'Sapporo Vietnam', N'Tầng 17, Tòa nhà Green Power, 35 Tôn Đức Thắng, Quận 1, Thành phố Hồ Chí Minh'),
	('Cocacola', N'Cocacola Vietnam', N'485 Xa lộ Hà Nội, Phường Linh Trung, Quận Thủ Đức, Tp. Hồ Chí Minh'),
	('Vinamilk', N'Công ty Cổ phần Sữa Việt Nam', N'Số 10, Đường Tân Trào, Phường Tân Phú, Quận 7, Tp. HCM'),
	('THMilk', N'Công ty Cổ phần Sữa TH', N'166 Nguyễn Thái Học, P. Quang Trung, TP. Vinh, Tỉnh Nghệ An'),
	('Sabeco', N'Tổng công ty cổ phần Bia - Rượu - Nước giải khát Sài Gòn', N'187 Nguyễn Chí Thanh, Phường 12, Quận 5, TP HCM'),
	('KemTrangTien', N'Công Ty Cổ Phần Kem Tràng Tiền', N'Số 35 Tràng Tiền, Hoàn Kiếm, Hà Nội'),
	('Lavifood', N'Công Ty Cổ Phần LAVIFOOD', N'261 Hoàng Văn Thụ, Phường 2, Quận Tân Bình, TP.HCM'),
	('Nestle', N'Công Ty TNHH Nestlé Việt Nam', N'Lầu 5, Empress Tower, 138-142 Hai Bà Trưng, Phường Đa Kao, Quận 1, Tp.Hồ Chí Minh'),
	('Nutifood', N'Công Ty Cổ Phần Thực Phẩm Dinh Dưỡng Nutifood', N'281-283 Hoàng Diệu, Phường 6, Quận 4, TP. Hồ Chí Minh'),
	('Kido', N'Công Ty Cổ Phần Thực Phẩm Đông Lạnh Kido', N'Lô A2 -7, Đường số N4, KCN Tây Bắc Củ Chi, Ấp Cây Sộp, Xã Tân An Hội, Huyện Củ Chi, Thành phố Hồ Chí Minh Việt Nam'),
	('Dalatmilk', N'Công Ty Cổ Phần Sữa Đà Lạt', N'Số 11A đường Cô Giang, Phường 9, Thành phố Đà Lạt, Lâm Đồng'),
	('NamViet', N'Công ty TNHH Một Thành Viên Thực Phẩm và Nước Giải Khát Nam Việt ', N'994/1C Nguyễn Thị Minh Khai, Khu Phố Tân Thắng, Phường Tân Bình, Thị Xã Dĩ Tỉnh An, Bình Dương')
GO

INSERT INTO [dbo].[Product] ([id], [name], [sellingPrice], [purchasePrice], [categoryId], [supplierId]) VALUES 
	('Pepsi', N'Pepsi', 10000, 20000, 1, 'Pepsico'), 
	('Coke', N'Cocacola', 10000, 20000, 1, 'Cocacola'), 
	('Lavie', N'Nước Khoáng La Vie', 3000, 6000, 3, 'Nestle'),
 	('333', N'Bia 333', 9000, 18000, 9, 'Pepsico'),
	('TrasuaTC', N'Trà sữa trân châu', 12000, 17000, 5, 'NamViet'),
	('Sting', N'Nước tăng lực Sting', 8000, 15000, 1, 'Pepsico'),
	('Sapporo', N'Bia Sapporo', 15000 , 30000, 9, 'Sapporo')
GO

CREATE TABLE [dbo].[Tables](
	[id] [int] IDENTITY(1,1),
	[name] [nvarchar](100) NOT NULL, 
	[status] [nvarchar](100) NOT NULL DEFAULT N'Trống'
	PRIMARY KEY (id)	
	)
GO

INSERT INTO [dbo].[Tables] ([name], [status]) VALUES 
	(N'Bàn 1', N'Trống'),	(N'Bàn 2', N'Có người'),
	(N'Bàn 3', N'Trống'),	(N'Bàn 4', N'Trống'),
	(N'Bàn 5', N'Trống'),	(N'Bàn 6', N'Trống'),
	(N'Bàn 7', N'Trống'),	(N'Bàn 8', N'Trống'),
	(N'Bàn 9', N'Có người'), (N'Bàn 10', N'Trống'),
	(N'Bàn 11', N'Trống'), (N'Bàn 12', N'Trống'),
	(N'Bàn 13', N'Trống'), (N'Bàn 14', N'Trống'),
	(N'Bàn 15', N'Trống'), (N'Bàn 16', N'Trống'),
	(N'Bàn 17', N'Có người'), (N'Bàn 18', N'Trống'),
	(N'Bàn 19', N'Trống'), (N'Bàn 20', N'Có người')
	
GO

CREATE TABLE [dbo].[Orders](
	[id] [int] IDENTITY(1,1),
	[orderDate] [date] NOT NULL DEFAULT GETDATE(), 
	[tableId] [int] NOT NULL,
	[status] [int] NOT NULL DEFAULT 0
	PRIMARY KEY (id)	
	)
GO

CREATE TABLE [dbo].[OrderItem](	
	[orderId] [int] NOT NULL, 
	[productId] [varchar](10) NOT NULL,
	[quantity] [int] NOT NULL DEFAULT 1
	PRIMARY KEY (orderId, productId)	
	)
GO
ALTER TABLE OrderItem ADD CONSTRAINT FK_ORDER_ORDERITEM FOREIGN KEY (orderId) REFERENCES [dbo].[Orders](id)
ALTER TABLE OrderItem ADD CONSTRAINT FK_PRODUCT_PRODUCT FOREIGN KEY (productId) REFERENCES Product(id)

INSERT INTO [dbo].[Orders] ([tableId]) VALUES 
	(2),
	(9),
	(17)
GO

INSERT INTO [dbo].[OrderItem] ([orderId], [productId], [quantity]) VALUES 
	(1, 'Pepsi', 2),	
	(1, 'Sting', 1),
	(1, 'Sapporo', 1),

	(2, 'Pepsi', 1),
	(2, 'TrasuaTC', 2),
	
	(3, 'Sting', 1),
	(3, 'Sapporo', 1)		
GO