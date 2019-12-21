using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyThuVien.Models
{
    public class yeuCauThemSach
    {
        [Key]
        [Required]
        public int IDYeuCau { get; set; }

        [Required(ErrorMessage = "*Chưa nhập tên sách")]
        [Display(Name = "Tên sách")]
        public string TenSach { get; set; }

        [Display(Name = "Tác giả")]
        public string TacGia { get; set; }
    }
}
