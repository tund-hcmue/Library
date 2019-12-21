using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyThuVien.Models
{
    public class LoaiSach
    {
        [Key]
        [Display(Name = "Mã loại sách")]
        public int IDLoai { get; set; }

        [Required(ErrorMessage = "*Không được để trống")]
       /* [Remote("CheckTenLoaiSach", "LoaiSach", AdditionalFields = "TenLoai",ErrorMessage ="*Loại sách này đã tồn tại")]*/
        [Display(Name = "Tên loại sách")]
        public string TenLoai { get; set; }

        [Display(Name ="Mô tả Loại sách")]
        public string MoTa{ get; set; }

    }
}
