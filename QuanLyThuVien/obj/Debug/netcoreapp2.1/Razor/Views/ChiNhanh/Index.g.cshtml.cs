#pragma checksum "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\ChiNhanh\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23449f21c501f6ed14874d2b9f097f0c8ed4361f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ChiNhanh_Index), @"mvc.1.0.view", @"/Views/ChiNhanh/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ChiNhanh/Index.cshtml", typeof(AspNetCore.Views_ChiNhanh_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23449f21c501f6ed14874d2b9f097f0c8ed4361f", @"/Views/ChiNhanh/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20a0cbbb9bc49e060a61bbf9750d63a1feede449", @"/Views/_ViewImports.cshtml")]
    public class Views_ChiNhanh_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<QuanLyThuVien.Models.ChiNhanh>>
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
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\ChiNhanh\Index.cshtml"
  
    ViewData["Title"] = "Danh sách chi nhánh";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(160, 34, true);
            WriteLiteral("\r\n<h2>Danh sách chi nhánh</h2>\r\n\r\n");
            EndContext();
#line 10 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\ChiNhanh\Index.cshtml"
 if (Model != null)
{

#line default
#line hidden
            BeginContext(218, 17, true);
            WriteLiteral("    <p>\r\n        ");
            EndContext();
            BeginContext(235, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b805155a22142399c2ec38f2132a2f2", async() => {
                BeginContext(282, 10, true);
                WriteLiteral("Create New");
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
            BeginContext(296, 116, true);
            WriteLiteral("\r\n    </p>\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(413, 46, false);
#line 19 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\ChiNhanh\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.IDChiNhanh));

#line default
#line hidden
            EndContext();
            BeginContext(459, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(527, 47, false);
#line 22 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\ChiNhanh\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.TenChiNhanh));

#line default
#line hidden
            EndContext();
            BeginContext(574, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(642, 42, false);
#line 25 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\ChiNhanh\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.DiaChi));

#line default
#line hidden
            EndContext();
            BeginContext(684, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(752, 48, false);
#line 28 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\ChiNhanh\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.NgayThanhLap));

#line default
#line hidden
            EndContext();
            BeginContext(800, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(868, 44, false);
#line 31 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\ChiNhanh\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.IDQuanLy));

#line default
#line hidden
            EndContext();
            BeginContext(912, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(980, 46, false);
#line 34 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\ChiNhanh\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.IDNhanVien));

#line default
#line hidden
            EndContext();
            BeginContext(1026, 106, true);
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 40 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\ChiNhanh\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(1189, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1262, 45, false);
#line 44 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\ChiNhanh\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.IDChiNhanh));

#line default
#line hidden
            EndContext();
            BeginContext(1307, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1387, 46, false);
#line 47 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\ChiNhanh\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TenChiNhanh));

#line default
#line hidden
            EndContext();
            BeginContext(1433, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1513, 41, false);
#line 50 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\ChiNhanh\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DiaChi));

#line default
#line hidden
            EndContext();
            BeginContext(1554, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1634, 47, false);
#line 53 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\ChiNhanh\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.NgayThanhLap));

#line default
#line hidden
            EndContext();
            BeginContext(1681, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1761, 43, false);
#line 56 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\ChiNhanh\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.IDQuanLy));

#line default
#line hidden
            EndContext();
            BeginContext(1804, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1884, 45, false);
#line 59 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\ChiNhanh\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.IDNhanVien));

#line default
#line hidden
            EndContext();
            BeginContext(1929, 131, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <a href=\"#\" class=\"btn btn-primary a-btn-slide-text\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2060, "\"", 2097, 3);
            WriteAttributeValue("", 2070, "btnDetail(", 2070, 10, true);
#line 62 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\ChiNhanh\Index.cshtml"
WriteAttributeValue("", 2080, item.IDChiNhanh, 2080, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 2096, ")", 2096, 1, true);
            EndWriteAttribute();
            BeginContext(2098, 214, true);
            WriteLiteral(">\r\n                            <span><strong>Detail</strong></span>\r\n                        </a>\r\n                        <a href=\"#\" class=\"btn btn-primary a-btn-slide-text\" style=\"background-color:darkslategray\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2312, "\"", 2347, 3);
            WriteAttributeValue("", 2322, "btnEdit(", 2322, 8, true);
#line 65 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\ChiNhanh\Index.cshtml"
WriteAttributeValue("", 2330, item.IDChiNhanh, 2330, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 2346, ")", 2346, 1, true);
            EndWriteAttribute();
            BeginContext(2348, 206, true);
            WriteLiteral(">\r\n                            <span><strong>Edit</strong></span>\r\n                        </a>\r\n                        <a href=\"#\" class=\"btn btn-primary a-btn-slide-text\" style=\"background-color:darkred\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2554, "\"", 2591, 3);
            WriteAttributeValue("", 2564, "btnDelete(", 2564, 10, true);
#line 68 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\ChiNhanh\Index.cshtml"
WriteAttributeValue("", 2574, item.IDChiNhanh, 2574, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 2590, ")", 2590, 1, true);
            EndWriteAttribute();
            BeginContext(2592, 149, true);
            WriteLiteral(">\r\n                            <span><strong>Delete</strong></span>\r\n                        </a>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 73 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\ChiNhanh\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2756, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 76 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\ChiNhanh\Index.cshtml"
}

#line default
#line hidden
#line 77 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\ChiNhanh\Index.cshtml"
 if (Model == null)
{

#line default
#line hidden
            BeginContext(2815, 51, true);
            WriteLiteral("    <h2>Bạn không có quyền xem thông tin này</h2>\r\n");
            EndContext();
#line 80 "D:\tund\net\libraryaspnet\QuanLyThuVien\Views\ChiNhanh\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2869, 347, true);
            WriteLiteral(@"    <script>
        function btnEdit(id) {
            window.location.href = ""/ChiNhanh/Edit/"" + id;
        }
        function btnDetail(id) {
            window.location.href = ""/ChiNhanh/Details/"" + id;
        }
        function btnDelete(id) {
            window.location.href = ""/ChiNhanh/Delete/"" + id;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<QuanLyThuVien.Models.ChiNhanh>> Html { get; private set; }
    }
}
#pragma warning restore 1591
