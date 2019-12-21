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
    public class NhanVienController : Controller
    {
        private readonly MyDBContext _context;

        public NhanVienController(MyDBContext context)
        {
            _context = context;
        }

        // GET: NhanVien
        public async Task<IActionResult> Index()
        {
            if (HttpContext.Session.GetInt32("IDNhanVien") == null) return RedirectToAction("Login", "NhanVien");
            
            if (HttpContext.Session.GetInt32("LoaiTaiKhoanNv") == 1)
            {
                IEnumerable<object> nhanVien = null;
                this.ViewBag.Result = nhanVien;
                return View();
            }
            else
            {
                this.ViewBag.Result = GetViewNhanViens();
                return View();
            }

        }         

        // GET: NhanVien/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhanVien = await _context.NhanViens
                .Include(n => n.ChiNhanh)
                .FirstOrDefaultAsync(m => m.IDNhanVien == id);
            if (nhanVien == null)
            {
                return NotFound();
            }

            return View(nhanVien);
        }

        // GET: NhanVien/Create
        public IActionResult Create()
        {
            if (HttpContext.Session.GetInt32("IDNhanVien") == null) return RedirectToAction("Login", "NhanVien");
            //
            ViewData["IDChiNhanh"] = new SelectList(_context.ChiNhanhs, "IDChiNhanh", "DiaChi");
            return View();
        }

        // POST: NhanVien/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDNhanVien,TaiKhoan,MatKhau,HoTen,NgaySinh,LoaiNhanVien,DiaChi,IDChiNhanh")] NhanVien nhanVien)
        {
            if (HttpContext.Session.GetInt32("IDNhanVien") == null) return RedirectToAction("Login", "NhanVien");
            //
            if (ModelState.IsValid)
            {
                _context.Add(nhanVien);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IDChiNhanh"] = new SelectList(_context.ChiNhanhs, "IDChiNhanh", "DiaChi", nhanVien.IDChiNhanh);
            return View(nhanVien);
        }

        // GET: NhanVien/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (HttpContext.Session.GetInt32("IDNhanVien") == null) return RedirectToAction("Login", "NhanVien");
            //
            if (id == null)
            {
                return NotFound();
            }

            var nhanVien = await _context.NhanViens.FindAsync(id);
            if (nhanVien == null)
            {
                return NotFound();
            }
            ViewData["IDChiNhanh"] = new SelectList(_context.ChiNhanhs, "IDChiNhanh", "DiaChi", nhanVien.IDChiNhanh);
            return View(nhanVien);
        }

        // POST: NhanVien/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDNhanVien,TaiKhoan,MatKhau,HoTen,NgaySinh,LoaiNhanVien,DiaChi,IDChiNhanh")] NhanVien nhanVien)
        {
            if (HttpContext.Session.GetInt32("IDNhanVien") == null) return RedirectToAction("Login", "NhanVien");
            //
            if (id != nhanVien.IDNhanVien)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nhanVien);
                    await _context.SaveChangesAsync();
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
            ViewData["IDChiNhanh"] = new SelectList(_context.ChiNhanhs, "IDChiNhanh", "DiaChi", nhanVien.IDChiNhanh);
            return View(nhanVien);
        }

        // GET: NhanVien/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhanVien = await _context.NhanViens
                .Include(n => n.ChiNhanh)
                .FirstOrDefaultAsync(m => m.IDNhanVien == id);
            if (nhanVien == null)
            {
                return NotFound();
            }

            return View(nhanVien);
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(NhanVienLogin Model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            NhanVienLogin nhanVien = (from nv in _context.NhanViens
                                      where nv.TaiKhoan == Model.TaiKhoan && nv.MatKhau == Model.MatKhau
                                      select new NhanVienLogin
                                      {
                                          IDNhanVien = nv.IDNhanVien,
                                          TaiKhoan = nv.TaiKhoan,
                                          MatKhau = nv.MatKhau,
                                          LoaiNhanVien = nv.LoaiNhanVien,
                                          IDChiNhanh = nv.IDChiNhanh
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
            return RedirectToAction("Index", "QuanLy");
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

        // POST: NhanVien/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nhanVien = await _context.NhanViens.FindAsync(id);
            _context.NhanViens.Remove(nhanVien);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NhanVienExists(int id)
        {
            return _context.NhanViens.Any(e => e.IDNhanVien == id);
        }
        public List<viewNhanVien> GetViewNhanViens()
        {
            IEnumerable<viewNhanVien> listViewNhanVien = from nv in _context.NhanViens
                                                         join cn in _context.ChiNhanhs
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
            IEnumerable<viewNhanVien> listViewNhanVien = from nv in _context.NhanViens
                                                         join cn in _context.ChiNhanhs
                                                         on nv.IDChiNhanh equals cn.IDChiNhanh
                                                         where nv.IDNhanVien == id
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
