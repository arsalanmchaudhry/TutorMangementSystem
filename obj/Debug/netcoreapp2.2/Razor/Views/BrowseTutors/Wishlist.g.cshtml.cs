#pragma checksum "C:\Users\arsal\Desktop\TMS\TutorMangementSystem\Views\BrowseTutors\Wishlist.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7110166d99e28ff765d0d8afe86f38e02ae7d3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BrowseTutors_Wishlist), @"mvc.1.0.view", @"/Views/BrowseTutors/Wishlist.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/BrowseTutors/Wishlist.cshtml", typeof(AspNetCore.Views_BrowseTutors_Wishlist))]
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
#line 1 "C:\Users\arsal\Desktop\TMS\TutorMangementSystem\Views\_ViewImports.cshtml"
using TutorMangementSystem;

#line default
#line hidden
#line 2 "C:\Users\arsal\Desktop\TMS\TutorMangementSystem\Views\_ViewImports.cshtml"
using TutorMangementSystem.Models;

#line default
#line hidden
#line 1 "C:\Users\arsal\Desktop\TMS\TutorMangementSystem\Views\BrowseTutors\Wishlist.cshtml"
using TutorMangementSystem.Models.ReserveModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7110166d99e28ff765d0d8afe86f38e02ae7d3b", @"/Views/BrowseTutors/Wishlist.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"048df9abc10abc6bc76751075d6f52bb55c42fcc", @"/Views/_ViewImports.cshtml")]
    public class Views_BrowseTutors_Wishlist : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TutorMangementSystem.Models.ReserveModels.ReserveModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(113, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\arsal\Desktop\TMS\TutorMangementSystem\Views\BrowseTutors\Wishlist.cshtml"
  
     ViewBag.Title = @Model.Tutor;

#line default
#line hidden
            BeginContext(158, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            BeginContext(199, 327, true);
            WriteLiteral(@"

<h1>Wishlist</h1>

<div class=""container"">
    <div class=""header clearfix detailHeading"">
        <h2 class=""text-muted"">Place Tutor in Wishlist</h2>
    </div>

    <div class=""jumbotron"">
        <div class=""row"">
            <div class=""col-md-3"">
                <div>
                    <p id=""itemTitle"">");
            EndContext();
            BeginContext(527, 11, false);
#line 24 "C:\Users\arsal\Desktop\TMS\TutorMangementSystem\Views\BrowseTutors\Wishlist.cshtml"
                                 Write(Model.Tutor);

#line default
#line hidden
            EndContext();
            BeginContext(538, 51, true);
            WriteLiteral(" </p>\r\n                    <img class=\"detailImage\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 589, "\"", 606, 2);
#line 25 "C:\Users\arsal\Desktop\TMS\TutorMangementSystem\Views\BrowseTutors\Wishlist.cshtml"
WriteAttributeValue("", 595, Model.IMG, 595, 10, false);

#line default
#line hidden
            WriteAttributeValue(" ", 605, "", 606, 1, true);
            EndWriteAttribute();
            BeginContext(607, 137, true);
            WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n           \r\n            <div class=\"col-md-9\">\r\n                <p>There are currently ");
            EndContext();
            BeginContext(745, 19, false);
#line 30 "C:\Users\arsal\Desktop\TMS\TutorMangementSystem\Views\BrowseTutors\Wishlist.cshtml"
                                  Write(Model.WishlistCount);

#line default
#line hidden
            EndContext();
            BeginContext(764, 57, true);
            WriteLiteral(" holds in the queue for this item.</p>\r\n               \r\n");
            EndContext();
#line 32 "C:\Users\arsal\Desktop\TMS\TutorMangementSystem\Views\BrowseTutors\Wishlist.cshtml"
                 using (Html.BeginForm("AddToWishlist", "BrowseTutors", FormMethod.Post))
                {
                    

#line default
#line hidden
            BeginContext(952, 30, false);
#line 34 "C:\Users\arsal\Desktop\TMS\TutorMangementSystem\Views\BrowseTutors\Wishlist.cshtml"
               Write(Html.HiddenFor(a => a.TutorId));

#line default
#line hidden
            EndContext();
            BeginContext(984, 108, true);
            WriteLiteral("                    <div>\r\n                        Please insert a Member Card ID.\r\n                        ");
            EndContext();
            BeginContext(1093, 32, false);
#line 37 "C:\Users\arsal\Desktop\TMS\TutorMangementSystem\Views\BrowseTutors\Wishlist.cshtml"
                   Write(Html.TextBoxFor(a => a.MemberId));

#line default
#line hidden
            EndContext();
            BeginContext(1125, 206, true);
            WriteLiteral("\r\n                        \r\n                    </div>\r\n                    <div>\r\n                        <button type=\"submit\" class=\"btn btn-info btn-lg\">Place Hold</button>\r\n                    </div>\r\n");
            EndContext();
#line 43 "C:\Users\arsal\Desktop\TMS\TutorMangementSystem\Views\BrowseTutors\Wishlist.cshtml"
                }

#line default
#line hidden
            BeginContext(1350, 54, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TutorMangementSystem.Models.ReserveModels.ReserveModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
