#pragma checksum "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Areas\Identity\Pages\Account\AccessDenied.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a2f745d1fabe9d6607c1a8769e6a3f0c4d4c6d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SmallTalks.Areas.Identity.Pages.Account.Areas_Identity_Pages_Account_AccessDenied), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/AccessDenied.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Identity/Pages/Account/AccessDenied.cshtml", typeof(SmallTalks.Areas.Identity.Pages.Account.Areas_Identity_Pages_Account_AccessDenied), null)]
namespace SmallTalks.Areas.Identity.Pages.Account
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Areas\Identity\Pages\_ViewImports.cshtml"
using SmallTalks.Areas.Identity;

#line default
#line hidden
#line 3 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Areas\Identity\Pages\_ViewImports.cshtml"
using SmallTalks.Models;

#line default
#line hidden
#line 1 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using SmallTalks.Areas.Identity.Pages.Account;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a2f745d1fabe9d6607c1a8769e6a3f0c4d4c6d3", @"/Areas/Identity/Pages/Account/AccessDenied.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74844372e1cb6012c106c94f9fb1e6f20dbe77f6", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c081b1756b3f2d4f54fde5db77771789b907712c", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_AccessDenied : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Areas\Identity\Pages\Account\AccessDenied.cshtml"
  
    ViewData["Title"] = "Access denied";

#line default
#line hidden
            BeginContext(82, 74, true);
            WriteLiteral("\r\n<header>\r\n    <br />\r\n    <h1 class=\"display-4 text-center text-danger\">");
            EndContext();
            BeginContext(157, 17, false);
#line 9 "C:\Users\Hubert\source\repos\SmallTalks\SmallTalks\Areas\Identity\Pages\Account\AccessDenied.cshtml"
                                             Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(174, 103, true);
            WriteLiteral("</h1>\r\n    <p class=\"text-center text-danger\">You do not have access to this resource.</p>\r\n</header>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AccessDeniedModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AccessDeniedModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AccessDeniedModel>)PageContext?.ViewData;
        public AccessDeniedModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
