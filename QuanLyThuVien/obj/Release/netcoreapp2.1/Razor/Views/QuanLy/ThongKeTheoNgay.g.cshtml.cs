#pragma checksum "E:\HCMUE\CNNET\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\ThongKeTheoNgay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8781d1bf7b572edebb5650fb263256b3dadfc62e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QuanLy_ThongKeTheoNgay), @"mvc.1.0.view", @"/Views/QuanLy/ThongKeTheoNgay.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/QuanLy/ThongKeTheoNgay.cshtml", typeof(AspNetCore.Views_QuanLy_ThongKeTheoNgay))]
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
#line 1 "E:\HCMUE\CNNET\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Views\_ViewImports.cshtml"
using QuanLyThuVien;

#line default
#line hidden
#line 2 "E:\HCMUE\CNNET\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Views\_ViewImports.cshtml"
using QuanLyThuVien.Models;

#line default
#line hidden
#line 1 "E:\HCMUE\CNNET\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\ThongKeTheoNgay.cshtml"
using System.Globalization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8781d1bf7b572edebb5650fb263256b3dadfc62e", @"/Views/QuanLy/ThongKeTheoNgay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20a0cbbb9bc49e060a61bbf9750d63a1feede449", @"/Views/_ViewImports.cshtml")]
    public class Views_QuanLy_ThongKeTheoNgay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\HCMUE\CNNET\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\ThongKeTheoNgay.cshtml"
  
    ViewData["Title"] = "ThongKe";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(125, 23, true);
            WriteLiteral("\r\n<h2>Thống kê từ ngày ");
            EndContext();
            BeginContext(149, 104, false);
