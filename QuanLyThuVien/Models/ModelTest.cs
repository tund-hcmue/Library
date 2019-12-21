using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyThuVien.Models
{
    public class ModelTest
    {
        [Key]
        [MaxLength(6, ErrorMessage = "*Không quá 6 kí tự")]
        [Required(ErrorMessage = "*Không để trống")]
        [Display(Name = "Số thứ tự")]
        public int ID { get; set; }

        [MaxLength(6, ErrorMessage = "*Không quá 6 kí tự")]
        [Required(ErrorMessage = "*Không để trống")]
        [Display(Name = "Sách")]
        public int IDSach { get; set; }

        [MaxLength(6, ErrorMessage = "*Không quá 6 kí tự")]
        [Required(ErrorMessage = "*Không để trống")]
        [Display(Name = "Chi Nhánh")]
        public int IDChiNhanh { get; set; }

        [Display(Name = "Tổng số lượng sách")]
        public int TongSoLuong { get; set; }

        [Display(Name = "Số sách còn lại")]
        public int SoSachCon { get; set; }
    }
}
