#pragma checksum "/Users/Guest/Desktop/Sweet-and-Savory/Bakery/Views/Account/Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07cb01e8671666b0f85b4801d0f8ebb171d46cd8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Login), @"mvc.1.0.view", @"/Views/Account/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Login.cshtml", typeof(AspNetCore.Views_Account_Login))]
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
#line 5 "/Users/Guest/Desktop/Sweet-and-Savory/Bakery/Views/Account/Login.cshtml"
using Bakery.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07cb01e8671666b0f85b4801d0f8ebb171d46cd8", @"/Views/Account/Login.cshtml")]
    public class Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoginViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/Sweet-and-Savory/Bakery/Views/Account/Login.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(53, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(76, 42, true);
            WriteLiteral("\n<h2>Log in with your account</h2>\n<hr />\n");
            EndContext();
#line 11 "/Users/Guest/Desktop/Sweet-and-Savory/Bakery/Views/Account/Login.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(151, 27, false);
#line 13 "/Users/Guest/Desktop/Sweet-and-Savory/Bakery/Views/Account/Login.cshtml"
Write(Html.LabelFor(m => m.Email));

#line default
#line hidden
            EndContext();
            BeginContext(184, 29, false);
#line 14 "/Users/Guest/Desktop/Sweet-and-Savory/Bakery/Views/Account/Login.cshtml"
Write(Html.TextBoxFor(m => m.Email));

#line default
#line hidden
            EndContext();
            BeginContext(220, 30, false);
#line 16 "/Users/Guest/Desktop/Sweet-and-Savory/Bakery/Views/Account/Login.cshtml"
Write(Html.LabelFor(m => m.Password));

#line default
#line hidden
            EndContext();
            BeginContext(256, 33, false);
#line 17 "/Users/Guest/Desktop/Sweet-and-Savory/Bakery/Views/Account/Login.cshtml"
Write(Html.PasswordFor(m => m.Password));

#line default
#line hidden
            EndContext();
            BeginContext(291, 67, true);
            WriteLiteral("    <input type=\"submit\" value=\"Log in\" class=\"btn btn-default\" />\n");
            EndContext();
#line 20 "/Users/Guest/Desktop/Sweet-and-Savory/Bakery/Views/Account/Login.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoginViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