#line 7 "E:\HCMUE\CNNET\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\ThongKeTheoNgay.cshtml"
                Write(DateTime.ParseExact(ViewBag.beginday, "yyyy-MM-dd", CultureInfo.InvariantCulture).ToString("dd-MM-yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(253, 10, true);
            WriteLiteral(" đến ngày ");
            EndContext();
            BeginContext(264, 102, false);
#line 7 "E:\HCMUE\CNNET\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\ThongKeTheoNgay.cshtml"
                                                                                                                                   Write(DateTime.ParseExact(ViewBag.endday, "yyyy-MM-dd", CultureInfo.InvariantCulture).ToString("dd-MM-yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(366, 90, true);
            WriteLiteral(" </h2>\r\n<div class=\"form-group\" style=\"color:black\">\r\n    <input type=\"date\" id=\"beginday\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 456, "\"", 481, 1);
#line 9 "E:\HCMUE\CNNET\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\ThongKeTheoNgay.cshtml"
WriteAttributeValue("", 464, ViewBag.beginday, 464, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(482, 39, true);
            WriteLiteral(" />\r\n    <input type=\"date\" id=\"endday\"");
            EndContext();
            BeginWriteAttribute("value", " value=", 521, "", 543, 1);
#line 10 "E:\HCMUE\CNNET\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\ThongKeTheoNgay.cshtml"
WriteAttributeValue("", 528, ViewBag.endday, 528, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(543, 2141, true);
            WriteLiteral(@" />
    <input id=""xem"" class=""btn btn-primary"" value=""Xem"" onclick=""btnView()"" />
</div>
<a onclick=""btnView0()"" class=""btn btn-default"">Đang đặt</a>
<a onclick=""btnView1()"" class=""btn btn-default"">Đang mượn</a>
<a onclick=""btnView2()"" class=""btn btn-default"">Đã trả</a>
<script>
    function btnView() {
        var bd = document.getElementById(""beginday"").value;
        var ed = document.getElementById(""endday"").value;
        window.location.href = ""/QuanLy/ThongKeTheoNgay?beginday="" + bd + ""&&endday="" + ed;
    }
    function btnView0() {
        var id = 0;
        var bd = document.getElementById(""beginday"").value;
        var ed = document.getElementById(""endday"").value;
        window.location.href = ""/QuanLy/ThongKeTheoNgay?id="" + id + ""&&beginday="" + bd + ""&&endday="" + ed;
    }
    function btnView1() {
        var id = 1;
        var bd = document.getElementById(""beginday"").value;
        var ed = document.getElementById(""endday"").value;
        window.location.href = ""/QuanLy");
            WriteLiteral(@"/ThongKeTheoNgay?id="" + id + ""&&beginday="" + bd + ""&&endday="" + ed;
    }
    function btnView2() {
        var id = 2;
        var bd = document.getElementById(""beginday"").value;
        var ed = document.getElementById(""endday"").value;
        window.location.href = ""/QuanLy/ThongKeTheoNgay?id="" + id + ""&&beginday="" + bd + ""&&endday="" + ed;
    }
</script>

<table class=""table"">
    <thead>
        <tr>
            <th>
                Mã phiếu
            </th>
            <th>
                Tên độc giả
            </th>
            <th>
                Tên sách
            </th>
            <th>
                Tên nhân viên
            </th>
            <th>
                Tên chi nhánh
            </th>

            <th>
                Phí mượn
            </th>
            <th>
                Tiền cọc
            </th>
            <th>
                Ngày mượn
            </th>
            <th>
                Trạng thái
            </th>
            <th>");
            WriteLiteral("\n                Ngày trả thực\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 79 "E:\HCMUE\CNNET\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\ThongKeTheoNgay.cshtml"
         foreach (var item in ViewBag.Result)
        {

#line default
#line hidden
            BeginContext(2742, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2803, 12, false);
#line 83 "E:\HCMUE\CNNET\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\ThongKeTheoNgay.cshtml"
               Write(item.IDPhieu);

#line default
#line hidden
            EndContext();
            BeginContext(2815, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2883, 14, false);
#line 86 "E:\HCMUE\CNNET\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\ThongKeTheoNgay.cshtml"
               Write(item.TenDocGia);

#line default
#line hidden
            EndContext();
            BeginContext(2897, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2965, 12, false);
#line 89 "E:\HCMUE\CNNET\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\ThongKeTheoNgay.cshtml"
               Write(item.TenSach);

#line default
#line hidden
            EndContext();
            BeginContext(2977, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3045, 16, false);
#line 92 "E:\HCMUE\CNNET\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\ThongKeTheoNgay.cshtml"
               Write(item.TenNhanVien);

#line default
#line hidden
            EndContext();
            BeginContext(3061, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3129, 16, false);
#line 95 "E:\HCMUE\CNNET\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\ThongKeTheoNgay.cshtml"
               Write(item.TenChiNhanh);

#line default
#line hidden
            EndContext();
            BeginContext(3145, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3213, 12, false);
#line 98 "E:\HCMUE\CNNET\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\ThongKeTheoNgay.cshtml"
               Write(item.PhiMuon);

#line default
#line hidden
            EndContext();
            BeginContext(3225, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3293, 12, false);
#line 101 "E:\HCMUE\CNNET\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\ThongKeTheoNgay.cshtml"
               Write(item.TienCoc);

#line default
#line hidden
            EndContext();
            BeginContext(3305, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3373, 13, false);
#line 104 "E:\HCMUE\CNNET\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\ThongKeTheoNgay.cshtml"
               Write(item.NgayMuon);

#line default
#line hidden
            EndContext();
            BeginContext(3386, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
#line 107 "E:\HCMUE\CNNET\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\ThongKeTheoNgay.cshtml"
                     if (item.TrangThai == 0)
                    {

#line default
#line hidden
            BeginContext(3503, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(3529, 10, true);
            WriteLiteral("Đang đặt\r\n");
            EndContext();
#line 110 "E:\HCMUE\CNNET\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\ThongKeTheoNgay.cshtml"
                    }

#line default
#line hidden
            BeginContext(3562, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 111 "E:\HCMUE\CNNET\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\ThongKeTheoNgay.cshtml"
                     if (item.TrangThai == 1)
                    {

#line default
#line hidden
            BeginContext(3632, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(3658, 11, true);
            WriteLiteral("Đang mượn\r\n");
            EndContext();
#line 114 "E:\HCMUE\CNNET\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\ThongKeTheoNgay.cshtml"
                    }

#line default
#line hidden
            BeginContext(3692, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 115 "E:\HCMUE\CNNET\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\ThongKeTheoNgay.cshtml"
                     if (item.TrangThai == 2)
                    {

#line default
#line hidden
            BeginContext(3762, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(3788, 8, true);
            WriteLiteral("Đã trả\r\n");
            EndContext();
#line 118 "E:\HCMUE\CNNET\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\ThongKeTheoNgay.cshtml"
                    }

#line default
#line hidden
            BeginContext(3819, 65, true);
            WriteLiteral("                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3885, 16, false);
#line 121 "E:\HCMUE\CNNET\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\ThongKeTheoNgay.cshtml"
               Write(item.NgayTraThuc);

#line default
#line hidden
            EndContext();
            BeginContext(3901, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 124 "E:\HCMUE\CNNET\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\ThongKeTheoNgay.cshtml"
        }

#line default
#line hidden
            BeginContext(3956, 43, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n<script>\r\n</script>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
