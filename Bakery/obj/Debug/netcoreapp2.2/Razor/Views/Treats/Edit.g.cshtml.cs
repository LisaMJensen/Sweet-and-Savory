#pragma checksum "C:\Users\Leese\Desktop\Sweet-and-Savory\Bakery\Views\Treats\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b56b4eaf4b4aae10e253cc2d74523b1f173c03e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Treats_Edit), @"mvc.1.0.view", @"/Views/Treats/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Treats/Edit.cshtml", typeof(AspNetCore.Views_Treats_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b56b4eaf4b4aae10e253cc2d74523b1f173c03e", @"/Views/Treats/Edit.cshtml")]
    public class Views_Treats_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bakery.Models.Treat>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Leese\Desktop\Sweet-and-Savory\Bakery\Views\Treats\Edit.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(60, 40, true);
            WriteLiteral("\r\n<h2>Edit</h2>\r\n\r\n<h4>Edit this treat: ");
            EndContext();
            BeginContext(101, 43, false);
#line 9 "C:\Users\Leese\Desktop\Sweet-and-Savory\Bakery\Views\Treats\Edit.cshtml"
                Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(144, 9, true);
            WriteLiteral("</h4>\r\n\r\n");
            EndContext();
#line 11 "C:\Users\Leese\Desktop\Sweet-and-Savory\Bakery\Views\Treats\Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(188, 38, false);
#line 13 "C:\Users\Leese\Desktop\Sweet-and-Savory\Bakery\Views\Treats\Edit.cshtml"
Write(Html.HiddenFor(model => model.TreatId));

#line default
#line hidden
            EndContext();
            BeginContext(235, 41, false);
#line 15 "C:\Users\Leese\Desktop\Sweet-and-Savory\Bakery\Views\Treats\Edit.cshtml"
Write(Html.LabelFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(283, 42, false);
#line 16 "C:\Users\Leese\Desktop\Sweet-and-Savory\Bakery\Views\Treats\Edit.cshtml"
Write(Html.EditorFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(334, 27, false);
#line 18 "C:\Users\Leese\Desktop\Sweet-and-Savory\Bakery\Views\Treats\Edit.cshtml"
Write(Html.Label("Select flavor"));

#line default
#line hidden
            EndContext();
            BeginContext(368, 29, false);
#line 19 "C:\Users\Leese\Desktop\Sweet-and-Savory\Bakery\Views\Treats\Edit.cshtml"
Write(Html.DropDownList("FlavorId"));

#line default
#line hidden
            EndContext();
            BeginContext(401, 42, true);
            WriteLiteral("    <input type=\"submit\" value=\"Save\" />\r\n");
            EndContext();
#line 22 "C:\Users\Leese\Desktop\Sweet-and-Savory\Bakery\Views\Treats\Edit.cshtml"
}

#line default
#line hidden
            BeginContext(446, 5, true);
            WriteLiteral("\r\n<p>");
            EndContext();
            BeginContext(452, 40, false);
#line 24 "C:\Users\Leese\Desktop\Sweet-and-Savory\Bakery\Views\Treats\Edit.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(492, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bakery.Models.Treat> Html { get; private set; }
    }
}
#pragma warning restore 1591
