#pragma checksum "C:\Library\LibraryWebApp\Views\User\EditUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12222056a39aba4b14bb5e3bd5d72bd5a6a7b7b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_EditUser), @"mvc.1.0.view", @"/Views/User/EditUser.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12222056a39aba4b14bb5e3bd5d72bd5a6a7b7b1", @"/Views/User/EditUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90e93c59d968b59b56c26f21090a31cb846cc108", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_EditUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LibraryWebApp.Models.UserModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Library\LibraryWebApp\Views\User\EditUser.cshtml"
   using (Html.BeginForm("EditUser","User",FormMethod.Get) )
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n     <label for \"username\">User ID</label>\r\n    ");
#nullable restore
#line 12 "C:\Library\LibraryWebApp\Views\User\EditUser.cshtml"
Write(Html.TextBoxFor(m=>m.userid,new{@class="form-control",@placeholder="UserID",@readonly="readonly"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <label for \"username\">UserName</label>\r\n    ");
#nullable restore
#line 14 "C:\Library\LibraryWebApp\Views\User\EditUser.cshtml"
Write(Html.TextBoxFor(m=>m.username,new{@class="form-control",@placeholder="Enter Username"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n     ");
#nullable restore
#line 15 "C:\Library\LibraryWebApp\Views\User\EditUser.cshtml"
Write(Html.ValidationMessageFor(model=>model.username,"",new{@class="text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n    <label for \"password\">Password</label>\r\n    ");
#nullable restore
#line 20 "C:\Library\LibraryWebApp\Views\User\EditUser.cshtml"
Write(Html.PasswordFor(m=>m.password,new{@class="form-control",@placeholder="Enter Password"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 21 "C:\Library\LibraryWebApp\Views\User\EditUser.cshtml"
Write(Html.ValidationMessageFor(model=>model.username,"",new{@class="text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
            WriteLiteral("<div class=\"form-group\">\r\n    <label for \"firstname\">FirstName</label>\r\n    ");
#nullable restore
#line 28 "C:\Library\LibraryWebApp\Views\User\EditUser.cshtml"
Write(Html.TextBoxFor(m=>m.firstname,new{@class="form-control",@placeholder="Enter Firstname",@readonly="readonly"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div class=\"form-group\">\r\n    <label for \"lasttname\">LastName</label>\r\n    ");
#nullable restore
#line 32 "C:\Library\LibraryWebApp\Views\User\EditUser.cshtml"
Write(Html.TextBoxFor(m=>m.lastname,new{@class="form-control",@placeholder="Enter lastname"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
            WriteLiteral("<div class=\"form-group\">\r\n    <label for \"email\">EmailId</label>\r\n    ");
#nullable restore
#line 37 "C:\Library\LibraryWebApp\Views\User\EditUser.cshtml"
Write(Html.TextBoxFor(m=>m.emailid,new{@class="form-control",@placeholder="Enter EmailId"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 38 "C:\Library\LibraryWebApp\Views\User\EditUser.cshtml"
Write(Html.ValidationMessageFor(model=>model.username,"",new{@class="text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
            WriteLiteral("<div class=\"form-group\">\r\n    <label for \"staddress\">Street Address</label>\r\n    ");
#nullable restore
#line 44 "C:\Library\LibraryWebApp\Views\User\EditUser.cshtml"
Write(Html.TextBoxFor(m=>m.streetaddress,new{@class="form-control",@placeholder="Enter StreetAddress"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div class=\"form-group\">\r\n    <label for \"city\">City</label>\r\n    ");
#nullable restore
#line 48 "C:\Library\LibraryWebApp\Views\User\EditUser.cshtml"
Write(Html.TextBoxFor(m=>m.city,new{@class="form-control",@placeholder="Enter City"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
            WriteLiteral("<div class=\"form-group\">\r\n    <label for \"pincode\">PinCode</label>\r\n    ");
#nullable restore
#line 53 "C:\Library\LibraryWebApp\Views\User\EditUser.cshtml"
Write(Html.TextBoxFor(m=>m.pincode,new{@class="form-control",@placeholder="Enter Pincode"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
            WriteLiteral("<div class=\"form-group\">\r\n    <label for \"phoneno\">PhoneNo</label>\r\n    ");
#nullable restore
#line 58 "C:\Library\LibraryWebApp\Views\User\EditUser.cshtml"
Write(Html.TextBoxFor(m=>m.phoneno,new{@class="form-control",@placeholder="Enter PhoneNo"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
            WriteLiteral("<div class=\"form-group\">\r\n    <label for \"accountinfo\">Account Status</label>\r\n  <!--  ");
#nullable restore
#line 63 "C:\Library\LibraryWebApp\Views\User\EditUser.cshtml"
   Write(Html.TextBoxFor(m=>m.accountstatus,new{@class="form-control",@placeholder="Enter Account Status"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" -->\r\n    ");
#nullable restore
#line 64 "C:\Library\LibraryWebApp\Views\User\EditUser.cshtml"
Write(Html.DropDownListFor(m=>m.accountstatus,new SelectList(ViewBag.accountstatus),new {style="width: 1110px;"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
            WriteLiteral("<div class=\"form-group\">\r\n    <label for \"roleinfo\">Roles</label>\r\n  <!--  ");
#nullable restore
#line 69 "C:\Library\LibraryWebApp\Views\User\EditUser.cshtml"
   Write(Html.TextBoxFor(m=>m.role,new{@class="form-control",@placeholder="Enter Role Name"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" -->\r\n    ");
#nullable restore
#line 70 "C:\Library\LibraryWebApp\Views\User\EditUser.cshtml"
Write(Html.DropDownListFor(m=>m.role,new SelectList(ViewBag.rolelist),new {style="width: 1110px;"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
            WriteLiteral("<div>\r\n    <input type=\"submit\" value=\"submit\"  class=\"btn btn-primary\" formmethod=\"post\"/>\r\n</div>\r\n");
#nullable restore
#line 76 "C:\Library\LibraryWebApp\Views\User\EditUser.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n");
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