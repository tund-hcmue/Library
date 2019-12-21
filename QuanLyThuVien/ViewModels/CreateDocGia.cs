using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyThuVien.ViewModels
{
    public class CreateDocGia
    {
        [Remote("CheckTaiKhoan", "DocGia", AdditionalFields = "TaiKhoan",ErrorMessage ="*Tài khoản này đã tồn tại")]
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

        [MaxLength(2,ErrorMessage ="*Loại tài khoản không chính xác")]
        [MinLength(0,ErrorMessage ="*Loại tài khoản không chính xác")]
        [Display(Name = "Loại đọc giả")]
        public int LoaiDocGia { get; set; }

        [Display(Name = "Địa chỉ")]
        public string DiaChi { get; set; }
    }
}
