#pragma checksum "/Users/deauntehall/Desktop/Factory.Solution/Factory/Views/Engineers/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d078d830a4e6b0f8bf3a324ed17752e5182011ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Engineers_Create), @"mvc.1.0.view", @"/Views/Engineers/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d078d830a4e6b0f8bf3a324ed17752e5182011ca", @"/Views/Engineers/Create.cshtml")]
    public class Views_Engineers_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Factory.Models.Engineer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/deauntehall/Desktop/Factory.Solution/Factory/Views/Engineers/Create.cshtml"
  
  Layout = "_EngineerLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Add a new engineer</h1>\n\n");
#nullable restore
#line 8 "/Users/deauntehall/Desktop/Factory.Solution/Factory/Views/Engineers/Create.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/deauntehall/Desktop/Factory.Solution/Factory/Views/Engineers/Create.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/deauntehall/Desktop/Factory.Solution/Factory/Views/Engineers/Create.cshtml"
Write(Html.TextBoxFor(model => model.Name, new { required="required" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/deauntehall/Desktop/Factory.Solution/Factory/Views/Engineers/Create.cshtml"
Write(Html.Label("Select machine"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/deauntehall/Desktop/Factory.Solution/Factory/Views/Engineers/Create.cshtml"
Write(Html.DropDownList("MachineId", (SelectList)ViewBag.MachineId, "None"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"submit\" value=\"Add new machine\" />\n");
#nullable restore
#line 16 "/Users/deauntehall/Desktop/Factory.Solution/Factory/Views/Engineers/Create.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Factory.Models.Engineer> Html { get; private set; }
    }
}
#pragma warning restore 1591
