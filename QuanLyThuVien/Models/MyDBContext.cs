using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyThuVien.Models
{
    public class MyDBContext:DbContext
    {

        public DbSet<yeuCauThemSach> yeuCauThemSaches { get; set; }
        public DbSet<LoaiSach> LoaiSaches { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<DocGia> DocGias { get; set; }
        public DbSet<MuonSach> MuonSaches { get; set; }
        public DbSet<BinhLuan> BinhLuans { get; set; }
        public DbSet<Sach> Saches { get; set; }
        public DbSet<ChiNhanh> ChiNhanhs { get; set; }
        public DbSet<SachChiNhanh> SachChiNhanhs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=.;Database=DBQuanLyThuVien;Integrated Security=True;");
        }

        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options)
        {
        }
        public MyDBContext()
        {

        }
    }
}
