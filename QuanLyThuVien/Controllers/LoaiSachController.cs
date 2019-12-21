using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuanLyThuVien.Models;

namespace QuanLyThuVien.Controllers
{
    public class LoaiSachController : Controller
    {

        private MyDBContext context;
        public LoaiSachController()
        {
            context = new MyDBContext();
        }
        public IActionResult Index()
        {
            var loaiSach = context.LoaiSaches.ToList();
            HttpContext.Session.SetString("loaisach" , "session");
            return View(loaiSach);
        }
        public IActionResult Edit(int id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var loaiSach = context.LoaiSaches.SingleOrDefault(c => c.IDLoai == id);
            if (loaiSach==null)
            {
                return NotFound();
            }
            return View(loaiSach);
        }
        [HttpPost]
        public IActionResult Edit(LoaiSach loaiSach)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            context.LoaiSaches.Update(loaiSach);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var loaiSach = context.LoaiSaches.SingleOrDefault(c => c.IDLoai == id);
            if (loaiSach == null) return NotFound();
            context.LoaiSaches.Remove(loaiSach);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Create()
        {
            return View();
        }
        /*public IActionResult CheckTenLoaiSach(string TenLoai)
        {
            var timLoaiSach = context.LoaiSaches.SingleOrDefault(c => c.TenLoai == TenLoai);
            if (timLoaiSach != null)
                return Json(data: "*Loại sách này đã tồn tại");
            return Json(data:true);
            
        }*/
        [HttpPost]
        public IActionResult Create(LoaiSach loaiSach)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            context.LoaiSaches.Add(loaiSach);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}