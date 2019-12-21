using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyThuVien.ViewModels
{
    public class viewMuonSach
    {
        [Required(ErrorMessage = "*Mã phiếu không để trống")]
        [Display(Name = "Mã phiếu mượn sách")]
        public int IDPhieu { get; set; }

        [Required(ErrorMessage = "*Mã độc giả không để trống")]
        [Display(Name = "Tên độc giả")]
        public string TenDocGia { get; set; }

        [Required(ErrorMessage = "*Chưa nhập mã sách")]
        [Display(Name = "Tên sách")]
        public string TenSach { get; set; }


        [Required(ErrorMessage = "*Chưa nhập nhân viên")]
        [Display(Name = "Nhân viên lập phiếu")]
        public string TenNhanVien { get; set; }

        [Display(Name ="Loại đọc giả")]
        public int LoaiDocGia { get; set; }

        [Display(Name = "Tên chi nhánh")]
        public string TenChiNhanh { get; set; }

        [Required(ErrorMessage = "*Chưa nhập tình trạng sách")]
        [Display(Name = "Tình trạng sách")]
        public string TinhTrangSach { get; set; }

        [Display(Name = "Phí mượn sách")]
        public int PhiMuon { get; set; }

        [Display(Name = "Tiền cọc")]
        public int TienCoc { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Ngày mượn")]
        public DateTime NgayMuon { get; set; }

        [Display(Name = "Trạng thái mượn sách")]
        public int TrangThai { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Ngày trả")]
        public DateTime NgayTra { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Ngày trả thực tế")]
        public DateTime NgayTraThuc { get; set; }

        [Display(Name = "Tên loại sách")]
        public string TenLoai { get; set; }
      

    }
}
