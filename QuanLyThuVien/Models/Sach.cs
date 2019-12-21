using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyThuVien.Models
{
    public class Sach
    {
        [Key]
        [Required(ErrorMessage ="*Chưa nhập mã sách")]
        [Display(Name ="Mã sách")]
        public int IDSach { get; set; }

        [Display(Name ="Loại sách")]
        public int IDLoai { get; set; }
        [ForeignKey("IDLoai")]
        public LoaiSach LoaiSach { get; set; }

        [Required(ErrorMessage ="*Chưa nhập tên sách")]
        [Display(Name ="Tên sách")]
        public string TenSach { get; set; }

        [Display(Name ="Hình ảnh")]
        public string HinhAnh { get; set; }

        [Display(Name ="Tác giả")]
        public string TacGia { get; set; }

        [Display(Name ="Nhà xuất bản")]
        public string NhaXuatBan { get; set; }

        [Display(Name ="Năm xuất bản")]
        public int NamXuatBan { get; set; }

        [Display(Name ="Số trang")]
        public int SoTrang { get; set; }

        [Display(Name ="Mô tả sách")]
        public string MoTa { get; set; }

        [DataType(DataType.Date)]
        [Display(Name ="Ngày nhập")]
        public DateTime NgayNhap { get; set; }

        [Display(Name ="Giá mua sách")]
        public int TienMua { get; set; }

        [Display(Name ="Giá mượn sách")]
        public int TienMuon { get; set; }

        [Display(Name ="Xếp hạng trung bình")]
        public float XepHangTb { get; set; }

        [Display(Name="Đánh giá sách")]
        public int DanhGia { get; set; }

        [Display(Name ="Số người đánh giá")]
        public int SoDanhGia { get; set; }
    }
}
