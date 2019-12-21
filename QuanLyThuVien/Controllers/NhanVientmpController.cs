using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QuanLyThuVien.Models;
using QuanLyThuVien.ViewModels;

namespace QuanLyThuVien.Controllers
{
    public class NhanVientmpController : Controller
    {
        private MyDBContext context;
        public NhanVientmpController()
        {
            context = new MyDBContext();
        }
        public IActionResult CheckTaiKhoan(string TaiKhoan)
        {
            var timNhanVien = context.NhanViens.SingleOrDefault(c => c.TaiKhoan == TaiKhoan);
            if (timNhanVien != null)
                return Json(data: "*Loại sách này đã tồn tại");
            return Json(data: true);

        }

        //////
        
        public IActionResult Index()
        {
            //phân quyền
            if (HttpContext.Session.GetInt32("IDNhanVien") == null) return RedirectToAction("Login", "NhanVien");
            //
            if (HttpContext.Session.GetInt32("LoaiTaiKhoanNv") == 1)
            {
                IEnumerable<object> nhanVien = null;
                this.ViewBag.Result = nhanVien;
                return View();
            }

            else
            {
                var nhanVien = GetViewNhanViens();
                this.ViewBag.Result = nhanVien;
                return View(nhanVien);
            }
        }
        public IActionResult Create()
        {
            //phân quyền
            if (HttpContext.Session.GetInt32("IDNhanVien") == null) return RedirectToAction("Login", "NhanVien");
            //
            ViewBag.ListChiNhanh = getListChiNhanh();
            return View();
        }
        [HttpPost]
        public IActionResult Create(NhanVien Model)
        {
            //phân quyền
            if (HttpContext.Session.GetInt32("IDNhanVien") == null) return RedirectToAction("Login", "NhanVien");
            //
            if (!ModelState.IsValid) return BadRequest(ModelState);
            context.NhanViens.Add(Model);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            //phân quyền
            if (HttpContext.Session.GetInt32("IDNhanVien") == null) return RedirectToAction("Login", "NhanVien");
            //
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var nhanVien = context.NhanViens.SingleOrDefault(m => m.IDNhanVien == id);
            if (nhanVien == null) return NotFound();
            ViewBag.ListChiNhanh = getListChiNhanh();
            return View(nhanVien);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhanVien = await context.NhanViens.FindAsync(id);
            if (nhanVien == null)
            {
                return NotFound();
            }
            ViewData["IDChiNhanh"] = new SelectList(context.ChiNhanhs, "IDChiNhanh", "DiaChi", nhanVien.IDChiNhanh);
            return View(nhanVien);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDNhanVien,TaiKhoan,MatKhau,HoTen,NgaySinh,LoaiNhanVien,DiaChi,IDChiNhanh")] NhanVien nhanVien)
        {
            if (id != nhanVien.IDNhanVien)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    context.Update(nhanVien);
                    await context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NhanVienExists(nhanVien.IDNhanVien))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["IDChiNhanh"] = new SelectList(context.ChiNhanhs, "IDChiNhanh", "DiaChi", nhanVien.IDChiNhanh);
            return View(nhanVien);
        }
        private bool NhanVienExists(int id)
        {
            return context.NhanViens.Any(e => e.IDNhanVien == id);
        }
        /*[HttpPost]
        public IActionResult Edit(NhanVien model)
        {
            //phân quyền
            if (HttpContext.Session.GetInt32("IDNhanVien") == null) return RedirectToAction("Login", "NhanVien");
            //
            model.TaiKhoan = HttpContext.Session.GetString("TaiKhoanNv");
            context.NhanViens.Update(model);
            context.SaveChanges();
            return RedirectToAction("Index","NhanVien");
        }*/
        public IActionResult Details(int id)
        {
            //phân quyền
            if (HttpContext.Session.GetInt32("IDNhanVien") == null) return RedirectToAction("Login", "NhanVien");
            //
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var nhanVien = GetViewNhanVien(id);
            if (nhanVien == null) return NotFound();
            return View(nhanVien);
        }
        public IActionResult Delete(int id)
        {
            //phân quyền
            if (HttpContext.Session.GetInt32("IDNhanVien") == null) return RedirectToAction("Login", "NhanVien");
            //
            if (!ModelState.IsValid) return BadRequest();
            var nhanVien = context.NhanViens.SingleOrDefault(m => m.IDNhanVien==id);
            if (nhanVien == null) return NotFound();
            context.NhanViens.Remove(nhanVien);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(NhanVienLogin Model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            NhanVienLogin nhanVien = (from nv in context.NhanViens
                                              where nv.TaiKhoan == Model.TaiKhoan && nv.MatKhau == Model.MatKhau
                                              select new NhanVienLogin
                                              {
                                                  IDNhanVien = nv.IDNhanVien,
                                                  TaiKhoan = nv.TaiKhoan,
                                                  MatKhau = nv.MatKhau,
                                                  LoaiNhanVien = nv.LoaiNhanVien,
                                                  IDChiNhanh=nv.IDChiNhanh
                                              }).SingleOrDefault();
            if (nhanVien == null)
            {
                ModelState.AddModelError("", "Sai tài khoản hoặc mật khẩu");
                return View();
            }
            else
            {
                HttpContext.Session.SetInt32("IDNhanVien", nhanVien.IDNhanVien);
                HttpContext.Session.SetString("TaiKhoanNv", Model.TaiKhoan);
                HttpContext.Session.SetString("MatKhauNv", Model.MatKhau);
                HttpContext.Session.SetInt32("LoaiTaiKhoanNv", nhanVien.LoaiNhanVien);
                HttpContext.Session.SetInt32("IDChiNhanh", nhanVien.IDChiNhanh);
            }
            return RedirectToAction("Index","QuanLy");
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("IDNhanVien");
            HttpContext.Session.Remove("TaiKhoanNv");
            HttpContext.Session.Remove("MatKhauNv");
            HttpContext.Session.Remove("LoaiTaiKhoanNv");
            HttpContext.Session.Remove("IDChiNhanh");
            return RedirectToAction("Index");
        }
        public SelectList getListChiNhanh()
        {
            List<ChiNhanh> chiNhanh = context.ChiNhanhs.ToList();
            SelectList listChiNhanh = new SelectList(chiNhanh, "IDChiNhanh", "TenChiNhanh");
            return listChiNhanh;
        }
        public List<viewNhanVien> GetViewNhanViens()
        {
            IEnumerable<viewNhanVien>listViewNhanVien =  from nv in context.NhanViens
                                    join cn in context.ChiNhanhs
                                    on nv.IDChiNhanh equals cn.IDChiNhanh
                                    select new viewNhanVien
                                    {
                                        IDNhanVien = nv.IDNhanVien,
                                        TaiKhoan = nv.TaiKhoan,
                                        MatKhau = nv.MatKhau,
                                        HoTen = nv.HoTen,
                                        NgaySinh = nv.NgaySinh,
                                        LoaiNhanVien = nv.LoaiNhanVien,
                                        DiaChi = nv.DiaChi,
                                        TenChiNhanh = cn.TenChiNhanh
                                    };
            List<viewNhanVien> ListViewNhanVien = new List<viewNhanVien>(listViewNhanVien);
            return ListViewNhanVien;            
        }
        public viewNhanVien GetViewNhanVien(int id)
        {
            IEnumerable<viewNhanVien> listViewNhanVien = from nv in context.NhanViens
                                                         join cn in context.ChiNhanhs
                                                         on nv.IDChiNhanh equals cn.IDChiNhanh
                                                         where nv.IDNhanVien==id
                                                         select new viewNhanVien
                                                         {
                                                             IDNhanVien = nv.IDNhanVien,
                                                             TaiKhoan = nv.TaiKhoan,
                                                             MatKhau = nv.MatKhau,
                                                             HoTen = nv.HoTen,
                                                             NgaySinh = nv.NgaySinh,
                                                             LoaiNhanVien = nv.LoaiNhanVien,
                                                             DiaChi = nv.DiaChi,
                                                             TenChiNhanh = cn.TenChiNhanh
                                                         };
            List<viewNhanVien> ListViewNhanVien = new List<viewNhanVien>(listViewNhanVien);
            if (ListViewNhanVien.Count == 0) return null;
            return ListViewNhanVien[0];
        }
    }
}