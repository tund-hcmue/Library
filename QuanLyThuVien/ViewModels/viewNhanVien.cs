using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyThuVien.ViewModels
{
    public class viewNhanVien
    {
        [Required(ErrorMessage = "*Mã nhân viên không để trống")]
        [Display(Name = "Mã nhân viên")]
        public int IDNhanVien { get; set; }

        [Required(ErrorMessage = "*Tài khoản không để trống")]
        [Display(Name = "Tài khoản")]
        public string TaiKhoan { get; set; }

        [Required(ErrorMessage = "*Mật khẩu không để trống")]
        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu")]
        public string MatKhau { get; set; }

        [Required(ErrorMessage = "*Họ tên không được để trống")]
        [Display(Name = "Họ tên")]
        public string HoTen { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Ngày sinh")]
        public DateTime NgaySinh { get; set; }

        [Range(0, 2, ErrorMessage = "*Loại nhân viên không chính xác")] //0: quản lý---- 1:bán hàng
        [Display(Name = "Loại nhân viên")]
        public int LoaiNhanVien { get; set; }

        [Display(Name = "Địa chỉ")]
        public string DiaChi { get; set; }

        [Required(ErrorMessage = "*Chưa chọn chi nhánh")]
        [Display(Name = "Chi nhánh")]
        public string TenChiNhanh { get; set; }
    }
}
