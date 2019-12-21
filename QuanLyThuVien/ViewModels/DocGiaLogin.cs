using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyThuVien.ViewModels
{
    public class DocGiaLogin
    {
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

        [Display(Name = "Loại đọc giả")]
        public int LoaiDocGia { get; set; }
    }
}
