USE [Mix_App]
GO
/****** Object:  Table [dbo].[Tb_CauHoi]    Script Date: 6/30/2022 1:05:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tb_CauHoi](
	[MaCauHoi] [varchar](50) NOT NULL,
	[MaKyThi] [nvarchar](50) NULL,
	[MaMon] [nvarchar](50) NULL,
	[MaDeThi] [nvarchar](50) NULL,
	[CauHoi] [nvarchar](200) NULL,
	[DA1] [nvarchar](200) NULL,
	[DA2] [nvarchar](200) NULL,
	[DA3] [nvarchar](200) NULL,
	[DA4] [nvarchar](200) NULL,
 CONSTRAINT [PK_Tb_CauHoi] PRIMARY KEY CLUSTERED 
(
	[MaCauHoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tb_DeThi]    Script Date: 6/30/2022 1:05:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tb_DeThi](
	[MaDeThi] [nvarchar](50) NOT NULL,
	[MaKyThi] [nvarchar](50) NOT NULL,
	[MaMon] [nvarchar](50) NOT NULL,
	[ThoiGian] [int] NULL,
	[SoCau] [int] NULL,
	[Ghichu1] [nvarchar](200) NULL,
	[Ghichu2] [nvarchar](200) NULL,
 CONSTRAINT [PK_Tb_DeThi] PRIMARY KEY CLUSTERED 
(
	[MaDeThi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tb_KyThi]    Script Date: 6/30/2022 1:05:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tb_KyThi](
	[MaKyThi] [nvarchar](50) NOT NULL,
	[TenKyThi] [nvarchar](200) NULL,
	[GhiChu] [nvarchar](200) NULL,
 CONSTRAINT [PK_Tb_KyThi] PRIMARY KEY CLUSTERED 
(
	[MaKyThi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tb_MonThi]    Script Date: 6/30/2022 1:05:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tb_MonThi](
	[MaMon] [nvarchar](50) NOT NULL,
	[TenMon] [nvarchar](200) NULL,
 CONSTRAINT [PK_Tb_MonThi] PRIMARY KEY CLUSTERED 
(
	[MaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Tb_CauHoi] ([MaCauHoi], [MaKyThi], [MaMon], [MaDeThi], [CauHoi], [DA1], [DA2], [DA3], [DA4]) VALUES (N'C001', N'001', N'001', N'DT004', N'123', N'123123', N'123123123', N'12123123', N'123')
INSERT [dbo].[Tb_CauHoi] ([MaCauHoi], [MaKyThi], [MaMon], [MaDeThi], [CauHoi], [DA1], [DA2], [DA3], [DA4]) VALUES (N'C1', N'001', N'005', N'DT001', N'Tham dự Hội nghị Ianta (2-1945) có nguyên thủ của những quốc gia nào dưới đây?', N'Anh, Pháp, Mĩ.', N'Anh, Pháp, Đức.', N'Liên Xô, Mĩ, Anh.', N'Mĩ, Liên Xô, Trung Quốc.')
INSERT [dbo].[Tb_CauHoi] ([MaCauHoi], [MaKyThi], [MaMon], [MaDeThi], [CauHoi], [DA1], [DA2], [DA3], [DA4]) VALUES (N'C10', N'001', N'005', N'DT001', N'Tổ chức nào dưới đây là tiền thân của tổ chức Liên hợp quốc ?', N'Khối Đồng minh chống phát xít.', N'Liên minh vì tiến bộ.', N'Đệ nhị Quốc tế.', N'Hội Quốc liên.')
INSERT [dbo].[Tb_CauHoi] ([MaCauHoi], [MaKyThi], [MaMon], [MaDeThi], [CauHoi], [DA1], [DA2], [DA3], [DA4]) VALUES (N'C11', N'001', N'005', N'DT001', N'Hiện nay, tổ chức Liên hợp quốc có bao nhiêu nước thành viên?', N'190', N'191', N'192', N'193')
INSERT [dbo].[Tb_CauHoi] ([MaCauHoi], [MaKyThi], [MaMon], [MaDeThi], [CauHoi], [DA1], [DA2], [DA3], [DA4]) VALUES (N'C12', N'001', N'005', N'DT001', N'Hội đồng Bảo an Liên hợp quốc hiện nay có bao nhiêu nước thành viên?', N'5', N'7', N'10', N'15')
INSERT [dbo].[Tb_CauHoi] ([MaCauHoi], [MaKyThi], [MaMon], [MaDeThi], [CauHoi], [DA1], [DA2], [DA3], [DA4]) VALUES (N'C13', N'001', N'005', N'DT001', N'Theo quyết định của Hội nghị Ianta, nước nào sẽ chiếm đóng Nhật Bản sau Chiến tranh thế giới thứ hai?', N'Mĩ', N'Liên Xô', N'Anh', N'Trung Quốc')
INSERT [dbo].[Tb_CauHoi] ([MaCauHoi], [MaKyThi], [MaMon], [MaDeThi], [CauHoi], [DA1], [DA2], [DA3], [DA4]) VALUES (N'C14', N'001', N'005', N'DT001', N'“Duy trì hòa bình và an ninh thế giới” là mục đích hoạt động của tổ chức nào dưới đây?', N'Hiệp hội các quốc gia Đông Nam Á (ASEAN)', N'Hiệp ước Đông Nam Á (SEATO).', N'Liên minh châu Âu (EU).', N'Liên hợp quốc (UN).')
INSERT [dbo].[Tb_CauHoi] ([MaCauHoi], [MaKyThi], [MaMon], [MaDeThi], [CauHoi], [DA1], [DA2], [DA3], [DA4]) VALUES (N'C15', N'001', N'005', N'DT001', N'Cơ quan nào dưới đây không thuộc tổ chức Liên hợp quốc ?', N'Đại hội đồng.', N'Ban Thư kí.', N'Hồi đồng Kinh tế và Xã hội.', N'Hội đồng bộ trưởng.')
INSERT [dbo].[Tb_CauHoi] ([MaCauHoi], [MaKyThi], [MaMon], [MaDeThi], [CauHoi], [DA1], [DA2], [DA3], [DA4]) VALUES (N'C16', N'001', N'005', N'DT001', N'Nội dung nào dưới đây không phải là nguyên tắc hoạt động của tổ chức Liên hợp quốc?', N'Giải quyết các tranh chấp quốc tế bằng biện pháp hòa bình.', N'Chung sống hòa bình và sự nhất trí của năm cường quốc.', N'Không sử dụng vũ lực hoặc đe dọa vũ lực với nhau.', N'Không can thiệp vào công việc nội bộ của các nước.')
INSERT [dbo].[Tb_CauHoi] ([MaCauHoi], [MaKyThi], [MaMon], [MaDeThi], [CauHoi], [DA1], [DA2], [DA3], [DA4]) VALUES (N'C17', N'001', N'005', N'DT001', N'Nội dung nào dưới đây không phải là quyết định của Hội nghị Ianta (2 – 1945)?', N'Thành lập tổ chức Liên hợp quốc.', N'Nhanh chóng khắc phục hậu quả của chiến tranh.', N'hống nhất mục tiêu tiêu diệt tận gốc chủ nghĩa phát xít.', N'Thỏa thuận về việc đóng quân tại các nước nhằm giải giáp phát xít.')
INSERT [dbo].[Tb_CauHoi] ([MaCauHoi], [MaKyThi], [MaMon], [MaDeThi], [CauHoi], [DA1], [DA2], [DA3], [DA4]) VALUES (N'C18', N'001', N'005', N'DT001', N'Sự kiện nào dưới đây góp phần hình thành khuôn khổ trật tự thế giới mới sau Chiến tranh thế giới thứ hai?', N'Hội nghị Ianta (2 – 1945).', N'Nhật Bản đầu hàng Đồng minh.', N'Tổ chức Liên hợp quốc được thành lập.', N'Tuyên bố của Tổng thống Mĩ Truman (3 – 1947).')
INSERT [dbo].[Tb_CauHoi] ([MaCauHoi], [MaKyThi], [MaMon], [MaDeThi], [CauHoi], [DA1], [DA2], [DA3], [DA4]) VALUES (N'C19', N'001', N'005', N'DT001', N'Một trong những mục đích hoạt động của tổ chức Liên hợp quốc là', N'duy trì hòa bình và an ninh thế giới.', N'khắc phục hậu quả sau chiến tranh.', N'giúp đỡ các nước thành viên về kinh tế, văn hóa.', N'giải quyết các tranh chấp bằng biện pháp hòa bìn')
INSERT [dbo].[Tb_CauHoi] ([MaCauHoi], [MaKyThi], [MaMon], [MaDeThi], [CauHoi], [DA1], [DA2], [DA3], [DA4]) VALUES (N'C2', N'001', N'005', N'DT001', N'Hội nghị Ianta (Liên Xô) diễn ra trong khoảng thời gian nào?', N'Từ ngày 4 đến 11-2-1945.

', N'Từ ngày 2 đến 12-2-1945.', N'Từ ngày 2 đến 12-4-1945.', N'Từ ngày 4 đến 12-4-1945.')
INSERT [dbo].[Tb_CauHoi] ([MaCauHoi], [MaKyThi], [MaMon], [MaDeThi], [CauHoi], [DA1], [DA2], [DA3], [DA4]) VALUES (N'C20', N'001', N'005', N'DT001', N'Nội dung nào sau đây là nguyên tắc hoạt động của tổ chức Liên hợp quốc?', N'Bình đẳng chủ quyền giữa các quốc gia và quyền tự quyết của các dân tộc.', N'Không sử dụng vũ lực hoặc đe dọa bằng vũ lực đối với nhau.', N'Hợp tác có hiệu quả trên lĩnh vực kinh tế, văn hóa, giáo dục.', N'Thúc đẩy các mối quan hệ hữu nghị, hợp tác quốc tế.')
INSERT [dbo].[Tb_CauHoi] ([MaCauHoi], [MaKyThi], [MaMon], [MaDeThi], [CauHoi], [DA1], [DA2], [DA3], [DA4]) VALUES (N'C3', N'001', N'005', N'DT001', N'Hội nghị cấp cao của ba cường quốc Liên Xô, Mĩ, Anh diễn ra từ ngày 4 đến 11-2-1945 được tổ chức tại đâu?', N'Oasinhtơn (Mĩ).', N'Ianta (Liên Xô).', N'Pốtxđam (Đức).', N'Luân Đôn (Anh).')
INSERT [dbo].[Tb_CauHoi] ([MaCauHoi], [MaKyThi], [MaMon], [MaDeThi], [CauHoi], [DA1], [DA2], [DA3], [DA4]) VALUES (N'C4', N'001', N'005', N'DT001', N'Theo quyết định của Hội nghị Ianta (2-1945), quân đội nước nào sẽ vào chiếm đóng Nhật Bản và Nam Triều Tiên?', N'Mĩ', N'Anh', N'Pháp', N'Liên Xô')
INSERT [dbo].[Tb_CauHoi] ([MaCauHoi], [MaKyThi], [MaMon], [MaDeThi], [CauHoi], [DA1], [DA2], [DA3], [DA4]) VALUES (N'C5', N'001', N'005', N'DT001', N'Sự kiện nào dưới đây gắn liền với ngày 24-10-1945?', N'Bản Hiến chương Liên hợp quốc chính thức có hiệu lực.', N'Mĩ và Liên Xô phê chuẩn bản Hiến chương Liên hợp quốc.', N'Hội nghị Xan Phranxixcô (Mĩ) thông qua bản Hiến chương Liên hợp quốc.', N'Năm nước Ủy viên thường trực Hội đồng Bảo an thông qua bản Hiến chương.')
INSERT [dbo].[Tb_CauHoi] ([MaCauHoi], [MaKyThi], [MaMon], [MaDeThi], [CauHoi], [DA1], [DA2], [DA3], [DA4]) VALUES (N'C6', N'001', N'005', N'DT001', N'Tháng 9-1977, Việt Nam đã gia nhập vào tổ chức nào dưới đây?', N'Liên hợp quốc (UN).', N'Hội đồng tương trợ kinh tế (SEV).', N'Tổ chức thương mại thế giới (WTO).', N'Hiệp hội các quốc gia Đông Nam Á (ASEAN).')
INSERT [dbo].[Tb_CauHoi] ([MaCauHoi], [MaKyThi], [MaMon], [MaDeThi], [CauHoi], [DA1], [DA2], [DA3], [DA4]) VALUES (N'C7', N'001', N'005', N'DT001', N'Có bao nhiêu nước là thành viên sáng lập tổ chức Liên hợp quốc?', N'30', N'40', N'45', N'50')
INSERT [dbo].[Tb_CauHoi] ([MaCauHoi], [MaKyThi], [MaMon], [MaDeThi], [CauHoi], [DA1], [DA2], [DA3], [DA4]) VALUES (N'C8', N'001', N'005', N'DT001', N'Cơ quan nào của Liên hợp quốc có sự tham gia đầy đủ đại diện các nước thành viên và mỗi năm họp một lần?', N'Ban Thư kí.', N'Đại hội đồng.', N'Hội đồng Bảo an.', N'Hội đồng Quản thác.')
INSERT [dbo].[Tb_CauHoi] ([MaCauHoi], [MaKyThi], [MaMon], [MaDeThi], [CauHoi], [DA1], [DA2], [DA3], [DA4]) VALUES (N'C9', N'001', N'005', N'DT001', N'Hiến chương Liên hợp quốc được thông qua tại hội nghị nào dưới đây?', N'Hội nghị Ianta (Liên Xô)', N'Hội nghị Niu Oóc (Mĩ).', N'Hội nghị Pốtxđam (Đức).', N'Hội nghị Xan Phranxixcô (Mĩ).')
GO
INSERT [dbo].[Tb_DeThi] ([MaDeThi], [MaKyThi], [MaMon], [ThoiGian], [SoCau], [Ghichu1], [Ghichu2]) VALUES (N'DT001', N'001', N'001', 60, 25, N'Không sử dụng điện thoại', N'Không sử dụng điện thoại')
INSERT [dbo].[Tb_DeThi] ([MaDeThi], [MaKyThi], [MaMon], [ThoiGian], [SoCau], [Ghichu1], [Ghichu2]) VALUES (N'DT002', N'001', N'002', 60, 20, N'Không sử dụng điện thoại', N'Không sử dụng tài liệu')
INSERT [dbo].[Tb_DeThi] ([MaDeThi], [MaKyThi], [MaMon], [ThoiGian], [SoCau], [Ghichu1], [Ghichu2]) VALUES (N'DT003', N'001', N'003', 45, 10, N'Không sử dụng điện thoại', N'Không sử dụng tài liệu')
INSERT [dbo].[Tb_DeThi] ([MaDeThi], [MaKyThi], [MaMon], [ThoiGian], [SoCau], [Ghichu1], [Ghichu2]) VALUES (N'DT004', N'001', N'001', 45, 20, N'Không sử dụng điện thoại', N'Không sử dụng tài liệu')
GO
INSERT [dbo].[Tb_KyThi] ([MaKyThi], [TenKyThi], [GhiChu]) VALUES (N'001', N'Giữa kỳ I', NULL)
INSERT [dbo].[Tb_KyThi] ([MaKyThi], [TenKyThi], [GhiChu]) VALUES (N'002', N'Cuối kỳ I', NULL)
INSERT [dbo].[Tb_KyThi] ([MaKyThi], [TenKyThi], [GhiChu]) VALUES (N'003', N'Giữa kỳ II', NULL)
INSERT [dbo].[Tb_KyThi] ([MaKyThi], [TenKyThi], [GhiChu]) VALUES (N'004', N'Cuối kỳ II', N'123')
INSERT [dbo].[Tb_KyThi] ([MaKyThi], [TenKyThi], [GhiChu]) VALUES (N'005', N'1231', N'123')
INSERT [dbo].[Tb_KyThi] ([MaKyThi], [TenKyThi], [GhiChu]) VALUES (N'0056', N'Kiểm tra chất lượng đầu vào', N'Không dùng tài liệu')
INSERT [dbo].[Tb_KyThi] ([MaKyThi], [TenKyThi], [GhiChu]) VALUES (N'006', N'123123', N'123123')
INSERT [dbo].[Tb_KyThi] ([MaKyThi], [TenKyThi], [GhiChu]) VALUES (N'007', N'132132', N'465465')
INSERT [dbo].[Tb_KyThi] ([MaKyThi], [TenKyThi], [GhiChu]) VALUES (N'008M', N'Chất lượng', N'123123123')
INSERT [dbo].[Tb_KyThi] ([MaKyThi], [TenKyThi], [GhiChu]) VALUES (N'009', N'abc', N'959e45')
GO
INSERT [dbo].[Tb_MonThi] ([MaMon], [TenMon]) VALUES (N'001', N'Toán')
INSERT [dbo].[Tb_MonThi] ([MaMon], [TenMon]) VALUES (N'002', N'Văn')
INSERT [dbo].[Tb_MonThi] ([MaMon], [TenMon]) VALUES (N'003', N'Anh')
INSERT [dbo].[Tb_MonThi] ([MaMon], [TenMon]) VALUES (N'004', N'Sinh')
INSERT [dbo].[Tb_MonThi] ([MaMon], [TenMon]) VALUES (N'005', N'Sử')
INSERT [dbo].[Tb_MonThi] ([MaMon], [TenMon]) VALUES (N'006', N'Địa')
INSERT [dbo].[Tb_MonThi] ([MaMon], [TenMon]) VALUES (N'007', N'Lý')
INSERT [dbo].[Tb_MonThi] ([MaMon], [TenMon]) VALUES (N'008', N'Hoá')
INSERT [dbo].[Tb_MonThi] ([MaMon], [TenMon]) VALUES (N'009', N'Vẽ')
INSERT [dbo].[Tb_MonThi] ([MaMon], [TenMon]) VALUES (N'010', N'GDCD')
INSERT [dbo].[Tb_MonThi] ([MaMon], [TenMon]) VALUES (N'011', N'Hátttt')
GO
ALTER TABLE [dbo].[Tb_CauHoi]  WITH CHECK ADD  CONSTRAINT [FK_Tb_CauHoi_Tb_DeThi] FOREIGN KEY([MaDeThi])
REFERENCES [dbo].[Tb_DeThi] ([MaDeThi])
GO
ALTER TABLE [dbo].[Tb_CauHoi] CHECK CONSTRAINT [FK_Tb_CauHoi_Tb_DeThi]
GO
ALTER TABLE [dbo].[Tb_CauHoi]  WITH CHECK ADD  CONSTRAINT [FK_Tb_CauHoi_Tb_KyThi] FOREIGN KEY([MaKyThi])
REFERENCES [dbo].[Tb_KyThi] ([MaKyThi])
GO
ALTER TABLE [dbo].[Tb_CauHoi] CHECK CONSTRAINT [FK_Tb_CauHoi_Tb_KyThi]
GO
ALTER TABLE [dbo].[Tb_CauHoi]  WITH CHECK ADD  CONSTRAINT [FK_Tb_CauHoi_Tb_MonThi] FOREIGN KEY([MaMon])
REFERENCES [dbo].[Tb_MonThi] ([MaMon])
GO
ALTER TABLE [dbo].[Tb_CauHoi] CHECK CONSTRAINT [FK_Tb_CauHoi_Tb_MonThi]
GO
ALTER TABLE [dbo].[Tb_DeThi]  WITH CHECK ADD  CONSTRAINT [FK_Tb_DeThi_Tb_KyThi] FOREIGN KEY([MaKyThi])
REFERENCES [dbo].[Tb_KyThi] ([MaKyThi])
GO
ALTER TABLE [dbo].[Tb_DeThi] CHECK CONSTRAINT [FK_Tb_DeThi_Tb_KyThi]
GO
ALTER TABLE [dbo].[Tb_DeThi]  WITH CHECK ADD  CONSTRAINT [FK_Tb_DeThi_Tb_MonThi] FOREIGN KEY([MaMon])
REFERENCES [dbo].[Tb_MonThi] ([MaMon])
GO
ALTER TABLE [dbo].[Tb_DeThi] CHECK CONSTRAINT [FK_Tb_DeThi_Tb_MonThi]
GO
