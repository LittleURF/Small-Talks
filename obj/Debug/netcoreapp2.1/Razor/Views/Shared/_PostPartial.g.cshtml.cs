#pragma checksum "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_PostPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e24ac43cfa50a96eaffd3cd6a8b8d37bb9c0bea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PostPartial), @"mvc.1.0.view", @"/Views/Shared/_PostPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_PostPartial.cshtml", typeof(AspNetCore.Views_Shared__PostPartial))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e24ac43cfa50a96eaffd3cd6a8b8d37bb9c0bea", @"/Views/Shared/_PostPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77a40699cabb1fb6e4ac8bdc9166f42c65e5f768", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PostPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmallTalks.Models.Post>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "PostId", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-success", new global::Microsoft.AspNetCore.Html.HtmlString("commentAdded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_CommentPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
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
#line 7 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_PostPartial.cshtml"
                      Write(Model.Creator.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(421, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(423, 22, false);
#line 7 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_PostPartial.cshtml"
                                              Write(Model.Creator.GetAge());

#line default
#line hidden
            EndContext();
            BeginContext(445, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(447, 47, false);
#line 7 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_PostPartial.cshtml"
                                                                      Write(Enum.GetName(typeof(Sex), Model.Creator.Sex)[0]);

#line default
#line hidden
            EndContext();
            BeginContext(494, 62, true);
            WriteLiteral("</p>\r\n            <p class=\"m-0\" style=\" word-spacing: 12px;\">");
            EndContext();
            BeginContext(557, 46, false);
#line 8 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_PostPartial.cshtml"
                                                   Write(Model.CreationDate.ToString("H:mm dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(603, 142, true);
            WriteLiteral("</p>\r\n            <i class=\"report-icon fas fa-exclamation-triangle\"></i>\r\n        </div>\r\n        <div>\r\n            <h1 class=\"post__title\">");
            EndContext();
            BeginContext(746, 11, false);
#line 12 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_PostPartial.cshtml"
                               Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(757, 41, true);
            WriteLiteral("</h1>\r\n            <p class=\"post__text\">");
            EndContext();
            BeginContext(799, 13, false);
#line 13 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_PostPartial.cshtml"
                             Write(Model.Content);

#line default
#line hidden
            EndContext();
            BeginContext(812, 44, true);
            WriteLiteral("</p>\r\n            <div class=\"post__tags\">\r\n");
            EndContext();
#line 15 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_PostPartial.cshtml"
                 foreach (var postTags in Model.PostTags)
                {

#line default
#line hidden
            BeginContext(934, 22, true);
            WriteLiteral("                    <i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 956, "\"", 1007, 3);
            WriteAttributeValue("", 964, "tag__icon", 964, 9, true);
            WriteAttributeValue(" ", 973, "post__tag", 974, 10, true);
#line 17 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_PostPartial.cshtml"
WriteAttributeValue(" ", 983, postTags.Tag.FaClasses, 984, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1008, 7, true);
            WriteLiteral("></i>\r\n");
            EndContext();
#line 18 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_PostPartial.cshtml"

                }

#line default
#line hidden
            BeginContext(1036, 172, true);
            WriteLiteral("            </div>\r\n            <div class=\"text-center\">\r\n                <button class=\"btn btn-dark\" type=\"button\" data-toggle=\"collapse\" data-target=\".comments-section-");
            EndContext();
            BeginContext(1209, 8, false);
#line 22 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_PostPartial.cshtml"
                                                                                                            Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1217, 154, true);
            WriteLiteral("\" aria-expanded=\"false\" aria-controls=\"comments-section\">\r\n                    &dArr;\r\n                </button>\r\n            </div>\r\n            <section");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1371, "\"", 1431, 4);
            WriteAttributeValue("", 1379, "collapse", 1379, 8, true);
            WriteAttributeValue(" ", 1387, "comments-section", 1388, 17, true);
            WriteAttributeValue(" ", 1404, "comments-section-", 1405, 18, true);
#line 26 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_PostPartial.cshtml"
WriteAttributeValue("", 1422, Model.Id, 1422, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1432, 87, true);
            WriteLiteral(">\r\n                <div class=\"add-comment__wrapper text-center\">\r\n                    ");
            EndContext();
            BeginContext(1519, 563, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64094bd3b77b4d068851ea60ffdc8775", async() => {
                BeginContext(1623, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(1649, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95e2fd4fe62c4dfd98bd9c10f7f984b9", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 29 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_PostPartial.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1709, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(1735, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "aba8b26cbbd0490b8e11c5a4c12d612e", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 30 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_PostPartial.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1785, 78, true);
                WriteLiteral("\r\n                        <textarea class=\"add-comment__textarea form-control\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 1863, "\"", 1894, 2);
                WriteAttributeValue("", 1868, "comment-textarea-", 1868, 17, true);
#line 31 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_PostPartial.cshtml"
WriteAttributeValue("", 1885, Model.Id, 1885, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1895, 180, true);
                WriteLiteral(" name=\"Content\" placeholder=\"Your comment\" required maxlength=\"2000\"></textarea>\r\n                        <input type=\"submit\" class=\"btn mt-1\" value=\"Add\" />\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2082, 63, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"comments\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2145, "\"", 2168, 2);
            WriteAttributeValue("", 2150, "comments-", 2150, 9, true);
#line 35 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_PostPartial.cshtml"
WriteAttributeValue("", 2159, Model.Id, 2159, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2169, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 36 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_PostPartial.cshtml"
                     foreach (var comment in Model.Comments)
                    {

#line default
#line hidden
            BeginContext(2257, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(2281, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2168998cae644cd0b130d0500f3d19f4", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
#line 38 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_PostPartial.cshtml"
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
            BeginContext(2332, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 39 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_PostPartial.cshtml"
                    }

#line default
#line hidden
            BeginContext(2357, 423, true);
            WriteLiteral(@"
                </div>
            </section>
        </div>
    </div>
</div>

<script>
    commentAdded = function (comment) {
        var div = $(""<div></div>"");

        div.load(""/Home/GetCommentPartial"", { comment })

        div.slideUp();
        $(""#comments-"" + comment.postId).append(div);
        div.slideDown(250);

        $(""#comment-textarea-"" + comment.postId).val("""");
    }
</script>");
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
