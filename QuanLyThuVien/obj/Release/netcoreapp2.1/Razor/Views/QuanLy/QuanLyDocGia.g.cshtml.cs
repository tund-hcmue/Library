#pragma checksum "E:\HCMUE\CNNET\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\QuanLyDocGia.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2bf1aae840a6e5771f0cf5ffd3f4bf75218b9bd0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QuanLy_QuanLyDocGia), @"mvc.1.0.view", @"/Views/QuanLy/QuanLyDocGia.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/QuanLy/QuanLyDocGia.cshtml", typeof(AspNetCore.Views_QuanLy_QuanLyDocGia))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bf1aae840a6e5771f0cf5ffd3f4bf75218b9bd0", @"/Views/QuanLy/QuanLyDocGia.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20a0cbbb9bc49e060a61bbf9750d63a1feede449", @"/Views/_ViewImports.cshtml")]
    public class Views_QuanLy_QuanLyDocGia : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<QuanLyThuVien.Models.DocGia>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\HCMUE\CNNET\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\QuanLyDocGia.cshtml"
  
    ViewData["Title"] = "Danh sách độc giả";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(156, 134, true);
            WriteLiteral("\r\n<h2>Quản lý danh sách độc giả</h2>\r\n\r\n<div class=\"container-yeucau\">\r\n    <div class=\"xulyyeucau\">\r\n        <p>Xử lý mượn sách</p>\r\n");
            EndContext();
