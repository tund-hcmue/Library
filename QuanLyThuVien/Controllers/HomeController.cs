using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuanLyThuVien.Models;
using QuanLyThuVien.ViewModels;
using PagedList;

namespace QuanLyThuVien.Controllers
{
    public class HomeController : Controller
    {
        private MyDBContext context;
        public HomeController()
        {
            context = new MyDBContext();
        }
        public IActionResult Index(int? id, int? page)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (page == null) page = 1;
            int pageSize = 6;
            int pageNumber = (page ?? 1);
            this.ViewBag.idloaisach = 0;
            if (id != null)
            {
                var sach = from s in context.Saches
                           join l in context.LoaiSaches
                           on s.IDLoai equals l.IDLoai
                           where s.IDLoai == id
                           select new viewSach
                           {
                               IDSach = s.IDSach,
                               TenSach = s.TenSach,
                               TenLoai = l.TenLoai,
                               TacGia = s.TacGia,
                               SoTrang = s.SoTrang,
                               TienMua = s.TienMua,
                               TienMuon = s.TienMuon,
                               HinhAnh = s.HinhAnh
                           };
                this.ViewBag.idloaisach = id;
                this.ViewBag.Result = sach.OrderBy(s => s.TenSach).ToPagedList(pageNumber, pageSize);
                var loaisach = context.LoaiSaches.ToList();
                this.ViewBag.loaisach = loaisach;
                return View("Index");
            }
            else
            {
                var sach = from s in context.Saches
                           join l in context.LoaiSaches
                           on s.IDLoai equals l.IDLoai
                           select new viewSach
                           {
                               IDSach = s.IDSach,
                               TenSach = s.TenSach,
                               TenLoai = l.TenLoai,
                               TacGia = s.TacGia,
                               SoTrang = s.SoTrang,
                               TienMua = s.TienMua,
                               TienMuon = s.TienMuon,
                               HinhAnh = s.HinhAnh
                           };
                this.ViewBag.idloaisach = 0;
                this.ViewBag.Result = sach.OrderBy(s => s.TenSach).ToPagedList(pageNumber, pageSize);
                var loaisach = context.LoaiSaches.ToList();
                this.ViewBag.loaisach = loaisach;
                return View();
            }
        }

        public IActionResult timSach(string key, int? id, int? page)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (page == null) page = 1;
            int pageSize = 1;
            int pageNumber = (page ?? 1);
            this.ViewBag.idloaisach = id;
            this.ViewBag.keys = key;
            if (id==null)
            {
                var sach = from s in context.Saches
                           join l in context.LoaiSaches
                           on s.IDLoai equals l.IDLoai
                           where s.TacGia.Contains(key) || s.TenSach.Contains(key)
                           select new viewSach
                           {
                               IDSach = s.IDSach,
                               TenSach = s.TenSach,
                               TenLoai = l.TenLoai,
                               TacGia = s.TacGia,
                               SoTrang = s.SoTrang,
                               TienMua = s.TienMua,
                               TienMuon = s.TienMuon,
                               HinhAnh = s.HinhAnh
                           };
                this.ViewBag.idloaisach = 0;
                this.ViewBag.Result = sach.OrderBy(s => s.TenSach).ToPagedList(pageNumber, pageSize);
                var loaisach = context.LoaiSaches.ToList();
                this.ViewBag.loaisach = loaisach;
                return View();
            }
            else
            {
                var sach = from s in context.Saches
                           join l in context.LoaiSaches
                           on s.IDLoai equals l.IDLoai
                           where l.IDLoai == id && (s.TacGia.Contains(key) || s.TenSach.Contains(key))
                           select new viewSach
                           {
                               IDSach = s.IDSach,
                               TenSach = s.TenSach,
                               TenLoai = l.TenLoai,
                               TacGia = s.TacGia,
                               SoTrang = s.SoTrang,
                               TienMua = s.TienMua,
                               TienMuon = s.TienMuon,
                               HinhAnh = s.HinhAnh
                           };
                this.ViewBag.idloaisach = id;
                this.ViewBag.Result = sach.OrderBy(s => s.TenSach).ToPagedList(pageNumber, pageSize);
                var loaisach = context.LoaiSaches.ToList();
                this.ViewBag.loaisach = loaisach;
                return View();
            }
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
