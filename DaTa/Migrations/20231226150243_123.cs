using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DaTa.Migrations
{
    public partial class _123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChatLieu",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatLieu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GioHang",
                columns: table => new
                {
                    IDKhachHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHang", x => x.IDKhachHang);
                });

            migrationBuilder.CreateTable(
                name: "KhuyenMai",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    GiaTri = table.Column<int>(type: "int", nullable: false),
                    NgayApDung = table.Column<DateTime>(type: "datetime", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuyenMai", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KichCo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KichCo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoaiSP",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiSP", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "NSX",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NSX", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhuongThucThanhToan",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhuongThucThanhToan", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ThuongHieu",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThuongHieu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VaiTro",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaiTro", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Voucher",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    SoTienCan = table.Column<int>(type: "int", nullable: false),
                    GiaTri = table.Column<int>(type: "int", nullable: false),
                    NgayApDung = table.Column<DateTime>(type: "datetime", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voucher", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GioiTinh = table.Column<int>(type: "int", nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiemTich = table.Column<int>(type: "int", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.ID);
                    table.ForeignKey(
                        name: "FK_KhachHang_GioHang_ID",
                        column: x => x.ID,
                        principalTable: "GioHang",
                        principalColumn: "IDKhachHang",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietSanPham",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    GiaBan = table.Column<int>(type: "int", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    IDKhuyenMai = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDKichCo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDChatLieu = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDNSX = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDThuongHieu = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDLoaiSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietSanPham", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ChiTietSanPham_ChatLieu_IDChatLieu",
                        column: x => x.IDChatLieu,
                        principalTable: "ChatLieu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietSanPham_KhuyenMai_IDKhuyenMai",
                        column: x => x.IDKhuyenMai,
                        principalTable: "KhuyenMai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietSanPham_KichCo_IDKichCo",
                        column: x => x.IDKichCo,
                        principalTable: "KichCo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietSanPham_LoaiSP_IDLoaiSP",
                        column: x => x.IDLoaiSP,
                        principalTable: "LoaiSP",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietSanPham_NSX_IDNSX",
                        column: x => x.IDNSX,
                        principalTable: "NSX",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietSanPham_ThuongHieu_IDThuongHieu",
                        column: x => x.IDThuongHieu,
                        principalTable: "ThuongHieu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(500)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    PassWord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: true),
                    IDVaiTro = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.ID);
                    table.ForeignKey(
                        name: "FK_NhanVien_VaiTro_IDVaiTro",
                        column: x => x.IDVaiTro,
                        principalTable: "VaiTro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Anh",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AnhSP = table.Column<string>(type: "varchar(200)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    IDSanPhamCT = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anh", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Anh_ChiTietSanPham_IDSanPhamCT",
                        column: x => x.IDSanPhamCT,
                        principalTable: "ChiTietSanPham",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietGioHang",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    IDNguoiDung = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDSanPhamCT = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietGioHang", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ChiTietGioHang_ChiTietSanPham_IDSanPhamCT",
                        column: x => x.IDSanPhamCT,
                        principalTable: "ChiTietSanPham",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietGioHang_GioHang_IDNguoiDung",
                        column: x => x.IDNguoiDung,
                        principalTable: "GioHang",
                        principalColumn: "IDKhachHang",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime", nullable: false),
                    NgayThanhToan = table.Column<DateTime>(type: "datetime", nullable: true),
                    TenNguoiNhan = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    SDT = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    TienShip = table.Column<int>(type: "int", nullable: false),
                    PhuongThucThanhToan = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    IDNhanVien = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IDKhacHang = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IDVoucher = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ThueVAT = table.Column<int>(type: "int", nullable: true),
                    TongTien = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    LoaiHD = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HoaDon_KhachHang_IDKhacHang",
                        column: x => x.IDKhacHang,
                        principalTable: "KhachHang",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_HoaDon_NhanVien_IDNhanVien",
                        column: x => x.IDNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_HoaDon_Voucher_IDVoucher",
                        column: x => x.IDVoucher,
                        principalTable: "Voucher",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ChiTietHoaDon",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DonGia = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    IDSanPHamCT = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietHoaDon", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDon_ChiTietSanPham_IDSanPHamCT",
                        column: x => x.IDSanPHamCT,
                        principalTable: "ChiTietSanPham",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDon_HoaDon_IDHoaDon",
                        column: x => x.IDHoaDon,
                        principalTable: "HoaDon",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietPTTT",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoTien = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    IDPTTT = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietPTTT", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ChiTietPTTT_HoaDon_IDHoaDon",
                        column: x => x.IDHoaDon,
                        principalTable: "HoaDon",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietPTTT_PhuongThucThanhToan_IDPTTT",
                        column: x => x.IDPTTT,
                        principalTable: "PhuongThucThanhToan",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Anh_IDSanPhamCT",
                table: "Anh",
                column: "IDSanPhamCT");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietGioHang_IDNguoiDung",
                table: "ChiTietGioHang",
                column: "IDNguoiDung");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietGioHang_IDSanPhamCT",
                table: "ChiTietGioHang",
                column: "IDSanPhamCT");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDon_IDHoaDon",
                table: "ChiTietHoaDon",
                column: "IDHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDon_IDSanPHamCT",
                table: "ChiTietHoaDon",
                column: "IDSanPHamCT");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPTTT_IDHoaDon",
                table: "ChiTietPTTT",
                column: "IDHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPTTT_IDPTTT",
                table: "ChiTietPTTT",
                column: "IDPTTT");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSanPham_IDChatLieu",
                table: "ChiTietSanPham",
                column: "IDChatLieu");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSanPham_IDKhuyenMai",
                table: "ChiTietSanPham",
                column: "IDKhuyenMai");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSanPham_IDKichCo",
                table: "ChiTietSanPham",
                column: "IDKichCo");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSanPham_IDLoaiSP",
                table: "ChiTietSanPham",
                column: "IDLoaiSP");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSanPham_IDNSX",
                table: "ChiTietSanPham",
                column: "IDNSX");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSanPham_IDThuongHieu",
                table: "ChiTietSanPham",
                column: "IDThuongHieu");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IDKhacHang",
                table: "HoaDon",
                column: "IDKhacHang");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IDNhanVien",
                table: "HoaDon",
                column: "IDNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IDVoucher",
                table: "HoaDon",
                column: "IDVoucher");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_IDVaiTro",
                table: "NhanVien",
                column: "IDVaiTro");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Anh");

            migrationBuilder.DropTable(
                name: "ChiTietGioHang");

            migrationBuilder.DropTable(
                name: "ChiTietHoaDon");

            migrationBuilder.DropTable(
                name: "ChiTietPTTT");

            migrationBuilder.DropTable(
                name: "ChiTietSanPham");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "PhuongThucThanhToan");

            migrationBuilder.DropTable(
                name: "ChatLieu");

            migrationBuilder.DropTable(
                name: "KhuyenMai");

            migrationBuilder.DropTable(
                name: "KichCo");

            migrationBuilder.DropTable(
                name: "LoaiSP");

            migrationBuilder.DropTable(
                name: "NSX");

            migrationBuilder.DropTable(
                name: "ThuongHieu");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "Voucher");

            migrationBuilder.DropTable(
                name: "GioHang");

            migrationBuilder.DropTable(
                name: "VaiTro");
        }
    }
}
