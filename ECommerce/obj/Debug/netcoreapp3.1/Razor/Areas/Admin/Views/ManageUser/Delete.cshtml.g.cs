#pragma checksum "D:\down\BaiTH91\Thư mục mới\ECommerce-ver2\ECommerce\Areas\Admin\Views\ManageUser\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c2d652475291ef66a239e498b3342c51e1a672a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ManageUser_Delete), @"mvc.1.0.view", @"/Areas/Admin/Views/ManageUser/Delete.cshtml")]
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
#line 1 "D:\down\BaiTH91\Thư mục mới\ECommerce-ver2\ECommerce\Areas\Admin\Views\_ViewImports.cshtml"
using ECommerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\down\BaiTH91\Thư mục mới\ECommerce-ver2\ECommerce\Areas\Admin\Views\_ViewImports.cshtml"
using ECommerce.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c2d652475291ef66a239e498b3342c51e1a672a", @"/Areas/Admin/Views/ManageUser/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec470632cb3b1b75499bc0cdcc8d1831e35eecad", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_ManageUser_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ECommerce.Areas.Identity.Models.ApplicationUser>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Delete</h1>\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\down\BaiTH91\Thư mục mới\ECommerce-ver2\ECommerce\Areas\Admin\Views\ManageUser\Delete.cshtml"
  

    ViewBag.Title = "Xóa thành viên";

    Layout = "~/Areas/Admin/Views/_Layout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n\r\n    <div class=\"col-sm-12\">\r\n\r\n        <h2>");
#nullable restore
#line 16 "D:\down\BaiTH91\Thư mục mới\ECommerce-ver2\ECommerce\Areas\Admin\Views\ManageUser\Delete.cshtml"
       Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n        <hr />\r\n\r\n        <div class=\"text-center\">\r\n\r\n\r\n            <h5>Bạn có chắc muốn xóa thành viên ");
#nullable restore
#line 23 "D:\down\BaiTH91\Thư mục mới\ECommerce-ver2\ECommerce\Areas\Admin\Views\ManageUser\Delete.cshtml"
                                           Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("?</h5>\r\n\r\n");
#nullable restore
#line 25 "D:\down\BaiTH91\Thư mục mới\ECommerce-ver2\ECommerce\Areas\Admin\Views\ManageUser\Delete.cshtml"
             using (Html.BeginForm())

            {

                

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\down\BaiTH91\Thư mục mới\ECommerce-ver2\ECommerce\Areas\Admin\Views\ManageUser\Delete.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "D:\down\BaiTH91\Thư mục mới\ECommerce-ver2\ECommerce\Areas\Admin\Views\ManageUser\Delete.cshtml"
           Write(Html.ValidationSummary("", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                <button type=\"submit\" class=\"btn btn-primary\">Chấp nhận</button>\r\n");
            WriteLiteral("                <a");
            BeginWriteAttribute("href", " href=\"", 678, "\"", 705, 1);
#nullable restore
#line 35 "D:\down\BaiTH91\Thư mục mới\ECommerce-ver2\ECommerce\Areas\Admin\Views\ManageUser\Delete.cshtml"
WriteAttributeValue("", 685, Url.Action("Index"), 685, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default\">Không xóa</a>\r\n");
#nullable restore
#line 36 "D:\down\BaiTH91\Thư mục mới\ECommerce-ver2\ECommerce\Areas\Admin\Views\ManageUser\Delete.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ECommerce.Areas.Identity.Models.ApplicationUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
