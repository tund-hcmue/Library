using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuanLyThuVien.Models;
using QuanLyThuVien.ViewModels;

namespace QuanLyThuVien.Controllers
{
    public class ChiNhanhController : Controller
    {
        private MyDBContext context;
        public ChiNhanhController()
        {
            context = new MyDBContext();
        }
        public IActionResult Index()
        {
            //phân quyền
            if (HttpContext.Session.GetString("TaiKhoanNv") == null) return RedirectToAction("Login", "NhanVien");
            //
            if (HttpContext.Session.GetInt32("LoaiTaiKhoanNv") == 1)
            {
                IEnumerable<object> chiNhanh = null;
                //this.ViewBag.Result = chiNhanh;
                return View(chiNhanh);
            }

            else
            {
                var chiNhanh = context.ChiNhanhs.ToList();
                //this.ViewBag.Result = chiNhanh;
                return View(chiNhanh);
            }

        }
        public IActionResult Create()
        {
            //phân quyền
            if (HttpContext.Session.GetString("TaiKhoanNv") == null) return RedirectToAction("Login", "NhanVien");
            //
            return View();
        }
        [HttpPost]
        public IActionResult Create(ChiNhanh Model)
        {
            //phân quyền
            if (HttpContext.Session.GetString("TaiKhoanNv") == null) return RedirectToAction("Login", "NhanVien");
            //
            if (!ModelState.IsValid) return BadRequest(ModelState);
            context.ChiNhanhs.Add(Model);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            //phân quyền
            if (HttpContext.Session.GetString("TaiKhoanNv") == null) return RedirectToAction("Login", "NhanVien");
            //
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var chiNhanh = context.ChiNhanhs.SingleOrDefault(m=>m.IDChiNhanh==id);
            if (chiNhanh == null) return NotFound();
            return View(chiNhanh);
        }
        [HttpPost]
        public IActionResult Edit(ChiNhanh Model)
        {
            //phân quyền
            if (HttpContext.Session.GetString("TaiKhoanNv") == null) return RedirectToAction("Login", "NhanVien");
            //
            if (!ModelState.IsValid) return BadRequest(ModelState);
            context.ChiNhanhs.Update(Model);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            //phân quyền
            if (HttpContext.Session.GetString("TaiKhoanNv") == null) return RedirectToAction("Login", "NhanVien");
            //
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var chiNhanh = context.ChiNhanhs.SingleOrDefault(m => m.IDChiNhanh == id);
            if (chiNhanh == null) return NotFound();
            return View(chiNhanh);
        }
        public IActionResult Delete(int id)
        {
            //phân quyền
            if (HttpContext.Session.GetString("TaiKhoanNv") == null) return RedirectToAction("Login", "NhanVien");
            //
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var chiNhanh = context.ChiNhanhs.SingleOrDefault(m => m.IDChiNhanh==id);
            if (chiNhanh == null) return NotFound();
            context.ChiNhanhs.Remove(chiNhanh);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        ////////////////////////////////////////
        public IActionResult themSachChiNhanh()
        {
            if (HttpContext.Session.GetInt32("IDChiNhanh") == null) return RedirectToAction("Login", "NhanVien");      
            return RedirectToAction("Index", "Sach");
        }
        public IActionResult SachTrongChiNhanh()
        {
            int? id = HttpContext.Session.GetInt32("IDChiNhanh");
            IEnumerable<viewSach> sach = from cn in context.ChiNhanhs
                                         join scn in context.SachChiNhanhs
                                         on cn.IDChiNhanh equals scn.IDChiNhanh
                                         join s in context.Saches
                                         on scn.IDSach equals s.IDSach
                                         join l in context.LoaiSaches
                                         on s.IDLoai equals l.IDLoai
                                         where scn.IDChiNhanh == id
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
                                             XepHangTb = s.XepHangTb,
                                             TongSoSach = scn.TongSoLuong,
                                             SoSachCon = scn.SoSachCon
                                         };
            List<viewSach> listSach = new List<viewSach>(sach);
            ViewBag.TenChiNhanh = context.ChiNhanhs.SingleOrDefault(m => m.IDChiNhanh == HttpContext.Session.GetInt32("IDChiNhanh")).TenChiNhanh;
            return View(listSach);
        }
        public IActionResult themSach(int id)
        {
            //phân quyền
            if (HttpContext.Session.GetString("TaiKhoanNv") == null) return RedirectToAction("Login", "NhanVien");
            //
            var sach = context.Saches.SingleOrDefault(m => m.IDSach == id);
            if (sach == null) return NotFound();
            ViewBag.TenSach = sach.TenSach;
            ViewBag.IDSach = id;

            int? idC = HttpContext.Session.GetInt32("IDChiNhanh");
            if (idC == null) RedirectToAction("Login", "NhanVien");
            ViewBag.TenChiNhanh = context.ChiNhanhs.SingleOrDefault(m => m.IDChiNhanh == idC).TenChiNhanh;
            ViewBag.IDChiNhanh = idC;

            /*var sachChiNhanh = new SachChiNhanh()
            {
                IDChiNhanh = chiNhanh.IDChiNhanh,
                IDSach = id
            };*/

            return View();
        }
        [HttpPost]
        public IActionResult themSach(SachChiNhanh Model)
        {
            //phân quyền
            if (HttpContext.Session.GetString("TaiKhoanNv") == null) return RedirectToAction("Login", "NhanVien");
            //
            if (!ModelState.IsValid) return BadRequest(ModelState);
            SachChiNhanh sachChiNhanh = (from scn in context.SachChiNhanhs
                                        where scn.IDChiNhanh == Model.IDChiNhanh && scn.IDSach == Model.IDSach
                                        select new SachChiNhanh
                                        {
                                            IDSachChiNhanh = scn.IDSachChiNhanh,
                                            IDSach = scn.IDSach,
                                            IDChiNhanh = scn.IDChiNhanh,
                                            TongSoLuong = scn.TongSoLuong,
                                            SoSachCon = scn.SoSachCon
                                        }).SingleOrDefault();
            if (sachChiNhanh != null)
            {
                sachChiNhanh.TongSoLuong += Model.TongSoLuong;
                sachChiNhanh.SoSachCon += Model.TongSoLuong;
                context.SachChiNhanhs.Update(sachChiNhanh);
                context.SaveChanges();
                return RedirectToAction("SachTrongChiNhanh");
            }
            else
            {
                Model.SoSachCon = Model.TongSoLuong;
                context.SachChiNhanhs.Add(Model);
                context.SaveChanges();
            }
            //Model.ID = Int32.Parse(null);
            return RedirectToAction("SachTrongChiNhanh");
        }
    }
}