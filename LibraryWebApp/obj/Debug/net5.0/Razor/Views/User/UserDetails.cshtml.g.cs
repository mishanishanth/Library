#pragma checksum "C:\Library\LibraryWebApp\Views\User\UserDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7dcc1abe4e25ddb29a13478ebbb856ef04990f6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_UserDetails), @"mvc.1.0.view", @"/Views/User/UserDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7dcc1abe4e25ddb29a13478ebbb856ef04990f6a", @"/Views/User/UserDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90e93c59d968b59b56c26f21090a31cb846cc108", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_UserDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LibraryWebApp.Models.UserModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
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
<div >
    <table class=""table table-striped table-sm"" >
        <tr>
            <th>User Id </th>
            <td>");
#nullable restore
#line 29 "C:\Library\LibraryWebApp\Views\User\UserDetails.cshtml"
           Write(Model.userid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n            <th>User Name </th>\r\n            <td>");
#nullable restore
#line 33 "C:\Library\LibraryWebApp\Views\User\UserDetails.cshtml"
           Write(Model.username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n        </tr>\r\n         <tr>\r\n            <th>User Email </th>\r\n            <td>");
#nullable restore
#line 38 "C:\Library\LibraryWebApp\Views\User\UserDetails.cshtml"
           Write(Model.emailid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n         <tr>\r\n            <th>Password </th>\r\n            <td>");
#nullable restore
#line 42 "C:\Library\LibraryWebApp\Views\User\UserDetails.cshtml"
           Write(Model.password);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n         <tr>\r\n            <th>Firstname </th>\r\n            <td>");
#nullable restore
#line 46 "C:\Library\LibraryWebApp\Views\User\UserDetails.cshtml"
           Write(Model.firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th>Lastname </th>\r\n            <td>");
#nullable restore
#line 50 "C:\Library\LibraryWebApp\Views\User\UserDetails.cshtml"
           Write(Model.lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n         <tr>\r\n            <th>Phone Number </th>\r\n            <td>");
#nullable restore
#line 54 "C:\Library\LibraryWebApp\Views\User\UserDetails.cshtml"
           Write(Model.lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n         <tr>\r\n            <th>PinCode </th>\r\n            <td>");
#nullable restore
#line 58 "C:\Library\LibraryWebApp\Views\User\UserDetails.cshtml"
           Write(Model.pincode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n         <tr>\r\n            <th>Street Address</th>\r\n            <td>");
#nullable restore
#line 62 "C:\Library\LibraryWebApp\Views\User\UserDetails.cshtml"
           Write(Model.streetaddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n         <tr>\r\n            <th>City</th>\r\n            <td>");
#nullable restore
#line 66 "C:\Library\LibraryWebApp\Views\User\UserDetails.cshtml"
           Write(Model.city);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n         <tr>\r\n            <th>Account Status </th>\r\n            <td>");
#nullable restore
#line 70 "C:\Library\LibraryWebApp\Views\User\UserDetails.cshtml"
           Write(Model.accountstatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n\r\n    </table>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LibraryWebApp.Models.UserModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
