#pragma checksum "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_CommentPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9570ac86fbf271291ced0f8fec69b656ddaa1a53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__CommentPartial), @"mvc.1.0.view", @"/Views/Shared/_CommentPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_CommentPartial.cshtml", typeof(AspNetCore.Views_Shared__CommentPartial))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9570ac86fbf271291ced0f8fec69b656ddaa1a53", @"/Views/Shared/_CommentPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77a40699cabb1fb6e4ac8bdc9166f42c65e5f768", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__CommentPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmallTalks.Models.Comment>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "CommentId", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddChildComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-success", new global::Microsoft.AspNetCore.Html.HtmlString("childCommentAdded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ChildCommentPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(34, 359, true);
            WriteLiteral(@"
<div class=""row d-flex justify-content-center"">
    <div class=""comment"">
        <div class=""comment__data d-flex justify-content-between p-1 w-75 m-auto"">
            <!--  The expression of getting Sex is basically - getting the name of defined as int Sex enum. then displaying only first letter of the name, so F or M -->
            <p class=""m-0"">");
            EndContext();
            BeginContext(394, 22, false);
#line 7 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_CommentPartial.cshtml"
                      Write(Model.Creator.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(416, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(418, 22, false);
#line 7 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_CommentPartial.cshtml"
                                              Write(Model.Creator.GetAge());

#line default
#line hidden
            EndContext();
            BeginContext(440, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(442, 47, false);
#line 7 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_CommentPartial.cshtml"
                                                                      Write(Enum.GetName(typeof(Sex), Model.Creator.Sex)[0]);

#line default
#line hidden
            EndContext();
            BeginContext(489, 62, true);
            WriteLiteral("</p>\r\n            <p class=\"m-0\" style=\" word-spacing: 12px;\">");
            EndContext();
            BeginContext(552, 46, false);
#line 8 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_CommentPartial.cshtml"
                                                   Write(Model.CreationDate.ToString("H:mm dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(598, 143, true);
            WriteLiteral("</p>\r\n            <i class=\"report-icon fas fa-exclamation-triangle\"></i>\r\n        </div>\r\n        <div>\r\n            <p class=\"comment__text\">");
            EndContext();
            BeginContext(742, 13, false);
#line 12 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_CommentPartial.cshtml"
                                Write(Model.Content);

#line default
#line hidden
            EndContext();
            BeginContext(755, 70, true);
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"comment__bottom text-center\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 825, "\"", 855, 2);
            WriteAttributeValue("", 830, "comment__bottom-", 830, 16, true);
#line 14 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_CommentPartial.cshtml"
WriteAttributeValue("", 846, Model.Id, 846, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(856, 128, true);
            WriteLiteral(">\r\n            <button type=\"button\" class=\"comment__reply btn btn-dark\" data-toggle=\"collapse\" data-target=\"#add-child-comment-");
            EndContext();
            BeginContext(985, 8, false);
#line 15 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_CommentPartial.cshtml"
                                                                                                                        Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(993, 76, true);
            WriteLiteral("\" aria-expanded=\"false\" aria-controls=\"add-child-comment\">Reply</button>\r\n\r\n");
            EndContext();
#line 17 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_CommentPartial.cshtml"
               string display = "d-none";
                if(Model.Comments.Count() > 0)
                {
                    display = "d-inline-block";
                }

                    

#line default
#line hidden
            BeginContext(1272, 19, true);
            WriteLiteral("            <button");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1291, "\"", 1333, 4);
            WriteAttributeValue("", 1299, "btn", 1299, 3, true);
            WriteAttributeValue(" ", 1302, "btn-sm", 1303, 7, true);
            WriteAttributeValue(" ", 1309, "btn-secondary", 1310, 14, true);
#line 24 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_CommentPartial.cshtml"
WriteAttributeValue("  ", 1323, display, 1325, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 1334, "\"", 1375, 2);
            WriteAttributeValue("", 1339, "show-children-comments-btn-", 1339, 27, true);
#line 24 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_CommentPartial.cshtml"
WriteAttributeValue("", 1366, Model.Id, 1366, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1376, 67, true);
            WriteLiteral(" type=\"button\" data-toggle=\"collapse\" data-target=\"#child-comments-");
            EndContext();
            BeginContext(1444, 8, false);
#line 24 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_CommentPartial.cshtml"
                                                                                                                                                                      Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1452, 149, true);
            WriteLiteral("\" aria-expanded=\"false\" aria-controls=\"child-comments\">\r\n                &dArr;\r\n            </button>\r\n        </div>\r\n        <div class=\"collapse\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1601, "\"", 1633, 2);
            WriteAttributeValue("", 1606, "add-child-comment-", 1606, 18, true);
#line 28 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_CommentPartial.cshtml"
WriteAttributeValue("", 1624, Model.Id, 1624, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1634, 79, true);
            WriteLiteral(">\r\n            <div class=\"add-comment__wrapper text-center\">\r\n                ");
            EndContext();
            BeginContext(1713, 633, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96034856c5be4043a95ed8c40151f645", async() => {
                BeginContext(1827, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(1849, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f72a505aeba46e3a7367a648759d15c", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 31 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_CommentPartial.cshtml"
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
                BeginContext(1909, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(1931, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e6ea6dbc341c483b8af82fa16e12cac5", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 32 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_CommentPartial.cshtml"
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
                BeginContext(1984, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(2006, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0172620ea0034c9fbd0cc6f5107d6699", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 33 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_CommentPartial.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PostId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2046, 74, true);
                WriteLiteral("\r\n                    <textarea class=\"add-comment__textarea form-control\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 2120, "\"", 2157, 2);
                WriteAttributeValue("", 2125, "child-comment-textarea-", 2125, 23, true);
#line 34 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_CommentPartial.cshtml"
WriteAttributeValue("", 2148, Model.Id, 2148, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2158, 181, true);
                WriteLiteral(" name=\"Content\" placeholder=\"Your comment\" required maxlength=\"2000\"></textarea>\r\n                    <input type=\"submit\" class=\"btn btn-main mt-1\" value=\"Add\" />\r\n                ");
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
            BeginContext(2346, 67, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"collapse\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2413, "\"", 2442, 2);
            WriteAttributeValue("", 2418, "child-comments-", 2418, 15, true);
#line 39 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_CommentPartial.cshtml"
WriteAttributeValue("", 2433, Model.Id, 2433, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2443, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 40 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_CommentPartial.cshtml"
             foreach (var childComment in Model.Comments)
            {

#line default
#line hidden
            BeginContext(2520, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(2536, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ba698b75dc6f4be2934304b9414eb606", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
#line 42 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_CommentPartial.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = childComment;

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
            BeginContext(2596, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 43 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_CommentPartial.cshtml"
            }

#line default
#line hidden
            BeginContext(2613, 523, true);
            WriteLiteral(@"
        </div>

    </div>
</div>

<script>
    childCommentAdded = function (childComment) {
        var div = $(""<div></div>"");

        div.load(""/Home/GetChildCommentPartial"", { childComment })

        div.slideUp();
        $(""#child-comments-"" + childComment.commentId).append(div);
        div.slideDown(250);

        $(""#child-comment-textarea-"" + childComment.commentId).val("""");

        $(""#show-children-comments-btn-"" + childComment.commentId).removeClass(""d-none"");


    };
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SmallTalks.Models.Comment> Html { get; private set; }
    }
}
#pragma warning restore 1591
