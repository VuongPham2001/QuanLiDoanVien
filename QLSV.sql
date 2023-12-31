USE [master]
GO
/****** Object:  Database [QLSV]    Script Date: 07/04/2023 5:24:02 PM ******/
CREATE DATABASE [QLSV]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLSV', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QLSV.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLSV_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QLSV_log.ldf' , SIZE = 816KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLSV] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLSV].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLSV] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLSV] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLSV] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLSV] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLSV] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLSV] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLSV] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLSV] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLSV] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLSV] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLSV] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLSV] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLSV] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLSV] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLSV] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLSV] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLSV] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLSV] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLSV] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLSV] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLSV] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLSV] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLSV] SET RECOVERY FULL 
GO
ALTER DATABASE [QLSV] SET  MULTI_USER 
GO
ALTER DATABASE [QLSV] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLSV] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLSV] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLSV] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QLSV] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLSV', N'ON'
GO
USE [QLSV]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 07/04/2023 5:24:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[TaiKhoan] [nchar](10) NULL,
	[MatKhau] [nchar](10) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DangVien]    Script Date: 07/04/2023 5:24:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DangVien](
	[DangVienID] [int] IDENTITY(1,1) NOT NULL,
	[SinhVienID] [int] NOT NULL,
	[HoTen] [nvarchar](200) NOT NULL,
	[NgayVaoDoan] [nvarchar](50) NOT NULL,
	[NgayKetNapDang] [nvarchar](50) NOT NULL,
	[DonVi] [nvarchar](200) NOT NULL,
	[ChucVu] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK__DoanVien__4D2586AE7A3DF43D] PRIMARY KEY CLUSTERED 
