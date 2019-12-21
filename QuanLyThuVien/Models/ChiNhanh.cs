using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyThuVien.Models
{
    public class ChiNhanh
    {
        [Key]
        [Required(ErrorMessage = "*Mã chi nhánh không để trống")]
        [Display(Name = "Mã chi nhánh")]
        public int IDChiNhanh { get; set; }

        [Required(ErrorMessage ="*Chưa nhập tên chi nhánh")]
        [Display(Name ="Tên chi nhánh")]
        public string TenChiNhanh { get; set; }

        [Required(ErrorMessage ="*Chưa nhập địa chỉ")]
        [Display(Name ="Địa chỉ")]
        public string DiaChi { get; set; }

        [DataType(DataType.Date)]
        [Display(Name ="Ngày Thành lập")]
        public DateTime NgayThanhLap { get; set; }

        [Display(Name ="Người quản lý")]
        public int IDQuanLy { get; set; }

        [Display(Name ="Nhân viên")]
        public int IDNhanVien { get; set; }
    }
}
