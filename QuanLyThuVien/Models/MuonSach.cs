using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyThuVien.Models
{
    public class MuonSach
    {
        [Key]
        [Required(ErrorMessage = "*Mã phiếu không để trống")]
        [Display(Name = "Mã phiếu mượn sách")]
        public int IDPhieu { get; set; }

        [Required(ErrorMessage = "*Mã độc giả không để trống")]
        [Display(Name = "Mã độc giả")]
        public int IDDocGia { get; set; }
        [ForeignKey("IDDocGia")]
        public DocGia DocGia { get; set; }

        [Required(ErrorMessage = "*Chưa nhập mã sách")]
        [Display(Name = "Mã sách")]
        public int IDSach { get; set; }
        [ForeignKey("IDSach")]
        public Sach Sach { get; set; }

        [Display(Name = "Nhân viên lập phiếu")]
        public int IDNhanVien { get; set; }
        [ForeignKey("IDNhanVien")]
        public NhanVien NhanVien { get; set; }

        [Display(Name ="Tên chi nhánh")]
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

        [DataType(DataType.Date)]
        [Display(Name = "Ngày trả")]
        public DateTime NgayTra { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Ngày trả thực tế")]
        public DateTime NgayTraThuc { get; set; }

        [Display(Name = "Trạng thái mượn sách")]
        public int TrangThai { get; set; }
    }
}