#line 13 "E:\HCMUE\CNNET\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\QuanLyDocGia.cshtml"
         using (Html.BeginForm("XuLy", "QuanLy"))
        {
            

#line default
#line hidden
            BeginContext(365, 23, false);
#line 15 "E:\HCMUE\CNNET\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\QuanLyDocGia.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(403, 64, false);
#line 16 "E:\HCMUE\CNNET\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\QuanLyDocGia.cshtml"
       Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(469, 256, true);
            WriteLiteral(@"            <div class=""form-group"">
                <input style=""color:black"" type=""text"" name=""key"" value="""" placeholder=""Nhập mã đọc giả"" />
                <input style=""color:black"" type=""submit"" name=""submit"" value=""Xử lý"" />
            </div>
");
            EndContext();
#line 21 "E:\HCMUE\CNNET\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\QuanLyDocGia.cshtml"
        }

#line default
#line hidden
            BeginContext(736, 29, true);
            WriteLiteral("    </div>\r\n</div>\r\n<p>\r\n    ");
            EndContext();
            BeginContext(765, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36c5b77d96bd4a2fbc2ebf39fbc3ee87", async() => {
                BeginContext(812, 10, true);
                WriteLiteral("Create new");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(826, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(919, 44, false);
#line 31 "E:\HCMUE\CNNET\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\QuanLyDocGia.cshtml"
           Write(Html.DisplayNameFor(model => model.IDDocGia));

#line default
#line hidden
            EndContext();
            BeginContext(963, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1019, 44, false);
#line 34 "E:\HCMUE\CNNET\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\QuanLyDocGia.cshtml"
           Write(Html.DisplayNameFor(model => model.TaiKhoan));

#line default
#line hidden
            EndContext();
            BeginContext(1063, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1119, 41, false);
#line 37 "E:\HCMUE\CNNET\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\QuanLyDocGia.cshtml"
           Write(Html.DisplayNameFor(model => model.HoTen));

#line default
#line hidden
            EndContext();
            BeginContext(1160, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1216, 44, false);
#line 40 "E:\HCMUE\CNNET\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\QuanLyDocGia.cshtml"
           Write(Html.DisplayNameFor(model => model.NgaySinh));

#line default
#line hidden
            EndContext();
            BeginContext(1260, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1316, 46, false);
#line 43 "E:\HCMUE\CNNET\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\QuanLyDocGia.cshtml"
           Write(Html.DisplayNameFor(model => model.LoaiDocGia));

#line default
#line hidden
            EndContext();
            BeginContext(1362, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1418, 42, false);
#line 46 "E:\HCMUE\CNNET\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\QuanLyDocGia.cshtml"
           Write(Html.DisplayNameFor(model => model.DiaChi));

#line default
#line hidden
            EndContext();
            BeginContext(1460, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 52 "E:\HCMUE\CNNET\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\QuanLyDocGia.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1595, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1656, 43, false);
#line 56 "E:\HCMUE\CNNET\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\QuanLyDocGia.cshtml"
               Write(Html.DisplayFor(modelItem => item.IDDocGia));

#line default
#line hidden
            EndContext();
            BeginContext(1699, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1767, 43, false);
#line 59 "E:\HCMUE\CNNET\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\QuanLyDocGia.cshtml"
               Write(Html.DisplayFor(modelItem => item.TaiKhoan));

#line default
#line hidden
            EndContext();
            BeginContext(1810, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1878, 40, false);
#line 62 "E:\HCMUE\CNNET\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\QuanLyDocGia.cshtml"
               Write(Html.DisplayFor(modelItem => item.HoTen));

#line default
#line hidden
            EndContext();
            BeginContext(1918, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1986, 43, false);
#line 65 "E:\HCMUE\CNNET\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\QuanLyDocGia.cshtml"
               Write(Html.DisplayFor(modelItem => item.NgaySinh));

#line default
#line hidden
            EndContext();
            BeginContext(2029, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
#line 68 "E:\HCMUE\CNNET\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\QuanLyDocGia.cshtml"
                     if (item.LoaiDocGia == 0)
                    {

#line default
#line hidden
            BeginContext(2147, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(2173, 12, true);
            WriteLiteral("Giảng viên\r\n");
            EndContext();
#line 71 "E:\HCMUE\CNNET\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\QuanLyDocGia.cshtml"
                    }

#line default
#line hidden
            BeginContext(2208, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 72 "E:\HCMUE\CNNET\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\QuanLyDocGia.cshtml"
                     if (item.LoaiDocGia == 1)
                    {

#line default
#line hidden
            BeginContext(2279, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(2305, 11, true);
            WriteLiteral("Sinh Viên\r\n");
            EndContext();
#line 75 "E:\HCMUE\CNNET\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\QuanLyDocGia.cshtml"
                    }

#line default
#line hidden
            BeginContext(2339, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 76 "E:\HCMUE\CNNET\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\QuanLyDocGia.cshtml"
                     if (item.LoaiDocGia == 2)
                    {

#line default
#line hidden
            BeginContext(2410, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(2436, 18, true);
            WriteLiteral("Nghề nghiệp khác\r\n");
            EndContext();
#line 79 "E:\HCMUE\CNNET\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\QuanLyDocGia.cshtml"
                    }

#line default
#line hidden
            BeginContext(2477, 65, true);
            WriteLiteral("                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2543, 41, false);
#line 82 "E:\HCMUE\CNNET\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\QuanLyDocGia.cshtml"
               Write(Html.DisplayFor(modelItem => item.DiaChi));

#line default
#line hidden
            EndContext();
            BeginContext(2584, 119, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a href=\"#\" class=\"btn btn-primary a-btn-slide-text\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2703, "\"", 2738, 3);
            WriteAttributeValue("", 2713, "btnDetail(", 2713, 10, true);
#line 85 "E:\HCMUE\CNNET\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\QuanLyDocGia.cshtml"
WriteAttributeValue("", 2723, item.IDDocGia, 2723, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 2737, ")", 2737, 1, true);
            EndWriteAttribute();
            BeginContext(2739, 202, true);
            WriteLiteral(">\r\n                        <span><strong>Detail</strong></span>\r\n                    </a>\r\n                    <a href=\"#\" class=\"btn btn-primary a-btn-slide-text\" style=\"background-color:darkslategray\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2941, "\"", 2974, 3);
            WriteAttributeValue("", 2951, "btnEdit(", 2951, 8, true);
#line 88 "E:\HCMUE\CNNET\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\QuanLyDocGia.cshtml"
WriteAttributeValue("", 2959, item.IDDocGia, 2959, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 2973, ")", 2973, 1, true);
            EndWriteAttribute();
            BeginContext(2975, 194, true);
            WriteLiteral(">\r\n                        <span><strong>Edit</strong></span>\r\n                    </a>\r\n                    <a href=\"#\" class=\"btn btn-primary a-btn-slide-text\" style=\"background-color:darkred\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3169, "\"", 3204, 3);
            WriteAttributeValue("", 3179, "btnDelete(", 3179, 10, true);
#line 91 "E:\HCMUE\CNNET\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\QuanLyDocGia.cshtml"
WriteAttributeValue("", 3189, item.IDDocGia, 3189, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 3203, ")", 3203, 1, true);
            EndWriteAttribute();
            BeginContext(3205, 133, true);
            WriteLiteral(">\r\n                        <span><strong>Delete</strong></span>\r\n                    </a>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 96 "E:\HCMUE\CNNET\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\QuanLyDocGia.cshtml"
        }

#line default
#line hidden
            BeginContext(3349, 321, true);
            WriteLiteral(@"    </tbody>
</table>
<script>
    function btnEdit(id) {
        window.location.href = ""/DocGia/Edit/"" + id;
    }
    function btnDetail(id) {
        window.location.href = ""/DocGia/Details/"" + id;
    }
    function btnDelete(id) {
        window.location.href = ""/DocGia/Delete/"" + id;
    }
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<QuanLyThuVien.Models.DocGia>> Html { get; private set; }
    }
}
#pragma warning restore 1591
