#pragma checksum "C:\Users\gnsni\Desktop\7012_DotNet_Final\OnlineVideoGamePortal\Pages\GamersProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5596007aea3707f52c54c1b3f8926b689f2ae356"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OnlineVideoGamePortal.Pages.Pages_GamersProfile), @"mvc.1.0.razor-page", @"/Pages/GamersProfile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/GamersProfile.cshtml", typeof(OnlineVideoGamePortal.Pages.Pages_GamersProfile), null)]
namespace OnlineVideoGamePortal.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\gnsni\Desktop\7012_DotNet_Final\OnlineVideoGamePortal\Pages\_ViewImports.cshtml"
using OnlineVideoGamePortal;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5596007aea3707f52c54c1b3f8926b689f2ae356", @"/Pages/GamersProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66ebb116eb5423875fc5a9788d8e61b13ef0d48a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_GamersProfile : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\gnsni\Desktop\7012_DotNet_Final\OnlineVideoGamePortal\Pages\GamersProfile.cshtml"
  
    ViewData["Title"] = "Profile Of All Gamers";

#line default
#line hidden
            BeginContext(119, 271, true);
            WriteLiteral(@"
<h1 class=""text-center"">Gamers Listed</h1>
<hr />
<table class=""table table-bordered table-striped"">
    <thead>
        <tr>
            <th>Name</th>
            <th>Age</th>
            <th>Preferred Video Game</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 18 "C:\Users\gnsni\Desktop\7012_DotNet_Final\OnlineVideoGamePortal\Pages\GamersProfile.cshtml"
         foreach (var mob in Model.Gamers)
        {


#line default
#line hidden
            BeginContext(447, 57, true);
            WriteLiteral("            <tr style=\"color:blue\">\r\n                <td>");
            EndContext();
            BeginContext(505, 8, false);
#line 22 "C:\Users\gnsni\Desktop\7012_DotNet_Final\OnlineVideoGamePortal\Pages\GamersProfile.cshtml"
               Write(mob.Name);

#line default
#line hidden
            EndContext();
            BeginContext(513, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(541, 7, false);
#line 23 "C:\Users\gnsni\Desktop\7012_DotNet_Final\OnlineVideoGamePortal\Pages\GamersProfile.cshtml"
               Write(mob.Age);

#line default
#line hidden
            EndContext();
            BeginContext(548, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(576, 22, false);
#line 24 "C:\Users\gnsni\Desktop\7012_DotNet_Final\OnlineVideoGamePortal\Pages\GamersProfile.cshtml"
               Write(mob.PreferredVideoGame);

#line default
#line hidden
            EndContext();
            BeginContext(598, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 26 "C:\Users\gnsni\Desktop\7012_DotNet_Final\OnlineVideoGamePortal\Pages\GamersProfile.cshtml"
        }

#line default
#line hidden
            BeginContext(635, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineVideoGamePortal.Pages.GamersProfileModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OnlineVideoGamePortal.Pages.GamersProfileModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OnlineVideoGamePortal.Pages.GamersProfileModel>)PageContext?.ViewData;
        public OnlineVideoGamePortal.Pages.GamersProfileModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
