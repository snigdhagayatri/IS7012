#pragma checksum "C:\Users\gnsni\Desktop\7012_DotNet_Final\OnlineVideoGamePortal\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e68a87d332e1a564b66801d478221135f9955cc2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OnlineVideoGamePortal.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(OnlineVideoGamePortal.Pages.Pages_Index), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e68a87d332e1a564b66801d478221135f9955cc2", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66ebb116eb5423875fc5a9788d8e61b13ef0d48a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\gnsni\Desktop\7012_DotNet_Final\OnlineVideoGamePortal\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(71, 1468, true);
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
</div>
<div class=""text-center"" alignment=""justify"">
    <centre><h1><font color=""blue"">Online Video Game Store</font></h1></centre>
</div>
<hr size=""80"" color=""black"">
<p>
    The video game industry is the economic sector involved in the development, marketing, and monetization of video games. It encompasses dozens of job disciplines and its component parts employ thousands of people worldwide.
    This is a video game website which stores all the video games we have in our store located and headquartered at CIncinnati. We keep a record of all the game CD's we have, the number of games purchased,the price of the various games, the amount being charged to the customer, the gamers and their information like their most favourite game and number of games purchased.
    The admin of this website can create, store, edit details of purchases made in the store and also can see what games are being sold most frequently and also keep a check");
            WriteLiteral(@" on the cash transactions as to which mode of payent is being used and which gamer payed money for which game.

</p>
<div class=""row"">
    <div class=""col-md-6"">
        <p>
            <img src=""https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS_4g-rJy00vATsUT4-myYMoSJ9hY4VR6Rd799dPDQa9DvgNo8z"" />
        </p>
    </div>
    <div class=""col-md-6"">
        <h3>DASHBOARD</h3>
        <ul>
            <li>Total Video Games : ");
            EndContext();
            BeginContext(1540, 23, false);
#line 29 "C:\Users\gnsni\Desktop\7012_DotNet_Final\OnlineVideoGamePortal\Pages\Index.cshtml"
                               Write(Model.CountOfVideoGames);

#line default
#line hidden
            EndContext();
            BeginContext(1563, 38, true);
            WriteLiteral("</li>\r\n            <li>Total Gamers : ");
            EndContext();
            BeginContext(1602, 19, false);
#line 30 "C:\Users\gnsni\Desktop\7012_DotNet_Final\OnlineVideoGamePortal\Pages\Index.cshtml"
                          Write(Model.CountOfGamers);

#line default
#line hidden
            EndContext();
            BeginContext(1621, 40, true);
            WriteLiteral("</li>\r\n            <li>Total Purchases: ");
            EndContext();
            BeginContext(1662, 22, false);
#line 31 "C:\Users\gnsni\Desktop\7012_DotNet_Final\OnlineVideoGamePortal\Pages\Index.cshtml"
                            Write(Model.CountOfPurchases);

#line default
#line hidden
            EndContext();
            BeginContext(1684, 50, true);
            WriteLiteral("</li>\r\n            <li>Number of Different Games: ");
            EndContext();
            BeginContext(1735, 27, false);
#line 32 "C:\Users\gnsni\Desktop\7012_DotNet_Final\OnlineVideoGamePortal\Pages\Index.cshtml"
                                      Write(Model.CountOfDifferentGames);

#line default
#line hidden
            EndContext();
            BeginContext(1762, 1071, true);
            WriteLiteral(@"</li>
        </ul>
    </div>
</div>
<h3>Sample URLs to the Manufacturer Profile Page</h3>
<ul>
    <li><a href=""https://localhost:44385/VideoGameProfile"">https://localhost:44385/VideoGameProfile</a></li>
    <li><a href=""https://localhost:44385/PurchaseDetails?purchaseid=1"">https://localhost:44385/PurchaseDetails?purchaseid=1</a></li>
    <li><a href=""https://localhost:44385/PurchaseDetails?purchaseid=2"">https://localhost:44385/PurchaseDetails?purchaseid=2</a></li>
    <li><a href=""https://localhost:44385/GamersProfile"">https://localhost:44385/GamersProfile</a></li>
</ul>
<h3>Custom Forms Navigation</h3>
<ul>
    <li><a href=""https://localhost:44385/searchvideogame"">https://localhost:44385/searchvideogame</a></li>
    <li><a href=""https://localhost:44385/updategamer?id=1"">https://localhost:44385/updategamer?id=1</a></li>
    <li><a href=""https://localhost:44385/updategamer?id=2"">https://localhost:44385/updategamer?id=2</a></li>
    <li><a href=""https://localhost:44385/startpurchase"">https://");
            WriteLiteral("localhost:44385/startpurchase</a></li>\r\n</ul>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
