#pragma checksum "C:\Library\LibraryWebApp\Views\Mediacheckout\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30126b48d38b688274753b0e162874404b5c5ffa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mediacheckout_Checkout), @"mvc.1.0.view", @"/Views/Mediacheckout/Checkout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30126b48d38b688274753b0e162874404b5c5ffa", @"/Views/Mediacheckout/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90e93c59d968b59b56c26f21090a31cb846cc108", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Mediacheckout_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LibraryWebApp.Models.Mediacheckout>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Library\LibraryWebApp\Views\Mediacheckout\Checkout.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30126b48d38b688274753b0e162874404b5c5ffa3940", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Checkout</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30126b48d38b688274753b0e162874404b5c5ffa5002", async() => {
                WriteLiteral("\r\n<p>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30126b48d38b688274753b0e162874404b5c5ffa5271", async() => {
                    WriteLiteral("Create New");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n</p>\r\n");
#nullable restore
#line 18 "C:\Library\LibraryWebApp\Views\Mediacheckout\Checkout.cshtml"
  using (Html.BeginForm("Checkout","Mediacheckout",FormMethod.Get) )
 {

#line default
#line hidden
#nullable disable
                WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\Library\LibraryWebApp\Views\Mediacheckout\Checkout.cshtml"
           Write(Html.DisplayNameFor(model => model.mediaid));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\Library\LibraryWebApp\Views\Mediacheckout\Checkout.cshtml"
           Write(Html.DisplayNameFor(model => model.medianame));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "C:\Library\LibraryWebApp\Views\Mediacheckout\Checkout.cshtml"
           Write(Html.DisplayNameFor(model => model.mediacheck));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "C:\Library\LibraryWebApp\Views\Mediacheckout\Checkout.cshtml"
           Write(Html.DisplayNameFor(model => model.numberofcopies));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 39 "C:\Library\LibraryWebApp\Views\Mediacheckout\Checkout.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 42 "C:\Library\LibraryWebApp\Views\Mediacheckout\Checkout.cshtml"
           Write(Html.DisplayFor(modelItem => item.mediaid));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 45 "C:\Library\LibraryWebApp\Views\Mediacheckout\Checkout.cshtml"
           Write(Html.DisplayFor(modelItem => item.medianame));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 48 "C:\Library\LibraryWebApp\Views\Mediacheckout\Checkout.cshtml"
           Write(Html.CheckBoxFor(modelItem => item.mediacheck));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 49 "C:\Library\LibraryWebApp\Views\Mediacheckout\Checkout.cshtml"
           Write(Html.HiddenFor(modelItem=>item.mediacheck));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Library\LibraryWebApp\Views\Mediacheckout\Checkout.cshtml"
           Write(Html.DisplayFor(modelItem => item.numberofcopies));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Library\LibraryWebApp\Views\Mediacheckout\Checkout.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" |\r\n                ");
#nullable restore
#line 56 "C:\Library\LibraryWebApp\Views\Mediacheckout\Checkout.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" |\r\n                ");
#nullable restore
#line 57 "C:\Library\LibraryWebApp\Views\Mediacheckout\Checkout.cshtml"
           Write(Html.ActionLink("FCheckout", "Checkout", new { id=item.mediaid }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 60 "C:\Library\LibraryWebApp\Views\Mediacheckout\Checkout.cshtml"
}

#line default
#line hidden
#nullable disable
                WriteLiteral("    </tbody>\r\n</table>\r\n<div>\r\n");
#nullable restore
#line 64 "C:\Library\LibraryWebApp\Views\Mediacheckout\Checkout.cshtml"
      using (Html.BeginForm("Submit","Mediacheckout") )
     {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <input type=\"submit\" value=\"Checkout\"  class=\"btn btn-primary\" />\r\n");
#nullable restore
#line 67 "C:\Library\LibraryWebApp\Views\Mediacheckout\Checkout.cshtml"
     }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n");
#nullable restore
#line 69 "C:\Library\LibraryWebApp\Views\Mediacheckout\Checkout.cshtml"
 }

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LibraryWebApp.Models.Mediacheckout>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591