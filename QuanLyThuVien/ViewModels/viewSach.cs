using Microsoft.AspNetCore.Mvc;
using QuanLyThuVien.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyThuVien.ViewModels
{
    public class viewSach
    {

        [Required(ErrorMessage = "*Chưa nhập mã sách")]
        [Display(Name = "Mã sách")]
        public int IDSach { get; set; }

        [Required(ErrorMessage = "*Không được để trống")]
        [Remote("CheckTenLoaiSach", "LoaiSach", AdditionalFields = "TenLoai", ErrorMessage = "*Loại sách này đã tồn tại")]
        [Display(Name = "Tên loại sách")]
        public string TenLoai { get; set; }

        [Required(ErrorMessage = "*Chưa nhập tên sách")]
        [Display(Name = "Tên sách")]
        public string TenSach { get; set; }

        [Display(Name = "Hình ảnh")]
        public string HinhAnh { get; set; }

        [Display(Name = "Tác giả")]
        public string TacGia { get; set; }

        [Display(Name = "Nhà xuất bản")]
        public string NhaXuatBan { get; set; }

        [Display(Name = "Năm xuất bản")]
        public int NamXuatBan { get; set; }

        [Display(Name = "Số trang")]
        public int SoTrang { get; set; }

        [Display(Name = "Mô tả sách")]
        public string MoTa { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Ngày nhập")]
        public DateTime NgayNhap { get; set; }

        [Display(Name = "Giá mua sách")]
        public int TienMua { get; set; }

        [Display(Name = "Giá mượn sách")]
        public int TienMuon { get; set; }

        [Display(Name = "Xếp hạng trung bình")]
        public float XepHangTb { get; set; }

        [Display(Name = "Đánh giá sách")]
        public int DanhGia { get; set; }

        [Display(Name = "Số người đánh giá")]
        public int SoDanhGia { get; set; }
        
        public List<BinhLuan> binhLuan { get; set; }

        [Display(Name ="Chi nhánh còn sách")]
        public int IDChiNhanh { get; set; }

        [Display(Name ="Tổng số sách")]
        public int TongSoSach { get; set; }

        [Display(Name ="Số sách còn trong kho")]
        public int SoSachCon { get; set; }
    }
}
