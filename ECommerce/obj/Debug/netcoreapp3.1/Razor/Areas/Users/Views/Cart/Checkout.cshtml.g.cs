#pragma checksum "C:\Users\ACER\OneDrive\Máy tính\E-Commerce-master\ECommerce\Areas\Users\Views\Cart\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04c6aca994f3aecc51645c33ef941db9eba38ea8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Users_Views_Cart_Checkout), @"mvc.1.0.view", @"/Areas/Users/Views/Cart/Checkout.cshtml")]
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
#nullable restore
#line 1 "C:\Users\ACER\OneDrive\Máy tính\E-Commerce-master\ECommerce\Areas\Users\_ViewImports.cshtml"
using ECommerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ACER\OneDrive\Máy tính\E-Commerce-master\ECommerce\Areas\Users\_ViewImports.cshtml"
using ECommerce.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04c6aca994f3aecc51645c33ef941db9eba38ea8", @"/Areas/Users/Views/Cart/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89fb089828dd866504103bfaeb2b6e1f9939c572", @"/Areas/Users/_ViewImports.cshtml")]
    public class Areas_Users_Views_Cart_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ECommerce.Models.DonHang>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("60"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("60"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ACER\OneDrive\Máy tính\E-Commerce-master\ECommerce\Areas\Users\Views\Cart\Checkout.cshtml"
   ViewData["Title"] = "Cart";
    Layout = "~/Areas/Users/Views/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"row\">\n    <div class=\"col-lg-12\">\n        <ul class=\"breadcrumb\">\n            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04c6aca994f3aecc51645c33ef941db9eba38ea85309", async() => {
                WriteLiteral("Trang Chủ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\n            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04c6aca994f3aecc51645c33ef941db9eba38ea86692", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("Gio hàng</li>\n        </ul>\n    </div>\n</div>\n");
#nullable restore
#line 13 "C:\Users\ACER\OneDrive\Máy tính\E-Commerce-master\ECommerce\Areas\Users\Views\Cart\Checkout.cshtml"
 if (ViewBag.Cart.Count > 0)
{
    decimal total = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\n    Tong sp: ");
#nullable restore
#line 17 "C:\Users\ACER\OneDrive\Máy tính\E-Commerce-master\ECommerce\Areas\Users\Views\Cart\Checkout.cshtml"
        Write(ViewBag.Cart.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>
                <table class=""table-bordered table"">
                    <tr>

                        <th>Name</th>
                        <th>Photo</th>
                        <th>Price</th>
                        <th>Quantity</th>
                        <th>Sub Total</th>
                    </tr>
");
#nullable restore
#line 28 "C:\Users\ACER\OneDrive\Máy tính\E-Commerce-master\ECommerce\Areas\Users\Views\Cart\Checkout.cshtml"
                     foreach (var item in ViewBag.Cart)
                    {
                        var thanhtien = item.Quantity * item.SanPham.DonGia;
                        total += thanhtien;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\n        <td>");
#nullable restore
#line 33 "C:\Users\ACER\OneDrive\Máy tính\E-Commerce-master\ECommerce\Areas\Users\Views\Cart\Checkout.cshtml"
       Write(item.SanPham.TenSP);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "04c6aca994f3aecc51645c33ef941db9eba38ea89618", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1078, "~/image/", 1078, 8, true);
#nullable restore
#line 34 "C:\Users\ACER\OneDrive\Máy tính\E-Commerce-master\ECommerce\Areas\Users\Views\Cart\Checkout.cshtml"
AddHtmlAttributeValue("", 1086, item.SanPham.HinhAnh, 1086, 21, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 35 "C:\Users\ACER\OneDrive\Máy tính\E-Commerce-master\ECommerce\Areas\Users\Views\Cart\Checkout.cshtml"
       Write(item.SanPham.DonGia);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 36 "C:\Users\ACER\OneDrive\Máy tính\E-Commerce-master\ECommerce\Areas\Users\Views\Cart\Checkout.cshtml"
       Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 37 "C:\Users\ACER\OneDrive\Máy tính\E-Commerce-master\ECommerce\Areas\Users\Views\Cart\Checkout.cshtml"
        Write(item.SanPham.DonGia * item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        \n    </tr>\n");
#nullable restore
#line 40 "C:\Users\ACER\OneDrive\Máy tính\E-Commerce-master\ECommerce\Areas\Users\Views\Cart\Checkout.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td align=\"right\" colspan=\"6\">Sum</td>\n                        <td>\n                            ");
#nullable restore
#line 44 "C:\Users\ACER\OneDrive\Máy tính\E-Commerce-master\ECommerce\Areas\Users\Views\Cart\Checkout.cshtml"
                        Write(total.ToString("n0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                    </tr>\n                </table>\n<div class=\"section group\">\n        <div class=\"col-md-6\">\n");
#nullable restore
#line 50 "C:\Users\ACER\OneDrive\Máy tính\E-Commerce-master\ECommerce\Areas\Users\Views\Cart\Checkout.cshtml"
             using (Html.BeginForm("Create", "DonHangs", FormMethod.Post))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""form-group"">
                    <label>Người nhận</label>
                    <input name=""TenKH"" class=""form-control"" />
                </div>
                <div class=""form-group"">
                    <label>Điện thoại</label>
                    <input name=""SoDienThoai"" class=""form-control"" />
                </div>
                <div class=""form-group"">
                    <label>Địa chỉ</label>
                    <input name=""DiaChiNhan"" class=""form-control"" />
                </div>
                <div class=""form-group"">
                    <label>Email</label>
                    <input name=""Email"" class=""form-control"" />
                </div>
                <div class=""form-group"">
                    <label>Ghi chu</label>
                    <input name=""GhiChuDH"" class=""form-control"" />
                </div>
");
            WriteLiteral("                <button type=\"submit\" class=\"btn\">Xac nhan</button>\n");
#nullable restore
#line 74 "C:\Users\ACER\OneDrive\Máy tính\E-Commerce-master\ECommerce\Areas\Users\Views\Cart\Checkout.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n       \n    </div>\n");
#nullable restore
#line 78 "C:\Users\ACER\OneDrive\Máy tính\E-Commerce-master\ECommerce\Areas\Users\Views\Cart\Checkout.cshtml"
}
 else
 {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"alert alert-danger\">Giỏ hàng trống</p>\n");
#nullable restore
#line 82 "C:\Users\ACER\OneDrive\Máy tính\E-Commerce-master\ECommerce\Areas\Users\Views\Cart\Checkout.cshtml"
 }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ECommerce.Models.DonHang>> Html { get; private set; }
    }
}
#pragma warning restore 1591
