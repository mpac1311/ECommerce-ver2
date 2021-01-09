#pragma checksum "C:\Users\Mi\Documents\GitHub\ECommerce-ver2\ECommerce\Areas\Users\Views\Cart\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c150b971f6f5b90cd56b67376716639fa4e1a531"
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
#line 1 "C:\Users\Mi\Documents\GitHub\ECommerce-ver2\ECommerce\Areas\Users\_ViewImports.cshtml"
using ECommerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mi\Documents\GitHub\ECommerce-ver2\ECommerce\Areas\Users\_ViewImports.cshtml"
using ECommerce.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c150b971f6f5b90cd56b67376716639fa4e1a531", @"/Areas/Users/Views/Cart/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec470632cb3b1b75499bc0cdcc8d1831e35eecad", @"/Areas/Users/_ViewImports.cshtml")]
    public class Areas_Users_Views_Cart_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ECommerce.Models.DonHang>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("60"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("60"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Mi\Documents\GitHub\ECommerce-ver2\ECommerce\Areas\Users\Views\Cart\Checkout.cshtml"
   ViewData["Title"] = "Cart";
    Layout = "~/Areas/Users/Views/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "C:\Users\Mi\Documents\GitHub\ECommerce-ver2\ECommerce\Areas\Users\Views\Cart\Checkout.cshtml"
 if (ViewBag.Cart.Count > 0)
{
    decimal total = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n    Tong sp: ");
#nullable restore
#line 10 "C:\Users\Mi\Documents\GitHub\ECommerce-ver2\ECommerce\Areas\Users\Views\Cart\Checkout.cshtml"
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
#line 21 "C:\Users\Mi\Documents\GitHub\ECommerce-ver2\ECommerce\Areas\Users\Views\Cart\Checkout.cshtml"
                     foreach (var item in ViewBag.Cart)
                    {
                        var thanhtien = item.Quantity * item.SanPham.DonGia;
                        total += thanhtien;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>");
#nullable restore
#line 26 "C:\Users\Mi\Documents\GitHub\ECommerce-ver2\ECommerce\Areas\Users\Views\Cart\Checkout.cshtml"
       Write(item.SanPham.TenSP);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c150b971f6f5b90cd56b67376716639fa4e1a5315707", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 835, "~/image/", 835, 8, true);
#nullable restore
#line 27 "C:\Users\Mi\Documents\GitHub\ECommerce-ver2\ECommerce\Areas\Users\Views\Cart\Checkout.cshtml"
AddHtmlAttributeValue("", 843, item.SanPham.HinhAnh, 843, 21, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 28 "C:\Users\Mi\Documents\GitHub\ECommerce-ver2\ECommerce\Areas\Users\Views\Cart\Checkout.cshtml"
       Write(item.SanPham.DonGia);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 29 "C:\Users\Mi\Documents\GitHub\ECommerce-ver2\ECommerce\Areas\Users\Views\Cart\Checkout.cshtml"
       Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 30 "C:\Users\Mi\Documents\GitHub\ECommerce-ver2\ECommerce\Areas\Users\Views\Cart\Checkout.cshtml"
        Write(item.SanPham.DonGia * item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        \r\n    </tr>\r\n");
#nullable restore
#line 33 "C:\Users\Mi\Documents\GitHub\ECommerce-ver2\ECommerce\Areas\Users\Views\Cart\Checkout.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td align=\"right\" colspan=\"6\">Sum</td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 37 "C:\Users\Mi\Documents\GitHub\ECommerce-ver2\ECommerce\Areas\Users\Views\Cart\Checkout.cshtml"
                        Write(total.ToString("n0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                </table>\r\n<div class=\"section group\">\r\n        <div class=\"col-md-6\">\r\n");
#nullable restore
#line 43 "C:\Users\Mi\Documents\GitHub\ECommerce-ver2\ECommerce\Areas\Users\Views\Cart\Checkout.cshtml"
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
            WriteLiteral("                <button type=\"submit\" class=\"btn\">Xac nhan</button>\r\n");
#nullable restore
#line 67 "C:\Users\Mi\Documents\GitHub\ECommerce-ver2\ECommerce\Areas\Users\Views\Cart\Checkout.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n       \r\n    </div>\r\n");
#nullable restore
#line 71 "C:\Users\Mi\Documents\GitHub\ECommerce-ver2\ECommerce\Areas\Users\Views\Cart\Checkout.cshtml"
}
 else
 {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"alert alert-danger\">Giỏ hàng trống</p>\r\n");
#nullable restore
#line 75 "C:\Users\Mi\Documents\GitHub\ECommerce-ver2\ECommerce\Areas\Users\Views\Cart\Checkout.cshtml"
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
