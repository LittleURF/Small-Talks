#pragma checksum "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_ChildCommentReadonlyPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "614a8a97b812e5a4397682f2a7c7d28c7b3c3fb8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ChildCommentReadonlyPartial), @"mvc.1.0.view", @"/Views/Shared/_ChildCommentReadonlyPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_ChildCommentReadonlyPartial.cshtml", typeof(AspNetCore.Views_Shared__ChildCommentReadonlyPartial))]
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
#line 1 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\_ViewImports.cshtml"
using SmallTalks;

#line default
#line hidden
#line 2 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\_ViewImports.cshtml"
using SmallTalks.Models;

#line default
#line hidden
#line 3 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\_ViewImports.cshtml"
using SmallTalks.ViewModels;

#line default
#line hidden
#line 4 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\_ViewImports.cshtml"
using SmallTalks.Enums;

#line default
#line hidden
#line 5 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\_ViewImports.cshtml"
using System.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"614a8a97b812e5a4397682f2a7c7d28c7b3c3fb8", @"/Views/Shared/_ChildCommentReadonlyPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77a40699cabb1fb6e4ac8bdc9166f42c65e5f768", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ChildCommentReadonlyPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ChildComment>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(21, 368, true);
            WriteLiteral(@"
<div class=""row d-flex justify-content-center"">
    <div class=""comment child-comment"">
        <div class=""comment__data d-flex justify-content-between p-1 m-auto"">
            <!--  The expression of getting Sex is basically - getting the name of defined as int Sex enum. then displaying only first letter of the name, so F or M -->
            <p class=""m-0"">");
            EndContext();
            BeginContext(390, 22, false);
#line 7 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_ChildCommentReadonlyPartial.cshtml"
                      Write(Model.Creator.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(412, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(414, 22, false);
#line 7 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_ChildCommentReadonlyPartial.cshtml"
                                              Write(Model.Creator.GetAge());

#line default
#line hidden
            EndContext();
            BeginContext(436, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(438, 47, false);
#line 7 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_ChildCommentReadonlyPartial.cshtml"
                                                                      Write(Enum.GetName(typeof(Sex), Model.Creator.Sex)[0]);

#line default
#line hidden
            EndContext();
            BeginContext(485, 62, true);
            WriteLiteral("</p>\r\n            <p class=\"m-0\" style=\" word-spacing: 12px;\">");
            EndContext();
            BeginContext(548, 46, false);
#line 8 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_ChildCommentReadonlyPartial.cshtml"
                                                   Write(Model.CreationDate.ToString("H:mm dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(594, 74, true);
            WriteLiteral("</p>\r\n        </div>\r\n        <div>\r\n            <p class=\"comment__text\">");
            EndContext();
            BeginContext(669, 13, false);
#line 11 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_ChildCommentReadonlyPartial.cshtml"
                                Write(Model.Content);

#line default
#line hidden
            EndContext();
            BeginContext(682, 42, true);
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ChildComment> Html { get; private set; }
    }
}
#pragma warning restore 1591