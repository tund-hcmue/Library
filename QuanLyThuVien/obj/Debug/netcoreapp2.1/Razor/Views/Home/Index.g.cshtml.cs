#pragma checksum "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3372902e60b21f7ad50d193f3ba3a2d1df865c4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\Home\Index.cshtml"
using PagedList.Mvc;

#line default
#line hidden
#line 2 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\Home\Index.cshtml"
using PagedList;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3372902e60b21f7ad50d193f3ba3a2d1df865c4f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20a0cbbb9bc49e060a61bbf9750d63a1feede449", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<QuanLyThuVien.ViewModels.viewSach>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(96, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
#line 7 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Trang chủ";

#line default
#line hidden
            BeginContext(147, 134, true);
            WriteLiteral("<br />\r\n<div class=\"form-group\" style=\"color:black; text-align:right;\">\r\n    <select id=\"selectloai\" style=\"font-size:13px\">\r\n        ");
            EndContext();
            BeginContext(281, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92032eef6cd348f0a8566074215e5ac1", async() => {
                BeginContext(299, 6, true);
                WriteLiteral("Tất cả");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(314, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 14 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\Home\Index.cshtml"
         foreach (var iteml in this.ViewBag.loaisach)
        {

#line default
#line hidden
            BeginContext(382, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(394, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e466491d93e84aa0bdc4de20a0a327d6", async() => {
                BeginContext(425, 13, false);
#line 16 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\Home\Index.cshtml"
                                     Write(iteml.TenLoai);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 16 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\Home\Index.cshtml"
               WriteLiteral(iteml.IDLoai);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(447, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 17 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(460, 745, true);
            WriteLiteral(@"    </select>
    <input style=""margin-top:10px"" type=""text"" name=""keysearch"" id=""keysearch"" value="""" placeholder=""Tìm kiếm sách/ tác giả..."" />
    <input style=""margin-top:10px"" type=""button"" onclick=""timSach()"" name=""name"" value=""Tìm Kiếm"" />
</div>
<script>
    function timSach() {
        var key = document.getElementById('selectloai');
        var idvalue = key[key.selectedIndex].value;
        var keysearch = document.getElementById('keysearch').value;
        if (idvalue == 0) {
            window.location.href = ""/Home/timSach?key="" + keysearch + ""&id=&page="";
        }
        else {
            window.location.href = ""/Home/timSach?key="" + keysearch + ""&id="" + idvalue + ""&page="";

        }
    }
</script>
");
            EndContext();
            BeginContext(1205, 1599, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e30bfc8271e84a3188457f61f3425c46", async() => {
                BeginContext(1211, 218, true);
                WriteLiteral("\r\n    <div class=\"col-lg-2\">\r\n        <h4 style=\"text-align:center; color:white;\"><b>Danh mục</b></h4></>\r\n        <div class=\"list-group\">\r\n            <a class=\"list-group-item\" href=\"/Home/Index\"><u>Tất cả</u></a>\r\n");
                EndContext();
#line 41 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\Home\Index.cshtml"
             foreach (var itemls in this.ViewBag.loaisach)
            {

#line default
#line hidden
                BeginContext(1504, 78, true);
                WriteLiteral("                <div>\r\n                    <a class=\"list-group-item\" href=\"#\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 1582, "\"", 1624, 3);
                WriteAttributeValue("", 1592, "viewSachTheoLoai(", 1592, 17, true);
#line 44 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\Home\Index.cshtml"
WriteAttributeValue("", 1609, itemls.IDLoai, 1609, 14, false);

#line default
#line hidden
                WriteAttributeValue("", 1623, ")", 1623, 1, true);
                EndWriteAttribute();
                BeginContext(1625, 4, true);
                WriteLiteral("><u>");
                EndContext();
                BeginContext(1630, 14, false);
#line 44 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\Home\Index.cshtml"
                                                                                                 Write(itemls.TenLoai);

#line default
#line hidden
                EndContext();
                BeginContext(1644, 34, true);
                WriteLiteral("</u></a>\r\n                </div>\r\n");
                EndContext();
#line 46 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\Home\Index.cshtml"
            }

#line default
#line hidden
                BeginContext(1693, 57, true);
                WriteLiteral("        </div>\r\n    </div>\r\n    <div class=\"col-lg-10\">\r\n");
                EndContext();
#line 50 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\Home\Index.cshtml"
         foreach (var item in this.ViewBag.Result)
        {

#line default
#line hidden
                BeginContext(1813, 110, true);
                WriteLiteral("            <div class=\"col-lg-4\">\r\n                <div class=\"item\">\r\n                    <div class=\"img\"> ");
                EndContext();
                BeginContext(1923, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "391bd0c963434f1c905d726e5ef0bba5", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1933, "~/HinhAnh/", 1933, 10, true);
#line 54 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1943, item.HinhAnh, 1943, 13, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1965, 39, true);
                WriteLiteral("</div>\r\n                    <a href=\"#\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 2004, "\"", 2037, 3);
                WriteAttributeValue("", 2014, "viewSach(", 2014, 9, true);
#line 55 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\Home\Index.cshtml"
WriteAttributeValue("", 2023, item.IDSach, 2023, 12, false);

#line default
#line hidden
                WriteAttributeValue("", 2035, ");", 2035, 2, true);
                EndWriteAttribute();
                BeginContext(2038, 27, true);
                WriteLiteral(">\r\n                        ");
                EndContext();
                BeginContext(2066, 12, false);
#line 56 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\Home\Index.cshtml"
                   Write(item.TenSach);

#line default
#line hidden
                EndContext();
                BeginContext(2078, 71, true);
                WriteLiteral("\r\n                    </a>\r\n                    <div class=\"tentacgia\">");
                EndContext();
                BeginContext(2150, 11, false);
#line 58 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\Home\Index.cshtml"
                                      Write(item.TacGia);

#line default
#line hidden
                EndContext();
                BeginContext(2161, 67, true);
                WriteLiteral("</div>\r\n                    <div class=\"price\">Tiền đặt cọc:&nbsp; ");
                EndContext();
                BeginContext(2229, 12, false);
#line 59 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\Home\Index.cshtml"
                                                      Write(item.TienMua);

#line default
#line hidden
                EndContext();
                BeginContext(2241, 72, true);
                WriteLiteral(" vnd</div>\r\n                    <div class=\"price\">Giá thuê sách:&nbsp; ");
                EndContext();
                BeginContext(2314, 13, false);
#line 60 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\Home\Index.cshtml"
                                                       Write(item.TienMuon);

#line default
#line hidden
                EndContext();
                BeginContext(2327, 56, true);
                WriteLiteral(" vnd</div>\r\n                </div>\r\n            </div>\r\n");
                EndContext();
#line 63 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\Home\Index.cshtml"
        }

#line default
#line hidden
                BeginContext(2394, 170, true);
                WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\" style=\"text-align:center\">\r\n        <button class=\"btn btn-primary\" onclick=\"btnBackPage()\">Trang trước</button>\r\n        Trang ");
                EndContext();
                BeginContext(2566, 99, false);
#line 68 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\Home\Index.cshtml"
          Write(this.ViewBag.Result.PageCount < this.ViewBag.Result.PageNumber ? 0 : this.ViewBag.Result.PageNumber);

#line default
#line hidden
                EndContext();
                BeginContext(2666, 3, true);
                WriteLiteral(" / ");
                EndContext();
                BeginContext(2670, 29, false);
#line 68 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\Home\Index.cshtml"
                                                                                                                  Write(this.ViewBag.Result.PageCount);

#line default
#line hidden
                EndContext();
                BeginContext(2699, 98, true);
                WriteLiteral("\r\n        <button class=\"btn btn-primary\" onclick=\"btnNextPage()\">Trang sau</button>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2804, 281, true);
            WriteLiteral(@"

<script>
    var n = 1;
    function viewSach(id) {
        window.location.href = ""/Sach/Details/"" + id;
    }
    function viewSachTheoLoai(id) {
        window.location.href = ""/Home/Index/"" + id;
    }
</script>
<script>
    function btnNextPage() {
        if (");
            EndContext();
            BeginContext(3086, 25, false);
#line 84 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\Home\Index.cshtml"
       Write(ViewBag.Result.PageNumber);

#line default
#line hidden
            EndContext();
            BeginContext(3111, 3, true);
            WriteLiteral(" < ");
            EndContext();
            BeginContext(3115, 24, false);
#line 84 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\Home\Index.cshtml"
                                    Write(ViewBag.Result.PageCount);

#line default
#line hidden
            EndContext();
            BeginContext(3139, 21, true);
            WriteLiteral(") {\r\n            n = ");
            EndContext();
            BeginContext(3161, 25, false);
#line 85 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\Home\Index.cshtml"
           Write(ViewBag.Result.PageNumber);

#line default
#line hidden
            EndContext();
            BeginContext(3186, 23, true);
            WriteLiteral(" + 1;\r\n            if (");
            EndContext();
            BeginContext(3210, 18, false);
#line 86 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\Home\Index.cshtml"
           Write(ViewBag.idloaisach);

#line default
#line hidden
            EndContext();
            BeginContext(3228, 69, true);
            WriteLiteral(" != 0) {\r\n                window.location.href = \"/Home/Index?id=\" + ");
            EndContext();
            BeginContext(3298, 18, false);
#line 87 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\Home\Index.cshtml"
                                                      Write(ViewBag.idloaisach);

#line default
#line hidden
            EndContext();
            BeginContext(3316, 49, true);
            WriteLiteral(" + \"&page=\" + n;\r\n            }\r\n            if (");
            EndContext();
            BeginContext(3366, 18, false);
#line 89 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\Home\Index.cshtml"
           Write(ViewBag.idloaisach);

#line default
#line hidden
            EndContext();
            BeginContext(3384, 225, true);
            WriteLiteral(" == 0) {\r\n                window.location.href = \"/Home/Index?id=&page=\" + n;\r\n            }\r\n\r\n        }\r\n        else {\r\n            alert(\"Hết sách rồi!!!\")\r\n        }\r\n    }\r\n        function btnBackPage() {\r\n        if (");
            EndContext();
            BeginContext(3610, 25, false);
#line 99 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\Home\Index.cshtml"
       Write(ViewBag.Result.PageNumber);

#line default
#line hidden
            EndContext();
            BeginContext(3635, 26, true);
            WriteLiteral(" != 1) {\r\n            n = ");
            EndContext();
            BeginContext(3662, 25, false);
#line 100 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\Home\Index.cshtml"
           Write(ViewBag.Result.PageNumber);

#line default
#line hidden
            EndContext();
            BeginContext(3687, 22, true);
            WriteLiteral(" -1;\r\n            if (");
            EndContext();
            BeginContext(3710, 18, false);
#line 101 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\Home\Index.cshtml"
           Write(ViewBag.idloaisach);

#line default
#line hidden
            EndContext();
            BeginContext(3728, 69, true);
            WriteLiteral(" != 0) {\r\n                window.location.href = \"/Home/Index?id=\" + ");
            EndContext();
            BeginContext(3798, 18, false);
#line 102 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\Home\Index.cshtml"
                                                      Write(ViewBag.idloaisach);

#line default
#line hidden
            EndContext();
            BeginContext(3816, 48, true);
            WriteLiteral("+ \"&page=\" + n;\r\n            }\r\n            if (");
            EndContext();
            BeginContext(3865, 18, false);
#line 104 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\Home\Index.cshtml"
           Write(ViewBag.idloaisach);

#line default
#line hidden
            EndContext();
            BeginContext(3883, 201, true);
            WriteLiteral(" == 0) {\r\n                window.location.href = \"/Home/Index?id=&page=\" + n;\r\n            }\r\n        }\r\n        else {\r\n            alert(\"Về page 0 là bug đó!!!\")\r\n        }\r\n    }\r\n\r\n</script>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<QuanLyThuVien.ViewModels.viewSach>> Html { get; private set; }
    }
}
#pragma warning restore 1591
