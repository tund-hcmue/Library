using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyThuVien.Migrations
{
    public partial class installmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChiNhanhs",
                columns: table => new
                {
                    IDChiNhanh = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TenChiNhanh = table.Column<string>(nullable: false),
                    DiaChi = table.Column<string>(nullable: false),
                    NgayThanhLap = table.Column<DateTime>(nullable: false),
                    IDQuanLy = table.Column<int>(nullable: false),
                    IDNhanVien = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiNhanhs", x => x.IDChiNhanh);
                });

            migrationBuilder.CreateTable(
                name: "DocGias",
                columns: table => new
                {
                    IDDocGia = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TaiKhoan = table.Column<string>(nullable: false),
                    MatKhau = table.Column<string>(nullable: false),
                    HoTen = table.Column<string>(nullable: false),
                    NgaySinh = table.Column<DateTime>(nullable: false),
                    LoaiDocGia = table.Column<int>(nullable: false),
                    DiaChi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocGias", x => x.IDDocGia);
                });

            migrationBuilder.CreateTable(
                name: "LoaiSaches",
                columns: table => new
                {
                    IDLoai = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TenLoai = table.Column<string>(nullable: false),
                    MoTa = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiSaches", x => x.IDLoai);
                });

            migrationBuilder.CreateTable(
                name: "yeuCauThemSaches",
                columns: table => new
                {
                    IDYeuCau = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TenSach = table.Column<string>(nullable: false),
                    TacGia = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_yeuCauThemSaches", x => x.IDYeuCau);
                });

            migrationBuilder.CreateTable(
                name: "NhanViens",
                columns: table => new
                {
                    IDNhanVien = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TaiKhoan = table.Column<string>(nullable: false),
                    MatKhau = table.Column<string>(nullable: false),
                    HoTen = table.Column<string>(nullable: false),
                    NgaySinh = table.Column<DateTime>(nullable: false),
                    LoaiNhanVien = table.Column<int>(nullable: false),
                    DiaChi = table.Column<string>(nullable: true),
                    IDChiNhanh = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanViens", x => x.IDNhanVien);
                    table.ForeignKey(
                        name: "FK_NhanViens_ChiNhanhs_IDChiNhanh",
                        column: x => x.IDChiNhanh,
                        principalTable: "ChiNhanhs",
                        principalColumn: "IDChiNhanh",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Saches",
                columns: table => new
                {
                    IDSach = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IDLoai = table.Column<int>(nullable: false),
                    TenSach = table.Column<string>(nullable: false),
                    HinhAnh = table.Column<string>(nullable: true),
                    TacGia = table.Column<string>(nullable: true),
                    NhaXuatBan = table.Column<string>(nullable: true),
                    NamXuatBan = table.Column<int>(nullable: false),
                    SoTrang = table.Column<int>(nullable: false),
                    MoTa = table.Column<string>(nullable: true),
                    NgayNhap = table.Column<DateTime>(nullable: false),
                    TienMua = table.Column<int>(nullable: false),
                    TienMuon = table.Column<int>(nullable: false),
                    XepHangTb = table.Column<float>(nullable: false),
                    DanhGia = table.Column<int>(nullable: false),
                    SoDanhGia = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saches", x => x.IDSach);
                    table.ForeignKey(
                        name: "FK_Saches_LoaiSaches_IDLoai",
                        column: x => x.IDLoai,
                        principalTable: "LoaiSaches",
                        principalColumn: "IDLoai",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BinhLuans",
                columns: table => new
                {
                    IDBinhLuan = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IDDocGia = table.Column<int>(nullable: false),
                    TenDocGia = table.Column<string>(nullable: false),
                    IDSach = table.Column<int>(nullable: false),
                    ThoiGian = table.Column<DateTime>(nullable: false),
                    NoiDung = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BinhLuans", x => x.IDBinhLuan);
                    table.ForeignKey(
                        name: "FK_BinhLuans_Saches_IDSach",
                        column: x => x.IDSach,
                        principalTable: "Saches",
                        principalColumn: "IDSach",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MuonSaches",
                columns: table => new
                {
                    IDPhieu = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IDDocGia = table.Column<int>(nullable: false),
                    IDSach = table.Column<int>(nullable: false),
                    IDNhanVien = table.Column<int>(nullable: false),
                    TenChiNhanh = table.Column<string>(nullable: true),
                    TinhTrangSach = table.Column<string>(nullable: false),
                    PhiMuon = table.Column<int>(nullable: false),
                    TienCoc = table.Column<int>(nullable: false),
                    NgayMuon = table.Column<DateTime>(nullable: false),
                    NgayTra = table.Column<DateTime>(nullable: false),
                    NgayTraThuc = table.Column<DateTime>(nullable: false),
                    TrangThai = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MuonSaches", x => x.IDPhieu);
                    table.ForeignKey(
                        name: "FK_MuonSaches_DocGias_IDDocGia",
                        column: x => x.IDDocGia,
                        principalTable: "DocGias",
                        principalColumn: "IDDocGia",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MuonSaches_NhanViens_IDNhanVien",
                        column: x => x.IDNhanVien,
                        principalTable: "NhanViens",
                        principalColumn: "IDNhanVien",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MuonSaches_Saches_IDSach",
                        column: x => x.IDSach,
                        principalTable: "Saches",
                        principalColumn: "IDSach",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SachChiNhanhs",
                columns: table => new
                {
                    IDSachChiNhanh = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IDSach = table.Column<int>(nullable: false),
                    IDChiNhanh = table.Column<int>(nullable: false),
                    TongSoLuong = table.Column<int>(nullable: false),
                    SoSachCon = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SachChiNhanhs", x => x.IDSachChiNhanh);
                    table.ForeignKey(
                        name: "FK_SachChiNhanhs_ChiNhanhs_IDChiNhanh",
                        column: x => x.IDChiNhanh,
                        principalTable: "ChiNhanhs",
                        principalColumn: "IDChiNhanh",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SachChiNhanhs_Saches_IDSach",
                        column: x => x.IDSach,
                        principalTable: "Saches",
                        principalColumn: "IDSach",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BinhLuans_IDSach",
                table: "BinhLuans",
                column: "IDSach");

            migrationBuilder.CreateIndex(
                name: "IX_MuonSaches_IDDocGia",
                table: "MuonSaches",
                column: "IDDocGia");

            migrationBuilder.CreateIndex(
                name: "IX_MuonSaches_IDNhanVien",
                table: "MuonSaches",
                column: "IDNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_MuonSaches_IDSach",
                table: "MuonSaches",
                column: "IDSach");

            migrationBuilder.CreateIndex(
                name: "IX_NhanViens_IDChiNhanh",
                table: "NhanViens",
                column: "IDChiNhanh");

            migrationBuilder.CreateIndex(
                name: "IX_SachChiNhanhs_IDChiNhanh",
                table: "SachChiNhanhs",
                column: "IDChiNhanh");

            migrationBuilder.CreateIndex(
                name: "IX_SachChiNhanhs_IDSach",
                table: "SachChiNhanhs",
                column: "IDSach");

            migrationBuilder.CreateIndex(
                name: "IX_Saches_IDLoai",
                table: "Saches",
                column: "IDLoai");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BinhLuans");

            migrationBuilder.DropTable(
                name: "MuonSaches");

            migrationBuilder.DropTable(
                name: "SachChiNhanhs");

            migrationBuilder.DropTable(
                name: "yeuCauThemSaches");

            migrationBuilder.DropTable(
                name: "DocGias");

            migrationBuilder.DropTable(
                name: "NhanViens");

            migrationBuilder.DropTable(
                name: "Saches");

            migrationBuilder.DropTable(
                name: "ChiNhanhs");

            migrationBuilder.DropTable(
                name: "LoaiSaches");
        }
    }
}
