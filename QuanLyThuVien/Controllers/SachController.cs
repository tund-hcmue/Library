using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QuanLyThuVien.Models;
using QuanLyThuVien.ViewModels;
using System.Web;

namespace QuanLyThuVien.Controllers
{
    public class SachController : Controller
    {
        private MyDBContext context;
        public SachController()
        {
            context = new MyDBContext();
        }
        public IActionResult Index()
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var sach = from s in context.Saches
                       join l in context.LoaiSaches
                       on s.IDLoai equals l.IDLoai
                       select new viewSach
                       {
                           IDSach = s.IDSach,
                           TenSach =s.TenSach,
                           TenLoai=l.TenLoai,
                           TacGia = s.TacGia,
                           MoTa=s.MoTa,
                           NamXuatBan=s.NamXuatBan,
                           NgayNhap=s.NgayNhap,
                           NhaXuatBan=s.NhaXuatBan,
                           SoTrang = s.SoTrang,
                           SoDanhGia =s.SoDanhGia,
                           XepHangTb = s.XepHangTb,
                           DanhGia=s.DanhGia,
                           TienMua=s.TienMua,
                           TienMuon=s.TienMuon,
                           HinhAnh=s.HinhAnh,
                       };
            return View(sach);
        }
        public IActionResult Create()
        {
            //if (HttpContext.Session.GetInt32("IDChiNhanh") == null) return RedirectToAction("Login", "NhanVien"); 
            ViewBag.ListLoaiSach = getListLoaiSach();
            //ViewBag.TenChiNhanh = context.ChiNhanhs.SingleOrDefault(m => m.IDChiNhanh == HttpContext.Session.GetInt32("IDChiNhanh")).TenChiNhanh;
            return View();
        }
        [HttpPost]
        public IActionResult Create(Sach Model, IFormFile fileUpload)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var yeuCau = context.yeuCauThemSaches.SingleOrDefault(m => m.TenSach == Model.TenSach);
            if (yeuCau != null)
            {
                context.yeuCauThemSaches.Remove(yeuCau);
                context.SaveChanges();
            }
            if (fileUpload != null)
            {
                //Lưu tên file
                var fileName = Path.GetFileName(fileUpload.FileName);
                //Lưu đường dẫn của file
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "HinhAnh", fileUpload.FileName);
                using (var file = new FileStream(path, FileMode.Create))
                {
                    fileUpload.CopyTo(file);
                }
                Model.HinhAnh = fileUpload.FileName;
            }

            context.Saches.Add(Model);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var sach = context.Saches.SingleOrDefault(m => m.IDSach == id);
            if (sach == null) return NotFound();
            ViewBag.ListLoaiSach = getListLoaiSach();
            return View(sach);
        }
        [HttpPost]
        public IActionResult Edit(Sach Model, IFormFile fileUpload)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            if (fileUpload != null)
            {
                //Lưu tên file
                var fileName = Path.GetFileName(fileUpload.FileName);
                //Lưu đường dẫn của file
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "HinhAnh", fileUpload.FileName);
                using (var file = new FileStream(path, FileMode.Create))
                {
                   fileUpload.CopyTo(file);
                }
                Model.HinhAnh = fileUpload.FileName;
            }
            context.Saches.Update(Model);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            List<BinhLuan> binhLuan = (from bl in context.BinhLuans
                                        where bl.IDSach == id
                                        select new BinhLuan
                                        {
                                            TenDocGia=bl.TenDocGia,
                                            NoiDung=bl.NoiDung,
                                            ThoiGian=bl.ThoiGian,
                                                 
                                        }).ToList();

            var sach = (from s in context.Saches
                       join l in context.LoaiSaches
                       on s.IDLoai equals l.IDLoai
                       where s.IDSach==id
                       select new viewSach
                       {
                           IDSach = s.IDSach,
                           TenSach = s.TenSach,
                           TenLoai = l.TenLoai,
                           TacGia = s.TacGia,
                           MoTa = s.MoTa,
                           NamXuatBan = s.NamXuatBan,
                           NgayNhap = s.NgayNhap,
                           NhaXuatBan = s.NhaXuatBan,
                           SoTrang = s.SoTrang,
                           SoDanhGia = s.SoDanhGia,
                           DanhGia=s.DanhGia,
                           XepHangTb = s.XepHangTb,
                           TienMua=s.TienMua,
                           TienMuon=s.TienMuon,  
                           HinhAnh=s.HinhAnh,
                           binhLuan=binhLuan
                       }).SingleOrDefault();
            if (sach == null) NotFound();
            ViewBag.Check = 1;
            if (HttpContext.Session.GetInt32("LoaiTaiKhoan") == 0)
            {
                if (soSachDangMuon((int)HttpContext.Session.GetInt32("IDDocGia")) < 5)
                {
                    ViewBag.Check = 1;
                }
                else ViewBag.Check = 0;
            }
            else if (HttpContext.Session.GetInt32("LoaiTaiKhoan") == 2)
            {
                if (soSachDangMuon((int)HttpContext.Session.GetInt32("IDDocGia")) < 3)
                {
                    ViewBag.Check = 1;
                }
                else ViewBag.Check = 0;
            }
            ViewBag.ListChiNhanh = getListChiNhanh(sach.IDSach);
            return View(sach);
        }
        public IActionResult DetailsPopup(int id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            List<BinhLuan> binhLuan = (from bl in context.BinhLuans
                                       where bl.IDSach == id
                                       select new BinhLuan
                                       {
                                           TenDocGia = bl.TenDocGia,
                                           NoiDung = bl.NoiDung,
                                           ThoiGian = bl.ThoiGian,

                                       }).ToList();

            var sach = (from s in context.Saches
                        join l in context.LoaiSaches
                        on s.IDLoai equals l.IDLoai
                        where s.IDSach == id
                        select new viewSach
                        {
                            IDSach = s.IDSach,
                            TenSach = s.TenSach,
                            TenLoai = l.TenLoai,
                            TacGia = s.TacGia,
                            MoTa = s.MoTa,
                            NamXuatBan = s.NamXuatBan,
                            NgayNhap = s.NgayNhap,
                            NhaXuatBan = s.NhaXuatBan,
                            SoTrang = s.SoTrang,
                            SoDanhGia = s.SoDanhGia,
                            DanhGia = s.DanhGia,
                            XepHangTb = s.XepHangTb,
                            TienMua = s.TienMua,
                            TienMuon = s.TienMuon,
                            HinhAnh = s.HinhAnh,
                            binhLuan = binhLuan
                        }).SingleOrDefault();
            if (sach == null) NotFound();
            ViewBag.Check = 1;
            if (HttpContext.Session.GetInt32("LoaiTaiKhoan") == 0)
            {
                if (soSachDangMuon((int)HttpContext.Session.GetInt32("IDDocGia")) < 5)
                {
                    ViewBag.Check = 1;
                }
                else ViewBag.Check = 0;
            }
            else if (HttpContext.Session.GetInt32("LoaiTaiKhoan") == 2)
            {
                if (soSachDangMuon((int)HttpContext.Session.GetInt32("IDDocGia")) < 3)
                {
                    ViewBag.Check = 1;
                }
                else ViewBag.Check = 0;
            }
            ViewBag.ListChiNhanh = getListChiNhanh(sach.IDSach);
            return View(sach);
        }
        public IActionResult Delete(int id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var sach = context.Saches.SingleOrDefault(m => m.IDSach == id);
            if (sach == null) return NotFound();
            context.Saches.Remove(sach);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Comment(int id)
        {
            if (HttpContext.Session.GetString("TaiKhoan") == null)
                return RedirectToAction("Login", "DocGia");
            string text = Request.Form["comment"];
            if(text=="") return RedirectToAction("Details", "sach", new { id = id });
            // code thêm bình luận vào table bảng ở dưới
            BinhLuan binhLuan = new BinhLuan()
            {
                IDDocGia = (int)HttpContext.Session.GetInt32("IDDocGia"),
                IDSach = id,
                TenDocGia = (string)HttpContext.Session.GetString("TaiKhoan"),
                NoiDung = text,
                ThoiGian = DateTime.Now
            };
            context.BinhLuans.Add(binhLuan);
            context.SaveChanges();
            return RedirectToAction("Details", "sach", new { id = id });
        }
        ///////////////////////////////////////////////////////////////////////////////////////////
        
        public SelectList getListLoaiSach()
        {
            List<LoaiSach> loaiSach = context.LoaiSaches.ToList();
            SelectList listLoaiSach = new SelectList(loaiSach, "IDLoai", "TenLoai");
            return listLoaiSach;
        }
        public SelectList getListChiNhanh(int idSach)
        {
            List<ChiNhanh> chiNhanh = (from cn in context.ChiNhanhs
                                         join scn in context.SachChiNhanhs
                                         on cn.IDChiNhanh equals scn.IDChiNhanh
                                         join s in context.Saches
                                         on scn.IDSach equals s.IDSach
                                         where scn.SoSachCon > 0 && scn.IDSach==idSach
                                         select new ChiNhanh
                                         {
                                             IDChiNhanh = cn.IDChiNhanh,
                                             TenChiNhanh = cn.TenChiNhanh + "(" + cn.DiaChi + ")"
                                         }).ToList();
            SelectList listChiNhanh = new SelectList(chiNhanh, "IDChiNhanh", "TenChiNhanh");
            return listChiNhanh;
        }
        public int soSachDangMuon(int id)
        {
            int count = (from ms in context.MuonSaches
                         where ms.IDDocGia == id && ms.TrangThai == 1 || ms.IDDocGia == id && ms.TrangThai == 0
                         select new viewMuonSach
                         {
                             IDPhieu = ms.IDPhieu
                         }).Count();
            return count;
        }
        public int soSachMuonTrongNam(int id)
        {
            int count = (from ms in context.MuonSaches
                         where ms.IDDocGia == id && ms.NgayMuon.Year == DateTime.Now.Year
                         select new viewMuonSach
                         {
                             IDPhieu = ms.IDPhieu
                         }).Count();
            return count;
        }
    }
}