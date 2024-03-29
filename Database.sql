USE [QLSieuThi]
GO
/****** Object:  Table [dbo].[CTHoaDonBanHang]    Script Date: 15/12/2023 1:52:36 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHoaDonBanHang](
	[MaHang] [nvarchar](50) NOT NULL,
	[SoHoaDon] [nvarchar](50) NOT NULL,
	[SoLuong] [float] NULL,
	[ThanhTien] [float] NULL,
 CONSTRAINT [PK_CTHoaDonBanHang] PRIMARY KEY CLUSTERED 
(
	[MaHang] ASC,
	[SoHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CTPhieuNhap]    Script Date: 15/12/2023 1:52:36 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTPhieuNhap](
	[SoPhieuNhap] [int] NOT NULL,
	[MaHang] [nvarchar](50) NOT NULL,
	[SoLuongNhap] [float] NULL,
	[ThanhTien] [float] NULL,
	[DonGiaNhap] [float] NULL,
 CONSTRAINT [PK_CTPhieuNhap] PRIMARY KEY CLUSTERED 
(
	[SoPhieuNhap] ASC,
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CTPhieuXuatHang]    Script Date: 15/12/2023 1:52:36 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTPhieuXuatHang](
	[SoPhieuXuat] [int] NOT NULL,
	[MaHang] [nvarchar](50) NOT NULL,
	[SoLuongXuat] [float] NULL,
 CONSTRAINT [PK_CTPhieuXuatHang] PRIMARY KEY CLUSTERED 
(
	[SoPhieuXuat] ASC,
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DangNhap]    Script Date: 15/12/2023 1:52:36 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DangNhap](
	[TaiKhoan] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](50) NULL,
	[MaNV] [nvarchar](50) NULL,
 CONSTRAINT [PK_DangNhap] PRIMARY KEY CLUSTERED 
(
	[TaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HangHoa]    Script Date: 15/12/2023 1:52:36 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangHoa](
	[MaHang] [nvarchar](50) NOT NULL,
	[TenHang] [nvarchar](50) NULL,
	[DVT] [nvarchar](50) NULL,
	[DonGia] [float] NULL,
	[NgaySX] [date] NULL,
	[HSD] [date] NULL,
	[SoLuongTon] [float] NULL,
	[MaLoai] [nvarchar](50) NULL,
	[MaNCC] [nvarchar](50) NULL,
 CONSTRAINT [PK_HangHoa] PRIMARY KEY CLUSTERED 
(
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDonBanHang]    Script Date: 15/12/2023 1:52:36 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonBanHang](
	[SoHoaDon] [nvarchar](50) NOT NULL,
	[NgayLap] [date] NULL,
	[VAT] [float] NULL,
	[TongTien] [float] NULL,
	[MaKHTT] [nvarchar](50) NULL,
	[MaNV] [nvarchar](50) NULL,
 CONSTRAINT [PK_HoaDonBanHang] PRIMARY KEY CLUSTERED 
(
	[SoHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHangThanThiet]    Script Date: 15/12/2023 1:52:36 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHangThanThiet](
	[MaThe] [nvarchar](50) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[NgaySinhKH] [date] NULL,
	[SDTKH] [nvarchar](50) NULL,
	[DiaChiKH] [nvarchar](50) NULL,
	[Diem] [float] NULL,
 CONSTRAINT [PK_KhachHangThanThiet] PRIMARY KEY CLUSTERED 
(
	[MaThe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiHangHoa]    Script Date: 15/12/2023 1:52:36 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiHangHoa](
	[MaLoai] [nvarchar](50) NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiHangHoa] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 15/12/2023 1:52:36 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [nvarchar](50) NOT NULL,
	[TenNCC] [nvarchar](50) NULL,
	[DiaChiNCC] [nvarchar](50) NULL,
	[SDTNCC] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 15/12/2023 1:52:36 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [nvarchar](50) NOT NULL,
	[HoTenNV] [nvarchar](50) NULL,
	[NgaySinhNV] [date] NULL,
	[ChucVu] [nvarchar](50) NULL,
	[Luong] [float] NULL,
	[SDTNV] [nvarchar](50) NULL,
	[DiaChiNv] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuNhapHang]    Script Date: 15/12/2023 1:52:36 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhapHang](
	[SoPhieuNhap] [int] NOT NULL,
	[NgayTaoPNH] [date] NULL,
	[MaNV] [nvarchar](50) NULL,
	[TrangThai] [nvarchar](50) NULL,
 CONSTRAINT [PK_PhieuNhapHang] PRIMARY KEY CLUSTERED 
(
	[SoPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuXuatHang]    Script Date: 15/12/2023 1:52:36 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuXuatHang](
	[SoPhieuXuat] [int] NOT NULL,
	[NgayTaoPXH] [date] NULL,
	[MaNV] [nvarchar](50) NULL,
	[TrangThai] [nvarchar](50) NULL,
 CONSTRAINT [PK_PhieuXuatHang] PRIMARY KEY CLUSTERED 
(
	[SoPhieuXuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[CTHoaDonBanHang] ([MaHang], [SoHoaDon], [SoLuong], [ThanhTien]) VALUES (N'HH001', N'HD001', 11, 130000)
INSERT [dbo].[CTHoaDonBanHang] ([MaHang], [SoHoaDon], [SoLuong], [ThanhTien]) VALUES (N'HH001', N'HD23835', 4, 20000)
INSERT [dbo].[CTHoaDonBanHang] ([MaHang], [SoHoaDon], [SoLuong], [ThanhTien]) VALUES (N'HH001', N'HD29217', 2, 10000)
INSERT [dbo].[CTHoaDonBanHang] ([MaHang], [SoHoaDon], [SoLuong], [ThanhTien]) VALUES (N'HH001', N'HD60730', 1, 5000)
INSERT [dbo].[CTHoaDonBanHang] ([MaHang], [SoHoaDon], [SoLuong], [ThanhTien]) VALUES (N'HH001', N'HD63445', 1, 5000)
INSERT [dbo].[CTHoaDonBanHang] ([MaHang], [SoHoaDon], [SoLuong], [ThanhTien]) VALUES (N'HH001', N'HD68572', 1, 5000)
INSERT [dbo].[CTHoaDonBanHang] ([MaHang], [SoHoaDon], [SoLuong], [ThanhTien]) VALUES (N'HH002', N'HD001', 3, 50000)
INSERT [dbo].[CTHoaDonBanHang] ([MaHang], [SoHoaDon], [SoLuong], [ThanhTien]) VALUES (N'HH002', N'HD23835', 2, 20000)
INSERT [dbo].[CTHoaDonBanHang] ([MaHang], [SoHoaDon], [SoLuong], [ThanhTien]) VALUES (N'HH002', N'HD68572', 2, 20000)
INSERT [dbo].[CTHoaDonBanHang] ([MaHang], [SoHoaDon], [SoLuong], [ThanhTien]) VALUES (N'HH002', N'HD75894', 1, 10000)
INSERT [dbo].[CTHoaDonBanHang] ([MaHang], [SoHoaDon], [SoLuong], [ThanhTien]) VALUES (N'HH003', N'HD001', 8, 1480000)
INSERT [dbo].[CTHoaDonBanHang] ([MaHang], [SoHoaDon], [SoLuong], [ThanhTien]) VALUES (N'HH003', N'HD002', 2, 80000)
INSERT [dbo].[CTHoaDonBanHang] ([MaHang], [SoHoaDon], [SoLuong], [ThanhTien]) VALUES (N'HH003', N'HD29217', 1, 200000)
INSERT [dbo].[CTHoaDonBanHang] ([MaHang], [SoHoaDon], [SoLuong], [ThanhTien]) VALUES (N'HH003', N'HD63445', 10, 1800000)
INSERT [dbo].[CTHoaDonBanHang] ([MaHang], [SoHoaDon], [SoLuong], [ThanhTien]) VALUES (N'HH003', N'HD75894', 1, 200000)
INSERT [dbo].[CTHoaDonBanHang] ([MaHang], [SoHoaDon], [SoLuong], [ThanhTien]) VALUES (N'HH004', N'HD75894', 1, 50000)
INSERT [dbo].[CTHoaDonBanHang] ([MaHang], [SoHoaDon], [SoLuong], [ThanhTien]) VALUES (N'HH005', N'HD001', 3, 31500)
INSERT [dbo].[CTHoaDonBanHang] ([MaHang], [SoHoaDon], [SoLuong], [ThanhTien]) VALUES (N'HH005', N'HD002', 1, 15000)
INSERT [dbo].[CTHoaDonBanHang] ([MaHang], [SoHoaDon], [SoLuong], [ThanhTien]) VALUES (N'HH006', N'HD001', 3, 15000)
INSERT [dbo].[CTPhieuNhap] ([SoPhieuNhap], [MaHang], [SoLuongNhap], [ThanhTien], [DonGiaNhap]) VALUES (1, N'HH001', 6, 18000, 3000)
INSERT [dbo].[CTPhieuNhap] ([SoPhieuNhap], [MaHang], [SoLuongNhap], [ThanhTien], [DonGiaNhap]) VALUES (1, N'HH004', 8, 160, 20)
INSERT [dbo].[CTPhieuNhap] ([SoPhieuNhap], [MaHang], [SoLuongNhap], [ThanhTien], [DonGiaNhap]) VALUES (2, N'HH005', 13, 13, 1)
INSERT [dbo].[CTPhieuNhap] ([SoPhieuNhap], [MaHang], [SoLuongNhap], [ThanhTien], [DonGiaNhap]) VALUES (2, N'HH006', 6, 120, 20)
INSERT [dbo].[CTPhieuNhap] ([SoPhieuNhap], [MaHang], [SoLuongNhap], [ThanhTien], [DonGiaNhap]) VALUES (3, N'HH004', 6, 108000, 18000)
INSERT [dbo].[CTPhieuNhap] ([SoPhieuNhap], [MaHang], [SoLuongNhap], [ThanhTien], [DonGiaNhap]) VALUES (4, N'HH009', 11, 11, 1)
INSERT [dbo].[CTPhieuXuatHang] ([SoPhieuXuat], [MaHang], [SoLuongXuat]) VALUES (1, N'HH001', 20)
INSERT [dbo].[CTPhieuXuatHang] ([SoPhieuXuat], [MaHang], [SoLuongXuat]) VALUES (1, N'HH002', 20)
INSERT [dbo].[CTPhieuXuatHang] ([SoPhieuXuat], [MaHang], [SoLuongXuat]) VALUES (2, N'HH006', 19)
INSERT [dbo].[CTPhieuXuatHang] ([SoPhieuXuat], [MaHang], [SoLuongXuat]) VALUES (2, N'HH007', 2)
INSERT [dbo].[CTPhieuXuatHang] ([SoPhieuXuat], [MaHang], [SoLuongXuat]) VALUES (4, N'HH001', 99)
INSERT [dbo].[CTPhieuXuatHang] ([SoPhieuXuat], [MaHang], [SoLuongXuat]) VALUES (5, N'HH009', 10)
INSERT [dbo].[DangNhap] ([TaiKhoan], [MatKhau], [MaNV]) VALUES (N'admin', N'1', N'NV004')
INSERT [dbo].[DangNhap] ([TaiKhoan], [MatKhau], [MaNV]) VALUES (N'nv01', N'123', N'NV001')
INSERT [dbo].[DangNhap] ([TaiKhoan], [MatKhau], [MaNV]) VALUES (N'nv02', N'123', N'NV002')
INSERT [dbo].[DangNhap] ([TaiKhoan], [MatKhau], [MaNV]) VALUES (N'nv03', N'123', N'NV003')
INSERT [dbo].[HangHoa] ([MaHang], [TenHang], [DVT], [DonGia], [NgaySX], [HSD], [SoLuongTon], [MaLoai], [MaNCC]) VALUES (N'HH001', N'Bánh mì', N'Ổ', 5000, CAST(N'2023-01-01' AS Date), CAST(N'2023-01-10' AS Date), 17, N'LOAI001', N'NCC001')
INSERT [dbo].[HangHoa] ([MaHang], [TenHang], [DVT], [DonGia], [NgaySX], [HSD], [SoLuongTon], [MaLoai], [MaNCC]) VALUES (N'HH002', N'Coca-Cola', N'Chai', 10000, CAST(N'2023-02-01' AS Date), CAST(N'2023-03-28' AS Date), 100, N'LOAI002', N'NCC002')
INSERT [dbo].[HangHoa] ([MaHang], [TenHang], [DVT], [DonGia], [NgaySX], [HSD], [SoLuongTon], [MaLoai], [MaNCC]) VALUES (N'HH003', N'Áo sơ mi nam', N'Cái', 200000, CAST(N'2023-03-01' AS Date), CAST(N'2025-03-31' AS Date), 103, N'LOAI003', N'NCC003')
INSERT [dbo].[HangHoa] ([MaHang], [TenHang], [DVT], [DonGia], [NgaySX], [HSD], [SoLuongTon], [MaLoai], [MaNCC]) VALUES (N'HH004', N'Quần jean nữ', N'Cái', 50000, CAST(N'2023-04-01' AS Date), CAST(N'2026-04-30' AS Date), 123, N'LOAI003', N'NCC003')
INSERT [dbo].[HangHoa] ([MaHang], [TenHang], [DVT], [DonGia], [NgaySX], [HSD], [SoLuongTon], [MaLoai], [MaNCC]) VALUES (N'HH005', N'Thìa inox', N'Cái', 15000, CAST(N'2023-05-01' AS Date), CAST(N'2023-05-31' AS Date), 100, N'LOAI004', N'NCC004')
INSERT [dbo].[HangHoa] ([MaHang], [TenHang], [DVT], [DonGia], [NgaySX], [HSD], [SoLuongTon], [MaLoai], [MaNCC]) VALUES (N'HH006', N'Ðũa gỗ', N'Cái', 5000, CAST(N'2023-06-01' AS Date), CAST(N'2023-06-30' AS Date), 100, N'LOAI004', N'NCC004')
INSERT [dbo].[HangHoa] ([MaHang], [TenHang], [DVT], [DonGia], [NgaySX], [HSD], [SoLuongTon], [MaLoai], [MaNCC]) VALUES (N'HH007', N'Mứt dâu', N'Hộp', 123, CAST(N'2023-10-29' AS Date), CAST(N'2024-03-23' AS Date), 0, N'LOAI001', N'NCC001')
INSERT [dbo].[HangHoa] ([MaHang], [TenHang], [DVT], [DonGia], [NgaySX], [HSD], [SoLuongTon], [MaLoai], [MaNCC]) VALUES (N'HH008', N'Sách', N'Quyển', 100000, CAST(N'2023-10-29' AS Date), CAST(N'2024-03-23' AS Date), 0, N'LOAI004', N'NCC001')
INSERT [dbo].[HangHoa] ([MaHang], [TenHang], [DVT], [DonGia], [NgaySX], [HSD], [SoLuongTon], [MaLoai], [MaNCC]) VALUES (N'HH009', N'aaaaaaa', N'aaaaaa', 12, CAST(N'2023-12-15' AS Date), CAST(N'2023-12-16' AS Date), 1, N'LOAI005', N'NCC002')
INSERT [dbo].[HoaDonBanHang] ([SoHoaDon], [NgayLap], [VAT], [TongTien], [MaKHTT], [MaNV]) VALUES (N'HD001', CAST(N'2023-01-01' AS Date), 10, 1895921.5, N'KH001', N'NV004')
INSERT [dbo].[HoaDonBanHang] ([SoHoaDon], [NgayLap], [VAT], [TongTien], [MaKHTT], [MaNV]) VALUES (N'HD002', CAST(N'2023-02-01' AS Date), 5, 950000, N'KH002', N'NV002')
INSERT [dbo].[HoaDonBanHang] ([SoHoaDon], [NgayLap], [VAT], [TongTien], [MaKHTT], [MaNV]) VALUES (N'HD003', CAST(N'2023-03-27' AS Date), NULL, 200000, N'KHVL', N'NV004')
INSERT [dbo].[HoaDonBanHang] ([SoHoaDon], [NgayLap], [VAT], [TongTien], [MaKHTT], [MaNV]) VALUES (N'HD004', CAST(N'2023-03-27' AS Date), NULL, 120000, N'KHVL', N'NV004')
INSERT [dbo].[HoaDonBanHang] ([SoHoaDon], [NgayLap], [VAT], [TongTien], [MaKHTT], [MaNV]) VALUES (N'HD005', CAST(N'2023-04-27' AS Date), NULL, 500000, N'KHVL', N'NV004')
INSERT [dbo].[HoaDonBanHang] ([SoHoaDon], [NgayLap], [VAT], [TongTien], [MaKHTT], [MaNV]) VALUES (N'HD006', CAST(N'2023-05-27' AS Date), NULL, 456123, N'KHVL', N'NV004')
INSERT [dbo].[HoaDonBanHang] ([SoHoaDon], [NgayLap], [VAT], [TongTien], [MaKHTT], [MaNV]) VALUES (N'HD007', CAST(N'2023-07-27' AS Date), NULL, 620000, N'KHVL', N'NV004')
INSERT [dbo].[HoaDonBanHang] ([SoHoaDon], [NgayLap], [VAT], [TongTien], [MaKHTT], [MaNV]) VALUES (N'HD008', CAST(N'2023-08-27' AS Date), NULL, 770000, N'KHVL', N'NV004')
INSERT [dbo].[HoaDonBanHang] ([SoHoaDon], [NgayLap], [VAT], [TongTien], [MaKHTT], [MaNV]) VALUES (N'HD009', CAST(N'2023-09-27' AS Date), NULL, 290000, N'KHVL', N'NV004')
INSERT [dbo].[HoaDonBanHang] ([SoHoaDon], [NgayLap], [VAT], [TongTien], [MaKHTT], [MaNV]) VALUES (N'HD010', CAST(N'2022-10-04' AS Date), 0, 2805000, N'KHVL', N'NV004')
INSERT [dbo].[HoaDonBanHang] ([SoHoaDon], [NgayLap], [VAT], [TongTien], [MaKHTT], [MaNV]) VALUES (N'HD011', CAST(N'2021-07-04' AS Date), 0, 805000, N'KHVL', N'NV004')
INSERT [dbo].[HoaDonBanHang] ([SoHoaDon], [NgayLap], [VAT], [TongTien], [MaKHTT], [MaNV]) VALUES (N'HD11424', CAST(N'2023-10-27' AS Date), NULL, 120000, N'KHVL', N'NV004')
INSERT [dbo].[HoaDonBanHang] ([SoHoaDon], [NgayLap], [VAT], [TongTien], [MaKHTT], [MaNV]) VALUES (N'HD15092', CAST(N'2023-10-27' AS Date), 10, 96000, N'KHVL', N'NV004')
INSERT [dbo].[HoaDonBanHang] ([SoHoaDon], [NgayLap], [VAT], [TongTien], [MaKHTT], [MaNV]) VALUES (N'HD23835', CAST(N'2023-12-15' AS Date), 3, 41200, N'KHVL', N'NV004')
INSERT [dbo].[HoaDonBanHang] ([SoHoaDon], [NgayLap], [VAT], [TongTien], [MaKHTT], [MaNV]) VALUES (N'HD24964', CAST(N'2023-10-27' AS Date), NULL, 58000, N'KHVL', N'NV004')
INSERT [dbo].[HoaDonBanHang] ([SoHoaDon], [NgayLap], [VAT], [TongTien], [MaKHTT], [MaNV]) VALUES (N'HD25178', CAST(N'2023-11-27' AS Date), NULL, 20000, N'KHVL', N'NV004')
INSERT [dbo].[HoaDonBanHang] ([SoHoaDon], [NgayLap], [VAT], [TongTien], [MaKHTT], [MaNV]) VALUES (N'HD29217', CAST(N'2023-12-15' AS Date), 10, 233310, N'KHVL', N'NV004')
INSERT [dbo].[HoaDonBanHang] ([SoHoaDon], [NgayLap], [VAT], [TongTien], [MaKHTT], [MaNV]) VALUES (N'HD46126', CAST(N'2023-11-27' AS Date), NULL, 5000, N'KHVL', N'NV004')
INSERT [dbo].[HoaDonBanHang] ([SoHoaDon], [NgayLap], [VAT], [TongTien], [MaKHTT], [MaNV]) VALUES (N'HD60730', CAST(N'2023-12-15' AS Date), NULL, NULL, N'KHVL', N'NV004')
INSERT [dbo].[HoaDonBanHang] ([SoHoaDon], [NgayLap], [VAT], [TongTien], [MaKHTT], [MaNV]) VALUES (N'HD63445', CAST(N'2023-10-04' AS Date), 0, 1805000, N'KHVL', N'NV004')
INSERT [dbo].[HoaDonBanHang] ([SoHoaDon], [NgayLap], [VAT], [TongTien], [MaKHTT], [MaNV]) VALUES (N'HD68572', CAST(N'2023-12-15' AS Date), 30, 33475, N'KHVL', N'NV004')
INSERT [dbo].[HoaDonBanHang] ([SoHoaDon], [NgayLap], [VAT], [TongTien], [MaKHTT], [MaNV]) VALUES (N'HD75894', CAST(N'2023-11-27' AS Date), 10, 277750, N'KH004', N'NV004')
INSERT [dbo].[KhachHangThanThiet] ([MaThe], [HoTen], [NgaySinhKH], [SDTKH], [DiaChiKH], [Diem]) VALUES (N'KH001', N'Nguyễn Van An', CAST(N'1990-01-01' AS Date), N'0123456789', N'TPHCM', 157)
INSERT [dbo].[KhachHangThanThiet] ([MaThe], [HoTen], [NgaySinhKH], [SDTKH], [DiaChiKH], [Diem]) VALUES (N'KH002', N'Trần Thế Bảo', CAST(N'1995-05-05' AS Date), N'0987654321', N'Vũng Tàu', 150)
INSERT [dbo].[KhachHangThanThiet] ([MaThe], [HoTen], [NgaySinhKH], [SDTKH], [DiaChiKH], [Diem]) VALUES (N'KH003', N'Lê Văn Cao', CAST(N'1988-12-31' AS Date), N'0123987654', N'TPHCM', 205)
INSERT [dbo].[KhachHangThanThiet] ([MaThe], [HoTen], [NgaySinhKH], [SDTKH], [DiaChiKH], [Diem]) VALUES (N'KH004', N'Thành', CAST(N'2000-01-01' AS Date), N'0', N'0', 0)
INSERT [dbo].[KhachHangThanThiet] ([MaThe], [HoTen], [NgaySinhKH], [SDTKH], [DiaChiKH], [Diem]) VALUES (N'KH14873', N'aaaaaa', CAST(N'2000-12-31' AS Date), N'123456780', N'aaaaaa', 0)
INSERT [dbo].[KhachHangThanThiet] ([MaThe], [HoTen], [NgaySinhKH], [SDTKH], [DiaChiKH], [Diem]) VALUES (N'KHVL', N'Khách Vãng Lai', CAST(N'1999-01-01' AS Date), N'0', N'0', 14)
INSERT [dbo].[LoaiHangHoa] ([MaLoai], [TenLoai]) VALUES (N'LOAI001', N'Đồ ăn')
INSERT [dbo].[LoaiHangHoa] ([MaLoai], [TenLoai]) VALUES (N'LOAI002', N'Nước uống')
INSERT [dbo].[LoaiHangHoa] ([MaLoai], [TenLoai]) VALUES (N'LOAI003', N'Quần áo')
INSERT [dbo].[LoaiHangHoa] ([MaLoai], [TenLoai]) VALUES (N'LOAI004', N'Dụng cụ')
INSERT [dbo].[LoaiHangHoa] ([MaLoai], [TenLoai]) VALUES (N'LOAI005', N'a')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChiNCC], [SDTNCC]) VALUES (N'NCC001', N'Kraft Heinz', N'TPHCM', N'0123456789')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChiNCC], [SDTNCC]) VALUES (N'NCC002', N'Coca-Cola', N'Đà Lạt', N'0987654321')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChiNCC], [SDTNCC]) VALUES (N'NCC003', N'Zara', N'TPHCM', N'0123987654')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChiNCC], [SDTNCC]) VALUES (N'NCC004', N'Black & Decker', N'TPHCM', N'0777756565')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChiNCC], [SDTNCC]) VALUES (N'NCC005', N'Vina Milk', N'TPHCM', N'0726595326')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChiNCC], [SDTNCC]) VALUES (N'NCC006', N'Lays', N'HCM', N'0123456897')
INSERT [dbo].[NhanVien] ([MaNV], [HoTenNV], [NgaySinhNV], [ChucVu], [Luong], [SDTNV], [DiaChiNv]) VALUES (N'NV001', N'Nguyễn Văn Nam', CAST(N'1990-01-01' AS Date), N'Nhân viên bán hàng', 10000000, N'0901234567', N'HCM')
INSERT [dbo].[NhanVien] ([MaNV], [HoTenNV], [NgaySinhNV], [ChucVu], [Luong], [SDTNV], [DiaChiNv]) VALUES (N'NV002', N'Trần Thị Hương', CAST(N'1995-02-02' AS Date), N'Nhân viên kế toán', 12000000, N'0909876543', N'Hanoi')
INSERT [dbo].[NhanVien] ([MaNV], [HoTenNV], [NgaySinhNV], [ChucVu], [Luong], [SDTNV], [DiaChiNv]) VALUES (N'NV003', N'Lê Văn Tùng', CAST(N'1992-03-03' AS Date), N'Nhân viên kho', 9000000, N'0905555555', N'Da Nang')
INSERT [dbo].[NhanVien] ([MaNV], [HoTenNV], [NgaySinhNV], [ChucVu], [Luong], [SDTNV], [DiaChiNv]) VALUES (N'NV004', N'Lê Quang Liêm', CAST(N'1992-03-03' AS Date), N'Quản lý', 1000000, N'0912939811', N'HCM')
INSERT [dbo].[NhanVien] ([MaNV], [HoTenNV], [NgaySinhNV], [ChucVu], [Luong], [SDTNV], [DiaChiNv]) VALUES (N'NV005', N'aaaaaa', NULL, N'Nhân viên bán hàng', NULL, N'123456700', NULL)
INSERT [dbo].[PhieuNhapHang] ([SoPhieuNhap], [NgayTaoPNH], [MaNV], [TrangThai]) VALUES (1, CAST(N'2022-07-20' AS Date), N'NV002', N'Hoàn thành')
INSERT [dbo].[PhieuNhapHang] ([SoPhieuNhap], [NgayTaoPNH], [MaNV], [TrangThai]) VALUES (2, CAST(N'2023-08-30' AS Date), N'NV003', N'Hoàn thành')
INSERT [dbo].[PhieuNhapHang] ([SoPhieuNhap], [NgayTaoPNH], [MaNV], [TrangThai]) VALUES (3, CAST(N'2023-11-05' AS Date), N'NV004', N'Hoàn thành')
INSERT [dbo].[PhieuNhapHang] ([SoPhieuNhap], [NgayTaoPNH], [MaNV], [TrangThai]) VALUES (4, CAST(N'2023-12-15' AS Date), N'NV004', N'Hoàn thành')
INSERT [dbo].[PhieuXuatHang] ([SoPhieuXuat], [NgayTaoPXH], [MaNV], [TrangThai]) VALUES (1, CAST(N'2023-10-20' AS Date), N'NV001', N'Hoàn thành')
INSERT [dbo].[PhieuXuatHang] ([SoPhieuXuat], [NgayTaoPXH], [MaNV], [TrangThai]) VALUES (2, CAST(N'2023-10-29' AS Date), N'NV004', N'Hoàn thành')
INSERT [dbo].[PhieuXuatHang] ([SoPhieuXuat], [NgayTaoPXH], [MaNV], [TrangThai]) VALUES (3, CAST(N'2023-10-29' AS Date), N'NV004', N'Hoàn thành')
INSERT [dbo].[PhieuXuatHang] ([SoPhieuXuat], [NgayTaoPXH], [MaNV], [TrangThai]) VALUES (4, CAST(N'2023-11-27' AS Date), N'NV004', NULL)
INSERT [dbo].[PhieuXuatHang] ([SoPhieuXuat], [NgayTaoPXH], [MaNV], [TrangThai]) VALUES (5, CAST(N'2023-12-15' AS Date), N'NV004', N'Hoàn thành')
ALTER TABLE [dbo].[CTHoaDonBanHang]  WITH CHECK ADD  CONSTRAINT [FK_CTHoaDonBanHang_HangHoa1] FOREIGN KEY([MaHang])
REFERENCES [dbo].[HangHoa] ([MaHang])
GO
ALTER TABLE [dbo].[CTHoaDonBanHang] CHECK CONSTRAINT [FK_CTHoaDonBanHang_HangHoa1]
GO
ALTER TABLE [dbo].[CTHoaDonBanHang]  WITH CHECK ADD  CONSTRAINT [FK_CTHoaDonBanHang_HoaDonBanHang] FOREIGN KEY([SoHoaDon])
REFERENCES [dbo].[HoaDonBanHang] ([SoHoaDon])
GO
ALTER TABLE [dbo].[CTHoaDonBanHang] CHECK CONSTRAINT [FK_CTHoaDonBanHang_HoaDonBanHang]
GO
ALTER TABLE [dbo].[CTPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_CTPhieuNhap_HangHoa] FOREIGN KEY([MaHang])
REFERENCES [dbo].[HangHoa] ([MaHang])
GO
ALTER TABLE [dbo].[CTPhieuNhap] CHECK CONSTRAINT [FK_CTPhieuNhap_HangHoa]
GO
ALTER TABLE [dbo].[CTPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_CTPhieuNhap_PhieuNhapHang] FOREIGN KEY([SoPhieuNhap])
REFERENCES [dbo].[PhieuNhapHang] ([SoPhieuNhap])
GO
ALTER TABLE [dbo].[CTPhieuNhap] CHECK CONSTRAINT [FK_CTPhieuNhap_PhieuNhapHang]
GO
ALTER TABLE [dbo].[CTPhieuXuatHang]  WITH CHECK ADD  CONSTRAINT [FK_CTPhieuXuatHang_HangHoa] FOREIGN KEY([MaHang])
REFERENCES [dbo].[HangHoa] ([MaHang])
GO
ALTER TABLE [dbo].[CTPhieuXuatHang] CHECK CONSTRAINT [FK_CTPhieuXuatHang_HangHoa]
GO
ALTER TABLE [dbo].[CTPhieuXuatHang]  WITH CHECK ADD  CONSTRAINT [FK_CTPhieuXuatHang_PhieuXuatHang] FOREIGN KEY([SoPhieuXuat])
REFERENCES [dbo].[PhieuXuatHang] ([SoPhieuXuat])
GO
ALTER TABLE [dbo].[CTPhieuXuatHang] CHECK CONSTRAINT [FK_CTPhieuXuatHang_PhieuXuatHang]
GO
ALTER TABLE [dbo].[DangNhap]  WITH CHECK ADD  CONSTRAINT [FK_DangNhap_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[DangNhap] CHECK CONSTRAINT [FK_DangNhap_NhanVien]
GO
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD  CONSTRAINT [FK_HangHoa_LoaiHangHoa] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LoaiHangHoa] ([MaLoai])
GO
ALTER TABLE [dbo].[HangHoa] CHECK CONSTRAINT [FK_HangHoa_LoaiHangHoa]
GO
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD  CONSTRAINT [FK_HangHoa_NhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[HangHoa] CHECK CONSTRAINT [FK_HangHoa_NhaCungCap]
GO
ALTER TABLE [dbo].[HoaDonBanHang]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonBanHang_KhachHangThanThiet] FOREIGN KEY([MaKHTT])
REFERENCES [dbo].[KhachHangThanThiet] ([MaThe])
GO
ALTER TABLE [dbo].[HoaDonBanHang] CHECK CONSTRAINT [FK_HoaDonBanHang_KhachHangThanThiet]
GO
ALTER TABLE [dbo].[HoaDonBanHang]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonBanHang_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDonBanHang] CHECK CONSTRAINT [FK_HoaDonBanHang_NhanVien]
GO
ALTER TABLE [dbo].[PhieuNhapHang]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhapHang_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[PhieuNhapHang] CHECK CONSTRAINT [FK_PhieuNhapHang_NhanVien]
GO
ALTER TABLE [dbo].[PhieuXuatHang]  WITH CHECK ADD  CONSTRAINT [FK_PhieuXuatHang_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[PhieuXuatHang] CHECK CONSTRAINT [FK_PhieuXuatHang_NhanVien]
GO
