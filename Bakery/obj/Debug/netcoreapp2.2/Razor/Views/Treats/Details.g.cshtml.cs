#pragma checksum "C:\Users\Leese\Desktop\Sweet-and-Savory\Bakery\Views\Treats\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c35d76ad3f2f8d5da77c4348b44262729860cde"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Treats_Details), @"mvc.1.0.view", @"/Views/Treats/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Treats/Details.cshtml", typeof(AspNetCore.Views_Treats_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c35d76ad3f2f8d5da77c4348b44262729860cde", @"/Views/Treats/Details.cshtml")]
    public class Views_Treats_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bakery.Models.Treat>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Leese\Desktop\Sweet-and-Savory\Bakery\Views\Treats\Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(60, 38, true);
            WriteLiteral("\r\n<h2>Treat Details</h2>\r\n<hr />\r\n<h3>");
            EndContext();
            BeginContext(99, 47, false);
#line 9 "C:\Users\Leese\Desktop\Sweet-and-Savory\Bakery\Views\Treats\Details.cshtml"
Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(146, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(149, 43, false);
#line 9 "C:\Users\Leese\Desktop\Sweet-and-Savory\Bakery\Views\Treats\Details.cshtml"
                                                 Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(192, 9, true);
            WriteLiteral("</h3>\r\n\r\n");
            EndContext();
#line 11 "C:\Users\Leese\Desktop\Sweet-and-Savory\Bakery\Views\Treats\Details.cshtml"
 if(@Model.Flavors.Count == 0)
{

#line default
#line hidden
            BeginContext(236, 52, true);
            WriteLiteral("  <p>This treat does not belong to any flavors</p>\r\n");
            EndContext();
#line 14 "C:\Users\Leese\Desktop\Sweet-and-Savory\Bakery\Views\Treats\Details.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(300, 43, true);
            WriteLiteral("  <h4>Flavors the treat has:</h4>\r\n  <ul>\r\n");
            EndContext();
#line 19 "C:\Users\Leese\Desktop\Sweet-and-Savory\Bakery\Views\Treats\Details.cshtml"
   foreach(var join in Model.Flavors)
  {

#line default
#line hidden
            BeginContext(387, 8, true);
            WriteLiteral("    <li>");
            EndContext();
            BeginContext(396, 16, false);
#line 21 "C:\Users\Leese\Desktop\Sweet-and-Savory\Bakery\Views\Treats\Details.cshtml"
   Write(join.Flavor.Name);

#line default
#line hidden
            EndContext();
            BeginContext(412, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 22 "C:\Users\Leese\Desktop\Sweet-and-Savory\Bakery\Views\Treats\Details.cshtml"
     using (Html.BeginForm("DeleteFlavor", "Treats"))
    {
      

#line default
#line hidden
            BeginContext(488, 42, false);
#line 24 "C:\Users\Leese\Desktop\Sweet-and-Savory\Bakery\Views\Treats\Details.cshtml"
 Write(Html.Hidden("joinId", @join.FlavorTreatId));

#line default
#line hidden
            EndContext();
            BeginContext(532, 45, true);
            WriteLiteral("      <input type=\"submit\" value=\"Delete\"/>\r\n");
            EndContext();
#line 26 "C:\Users\Leese\Desktop\Sweet-and-Savory\Bakery\Views\Treats\Details.cshtml"
    }

#line default
#line hidden
#line 26 "C:\Users\Leese\Desktop\Sweet-and-Savory\Bakery\Views\Treats\Details.cshtml"
     
  }

#line default
#line hidden
            BeginContext(589, 9, true);
            WriteLiteral("  </ul>\r\n");
            EndContext();
#line 29 "C:\Users\Leese\Desktop\Sweet-and-Savory\Bakery\Views\Treats\Details.cshtml"
}

#line default
#line hidden
            BeginContext(601, 5, true);
            WriteLiteral("\r\n<p>");
            EndContext();
            BeginContext(607, 40, false);
#line 31 "C:\Users\Leese\Desktop\Sweet-and-Savory\Bakery\Views\Treats\Details.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(647, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(657, 65, false);
#line 32 "C:\Users\Leese\Desktop\Sweet-and-Savory\Bakery\Views\Treats\Details.cshtml"
Write(Html.ActionLink("Edit Treat", "Edit", new { id = Model.TreatId }));

#line default
#line hidden
            EndContext();
            BeginContext(722, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(732, 72, false);
#line 33 "C:\Users\Leese\Desktop\Sweet-and-Savory\Bakery\Views\Treats\Details.cshtml"
Write(Html.ActionLink("Add a Flavor", "AddFlavor", new { id = Model.TreatId }));

#line default
#line hidden
            EndContext();
            BeginContext(804, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(814, 69, false);
#line 34 "C:\Users\Leese\Desktop\Sweet-and-Savory\Bakery\Views\Treats\Details.cshtml"
Write(Html.ActionLink("Delete Treat", "Delete", new { id = Model.TreatId }));

#line default
#line hidden
            EndContext();
            BeginContext(883, 4, true);
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