(
	[DangVienID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Khoa]    Script Date: 07/04/2023 5:24:02 PM ******/
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
/****** Object:  Table [dbo].[Lop]    Script Date: 07/04/2023 5:24:02 PM ******/
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
/****** Object:  Table [dbo].[SinhVien]    Script Date: 07/04/2023 5:24:02 PM ******/
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
	[NgayVaoDoan] [nvarchar](50) NOT NULL,
	[LopID] [int] NOT NULL,
	[DonVi] [nvarchar](50) NULL,
	[ChucVu] [nvarchar](50) NULL,
 CONSTRAINT [PK__SinhVien__F3CF812EE6334B71] PRIMARY KEY CLUSTERED 
(
	[SinhVienID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Admin] ([TaiKhoan], [MatKhau]) VALUES (N'a         ', N'1         ')
INSERT [dbo].[Admin] ([TaiKhoan], [MatKhau]) VALUES (N'AdminThang', N'12345     ')
INSERT [dbo].[Admin] ([TaiKhoan], [MatKhau]) VALUES (N'Admin     ', N'12345     ')
SET IDENTITY_INSERT [dbo].[DangVien] ON 

INSERT [dbo].[DangVien] ([DangVienID], [SinhVienID], [HoTen], [NgayVaoDoan], [NgayKetNapDang], [DonVi], [ChucVu]) VALUES (2, 1, N'Tran Thi B', N'2003-04-04', N'2003-04-04', N'Đảng Viên', N'Đảng Viên')
INSERT [dbo].[DangVien] ([DangVienID], [SinhVienID], [HoTen], [NgayVaoDoan], [NgayKetNapDang], [DonVi], [ChucVu]) VALUES (3, 3, N'Le Van C', N'2002-03-03', N'04/04/2003', N'Ð?ng Viên', N'Ð?ng Viên')
INSERT [dbo].[DangVien] ([DangVienID], [SinhVienID], [HoTen], [NgayVaoDoan], [NgayKetNapDang], [DonVi], [ChucVu]) VALUES (4, 4, N'Pham Thi D', N'2003-04-04', N'2003-04-04', N'Đảng Viên', N'Đảng Viên')
INSERT [dbo].[DangVien] ([DangVienID], [SinhVienID], [HoTen], [NgayVaoDoan], [NgayKetNapDang], [DonVi], [ChucVu]) VALUES (5, 5, N'Vu Van E', N'2003-04-04', N'2003-04-04', N'Đảng Viên', N'Đảng Viên')
INSERT [dbo].[DangVien] ([DangVienID], [SinhVienID], [HoTen], [NgayVaoDoan], [NgayKetNapDang], [DonVi], [ChucVu]) VALUES (13, 19, N'Pham Thi D', N'21/01/2001', N'07/04/2023', N'Đảng Viên', N'Đảng Viên')
INSERT [dbo].[DangVien] ([DangVienID], [SinhVienID], [HoTen], [NgayVaoDoan], [NgayKetNapDang], [DonVi], [ChucVu]) VALUES (14, 19, N'Pham Thi D', N'21/01/2001', N'07/04/2023', N'Đảng Viên', N'Đảng Viên')
SET IDENTITY_INSERT [dbo].[DangVien] OFF
SET IDENTITY_INSERT [dbo].[Khoa] ON 

INSERT [dbo].[Khoa] ([KhoaID], [TenKhoa]) VALUES (1, N'Khoa Ky thuat thong tin')
INSERT [dbo].[Khoa] ([KhoaID], [TenKhoa]) VALUES (2, N'Khoa Công nghe thong tin')
INSERT [dbo].[Khoa] ([KhoaID], [TenKhoa]) VALUES (3, N'Khoa Khoa hoc may tinh')
INSERT [dbo].[Khoa] ([KhoaID], [TenKhoa]) VALUES (4, N'Khoa Kien Truc')
INSERT [dbo].[Khoa] ([KhoaID], [TenKhoa]) VALUES (5, N'Khoa Noi That')
INSERT [dbo].[Khoa] ([KhoaID], [TenKhoa]) VALUES (6, N'Khoa Quan Ly Nhan Luc')
INSERT [dbo].[Khoa] ([KhoaID], [TenKhoa]) VALUES (7, N'Khoa Thoi Trang')
SET IDENTITY_INSERT [dbo].[Khoa] OFF
SET IDENTITY_INSERT [dbo].[Lop] ON 

INSERT [dbo].[Lop] ([LopID], [TenLop], [KhoaID]) VALUES (1, N'CNTT1', 1)
INSERT [dbo].[Lop] ([LopID], [TenLop], [KhoaID]) VALUES (2, N'CNTT2', 1)
INSERT [dbo].[Lop] ([LopID], [TenLop], [KhoaID]) VALUES (3, N'KTMT1', 3)
INSERT [dbo].[Lop] ([LopID], [TenLop], [KhoaID]) VALUES (4, N'KTMT2', 3)
INSERT [dbo].[Lop] ([LopID], [TenLop], [KhoaID]) VALUES (5, N'CNTT3', 2)
SET IDENTITY_INSERT [dbo].[Lop] OFF
SET IDENTITY_INSERT [dbo].[SinhVien] ON 

INSERT [dbo].[SinhVien] ([SinhVienID], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [Email], [DienThoai], [NgayVaoDoan], [LopID], [DonVi], [ChucVu]) VALUES (1, N'Nguyễnn Văn A', N'2001-01-21', 1, N'Hà Nội', N'nguyenvana@gmail.com', N'0123456789', N'2001-01-21', 1, N'Ðoàn Viên', N'Ðoàn Viên')
INSERT [dbo].[SinhVien] ([SinhVienID], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [Email], [DienThoai], [NgayVaoDoan], [LopID], [DonVi], [ChucVu]) VALUES (2, N'Tran Thi B', N'2001-02-02', 0, N'H?i Phòng', N'tranthib@gmail.com', N'0234567891', N'2001-01-21', 2, N'Ðoàn Viên', N'Ðoàn Viên')
INSERT [dbo].[SinhVien] ([SinhVienID], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [Email], [DienThoai], [NgayVaoDoan], [LopID], [DonVi], [ChucVu]) VALUES (3, N'Le Van C', N'2002-03-03', 1, N'B?c Ninh', N'levanc@gmail.com', N'0345678912', N'2001-01-21', 2, N'Ðoàn Viên', N'Ðoàn Viên')
INSERT [dbo].[SinhVien] ([SinhVienID], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [Email], [DienThoai], [NgayVaoDoan], [LopID], [DonVi], [ChucVu]) VALUES (4, N'Pham Thi D', N'2003-04-04', 0, N'H?i Duong', N'phamthid@gmail.com', N'0456789123', N'2001-01-21', 3, N'Ðoàn Viên', N'Ðoàn Viên')
INSERT [dbo].[SinhVien] ([SinhVienID], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [Email], [DienThoai], [NgayVaoDoan], [LopID], [DonVi], [ChucVu]) VALUES (5, N'Vu Van E', N'2004-05-05', 1, N'Hà Nam', N'vuvane@gmail.com', N'0567891234', N'2001-01-21', 4, N'Ðoàn Viên', N'Ðoàn Viên')
INSERT [dbo].[SinhVien] ([SinhVienID], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [Email], [DienThoai], [NgayVaoDoan], [LopID], [DonVi], [ChucVu]) VALUES (6, N'Ngo Thi F', N'2005-06-06', 0, N'Hà Tinh', N'ngothif@gmail.com', N'0678912345', N'2001-01-21', 5, N'Ðoàn Viên', N'Ðoàn Viên')
INSERT [dbo].[SinhVien] ([SinhVienID], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [Email], [DienThoai], [NgayVaoDoan], [LopID], [DonVi], [ChucVu]) VALUES (18, N'Đỗ Đức Thắng', N'07/04/2023', 1, N'Nam Ð?nh', N'dothang@gmail.com', N'057657657', N'07/04/2023', 3, N'Ðoàn Viên', N'Ðoàn Viên')
INSERT [dbo].[SinhVien] ([SinhVienID], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [Email], [DienThoai], [NgayVaoDoan], [LopID], [DonVi], [ChucVu]) VALUES (19, N'Pham Thi D', N'04/04/2003', 0, N'H?i Duong', N'phamthid@gmail.com', N'0456789123', N'21/01/2001', 2, N'Ðoàn Viên', N'Doàn Viên')
INSERT [dbo].[SinhVien] ([SinhVienID], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [Email], [DienThoai], [NgayVaoDoan], [LopID], [DonVi], [ChucVu]) VALUES (21, N'Phạm Thị Trang', N'07/04/2023', 1, N'H?i Duong', N'trang@gmail.com', N'0464564644', N'07/04/2023', 5, N'Ðoàn Viên', N'Ðoàn Viên')
INSERT [dbo].[SinhVien] ([SinhVienID], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [Email], [DienThoai], [NgayVaoDoan], [LopID], [DonVi], [ChucVu]) VALUES (22, N'Phạm Bá Vương', N'07/06/2001', 1, N'Ninh Bình', N'vuong@gmail.com', N'0767676657', N'14/07/2020', 1, N'Ðoàn Viên', N'Ðoàn Viên')
INSERT [dbo].[SinhVien] ([SinhVienID], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [Email], [DienThoai], [NgayVaoDoan], [LopID], [DonVi], [ChucVu]) VALUES (23, N'Nguyễn Huy Tuấn', N'07/03/2001', 1, N'Hà N?i', N'tuan@gmail.com', N'0567676543', N'21/01/2001', 1, N'Ðoàn Viên', N'Ðoàn Viên')
INSERT [dbo].[SinhVien] ([SinhVienID], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [Email], [DienThoai], [NgayVaoDoan], [LopID], [DonVi], [ChucVu]) VALUES (24, N'Nguy?n Van B', N'07/04/2001', 0, N'Hà N?i', N'nguyenvanb@gmail.com', N'0676767567', N'07/04/2023', 1, N'Ðoàn Viên', N'Ðoàn Viên')
SET IDENTITY_INSERT [dbo].[SinhVien] OFF
ALTER TABLE [dbo].[DangVien]  WITH CHECK ADD  CONSTRAINT [FK_DoanVien_SinhVien] FOREIGN KEY([SinhVienID])
REFERENCES [dbo].[SinhVien] ([SinhVienID])
GO
ALTER TABLE [dbo].[DangVien] CHECK CONSTRAINT [FK_DoanVien_SinhVien]
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
USE [master]
GO
ALTER DATABASE [QLSV] SET  READ_WRITE 
GO
