#pragma checksum "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Moderator\ReportDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5626ea0a2dd00ddc1b632af8b3aa6bbd5d23f3c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Moderator_ReportDetails), @"mvc.1.0.view", @"/Views/Moderator/ReportDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Moderator/ReportDetails.cshtml", typeof(AspNetCore.Views_Moderator_ReportDetails))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5626ea0a2dd00ddc1b632af8b3aa6bbd5d23f3c7", @"/Views/Moderator/ReportDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77a40699cabb1fb6e4ac8bdc9166f42c65e5f768", @"/Views/_ViewImports.cshtml")]
    public class Views_Moderator_ReportDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReportDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BanUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveReport", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BanFromReport", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("modal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-target", new global::Microsoft.AspNetCore.Html.HtmlString("#ban-modal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_PostReadonlyPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Moderator\ReportDetails.cshtml"
  
    ViewData["Title"] = "Report Details";

#line default
#line hidden
            BeginContext(83, 322, true);
            WriteLiteral(@"<br />

<div class=""modal fade"" id=""ban-modal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""ban-modal-label"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""ban-model-label"">Ban ");
            EndContext();
            BeginContext(406, 37, false);
#line 12 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Moderator\ReportDetails.cshtml"
                                                            Write(Model.ReportedObject.Creator.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(443, 324, true);
            WriteLiteral(@"</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>Reason of the report - what's wrong?</p>
                ");
            EndContext();
            BeginContext(767, 901, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c20a3caebac4ed2b23c742b42565fc6", async() => {
                BeginContext(794, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(816, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b83fc77121447cd9f603fd9e713f849", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 20 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Moderator\ReportDetails.cshtml"
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
                BeginContext(876, 42, true);
                WriteLiteral("\r\n                    <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 918, "\"", 964, 1);
#line 21 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Moderator\ReportDetails.cshtml"
WriteAttributeValue("", 926, Model.ReportedObject.Creator.UserName, 926, 38, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(965, 61, true);
                WriteLiteral(" name=\"userName\" />\r\n                    <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1026, "\"", 1050, 1);
#line 22 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Moderator\ReportDetails.cshtml"
WriteAttributeValue("", 1034, Model.Report.Id, 1034, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1051, 610, true);
                WriteLiteral(@" name=""reportId"" />

                    <textarea class=""form-control mb-2"" name=""description"" placeholder=""..."" required maxlength=""1000""></textarea>
                    <p>End Date</p>
                    <input class=""form-control"" type=""date"" name=""endTime"" placeholder=""Ending Date"" aria-label=""Ending Date"" required />
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn"" data-dismiss=""modal"">Close</button>
                        <input type=""submit"" class=""btn btn-danger"" value=""Send Report"" />
                    </div>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1668, 104, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<h1 class=\"display-4 text-center\">Report ID ");
            EndContext();
            BeginContext(1773, 15, false);
#line 37 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Moderator\ReportDetails.cshtml"
                                       Write(Model.Report.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1788, 150, true);
            WriteLiteral("</h1>\r\n<br />\r\n\r\n<br />\r\n<div class=\"reported-object row d-flex justify-content-between w-75 m-auto bg-light p-2\">\r\n    <h4 class=\"w-100 text-center\">");
            EndContext();
            BeginContext(1939, 31, false);
#line 42 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Moderator\ReportDetails.cshtml"
                             Write(Model.Report.ReportedObjectType);

#line default
#line hidden
            EndContext();
            BeginContext(1970, 52, true);
            WriteLiteral("</h4>\r\n    <p class=\"w-100 text-center\">Reported by ");
            EndContext();
            BeginContext(2023, 37, false);
#line 43 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Moderator\ReportDetails.cshtml"
                                        Write(Model.ReportedObject.Creator.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(2060, 39, true);
            WriteLiteral("</p>\r\n    <p class=\"w-100 text-center\">");
            EndContext();
            BeginContext(2100, 20, false);
#line 44 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Moderator\ReportDetails.cshtml"
                            Write(Model.Report.Content);

#line default
#line hidden
            EndContext();
            BeginContext(2120, 137, true);
            WriteLiteral("</p>\r\n    <div class=\"reported-object__preview p-2 w-100\">\r\n        <div class=\"d-flex justify-content-between mb-2\">\r\n            <span>");
            EndContext();
            BeginContext(2258, 37, false);
#line 47 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Moderator\ReportDetails.cshtml"
             Write(Model.ReportedObject.Creator.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(2295, 27, true);
            WriteLiteral("</span>\r\n            <span>");
            EndContext();
            BeginContext(2323, 33, false);
#line 48 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Moderator\ReportDetails.cshtml"
             Write(Model.ReportedObject.CreationDate);

#line default
#line hidden
            EndContext();
            BeginContext(2356, 25, true);
            WriteLiteral("</span>\r\n        </div>\r\n");
            EndContext();
#line 50 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Moderator\ReportDetails.cshtml"
         if (Model.Report.ReportedObjectType == ObjectType.Post)
        {

#line default
#line hidden
            BeginContext(2458, 16, true);
            WriteLiteral("            <h4>");
            EndContext();
            BeginContext(2475, 26, false);
#line 52 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Moderator\ReportDetails.cshtml"
           Write(Model.ReportedObject.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2501, 27, true);
            WriteLiteral("</h4>\r\n            <br />\r\n");
            EndContext();
#line 54 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Moderator\ReportDetails.cshtml"
        }

#line default
#line hidden
            BeginContext(2539, 11, true);
            WriteLiteral("        <p>");
            EndContext();
            BeginContext(2551, 28, false);
#line 55 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Moderator\ReportDetails.cshtml"
      Write(Model.ReportedObject.Content);

#line default
#line hidden
            EndContext();
            BeginContext(2579, 71, true);
            WriteLiteral("</p>\r\n    </div>\r\n\r\n\r\n</div>\r\n<div class=\"text-center mt-1 mb-4\">\r\n    ");
            EndContext();
            BeginContext(2650, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "552ede89d2cc4ef6bcce5d3339257b0c", async() => {
                BeginContext(2733, 6, true);
                WriteLiteral("Ignore");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 61 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Moderator\ReportDetails.cshtml"
                                   WriteLiteral(Model.Report.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2743, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(2749, 159, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b29c159fdc2e4782839226cd43ef4d86", async() => {
                BeginContext(2901, 3, true);
                WriteLiteral("Ban");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 62 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Moderator\ReportDetails.cshtml"
                                    WriteLiteral(Model.ReportedObject.Creator.UserName);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(2908, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
            BeginContext(2918, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f313ec08aee94419bb8ce24e633e1602", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
#line 64 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Views\Moderator\ReportDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.Post;

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
            BeginContext(2976, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReportDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
