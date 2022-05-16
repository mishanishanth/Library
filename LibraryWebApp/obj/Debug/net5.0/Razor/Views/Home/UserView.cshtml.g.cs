#pragma checksum "C:\Library\LibraryWebApp\Views\Home\UserView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec9f9f3da3a66d4757f1d25937db139e813fd72f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UserView), @"mvc.1.0.view", @"/Views/Home/UserView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec9f9f3da3a66d4757f1d25937db139e813fd72f", @"/Views/Home/UserView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90e93c59d968b59b56c26f21090a31cb846cc108", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_UserView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LibraryWebApp.Models.UserModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Library\LibraryWebApp\Views\Home\UserView.cshtml"
  
    ViewData["title"] = "UserView";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    <nav class=""navbar navbar-expand-sm bg-dark top-bar fixed-top"">
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
<p>
    <input type=""button"" value=""Register"" onclick=""window.location.href='https://localhost:44315/home/Register';""/>
   <!-- <a asp-action=""Create"">Create New</a>-->
</p>
<table class=""table table-striped"" >
    <thead>
        <tr>
            <th>
                ");
#nullable restore
#line 34 "C:\Library\LibraryWebApp\Views\Home\UserView.cshtml"
           Write(Html.DisplayNameFor(model => model.userid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\Library\LibraryWebApp\Views\Home\UserView.cshtml"
           Write(Html.DisplayNameFor(model => model.username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            \r\n            <th>\r\n                ");
#nullable restore
#line 41 "C:\Library\LibraryWebApp\Views\Home\UserView.cshtml"
           Write(Html.DisplayNameFor(model => model.firstname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 44 "C:\Library\LibraryWebApp\Views\Home\UserView.cshtml"
           Write(Html.DisplayNameFor(model => model.lastname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n                   \r\n                      \r\n            </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 51 "C:\Library\LibraryWebApp\Views\Home\UserView.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n             <td>\r\n                ");
#nullable restore
#line 54 "C:\Library\LibraryWebApp\Views\Home\UserView.cshtml"
           Write(Html.DisplayFor(modelItem => item.userid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 57 "C:\Library\LibraryWebApp\Views\Home\UserView.cshtml"
           Write(Html.DisplayFor(modelItem => item.username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            \r\n            <td>\r\n                ");
#nullable restore
#line 61 "C:\Library\LibraryWebApp\Views\Home\UserView.cshtml"
           Write(Html.DisplayFor(modelItem => item.firstname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 64 "C:\Library\LibraryWebApp\Views\Home\UserView.cshtml"
           Write(Html.DisplayFor(modelItem => item.lastname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>        \r\n            \r\n        <td>\r\n                ");
#nullable restore
#line 68 "C:\Library\LibraryWebApp\Views\Home\UserView.cshtml"
           Write(Html.ActionLink("Edit","EditUser" ,"User", new{userid=item.userid}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 69 "C:\Library\LibraryWebApp\Views\Home\UserView.cshtml"
           Write(Html.ActionLink("Details", "UserDetails","User", new{userid=item.userid }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n             </td>\r\n        </tr>\r\n");
#nullable restore
#line 72 "C:\Library\LibraryWebApp\Views\Home\UserView.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LibraryWebApp.Models.UserModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
