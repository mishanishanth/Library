#pragma checksum "C:\Library\LibraryWebApp\Views\Login\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3264c32c30a41a24a1182c810bf7ae9f26e5be81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Login), @"mvc.1.0.view", @"/Views/Login/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3264c32c30a41a24a1182c810bf7ae9f26e5be81", @"/Views/Login/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90e93c59d968b59b56c26f21090a31cb846cc108", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Login_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LibraryWebApp.Models.Login>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "C:\Library\LibraryWebApp\Views\Login\Login.cshtml"
  
    ViewData["title"] = "Login";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<nav class=""navbar navbar-expand-sm bg-dark top-bar fixed-top"">
    <div class=""d-sm-inline-flex"">
        <ul class=""navbar-nav"">
            <li class=""nav-item"">
                <a class=""nav-link"" href=""https://localhost:44315/Login"">Home</a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""https://localhost:44315/Home/Catalogue"">Catalogue</a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""https://localhost:44315/Home/Login"">Login</a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""#"">ContactUs</a>
            </li>
        </ul>
    </div>
</nav>


");
#nullable restore
#line 32 "C:\Library\LibraryWebApp\Views\Login\Login.cshtml"
 using (Html.BeginForm("Login","Login",FormMethod.Post) )
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Library\LibraryWebApp\Views\Login\Login.cshtml"
Write(Html.ValidationSummary(true,"",new{@class="text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n        <label for \"name\">Username</label>\r\n    ");
#nullable restore
#line 38 "C:\Library\LibraryWebApp\Views\Login\Login.cshtml"
Write(Html.TextBoxFor(model=>model.username,new{@class="form-control",@placeholder="Enter Username"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 39 "C:\Library\LibraryWebApp\Views\Login\Login.cshtml"
Write(Html.ValidationMessageFor(model=>model.username,"",new{@class="text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n   \r\n    </div>\r\n     <div class=\"form-group\">\r\n        <label for \"password\">Password</label>\r\n    ");
#nullable restore
#line 44 "C:\Library\LibraryWebApp\Views\Login\Login.cshtml"
Write(Html.PasswordFor(model=>model.password,new{@class="form-control",@placeholder="Enter Password"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 45 "C:\Library\LibraryWebApp\Views\Login\Login.cshtml"
Write(Html.ValidationMessageFor(model=>model.password,"",new{@class="text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
    <div>
    <input type=""submit"" value=""Login""  class=""btn btn-primary"" /><span>
    
    <input type=button onclick=""window.location.href='https://localhost:44315/home/Register';"" class=""btn btn-primary"" value=""Register""/>
    </span>
</div>
");
#nullable restore
#line 53 "C:\Library\LibraryWebApp\Views\Login\Login.cshtml"
   
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n    \r\n    \r\n       \r\n    \r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LibraryWebApp.Models.Login> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591