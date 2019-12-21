using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyThuVien.Models
{
    public class SachChiNhanh
    {
        [Key]
        [Required(ErrorMessage ="*Không để trống")]
        [Display(Name ="Số thứ tự")]
        public int IDSachChiNhanh{ get; set; }

        [Required(ErrorMessage ="*Không để trống")]
        [Display(Name ="Sách")]
        public int IDSach { get; set; }
        [ForeignKey("IDSach")]
        public Sach Sach { get; set; }
   
        [Required(ErrorMessage ="*Không để trống")]
        [Display(Name ="Chi Nhánh")]
        public int IDChiNhanh { get; set; }
        [ForeignKey("IDChiNhanh")]
        public ChiNhanh ChiNhanh { get; set; }


        [Display(Name = "Tổng số lượng sách")]
        public int TongSoLuong { get; set; }

        [Display(Name = "Số sách còn lại")]
        public int SoSachCon { get; set; }
    }
}
