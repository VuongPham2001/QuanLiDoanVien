USE [master]
GO

CREATE DATABASE [QLSV]
GO

USE [QLSV]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 3/4/2023 5:04:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[TaiKhoan] [nchar](10) NULL,
	[MatKhau] [nchar](10) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DoanVien]    Script Date: 3/4/2023 5:04:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoanVien](
	[DoanVienID] [int] IDENTITY(1,1) NOT NULL,
	[SinhVienID] [int] NOT NULL,
	[HoTen] [nvarchar](200) NOT NULL,
	[NgayVaoDoan] [nvarchar](50) NOT NULL,
	[NgayRaDoan] [nvarchar](50) NULL,
	[DonVi] [nvarchar](200) NOT NULL,
	[ChucVu] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK__DoanVien__4D2586AE7A3DF43D] PRIMARY KEY CLUSTERED 
(
	[DoanVienID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Khoa]    Script Date: 3/4/2023 5:04:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khoa](
	[KhoaID] [int] IDENTITY(1,1) NOT NULL,
	[TenKhoa] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[KhoaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Lop]    Script Date: 3/4/2023 5:04:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lop](
	[LopID] [int] IDENTITY(1,1) NOT NULL,
	[TenLop] [nvarchar](100) NOT NULL,
	[KhoaID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[LopID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 3/4/2023 5:04:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[SinhVienID] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](100) NOT NULL,
	[NgaySinh] [nvarchar](50) NOT NULL,
	[GioiTinh] [bit] NOT NULL,
	[DiaChi] [nvarchar](200) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[DienThoai] [nvarchar](20) NOT NULL,
	[LopID] [int] NOT NULL,
 CONSTRAINT [PK__SinhVien__F3CF812EE6334B71] PRIMARY KEY CLUSTERED 
(
	[SinhVienID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Admin] ([TaiKhoan], [MatKhau]) VALUES (N'a         ', N'1         ')
INSERT [dbo].[Admin] ([TaiKhoan], [MatKhau]) VALUES (N'AdminThang', N'12345     ')
INSERT [dbo].[Admin] ([TaiKhoan], [MatKhau]) VALUES (N'Admin     ', N'12345     ')
SET IDENTITY_INSERT [dbo].[DoanVien] ON 

INSERT [dbo].[DoanVien] ([DoanVienID], [SinhVienID], [HoTen], [NgayVaoDoan], [NgayRaDoan], [DonVi], [ChucVu]) VALUES (2, 1, N'Tran Thi B', N'2/2/2001', N'', N'Doan pho', N'Chu nhiem')
INSERT [dbo].[DoanVien] ([DoanVienID], [SinhVienID], [HoTen], [NgayVaoDoan], [NgayRaDoan], [DonVi], [ChucVu]) VALUES (3, 3, N'Le Van C', N'2002-03-03', NULL, N'Ð?i phó', N'Ch? nhi?m')
INSERT [dbo].[DoanVien] ([DoanVienID], [SinhVienID], [HoTen], [NgayVaoDoan], [NgayRaDoan], [DonVi], [ChucVu]) VALUES (4, 4, N'Pham Thi D', N'2003-04-04', NULL, N'Ð?i phó', N'Ch? nhi?m')
INSERT [dbo].[DoanVien] ([DoanVienID], [SinhVienID], [HoTen], [NgayVaoDoan], [NgayRaDoan], [DonVi], [ChucVu]) VALUES (5, 5, N'Vu Van E', N'5/5/2004', N'5/4/2001', N'Ð?i phó', N'Ch? nhi?m')
INSERT [dbo].[DoanVien] ([DoanVienID], [SinhVienID], [HoTen], [NgayVaoDoan], [NgayRaDoan], [DonVi], [ChucVu]) VALUES (11, 6, N'Ngo Thi F', N'3/4/2023', N'', N'áda', N'ádá')
SET IDENTITY_INSERT [dbo].[DoanVien] OFF
SET IDENTITY_INSERT [dbo].[Khoa] ON 

INSERT [dbo].[Khoa] ([KhoaID], [TenKhoa]) VALUES (1, N'Khoa Ky thuat thong tin')
INSERT [dbo].[Khoa] ([KhoaID], [TenKhoa]) VALUES (2, N'Khoa Công nghe thong tin')
INSERT [dbo].[Khoa] ([KhoaID], [TenKhoa]) VALUES (3, N'Khoa Khoa hoc may tinh')
SET IDENTITY_INSERT [dbo].[Khoa] OFF
SET IDENTITY_INSERT [dbo].[Lop] ON 

INSERT [dbo].[Lop] ([LopID], [TenLop], [KhoaID]) VALUES (1, N'CNTT1', 1)
INSERT [dbo].[Lop] ([LopID], [TenLop], [KhoaID]) VALUES (2, N'CNTT2', 1)
INSERT [dbo].[Lop] ([LopID], [TenLop], [KhoaID]) VALUES (3, N'KTMT1', 3)
INSERT [dbo].[Lop] ([LopID], [TenLop], [KhoaID]) VALUES (4, N'KTMT2', 3)
INSERT [dbo].[Lop] ([LopID], [TenLop], [KhoaID]) VALUES (5, N'CNTT3', 2)
SET IDENTITY_INSERT [dbo].[Lop] OFF
SET IDENTITY_INSERT [dbo].[SinhVien] ON 

INSERT [dbo].[SinhVien] ([SinhVienID], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [Email], [DienThoai], [LopID]) VALUES (1, N'Nguy?n Van A', N'2001-01-21', 1, N'Hà N?i', N'nguyenvana@gmail.com', N'0123456789', 1)
INSERT [dbo].[SinhVien] ([SinhVienID], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [Email], [DienThoai], [LopID]) VALUES (2, N'Tran Thi B', N'2001-02-02', 0, N'H?i Phòng', N'tranthib@gmail.com', N'0234567891', 2)
INSERT [dbo].[SinhVien] ([SinhVienID], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [Email], [DienThoai], [LopID]) VALUES (3, N'Le Van C', N'2002-03-03', 1, N'B?c Ninh', N'levanc@gmail.com', N'0345678912', 2)
INSERT [dbo].[SinhVien] ([SinhVienID], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [Email], [DienThoai], [LopID]) VALUES (4, N'Pham Thi D', N'2003-04-04', 0, N'H?i Duong', N'phamthid@gmail.com', N'0456789123', 3)
INSERT [dbo].[SinhVien] ([SinhVienID], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [Email], [DienThoai], [LopID]) VALUES (5, N'Vu Van E', N'2004-05-05', 1, N'Hà Nam', N'vuvane@gmail.com', N'0567891234', 4)
INSERT [dbo].[SinhVien] ([SinhVienID], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [Email], [DienThoai], [LopID]) VALUES (6, N'Ngo Thi F', N'2005-06-06', 0, N'Hà Tinh', N'ngothif@gmail.com', N'0678912345', 5)
INSERT [dbo].[SinhVien] ([SinhVienID], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [Email], [DienThoai], [LopID]) VALUES (9, N'áda', N'2021-03-01', 1, N'áda', N'das', N'adsda', 1)
INSERT [dbo].[SinhVien] ([SinhVienID], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [Email], [DienThoai], [LopID]) VALUES (11, N'áda', N'2001-03-07', 1, N'áda', N'ads', N'ada', 1)
INSERT [dbo].[SinhVien] ([SinhVienID], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [Email], [DienThoai], [LopID]) VALUES (12, N'ád?', N'22/7/2001', 1, N'áda', N'ádá', N'adsda', 1)
SET IDENTITY_INSERT [dbo].[SinhVien] OFF
ALTER TABLE [dbo].[DoanVien]  WITH CHECK ADD  CONSTRAINT [FK_DoanVien_SinhVien] FOREIGN KEY([SinhVienID])
REFERENCES [dbo].[SinhVien] ([SinhVienID])
GO
ALTER TABLE [dbo].[DoanVien] CHECK CONSTRAINT [FK_DoanVien_SinhVien]
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD  CONSTRAINT [FK_Lop_Khoa] FOREIGN KEY([KhoaID])
REFERENCES [dbo].[Khoa] ([KhoaID])
GO
ALTER TABLE [dbo].[Lop] CHECK CONSTRAINT [FK_Lop_Khoa]
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD  CONSTRAINT [FK_SinhVien_Lop] FOREIGN KEY([LopID])
REFERENCES [dbo].[Lop] ([LopID])
GO
ALTER TABLE [dbo].[SinhVien] CHECK CONSTRAINT [FK_SinhVien_Lop]
GO
