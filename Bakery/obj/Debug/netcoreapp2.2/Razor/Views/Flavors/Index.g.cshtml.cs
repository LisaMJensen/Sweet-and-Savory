#pragma checksum "C:\Users\Leese\Desktop\Sweet-and-Savory\Bakery\Views\Flavors\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad98fb4bcb6649082c9e7446b9194f360002fe5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flavors_Index), @"mvc.1.0.view", @"/Views/Flavors/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Flavors/Index.cshtml", typeof(AspNetCore.Views_Flavors_Index))]
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
#line 4 "C:\Users\Leese\Desktop\Sweet-and-Savory\Bakery\Views\Flavors\Index.cshtml"
using System.Security.Claims;

#line default
#line hidden
#line 5 "C:\Users\Leese\Desktop\Sweet-and-Savory\Bakery\Views\Flavors\Index.cshtml"
using Bakery.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad98fb4bcb6649082c9e7446b9194f360002fe5a", @"/Views/Flavors/Index.cshtml")]
    public class Views_Flavors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Bakery.Models.Flavor>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Leese\Desktop\Sweet-and-Savory\Bakery\Views\Flavors\Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(121, 22, true);
            WriteLiteral("\r\n<h1>Flavors</h1>\r\n\r\n");
            EndContext();
#line 10 "C:\Users\Leese\Desktop\Sweet-and-Savory\Bakery\Views\Flavors\Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
            BeginContext(171, 44, true);
            WriteLiteral("  <h3>No flavors have been added yet!</h3>\r\n");
            EndContext();
#line 13 "C:\Users\Leese\Desktop\Sweet-and-Savory\Bakery\Views\Flavors\Index.cshtml"
} 

#line default
#line hidden
            BeginContext(219, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 15 "C:\Users\Leese\Desktop\Sweet-and-Savory\Bakery\Views\Flavors\Index.cshtml"
 foreach (Flavor flavor in Model)
{

#line default
#line hidden
            BeginContext(259, 6, true);
            WriteLiteral("  <li>");
            EndContext();
            BeginContext(266, 74, false);
#line 17 "C:\Users\Leese\Desktop\Sweet-and-Savory\Bakery\Views\Flavors\Index.cshtml"
 Write(Html.ActionLink($"{flavor.Name}", "Details", new { id = flavor.FlavorId }));

#line default
#line hidden
            EndContext();
            BeginContext(340, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 18 "C:\Users\Leese\Desktop\Sweet-and-Savory\Bakery\Views\Flavors\Index.cshtml"
}

#line default
#line hidden
            BeginContext(350, 5, true);
            WriteLiteral("\r\n<p>");
            EndContext();
            BeginContext(356, 43, false);
#line 20 "C:\Users\Leese\Desktop\Sweet-and-Savory\Bakery\Views\Flavors\Index.cshtml"
Write(Html.ActionLink("Add new flavor", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(399, 11, true);
            WriteLiteral("</p>\r\n\r\n<p>");
            EndContext();
            BeginContext(411, 40, false);
#line 22 "C:\Users\Leese\Desktop\Sweet-and-Savory\Bakery\Views\Flavors\Index.cshtml"
Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(451, 4, true);
            WriteLiteral("</p>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Bakery.Models.Flavor>> Html { get; private set; }
    }
}
#pragma warning restore 1591
