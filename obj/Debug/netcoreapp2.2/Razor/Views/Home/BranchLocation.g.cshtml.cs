#pragma checksum "C:\Users\arsal\Desktop\TMS\TutorMangementSystem\Views\Home\BranchLocation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93e9917ee9982c506429afbee390b21e9727326d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_BranchLocation), @"mvc.1.0.view", @"/Views/Home/BranchLocation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/BranchLocation.cshtml", typeof(AspNetCore.Views_Home_BranchLocation))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93e9917ee9982c506429afbee390b21e9727326d", @"/Views/Home/BranchLocation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"048df9abc10abc6bc76751075d6f52bb55c42fcc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_BranchLocation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OfficeDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\arsal\Desktop\TMS\TutorMangementSystem\Views\Home\BranchLocation.cshtml"
  
    ViewData["Title"] = "Branch";

#line default
#line hidden
            BeginContext(44, 288, true);
            WriteLiteral(@"

<h1>Office Index</h1>

<table class=""table"" id=""officeIndexTable"">
    <thead>
        <tr>
            <th>Office Name</th>
            <th>Open Now</th>
            <th>Number Of Tutors</th>
            <th>Number of Students</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 19 "C:\Users\arsal\Desktop\TMS\TutorMangementSystem\Views\Home\BranchLocation.cshtml"
         foreach (var office in Model.Offices)
        {

#line default
#line hidden
            BeginContext(391, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(421, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93e9917ee9982c506429afbee390b21e9727326d4711", async() => {
                BeginContext(499, 17, false);
#line 22 "C:\Users\arsal\Desktop\TMS\TutorMangementSystem\Views\Home\BranchLocation.cshtml"
                                                                                        Write(office.OfficeName);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 22 "C:\Users\arsal\Desktop\TMS\TutorMangementSystem\Views\Home\BranchLocation.cshtml"
                                                                     WriteLiteral(office.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(520, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(544, 13, false);
#line 23 "C:\Users\arsal\Desktop\TMS\TutorMangementSystem\Views\Home\BranchLocation.cshtml"
           Write(office.IsOpen);

#line default
#line hidden
            EndContext();
            BeginContext(557, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(581, 21, false);
#line 24 "C:\Users\arsal\Desktop\TMS\TutorMangementSystem\Views\Home\BranchLocation.cshtml"
           Write(office.NumberOfTutors);

#line default
#line hidden
            EndContext();
            BeginContext(602, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(626, 23, false);
#line 25 "C:\Users\arsal\Desktop\TMS\TutorMangementSystem\Views\Home\BranchLocation.cshtml"
           Write(office.NumberOfStudents);

#line default
#line hidden
            EndContext();
            BeginContext(649, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 27 "C:\Users\arsal\Desktop\TMS\TutorMangementSystem\Views\Home\BranchLocation.cshtml"
        }

#line default
#line hidden
            BeginContext(682, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
