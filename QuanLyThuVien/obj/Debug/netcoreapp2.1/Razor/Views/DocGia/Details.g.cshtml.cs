#pragma checksum "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\DocGia\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6a5d7b815120c9288f1a710b9bd6c795cba6dbe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DocGia_Details), @"mvc.1.0.view", @"/Views/DocGia/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DocGia/Details.cshtml", typeof(AspNetCore.Views_DocGia_Details))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\_ViewImports.cshtml"
using QuanLyThuVien;

#line default
#line hidden
#line 2 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\_ViewImports.cshtml"
using QuanLyThuVien.Models;

#line default
#line hidden
#line 2 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\DocGia\Details.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6a5d7b815120c9288f1a710b9bd6c795cba6dbe", @"/Views/DocGia/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20a0cbbb9bc49e060a61bbf9750d63a1feede449", @"/Views/_ViewImports.cshtml")]
    public class Views_DocGia_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QuanLyThuVien.Models.DocGia>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\DocGia\Details.cshtml"
  
    ViewData["Title"] = "Thông tin tài khoản";

#line default
#line hidden
            BeginContext(125, 60, true);
            WriteLiteral("\r\n<h2>Thông tin tài khoản</h2>\r\n\r\n<div>\r\n    <h4>Tài khoản: ");
            EndContext();
            BeginContext(186, 14, false);
#line 10 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\DocGia\Details.cshtml"
              Write(Model.TaiKhoan);

#line default
#line hidden
            EndContext();
            BeginContext(200, 11, true);
            WriteLiteral("</h4>\r\n    ");
            EndContext();
            BeginContext(212, 120, false);
#line 11 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\DocGia\Details.cshtml"
Write(Html.ActionLink("Xem lịch sử mượn sách", "DanhSach", "DocGia", new {id=Model.IDDocGia}, new { @class="btn btn-default"}));

#line default
#line hidden
            EndContext();
            BeginContext(332, 90, true);
            WriteLiteral("\r\n\r\n    <br /><br />    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(423, 44, false);
#line 16 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\DocGia\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IDDocGia));

#line default
#line hidden
            EndContext();
            BeginContext(467, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(511, 40, false);
#line 19 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\DocGia\Details.cshtml"
       Write(Html.DisplayFor(model => model.IDDocGia));

#line default
#line hidden
            EndContext();
            BeginContext(551, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(595, 43, false);
#line 22 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\DocGia\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MatKhau));

#line default
#line hidden
            EndContext();
            BeginContext(638, 92, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ******\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(731, 41, false);
#line 28 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\DocGia\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HoTen));

#line default
#line hidden
            EndContext();
            BeginContext(772, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(816, 37, false);
#line 31 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\DocGia\Details.cshtml"
       Write(Html.DisplayFor(model => model.HoTen));

#line default
#line hidden
            EndContext();
            BeginContext(853, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(897, 44, false);
#line 34 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\DocGia\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NgaySinh));

#line default
#line hidden
            EndContext();
            BeginContext(941, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(985, 40, false);
#line 37 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\DocGia\Details.cshtml"
       Write(Html.DisplayFor(model => model.NgaySinh));

#line default
#line hidden
            EndContext();
            BeginContext(1025, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1069, 46, false);
#line 40 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\DocGia\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LoaiDocGia));

#line default
#line hidden
            EndContext();
            BeginContext(1115, 31, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n");
            EndContext();
#line 43 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\DocGia\Details.cshtml"
             if (Model.LoaiDocGia == 0)
            {

#line default
#line hidden
            BeginContext(1202, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1220, 12, true);
            WriteLiteral("Giảng viên\r\n");
            EndContext();
#line 46 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\DocGia\Details.cshtml"
            }

#line default
#line hidden
            BeginContext(1247, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 47 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\DocGia\Details.cshtml"
             if (Model.LoaiDocGia == 1)
            {

#line default
#line hidden
            BeginContext(1303, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1321, 11, true);
            WriteLiteral("Sinh Viên\r\n");
            EndContext();
#line 50 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\DocGia\Details.cshtml"
            }

#line default
#line hidden
            BeginContext(1347, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 51 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\DocGia\Details.cshtml"
             if (Model.LoaiDocGia == 2)
            {

#line default
#line hidden
            BeginContext(1403, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1421, 17, true);
            WriteLiteral("Nghề ngiệp khác\r\n");
            EndContext();
#line 54 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\DocGia\Details.cshtml"
            }

#line default
#line hidden
            BeginContext(1453, 41, true);
            WriteLiteral("        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1495, 42, false);
#line 57 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\DocGia\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DiaChi));

#line default
#line hidden
            EndContext();
            BeginContext(1537, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1581, 38, false);
#line 60 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\DocGia\Details.cshtml"
       Write(Html.DisplayFor(model => model.DiaChi));

#line default
#line hidden
            EndContext();
            BeginContext(1619, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(1667, 114, false);
#line 64 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\DocGia\Details.cshtml"
   Write(Html.ActionLink("Sửa thông tin tài khoản", "Edit", new { id = Model.IDDocGia }, new { @class = "btn btn-primary"}));

#line default
#line hidden
            EndContext();
            BeginContext(1781, 24, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1823, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 69 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\DocGia\Details.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuanLyThuVien.Models.DocGia> Html { get; private set; }
    }
}
#pragma warning restore 1591
