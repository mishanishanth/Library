#pragma checksum "C:\Library\LibraryWebApp\Views\Home\Catalogue.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b239fbe52399500668d9e8970dd4bd494e37c62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Catalogue), @"mvc.1.0.view", @"/Views/Home/Catalogue.cshtml")]
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
#line 1 "C:\Library\LibraryWebApp\Views\_ViewImports.cshtml"
using LibraryWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Library\LibraryWebApp\Views\_ViewImports.cshtml"
using LibraryWebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Library\LibraryWebApp\Views\Home\Catalogue.cshtml"
using LibraryWebApp.common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b239fbe52399500668d9e8970dd4bd494e37c62", @"/Views/Home/Catalogue.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90e93c59d968b59b56c26f21090a31cb846cc108", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Catalogue : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LibraryWebApp.Models.Catalogue>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Library\LibraryWebApp\Views\Home\Catalogue.cshtml"
  
    ViewData["Title"] = "Catalogue";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<nav class=""navbar navbar-expand-sm bg-dark top-bar fixed-top"">
    <div class=""d-sm-inline-flex"">
        <ul class=""navbar-nav"">
            <li class=""nav-item"">
                <a class=""nav-link"" href=""https://localhost:44315/Home"">Home</a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""https://localhost:44315/Home/Catalogue"">Catalogue</a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""https://localhost:44315/Login/Login"">Login</a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""#"">ContactUs</a>
            </li>
        </ul>
    </div>
</nav>


<h1>Catalogue</h1>


");
#nullable restore
#line 29 "C:\Library\LibraryWebApp\Views\Home\Catalogue.cshtml"
  using (Html.BeginForm("catalogue","Home",FormMethod.Get) )
 {
         

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Library\LibraryWebApp\Views\Home\Catalogue.cshtml"
    Write(Html.TextBox("cmedianame"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<input type=\"submit\" value=\"Search\"/>\r\n");
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n           <!-- <th>\r\n                ");
#nullable restore
#line 37 "C:\Library\LibraryWebApp\Views\Home\Catalogue.cshtml"
           Write(Html.DisplayNameFor(model=>model.mediaid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "C:\Library\LibraryWebApp\Views\Home\Catalogue.cshtml"
           Write(Html.DisplayNameFor(model=>model.mediacheck));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>-->\r\n            <th>\r\n                ");
#nullable restore
#line 43 "C:\Library\LibraryWebApp\Views\Home\Catalogue.cshtml"
           Write(Html.DisplayNameFor(model => model.medianame));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n           <!-- <th>\r\n                ");
#nullable restore
#line 46 "C:\Library\LibraryWebApp\Views\Home\Catalogue.cshtml"
           Write(Html.DisplayNameFor(model => model.mediatype));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>-->\r\n           <!-- <th>\r\n                ");
#nullable restore
#line 49 "C:\Library\LibraryWebApp\Views\Home\Catalogue.cshtml"
           Write(Html.DisplayNameFor(model => model.mediagenre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>-->\r\n            <th>\r\n                ");
#nullable restore
#line 52 "C:\Library\LibraryWebApp\Views\Home\Catalogue.cshtml"
           Write(Html.DisplayNameFor(model => model.mediaauthor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 55 "C:\Library\LibraryWebApp\Views\Home\Catalogue.cshtml"
           Write(Html.DisplayNameFor(model => model.numberofcopies));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n\r\n\r\n\r\n");
#nullable restore
#line 64 "C:\Library\LibraryWebApp\Views\Home\Catalogue.cshtml"
 foreach (var item in Model) 
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <!--  <td>\r\n                <input type=\"checkbox\" data-val=\"true\" id=\"chk@item.mediaid\" name=\"mediacheck\" value=\"true\">\r\n                     <input name=\"mediacheck\" type=\"hidden\" value=\"false\"> \r\n                      ");
#nullable restore
#line 70 "C:\Library\LibraryWebApp\Views\Home\Catalogue.cshtml"
                 Write(Html.CheckBoxFor(modelItem=>item.mediacheck));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n                              \r\n            </td>\r\n            <td>\r\n                 ");
#nullable restore
#line 74 "C:\Library\LibraryWebApp\Views\Home\Catalogue.cshtml"
            Write(Html.DisplayFor(modelItem => item.mediaid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>-->\r\n            <td>\r\n                 ");
#nullable restore
#line 77 "C:\Library\LibraryWebApp\Views\Home\Catalogue.cshtml"
            Write(Html.DisplayFor(modelItem => item.medianame));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n              \r\n            <!-- <td>\r\n                ");
#nullable restore
#line 81 "C:\Library\LibraryWebApp\Views\Home\Catalogue.cshtml"
           Write(Html.DisplayFor(modelItem => item.mediatype));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n             </td>\r\n            <td>\r\n               ");
#nullable restore
#line 84 "C:\Library\LibraryWebApp\Views\Home\Catalogue.cshtml"
          Write(Html.DisplayFor(modelItem => item.mediagenre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>-->\r\n            <td>\r\n                ");
#nullable restore
#line 87 "C:\Library\LibraryWebApp\Views\Home\Catalogue.cshtml"
           Write(Html.DisplayFor(modelItem => item.mediaauthor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n             \r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 91 "C:\Library\LibraryWebApp\Views\Home\Catalogue.cshtml"
           Write(Html.DisplayFor(modelItem => item.numberofcopies));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n               \r\n            </td>\r\n \r\n\r\n         <td>\r\n                ");
#nullable restore
#line 97 "C:\Library\LibraryWebApp\Views\Home\Catalogue.cshtml"
           Write(Html.ActionLink("CheckOut", "Details","MediaCheckout", new { mediaid=item.mediaid }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n                  \r\n          </td>\r\n        </tr>\r\n");
#nullable restore
#line 101 "C:\Library\LibraryWebApp\Views\Home\Catalogue.cshtml"
       
}

#line default
#line hidden
#nullable disable
            WriteLiteral(" </tbody>\r\n</table> \r\n");
#nullable restore
#line 105 "C:\Library\LibraryWebApp\Views\Home\Catalogue.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LibraryWebApp.Models.Catalogue>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
