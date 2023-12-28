USE [frm_QuanLy_ShopConCung2]
GO
/****** Object:  Table [dbo].[DanhMucSanPham]    Script Date: 12/28/2023 21:33:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DanhMucSanPham](
	[MaDanhMuc] [varchar](10) NOT NULL,
	[TenDanhMuc] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDanhMuc] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[DanhMucSanPham] ([MaDanhMuc], [TenDanhMuc]) VALUES (N'DM001', N'Sữa cho em bé')
INSERT [dbo].[DanhMucSanPham] ([MaDanhMuc], [TenDanhMuc]) VALUES (N'DM002', N'Tả giấy')
INSERT [dbo].[DanhMucSanPham] ([MaDanhMuc], [TenDanhMuc]) VALUES (N'DM003', N'Thuốc bổ cho em bé')
INSERT [dbo].[DanhMucSanPham] ([MaDanhMuc], [TenDanhMuc]) VALUES (N'DM004', N'Thuốc bổ cho mẹ bầu')
INSERT [dbo].[DanhMucSanPham] ([MaDanhMuc], [TenDanhMuc]) VALUES (N'DM005', N'Đồ chơi cho em bé')
INSERT [dbo].[DanhMucSanPham] ([MaDanhMuc], [TenDanhMuc]) VALUES (N'DM006', N'Quần áo cho em bé')
INSERT [dbo].[DanhMucSanPham] ([MaDanhMuc], [TenDanhMuc]) VALUES (N'DM007', N'Dụng cụ chăm sóc em bé')
INSERT [dbo].[DanhMucSanPham] ([MaDanhMuc], [TenDanhMuc]) VALUES (N'DM008', N'Dầu gội cho em bé')
INSERT [dbo].[DanhMucSanPham] ([MaDanhMuc], [TenDanhMuc]) VALUES (N'DM009', N'Thức ăn cho em bé')
INSERT [dbo].[DanhMucSanPham] ([MaDanhMuc], [TenDanhMuc]) VALUES (N'DM010', N'Phụ kiện cho mẹ bầu')
/****** Object:  Table [dbo].[NhanVien]    Script Date: 12/28/2023 21:33:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [varchar](10) NOT NULL,
	[TenNhanVien] [nvarchar](255) NULL,
	[GioiTinh] [nvarchar](5) NULL,
	[ChucVu] [varchar](50) NULL,
	[SDT] [varchar](12) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [GioiTinh], [ChucVu], [SDT]) VALUES (N'AD001', N'Nguyễn Văn Admin', N'Nam', N'Quan Tri Vien', N'0399999999')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [GioiTinh], [ChucVu], [SDT]) VALUES (N'NV001', N'Trần Văn A', N'Nam', N'Quan lý', N'0123456789')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [GioiTinh], [ChucVu], [SDT]) VALUES (N'NV002', N'Nguyễn Thị B', N'Nữ', N'Nhân viên bán hàng', N'0987654322')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [GioiTinh], [ChucVu], [SDT]) VALUES (N'NV003', N'Lê Văn C', N'Nam', N'Nhân viên kho', N'0123456780')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [GioiTinh], [ChucVu], [SDT]) VALUES (N'NV004', N'Trần Thanh D', N'Nữ', N'Nhân viên thu ngân', N'0213365565')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [GioiTinh], [ChucVu], [SDT]) VALUES (N'NV005', N'Nguyễn Nam', N'Nam', N'Nhân viên kho ', N'0212222565')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [GioiTinh], [ChucVu], [SDT]) VALUES (N'NV006', N'Nguyễn Thị Nữ', N'Nữ', N'Quan lý', N'0325566522')
/****** Object:  Table [dbo].[KhachHang]    Script Date: 12/28/2023 21:33:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKhachHang] [varchar](10) NOT NULL,
	[HoTen] [nvarchar](255) NULL,
	[GioiTinh] [nvarchar](5) NOT NULL,
	[DiaChi] [nvarchar](255) NOT NULL,
	[SDT] [varchar](12) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[SDT] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [GioiTinh], [DiaChi], [SDT]) VALUES (N'KH001', N'Nguyễn Văn A', N'Nam', N'123 Đường ABC, Quận 1, TP.HCM', N'0123456789')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [GioiTinh], [DiaChi], [SDT]) VALUES (N'KH002', N'Trần Thị B', N'Nữ', N'457 Đường XYZ, Quận 2, TP.HCM', N'0987654321')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [GioiTinh], [DiaChi], [SDT]) VALUES (N'KH003', N'Lê Văn C', N'Nam', N'789 Đường DEF, Quận 3, TP.HCM', N'0123456780')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [GioiTinh], [DiaChi], [SDT]) VALUES (N'KH004', N'Phạm Thị D', N'Nữ', N'101 Đường HIJ, Quận 4, TP.HCM', N'0987654312')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [GioiTinh], [DiaChi], [SDT]) VALUES (N'KH005', N'Hoàng Văn E', N'Nam', N'205 Đường KLM, Quận 5, TP.HCM', N'0123456709')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [GioiTinh], [DiaChi], [SDT]) VALUES (N'KH006', N'Nguyễn Thị F', N'Nữ', N'303 Đường NOP, Quận 6, TP.HCM', N'0987654789')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [GioiTinh], [DiaChi], [SDT]) VALUES (N'KH007', N'Trần Văn G', N'Nam', N'404 Đường QRS, Quận 7, TP.HCM', N'0123456890')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [GioiTinh], [DiaChi], [SDT]) VALUES (N'KH008', N'Lê Thị H', N'Nữ', N'504 Đường TUV, Quận 8, TP.HCM', N'0987654067')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [GioiTinh], [DiaChi], [SDT]) VALUES (N'KH009', N'Phan Văn I', N'Nam', N'606 Đường WXY, Quận 9, TP.HCM', N'0123456123')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [GioiTinh], [DiaChi], [SDT]) VALUES (N'KH010', N'Trần Thị K', N'Nữ', N'707 Đường ZAB, Quận 10, TP.HCM', N'0987656234')
/****** Object:  Table [dbo].[DonHang]    Script Date: 12/28/2023 21:33:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DonHang](
	[MaDonHang] [varchar](10) NOT NULL,
	[NgayDatHang] [date] NOT NULL,
	[MaKhachHang] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDonHang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[DonHang] ([MaDonHang], [NgayDatHang], [MaKhachHang]) VALUES (N'DH001', CAST(0xF7440B00 AS Date), N'KH001')
INSERT [dbo].[DonHang] ([MaDonHang], [NgayDatHang], [MaKhachHang]) VALUES (N'DH002', CAST(0xE6440B00 AS Date), N'KH002')
INSERT [dbo].[DonHang] ([MaDonHang], [NgayDatHang], [MaKhachHang]) VALUES (N'DH003', CAST(0x26450B00 AS Date), N'KH003')
INSERT [dbo].[DonHang] ([MaDonHang], [NgayDatHang], [MaKhachHang]) VALUES (N'DH004', CAST(0x36450B00 AS Date), N'KH004')
INSERT [dbo].[DonHang] ([MaDonHang], [NgayDatHang], [MaKhachHang]) VALUES (N'DH005', CAST(0x59450B00 AS Date), N'KH005')
INSERT [dbo].[DonHang] ([MaDonHang], [NgayDatHang], [MaKhachHang]) VALUES (N'DH006', CAST(0x7D450B00 AS Date), N'KH006')
INSERT [dbo].[DonHang] ([MaDonHang], [NgayDatHang], [MaKhachHang]) VALUES (N'DH007', CAST(0xA5450B00 AS Date), N'KH007')
INSERT [dbo].[DonHang] ([MaDonHang], [NgayDatHang], [MaKhachHang]) VALUES (N'DH008', CAST(0xAD450B00 AS Date), N'KH008')
INSERT [dbo].[DonHang] ([MaDonHang], [NgayDatHang], [MaKhachHang]) VALUES (N'DH009', CAST(0xDC450B00 AS Date), N'KH009')
INSERT [dbo].[DonHang] ([MaDonHang], [NgayDatHang], [MaKhachHang]) VALUES (N'DH010', CAST(0x06460B00 AS Date), N'KH010')
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 12/28/2023 21:33:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[idtaikhoan] [varchar](10) NOT NULL,
	[taikhoan] [nvarchar](20) NULL,
	[matkhau] [varchar](10) NULL,
	[quyen] [int] NULL,
	[MaNhanVien] [varchar](10) NULL,
	[MaKhachHang] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[idtaikhoan] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[TaiKhoan] ([idtaikhoan], [taikhoan], [matkhau], [quyen], [MaNhanVien], [MaKhachHang]) VALUES (N'8L86h', N'q', N'q', NULL, NULL, NULL)
INSERT [dbo].[TaiKhoan] ([idtaikhoan], [taikhoan], [matkhau], [quyen], [MaNhanVien], [MaKhachHang]) VALUES (N'lKUFg', N'khachhang3', N'khachhang3', NULL, NULL, NULL)
INSERT [dbo].[TaiKhoan] ([idtaikhoan], [taikhoan], [matkhau], [quyen], [MaNhanVien], [MaKhachHang]) VALUES (N'TK001', N'admin', N'admin', 1, N'AD001', NULL)
INSERT [dbo].[TaiKhoan] ([idtaikhoan], [taikhoan], [matkhau], [quyen], [MaNhanVien], [MaKhachHang]) VALUES (N'TK002', N'nhanvien', N'nhanvien', 0, N'NV002', NULL)
INSERT [dbo].[TaiKhoan] ([idtaikhoan], [taikhoan], [matkhau], [quyen], [MaNhanVien], [MaKhachHang]) VALUES (N'TK003', N'nhanvien3', N'nhanvien3', 0, N'NV003', NULL)
INSERT [dbo].[TaiKhoan] ([idtaikhoan], [taikhoan], [matkhau], [quyen], [MaNhanVien], [MaKhachHang]) VALUES (N'TK004', N'khachhang1', N'khachhang1', NULL, NULL, N'KH001')
INSERT [dbo].[TaiKhoan] ([idtaikhoan], [taikhoan], [matkhau], [quyen], [MaNhanVien], [MaKhachHang]) VALUES (N'TK005', N'khachhang2', N'khachhang2', NULL, NULL, N'KH002')
/****** Object:  Table [dbo].[SanPham]    Script Date: 12/28/2023 21:33:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSanPham] [varchar](10) NOT NULL,
	[TenSanPham] [nvarchar](255) NULL,
	[Gia] [int] NOT NULL,
	[SoLuongTrongKho] [int] NOT NULL,
	[MaDanhMuc] [varchar](10) NULL,
	[HinhAnh] [nvarchar](255) NULL,
	[SoLuongDaBan] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSanPham] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuongTrongKho], [MaDanhMuc], [HinhAnh], [SoLuongDaBan]) VALUES (N'SP001', N'Sữa Enfamil', 180000, 1000, N'DM001', N'https://suachobeyeu.vn/upload/images/sua-enfamil-a-neuro-pro-400g-cho-tre-0-6-thang-2.jpg', 12)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuongTrongKho], [MaDanhMuc], [HinhAnh], [SoLuongDaBan]) VALUES (N'SP002', N'Tả Pampers', 210000, 50, N'DM002', N'https://www.moby.com.vn/data/bt6/bim-ta-quan-pampers-sj-size-m-74-mieng-be-7-12kg-1620445988.jpg', 20)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuongTrongKho], [MaDanhMuc], [HinhAnh], [SoLuongDaBan]) VALUES (N'SP003', N'Dầu ăn cho em bé', 25000, 200, N'DM003', N'https://media.shoptretho.com.vn/upload/image/product/20230323/dau-an-dinh-duong-kiddy-250ml.png', 15)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuongTrongKho], [MaDanhMuc], [HinhAnh], [SoLuongDaBan]) VALUES (N'SP004', N'Vitamin cho mẹ bầu', 120000, 81, N'DM004', N'https://benhvienbacha.vn/wp-content/uploads/2019/10/elevit-vitamin-cho-ba-bau.jpg', 36)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuongTrongKho], [MaDanhMuc], [HinhAnh], [SoLuongDaBan]) VALUES (N'SP005', N'Búp bê ngủ', 60000, 30, N'DM005', N'https://imgcdn.thitruongsi.com/tts/rs:fill:600:0:1:1/g:sm/plain/file://product/2022/08/09/685712a0-179b-11ed-a06e-9d5ffd5d170d.jpg', 15)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuongTrongKho], [MaDanhMuc], [HinhAnh], [SoLuongDaBan]) VALUES (N'SP006', N'Áo jumpsuit cho bé gái', 100000, 40, N'DM006', N'https://bizweb.dktcdn.net/100/032/149/files/jumpsuit-cho-be-gai-m885-7.jpg?v=1571897414065', 30)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuongTrongKho], [MaDanhMuc], [HinhAnh], [SoLuongDaBan]) VALUES (N'SP007', N'Bình sữa silicon', 50000, 120, N'DM007', N'https://img.websosanh.vn/v10/users/review/images/hlhxpwikicwnr/binh-sua-comotomo-silicon.jpg?compress=85', 50)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuongTrongKho], [MaDanhMuc], [HinhAnh], [SoLuongDaBan]) VALUES (N'SP008', N'Dầu gội Johnson', 45000, 150, N'DM008', N'https://cdn-v2.kidsplaza.vn/media/wysiwyg/product/be-tam/sua-tam-dau-goi/dau-goi-ong-muot-johnson-baby-hong-200ml-1_1.jpg', 100)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuongTrongKho], [MaDanhMuc], [HinhAnh], [SoLuongDaBan]) VALUES (N'SP009', N'Thức ăn hỗ trợ sức khỏe', 90000, 60, N'DM009', N'https://www.vinmec.com/s3-images/20210519_065638_691484_thuc-pham-tot-cho-suc.max-800x800.jpg', 30)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuongTrongKho], [MaDanhMuc], [HinhAnh], [SoLuongDaBan]) VALUES (N'SP010', N'Gối hỗ trợ bụng bầu', 180000, 20, N'DM010', N'https://lzd-img-global.slatic.net/g/p/859b81b33bf55a2f8e9b0b64888af617.png_720x720q80.png', 12)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuongTrongKho], [MaDanhMuc], [HinhAnh], [SoLuongDaBan]) VALUES (N'SP011', N'Sữa Similac', 130000, 80, N'DM001', N'https://concung.com/2023/04/43266-99865-large_mobile/sua-similac-5g-so-1-900g-0-6-thang.png', 60)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuongTrongKho], [MaDanhMuc], [HinhAnh], [SoLuongDaBan]) VALUES (N'SP012', N'Tả Huggies', 180000, 60, N'DM002', N'https://concung.com/2023/03/62031-99494-large_mobile/ta-dan-so-sinh-huggies-dry-s-4-8kg-80-mieng-2-mieng.png', 20)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuongTrongKho], [MaDanhMuc], [HinhAnh], [SoLuongDaBan]) VALUES (N'SP013', N'Dầu gội cho trẻ sơ sinh', 55000, 100, N'DM003', N'https://cdn-v2.kidsplaza.vn/media/catalog/product/t/a/tam-goi-cho-be-dnee-xanh-la-200ml.jpg', 10)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuongTrongKho], [MaDanhMuc], [HinhAnh], [SoLuongDaBan]) VALUES (N'SP014', N'Aspirin cho mẹ bầu', 110000, 40, N'DM004', N'https://storage.pca-tech.online/Cms_Data/Contents/mau4_1/Media/N%C4%83m%202021/NTV-104-02.jpg', 4)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuongTrongKho], [MaDanhMuc], [HinhAnh], [SoLuongDaBan]) VALUES (N'SP015', N'Xe đẩy cho em bé', 500000, 20, N'DM005', N'https://media.shoptretho.com.vn/upload/image/product/20230424/xe-day-tre-em-joie-litetrax-4-dlx-w-rc-deep-sea.jpg?mode=max&width=400&height=400', 10)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuongTrongKho], [MaDanhMuc], [HinhAnh], [SoLuongDaBan]) VALUES (N'SP016', N'Bộ quần áo unisex cho em bé', 90000, 30, N'DM006', N'https://lzd-img-global.slatic.net/g/p/d60838bd3c88a3c07d2b52d89ed28a2a.jpg_720x720q80.jpg', 20)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuongTrongKho], [MaDanhMuc], [HinhAnh], [SoLuongDaBan]) VALUES (N'SP017', N'Bàn chải và kem đánh răng cho em bé', 35000, 150, N'DM007', N'https://images.depxinh.net/products/item.10_2017/2/detail/bo-chai-rang-ps-26-1-dep-xinh.jpg', 12)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuongTrongKho], [MaDanhMuc], [HinhAnh], [SoLuongDaBan]) VALUES (N'SP018', N'Dầu gội baby Dove', 48000, 120, N'DM008', N'https://salt.tikicdn.com/ts/product/4a/79/2b/2212a28d47c5134cbcdec04a2126f1ef.jpg', 32)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuongTrongKho], [MaDanhMuc], [HinhAnh], [SoLuongDaBan]) VALUES (N'SP019', N'Bột ăn dặm Nestle', 75000, 90, N'DM009', N'https://cdn-v2.kidsplaza.vn/424x424/media/catalog/product/b/o/bot-an-dam-gao-va-trai-cay-hon-hop-nestle.jpg', 6)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuongTrongKho], [MaDanhMuc], [HinhAnh], [SoLuongDaBan]) VALUES (N'SP020', N'Gối chống trầm cảm cho mẹ bầu', 200000, 15, N'DM010', N'https://ichikobaby.com/wp-content/uploads/2020/09/goi-massage-bau.jpg', 5)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuongTrongKho], [MaDanhMuc], [HinhAnh], [SoLuongDaBan]) VALUES (N'SP021', N'Sữa Nutrilon', 140000, 90, N'DM001', N'https://www.suatot247.com/upload/images/Sua-bot-Nutrilon-cua-Sec.jpg', 12)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuongTrongKho], [MaDanhMuc], [HinhAnh], [SoLuongDaBan]) VALUES (N'SP022', N'Tả Libero', 190000, 70, N'DM002', N'https://bizweb.dktcdn.net/100/348/768/products/shopee-bobby-quan-s-46-mieng.jpg?v=1637664745783', 21)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuongTrongKho], [MaDanhMuc], [HinhAnh], [SoLuongDaBan]) VALUES (N'SP023', N'Dầu tắm cho em bé Johnson', 60000, 120, N'DM003', N'https://www.johnsonsbaby.com.vn/sites/jbaby_vn/files/jbaby-top-to-toe-baby-bath-500ml-front.jpg', 14)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuongTrongKho], [MaDanhMuc], [HinhAnh], [SoLuongDaBan]) VALUES (N'SP024', N'Canxi cho mẹ bầu', 125000, 50, N'DM004', N'https://nhathuoc365.vn/upload_images/images/vitamin-d-calcium-ostelin-cua-uc-5ba9dd6f5199f-25092018140207.jpg', 15)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuongTrongKho], [MaDanhMuc], [HinhAnh], [SoLuongDaBan]) VALUES (N'SP025', N'Đèn trần cho phòng em bé', 130000, 30, N'DM005', N'https://bandentrangtri.com.vn/wp-content/uploads/2022/06/8b1d68fd6228faf04e75bbd480ccc30d.jpg', 12)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuongTrongKho], [MaDanhMuc], [HinhAnh], [SoLuongDaBan]) VALUES (N'SP026', N'Bộ body bé gái', 95000, 35, N'DM006', N'https://img.ws.mms.shopee.vn/1e08bc97454fc315a13eb222ec4606e6', 14)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuongTrongKho], [MaDanhMuc], [HinhAnh], [SoLuongDaBan]) VALUES (N'SP027', N'Bình sữa Tommee Tippee', 75000, 100, N'DM007', N'https://tommeetippeevietnam.com/wp-content/uploads/2019/04/PP-260ml_Slide-5.jpg', 15)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuongTrongKho], [MaDanhMuc], [HinhAnh], [SoLuongDaBan]) VALUES (N'SP028', N'Dầu gội Mustela', 55000, 110, N'DM008', N'https://product.hstatic.net/1000219405/product/dau_goi_200ml_-_trang__moi__59f3914112094b2ab46e07df7960bf86_large.jpg', 35)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuongTrongKho], [MaDanhMuc], [HinhAnh], [SoLuongDaBan]) VALUES (N'SP029', N'Bột ăn dặm Gerber', 78000, 80, N'DM009', N'https://anskitchen.vn/wp-content/uploads/2022/08/103-1.png', 12)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuongTrongKho], [MaDanhMuc], [HinhAnh], [SoLuongDaBan]) VALUES (N'SP030', N'Gối hơi hỗ trợ bụng bầu', 190000, 25, N'DM010', N'https://shopmevabe.com.vn/upload/sanpham/goi-ke-bung-canh-tien-ho-tro-giam-dau-lung-cho-me-bau-(4)-5357.jpg', 14)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuongTrongKho], [MaDanhMuc], [HinhAnh], [SoLuongDaBan]) VALUES (N'SP031', N'Sữa Frisolac', 155000, 75, N'DM001', N'https://www.kidsplaza.vn/blog/wp-content/uploads/2022/07/sua-Frisolac-Gold-1-co-tang-can-khong-1.jpg', 11)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuongTrongKho], [MaDanhMuc], [HinhAnh], [SoLuongDaBan]) VALUES (N'SP032', N'Tả Mamypoko', 210000, 55, N'DM002', N'https://down-vn.img.susercontent.com/file/c5144345910c3ac6bb603fd62f0ce6f8', 10)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuongTrongKho], [MaDanhMuc], [HinhAnh], [SoLuongDaBan]) VALUES (N'SP033', N'Nước tắm gội cho trẻ sơ sinh', 65000, 90, N'DM003', N'https://bizweb.dktcdn.net/100/421/012/products/sua-tam-goi-toan-than-cho-be-cetaphil-400ml-hoa-cuc-1-1678728068614.png?v=1678728072270', 11)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuongTrongKho], [MaDanhMuc], [HinhAnh], [SoLuongDaBan]) VALUES (N'SP034', N'Vitamin D cho mẹ bầu', 115000, 45, N'DM004', N'https://www.hangngoainhap.com.vn/images/201907/goods_img/1566-p2-1562808735.jpg', 16)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuongTrongKho], [MaDanhMuc], [HinhAnh], [SoLuongDaBan]) VALUES (N'SP035', N'Đèn đọc sách cho em bé', 110000, 28, N'DM005', N'https://lzd-img-global.slatic.net/g/p/7f9fd1ccaf5f5369f28700fa11dd77a4.jpg_webp_720x720q80.jpg', 22)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuongTrongKho], [MaDanhMuc], [HinhAnh], [SoLuongDaBan]) VALUES (N'SP036', N'Bộ body bé trai', 87000, 48, N'DM006', N'https://www.kidsplaza.vn/blog/wp-content/uploads/2017/07/body-so-sinh.jpg', 11)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuongTrongKho], [MaDanhMuc], [HinhAnh], [SoLuongDaBan]) VALUES (N'SP037', N'Bình sữa Dr. Brown', 82000, 95, N'DM007', N'https://cdn-v2.kidsplaza.vn/media/wysiwyg/product/be-an-be-uong/binh-sua/SB41005.jpg', 12)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuongTrongKho], [MaDanhMuc], [HinhAnh], [SoLuongDaBan]) VALUES (N'SP038', N'Dầu gội Cetaphil', 62000, 85, N'DM008', N'https://data-service.pharmacity.io/pmc-upload-media/production/pmc-ecm-core/products/P09428_3.jpg', 20)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuongTrongKho], [MaDanhMuc], [HinhAnh], [SoLuongDaBan]) VALUES (N'SP039', N'Cháo hỗ trợ tăng cường dinh dưỡng', 88000, 65, N'DM009', N'https://lh6.googleusercontent.com/X6ayCdkjSnnojRFagKQKcv2UHgErs3n2X7Sj1j-J6yWUHR8Qu8bh7NrqhTOTK8Qq5E2WrtjmOqymlpAjhTZosdvcQgdq72mt5T-IH43b6Dqltarb0dAnS1nYSzDqQXyotYtT7VJ_K9bOubJTpExFNg', 11)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuongTrongKho], [MaDanhMuc], [HinhAnh], [SoLuongDaBan]) VALUES (N'SP040', N'Gối chống đau vai và cổ cho mẹ bầu', 240000, 20, N'DM010', N'https://www.liena.com.vn/media/.renditions/liena_blog/2023-10/goi-cho-ba-bau-2023-1.jpg', 11)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuongTrongKho], [MaDanhMuc], [HinhAnh], [SoLuongDaBan]) VALUES (N'SP041', N'Sữa Friso', 160000, 70, N'DM001', N'https://cdn.tgdd.vn/Files/2021/12/07/1402764/sua-frisolac-co-tot-khong-nhung-li-do-me-nen-chon-sua-frisolac-cho-con-202112070409490146.jpg', 14)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuongTrongKho], [MaDanhMuc], [HinhAnh], [SoLuongDaBan]) VALUES (N'SP042', N'Tả Goon', 220000, 45, N'DM002', N'https://www.moby.com.vn/data/bt7/giup-me-phan-biet-bim-ta-goon-that-gia-chi-tiet-va-de-dang-1635498060.png', 12)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuongTrongKho], [MaDanhMuc], [HinhAnh], [SoLuongDaBan]) VALUES (N'SP043', N'Dầu tắm cho trẻ sơ sinh', 60000, 80, N'DM003', N'https://img.websosanh.vn/v10/users/review/images/9ldz5snbjvkx6/sj.jpg?compress=85', 20)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuongTrongKho], [MaDanhMuc], [HinhAnh], [SoLuongDaBan]) VALUES (N'SP044', N'Calcium cho mẹ bầu', 130000, 35, N'DM004', N'https://cdn.nhathuoclongchau.com.vn/unsafe/800x0/filters:quality(95)/https://cms-prod.s3-sgn09.fptcloud.com/2_43e23d8fd6.jpg', 22)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuongTrongKho], [MaDanhMuc], [HinhAnh], [SoLuongDaBan]) VALUES (N'SP045', N'Đèn ngủ cho em bé', 120000, 25, N'DM005', N'https://boandbi.vn/images/2020/08/19/0-0-den-ngu-cho-tre-so-sinh-9-c.jpg', 21)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuongTrongKho], [MaDanhMuc], [HinhAnh], [SoLuongDaBan]) VALUES (N'SP046', N'Bộ body bé trai', 85000, 50, N'DM006', N'https://img.zinbaby.com/uploads/unknown/29/2017/12/11/12/25115053_1967793460159702_1770239216_n.jpg', 5)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuongTrongKho], [MaDanhMuc], [HinhAnh], [SoLuongDaBan]) VALUES (N'SP047', N'Bình sữa Avent', 80000, 110, N'DM007', N'https://www.kidsplaza.vn/blog/wp-content/uploads/2018/07/binh-sua-avent.jpg', 15)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuongTrongKho], [MaDanhMuc], [HinhAnh], [SoLuongDaBan]) VALUES (N'SP048', N'Dầu gội Green People', 60000, 100, N'DM008', N'https://bizweb.dktcdn.net/100/141/195/products/20211221-152043.jpg?v=1655983786770', 12)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuongTrongKho], [MaDanhMuc], [HinhAnh], [SoLuongDaBan]) VALUES (N'SP049', N'Cháo hỗ trợ tiêu hóa cho em bé', 85000, 70, N'DM009', N'https://hongngochospital.vn/wp-content/uploads/2013/11/chao-tri-roi-loan-tieu-hoa.jpg', 13)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuongTrongKho], [MaDanhMuc], [HinhAnh], [SoLuongDaBan]) VALUES (N'SP050', N'Gối chống đau lưng cho mẹ bầu', 220000, 18, N'DM010', N'https://shopmevabe.com.vn/upload/sanpham/goi-ke-bung-canh-tien-ho-tro-giam-dau-lung-cho-me-bau-(4)-5357.jpg', 15)
/****** Object:  Table [dbo].[ChiTietDonHang]    Script Date: 12/28/2023 21:33:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietDonHang](
	[MaChiTietDonHang] [varchar](10) NOT NULL,
	[MaDonHang] [varchar](10) NULL,
	[MaSanPham] [varchar](10) NULL,
	[SoLuong] [int] NOT NULL,
	[Gia] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChiTietDonHang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ChiTietDonHang] ([MaChiTietDonHang], [MaDonHang], [MaSanPham], [SoLuong], [Gia]) VALUES (N'CTDH001', N'DH001', N'SP001', 2, 300000)
INSERT [dbo].[ChiTietDonHang] ([MaChiTietDonHang], [MaDonHang], [MaSanPham], [SoLuong], [Gia]) VALUES (N'CTDH002', N'DH002', N'SP002', 1, 200000)
INSERT [dbo].[ChiTietDonHang] ([MaChiTietDonHang], [MaDonHang], [MaSanPham], [SoLuong], [Gia]) VALUES (N'CTDH003', N'DH003', N'SP003', 4, 150000)
INSERT [dbo].[ChiTietDonHang] ([MaChiTietDonHang], [MaDonHang], [MaSanPham], [SoLuong], [Gia]) VALUES (N'CTDH004', N'DH004', N'SP004', 2, 240000)
INSERT [dbo].[ChiTietDonHang] ([MaChiTietDonHang], [MaDonHang], [MaSanPham], [SoLuong], [Gia]) VALUES (N'CTDH005', N'DH005', N'SP005', 1, 500000)
INSERT [dbo].[ChiTietDonHang] ([MaChiTietDonHang], [MaDonHang], [MaSanPham], [SoLuong], [Gia]) VALUES (N'CTDH006', N'DH006', N'SP006', 4, 400000)
INSERT [dbo].[ChiTietDonHang] ([MaChiTietDonHang], [MaDonHang], [MaSanPham], [SoLuong], [Gia]) VALUES (N'CTDH007', N'DH007', N'SP007', 2, 140000)
INSERT [dbo].[ChiTietDonHang] ([MaChiTietDonHang], [MaDonHang], [MaSanPham], [SoLuong], [Gia]) VALUES (N'CTDH008', N'DH008', N'SP008', 5, 225000)
INSERT [dbo].[ChiTietDonHang] ([MaChiTietDonHang], [MaDonHang], [MaSanPham], [SoLuong], [Gia]) VALUES (N'CTDH009', N'DH009', N'SP009', 3, 270000)
INSERT [dbo].[ChiTietDonHang] ([MaChiTietDonHang], [MaDonHang], [MaSanPham], [SoLuong], [Gia]) VALUES (N'CTDH010', N'DH010', N'SP010', 1, 180000)
/****** Object:  ForeignKey [FK__ChiTietDo__MaDon__15502E78]    Script Date: 12/28/2023 21:33:53 ******/
ALTER TABLE [dbo].[ChiTietDonHang]  WITH CHECK ADD FOREIGN KEY([MaDonHang])
REFERENCES [dbo].[DonHang] ([MaDonHang])
GO
/****** Object:  ForeignKey [FK__ChiTietDo__MaSan__164452B1]    Script Date: 12/28/2023 21:33:53 ******/
ALTER TABLE [dbo].[ChiTietDonHang]  WITH CHECK ADD FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[SanPham] ([MaSanPham])
GO
/****** Object:  ForeignKey [FK__DonHang__MaKhach__108B795B]    Script Date: 12/28/2023 21:33:53 ******/
ALTER TABLE [dbo].[DonHang]  WITH CHECK ADD FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
/****** Object:  ForeignKey [FK__SanPham__MaDanhM__0519C6AF]    Script Date: 12/28/2023 21:33:53 ******/
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD FOREIGN KEY([MaDanhMuc])
REFERENCES [dbo].[DanhMucSanPham] ([MaDanhMuc])
GO
/****** Object:  ForeignKey [FK__TaiKhoan__MaKhac__6C190EBB]    Script Date: 12/28/2023 21:33:53 ******/
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
/****** Object:  ForeignKey [FK__TaiKhoan__MaNhan__6B24EA82]    Script Date: 12/28/2023 21:33:53 ******/
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
