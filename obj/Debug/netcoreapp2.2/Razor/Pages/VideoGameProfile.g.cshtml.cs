#pragma checksum "C:\Users\gnsni\Desktop\7012_DotNet_Final\OnlineVideoGamePortal\Pages\VideoGameProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb15bff8ac2dd0e42a69cbbd8b4ab80a2f03eb43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OnlineVideoGamePortal.Pages.Pages_VideoGameProfile), @"mvc.1.0.razor-page", @"/Pages/VideoGameProfile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/VideoGameProfile.cshtml", typeof(OnlineVideoGamePortal.Pages.Pages_VideoGameProfile), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb15bff8ac2dd0e42a69cbbd8b4ab80a2f03eb43", @"/Pages/VideoGameProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66ebb116eb5423875fc5a9788d8e61b13ef0d48a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_VideoGameProfile : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\gnsni\Desktop\7012_DotNet_Final\OnlineVideoGamePortal\Pages\VideoGameProfile.cshtml"
  
    ViewData["Title"] = "VideoGameProfile";

#line default
#line hidden
            BeginContext(117, 281, true);
            WriteLiteral(@"
<h1 class=""text-center"">Video Game Details</h1>
<hr />
<table class=""table table-bordered table-striped"">
    <thead>
        <tr>
            <th>Video Game Name</th>
            <th>Release Date</th>
            <th>Price</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 18 "C:\Users\gnsni\Desktop\7012_DotNet_Final\OnlineVideoGamePortal\Pages\VideoGameProfile.cshtml"
         foreach (var mob in Model.VideoGame)
        {

#line default
#line hidden
            BeginContext(456, 57, true);
            WriteLiteral("            <tr style=\"color:blue\">\r\n                <td>");
            EndContext();
            BeginContext(514, 9, false);
#line 21 "C:\Users\gnsni\Desktop\7012_DotNet_Final\OnlineVideoGamePortal\Pages\VideoGameProfile.cshtml"
               Write(mob.Title);

#line default
#line hidden
            EndContext();
            BeginContext(523, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(551, 15, false);
#line 22 "C:\Users\gnsni\Desktop\7012_DotNet_Final\OnlineVideoGamePortal\Pages\VideoGameProfile.cshtml"
               Write(mob.ReleaseDate);

#line default
#line hidden
            EndContext();
            BeginContext(566, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(594, 9, false);
#line 23 "C:\Users\gnsni\Desktop\7012_DotNet_Final\OnlineVideoGamePortal\Pages\VideoGameProfile.cshtml"
               Write(mob.Price);

#line default
#line hidden
            EndContext();
            BeginContext(603, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 25 "C:\Users\gnsni\Desktop\7012_DotNet_Final\OnlineVideoGamePortal\Pages\VideoGameProfile.cshtml"
        }

#line default
#line hidden
            BeginContext(640, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineVideoGamePortal.Pages.VideoGameProfileModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OnlineVideoGamePortal.Pages.VideoGameProfileModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OnlineVideoGamePortal.Pages.VideoGameProfileModel>)PageContext?.ViewData;
        public OnlineVideoGamePortal.Pages.VideoGameProfileModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591