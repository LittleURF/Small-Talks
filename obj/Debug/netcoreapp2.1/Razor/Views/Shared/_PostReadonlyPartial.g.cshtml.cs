#pragma checksum "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_PostReadonlyPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ba40fb4d02da5d1d2b66bce0692c0e56bc99dbd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PostReadonlyPartial), @"mvc.1.0.view", @"/Views/Shared/_PostReadonlyPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_PostReadonlyPartial.cshtml", typeof(AspNetCore.Views_Shared__PostReadonlyPartial))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ba40fb4d02da5d1d2b66bce0692c0e56bc99dbd", @"/Views/Shared/_PostReadonlyPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77a40699cabb1fb6e4ac8bdc9166f42c65e5f768", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PostReadonlyPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmallTalks.Models.Post>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_CommentReadonlyPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 367, true);
            WriteLiteral(@"
<div class=""post__wrapper row d-flex justify-content-center"">
    <div class=""post"">
        <div class=""post__data d-flex justify-content-between p-1 w-75 m-auto"">
            <!--  The expression of getting Sex is basically - getting the name of defined as int Sex enum. then displaying only first letter of the name, so F or M -->
            <p class=""m-0"">");
            EndContext();
            BeginContext(399, 22, false);
#line 7 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_PostReadonlyPartial.cshtml"
                      Write(Model.Creator.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(421, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(423, 22, false);
#line 7 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_PostReadonlyPartial.cshtml"
                                              Write(Model.Creator.GetAge());

#line default
#line hidden
            EndContext();
            BeginContext(445, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(447, 47, false);
#line 7 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_PostReadonlyPartial.cshtml"
                                                                      Write(Enum.GetName(typeof(Sex), Model.Creator.Sex)[0]);

#line default
#line hidden
            EndContext();
            BeginContext(494, 62, true);
            WriteLiteral("</p>\r\n            <p class=\"m-0\" style=\" word-spacing: 12px;\">");
            EndContext();
            BeginContext(557, 46, false);
#line 8 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_PostReadonlyPartial.cshtml"
                                                   Write(Model.CreationDate.ToString("H:mm dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(603, 73, true);
            WriteLiteral("</p>\r\n        </div>\r\n        <div>\r\n            <h1 class=\"post__title\">");
            EndContext();
            BeginContext(677, 11, false);
#line 11 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_PostReadonlyPartial.cshtml"
                               Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(688, 41, true);
            WriteLiteral("</h1>\r\n            <p class=\"post__text\">");
            EndContext();
            BeginContext(730, 13, false);
#line 12 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_PostReadonlyPartial.cshtml"
                             Write(Model.Content);

#line default
#line hidden
            EndContext();
            BeginContext(743, 44, true);
            WriteLiteral("</p>\r\n            <div class=\"post__tags\">\r\n");
            EndContext();
#line 14 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_PostReadonlyPartial.cshtml"
                 foreach (var postTags in Model.PostTags)
                {

#line default
#line hidden
            BeginContext(865, 22, true);
            WriteLiteral("                    <i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 887, "\"", 938, 3);
            WriteAttributeValue("", 895, "tag__icon", 895, 9, true);
            WriteAttributeValue(" ", 904, "post__tag", 905, 10, true);
#line 16 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_PostReadonlyPartial.cshtml"
WriteAttributeValue(" ", 914, postTags.Tag.FaClasses, 915, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(939, 7, true);
            WriteLiteral("></i>\r\n");
            EndContext();
#line 17 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_PostReadonlyPartial.cshtml"

                }

#line default
#line hidden
            BeginContext(967, 172, true);
            WriteLiteral("            </div>\r\n            <div class=\"text-center\">\r\n                <button class=\"btn btn-dark\" type=\"button\" data-toggle=\"collapse\" data-target=\".comments-section-");
            EndContext();
            BeginContext(1140, 8, false);
#line 21 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_PostReadonlyPartial.cshtml"
                                                                                                            Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1148, 154, true);
            WriteLiteral("\" aria-expanded=\"false\" aria-controls=\"comments-section\">\r\n                    &dArr;\r\n                </button>\r\n            </div>\r\n            <section");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1302, "\"", 1362, 4);
            WriteAttributeValue("", 1310, "collapse", 1310, 8, true);
            WriteAttributeValue(" ", 1318, "comments-section", 1319, 17, true);
            WriteAttributeValue(" ", 1335, "comments-section-", 1336, 18, true);
#line 25 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_PostReadonlyPartial.cshtml"
WriteAttributeValue("", 1353, Model.Id, 1353, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1363, 40, true);
            WriteLiteral(">\r\n                <div class=\"comments\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1403, "\"", 1426, 2);
            WriteAttributeValue("", 1408, "comments-", 1408, 9, true);
#line 26 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_PostReadonlyPartial.cshtml"
WriteAttributeValue("", 1417, Model.Id, 1417, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1427, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 27 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_PostReadonlyPartial.cshtml"
                     foreach (var comment in Model.Comments)
                    {

#line default
#line hidden
            BeginContext(1515, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1539, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d048027f664e4687958d64a23fcea306", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 29 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_PostReadonlyPartial.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = comment;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1598, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 30 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_PostReadonlyPartial.cshtml"
                    }

#line default
#line hidden
            BeginContext(1623, 84, true);
            WriteLiteral("\r\n                </div>\r\n            </section>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SmallTalks.Models.Post> Html { get; private set; }
    }
}
#pragma warning restore 1591
