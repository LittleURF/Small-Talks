#pragma checksum "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_CommentPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e21df6ce8d63f3240e384cde682abbe49be35b4"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e21df6ce8d63f3240e384cde682abbe49be35b4", @"/Views/Shared/_CommentPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77a40699cabb1fb6e4ac8bdc9166f42c65e5f768", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__CommentPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmallTalks.Models.Comment>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ReportModalPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "CommentId", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddChildComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-success", new global::Microsoft.AspNetCore.Html.HtmlString("childCommentAdded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ChildCommentPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(56, 114, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8eaf340408d64689b2687afac2ab6df5", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 4 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_CommentPartial.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = new UserCreatedObj{ Id = Model.Id, ObjectType = ObjectType.Comment};

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
            BeginContext(170, 363, true);
            WriteLiteral(@"


<div class=""row d-flex justify-content-center"">
    <div class=""comment"">
        <div class=""comment__data d-flex justify-content-between p-1 w-75 m-auto"">
            <!--  The expression of getting Sex is basically - getting the name of defined as int Sex enum. then displaying only first letter of the name, so F or M -->
            <p class=""m-0"">");
            EndContext();
            BeginContext(534, 22, false);
#line 11 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_CommentPartial.cshtml"
                      Write(Model.Creator.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(556, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(558, 22, false);
#line 11 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_CommentPartial.cshtml"
                                              Write(Model.Creator.GetAge());

#line default
#line hidden
            EndContext();
            BeginContext(580, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(582, 47, false);
#line 11 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_CommentPartial.cshtml"
                                                                      Write(Enum.GetName(typeof(Sex), Model.Creator.Sex)[0]);

#line default
#line hidden
            EndContext();
            BeginContext(629, 62, true);
            WriteLiteral("</p>\r\n            <p class=\"m-0\" style=\" word-spacing: 12px;\">");
            EndContext();
            BeginContext(692, 46, false);
#line 12 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_CommentPartial.cshtml"
                                                   Write(Model.CreationDate.ToString("H:mm dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(738, 97, true);
            WriteLiteral("</p>\r\n            <a class=\"report-icon__wrapper\" data-toggle=\"modal\" data-target=\"#report-modal-");
            EndContext();
            BeginContext(836, 8, false);
#line 13 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_CommentPartial.cshtml"
                                                                                      Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(844, 171, true);
            WriteLiteral("-Comment\">\r\n                <i class=\"report-icon fas fa-exclamation-triangle\"></i>\r\n            </a>\r\n        </div>\r\n        <div>\r\n            <p class=\"comment__text\">");
            EndContext();
            BeginContext(1016, 13, false);
#line 18 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_CommentPartial.cshtml"
                                Write(Model.Content);

#line default
#line hidden
            EndContext();
            BeginContext(1029, 70, true);
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"comment__bottom text-center\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1099, "\"", 1129, 2);
            WriteAttributeValue("", 1104, "comment__bottom-", 1104, 16, true);
#line 20 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_CommentPartial.cshtml"
WriteAttributeValue("", 1120, Model.Id, 1120, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1130, 128, true);
            WriteLiteral(">\r\n            <button type=\"button\" class=\"comment__reply btn btn-dark\" data-toggle=\"collapse\" data-target=\"#add-child-comment-");
            EndContext();
            BeginContext(1259, 8, false);
#line 21 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_CommentPartial.cshtml"
                                                                                                                        Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1267, 76, true);
            WriteLiteral("\" aria-expanded=\"false\" aria-controls=\"add-child-comment\">Reply</button>\r\n\r\n");
            EndContext();
#line 23 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_CommentPartial.cshtml"
               string display = "d-none";
                if (Model.Comments.Count() > 0)
                {
                    display = "d-inline-block";
                }

            

#line default
#line hidden
            BeginContext(1539, 19, true);
            WriteLiteral("            <button");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1558, "\"", 1600, 4);
            WriteAttributeValue("", 1566, "btn", 1566, 3, true);
            WriteAttributeValue(" ", 1569, "btn-sm", 1570, 7, true);
            WriteAttributeValue(" ", 1576, "btn-secondary", 1577, 14, true);
#line 30 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_CommentPartial.cshtml"
WriteAttributeValue("  ", 1590, display, 1592, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 1601, "\"", 1642, 2);
            WriteAttributeValue("", 1606, "show-children-comments-btn-", 1606, 27, true);
#line 30 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_CommentPartial.cshtml"
WriteAttributeValue("", 1633, Model.Id, 1633, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1643, 67, true);
            WriteLiteral(" type=\"button\" data-toggle=\"collapse\" data-target=\"#child-comments-");
            EndContext();
            BeginContext(1711, 8, false);
#line 30 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_CommentPartial.cshtml"
                                                                                                                                                                      Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1719, 149, true);
            WriteLiteral("\" aria-expanded=\"false\" aria-controls=\"child-comments\">\r\n                &dArr;\r\n            </button>\r\n        </div>\r\n        <div class=\"collapse\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1868, "\"", 1900, 2);
            WriteAttributeValue("", 1873, "add-child-comment-", 1873, 18, true);
#line 34 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_CommentPartial.cshtml"
WriteAttributeValue("", 1891, Model.Id, 1891, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1901, 79, true);
            WriteLiteral(">\r\n            <div class=\"add-comment__wrapper text-center\">\r\n                ");
            EndContext();
            BeginContext(1980, 632, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ac3497dfe75411d9862a4d047d1aefb", async() => {
                BeginContext(2094, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(2116, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54c2255acd014fdf8c1d715f3f23a935", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 37 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_CommentPartial.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2176, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(2198, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e02eae6141ae4824910341daa3e276b7", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 38 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_CommentPartial.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2251, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(2273, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0a3e841938be45f181e48808bc244906", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 39 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_CommentPartial.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PostId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2313, 74, true);
                WriteLiteral("\r\n                    <textarea class=\"add-comment__textarea form-control\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 2387, "\"", 2424, 2);
                WriteAttributeValue("", 2392, "child-comment-textarea-", 2392, 23, true);
#line 40 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_CommentPartial.cshtml"
WriteAttributeValue("", 2415, Model.Id, 2415, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2425, 180, true);
                WriteLiteral(" name=\"Content\" placeholder=\"Your comment\" required maxlength=\"300\"></textarea>\r\n                    <input type=\"submit\" class=\"btn btn-main mt-1\" value=\"Add\" />\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2612, 67, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"collapse\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2679, "\"", 2708, 2);
            WriteAttributeValue("", 2684, "child-comments-", 2684, 15, true);
#line 45 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_CommentPartial.cshtml"
WriteAttributeValue("", 2699, Model.Id, 2699, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2709, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 46 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_CommentPartial.cshtml"
             foreach (var childComment in Model.Comments)
            {

#line default
#line hidden
            BeginContext(2786, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(2802, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1e628d3c6b3843049d4fa3b9c5a37bda", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
#line 48 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_CommentPartial.cshtml"
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
            BeginContext(2862, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 49 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Shared\_CommentPartial.cshtml"
            }

#line default
#line hidden
            BeginContext(2879, 523, true);
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
