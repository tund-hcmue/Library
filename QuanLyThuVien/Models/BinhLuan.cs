using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyThuVien.Models
{
    public class BinhLuan
    {
        [Key]
        [Required(ErrorMessage = "*Mã bình luận không để trống")]
        [Display(Name = "Mã bình luận")]
        public int IDBinhLuan { get; set; }
        
        [Required(ErrorMessage = "*Mã độc giả không để trống")]
        [Display(Name = "Mã độc giả")]
        public int IDDocGia { get; set; }

        [Required(ErrorMessage ="*Tên độc giả không được để trống")]
        [Display(Name ="Tên dộc giả")]
        public string TenDocGia { get; set; }
        
        [Display(Name ="Sách")]
        public int IDSach { get; set; }
        [ForeignKey("IDSach")]
        public Sach Sach { get; set; }

        [Display(Name ="Thời gian bình luận")]
        public DateTime ThoiGian { get; set; }

        [Display(Name ="Nội dung bình luận")]
        public string NoiDung { get; set; }

    }
}
