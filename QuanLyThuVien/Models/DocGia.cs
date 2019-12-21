using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyThuVien.Models
{
    public class DocGia
    {
        [Key]
        [Required(ErrorMessage = "*Mã độc giả không để trống")]
        [Display(Name = "Mã độc giả")]
        public int IDDocGia { get; set; }
        
        [Required(ErrorMessage = "*Tài khoản không để trống")]
        [Display(Name = "Tài khoản")]
        public string TaiKhoan { get; set; }

        [Required(ErrorMessage = "*Mật khẩu không để trống")]
        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu")]
        public string MatKhau { get; set; }

        [Required(ErrorMessage ="*Họ tên không được để trống")]
        [Display(Name ="Họ tên")]
        public string HoTen { get; set; }

        [DataType(DataType.Date)]
        [Display(Name ="Ngày sinh")]
        public DateTime NgaySinh { get; set; }

        //[Range(0,2, ErrorMessage ="*Loại độc giả không chính xác")] //0:giảng viên----1:học sinh,sinh viên----2:khác
        [Display(Name ="Loại đọc giả")]
        public int LoaiDocGia { get; set; }

        [Display(Name ="Địa chỉ")]
        public string DiaChi { get; set; }
    }
}
