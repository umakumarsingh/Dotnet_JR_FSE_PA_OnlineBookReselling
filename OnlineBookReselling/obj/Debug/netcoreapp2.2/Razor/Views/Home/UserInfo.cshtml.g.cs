#pragma checksum "D:\IIHT\Task-14\InMemory\OnlineBookReselling\Views\Home\UserInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f508bf19f0e2d1e59740fa6bc0bf40dd26d3c571"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UserInfo), @"mvc.1.0.view", @"/Views/Home/UserInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/UserInfo.cshtml", typeof(AspNetCore.Views_Home_UserInfo))]
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
#line 1 "D:\IIHT\Task-14\InMemory\OnlineBookReselling\Views\_ViewImports.cshtml"
using OnlineBookReselling;

#line default
#line hidden
#line 2 "D:\IIHT\Task-14\InMemory\OnlineBookReselling\Views\_ViewImports.cshtml"
using OnlineBookReselling.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f508bf19f0e2d1e59740fa6bc0bf40dd26d3c571", @"/Views/Home/UserInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc52771b72e0cb294f262d0364f31e0a281a61c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UserInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineBookReselling.Entities.ApplicationUser>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\IIHT\Task-14\InMemory\OnlineBookReselling\Views\Home\UserInfo.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(96, 290, true);
            WriteLiteral(@"<div class=""card"" style=""width:100%; margin-top:10px;"">
    <div class=""card-header bg-dark text-white"">
        <h5>User Details</h5>
    </div>
    <div class=""card-body"">
        <table class=""table table-borderless"">
            <tr>
                <td>
                    <b>");
            EndContext();
            BeginContext(387, 32, false);
#line 13 "D:\IIHT\Task-14\InMemory\OnlineBookReselling\Views\Home\UserInfo.cshtml"
                  Write(Html.DisplayNameFor(m => m.Name));

#line default
#line hidden
            EndContext();
            BeginContext(419, 49, true);
            WriteLiteral("</b>\r\n                </td>\r\n                <td>");
            EndContext();
            BeginContext(469, 28, false);
#line 15 "D:\IIHT\Task-14\InMemory\OnlineBookReselling\Views\Home\UserInfo.cshtml"
               Write(Html.DisplayFor(m => m.Name));

#line default
#line hidden
            EndContext();
            BeginContext(497, 52, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    <b>");
            EndContext();
            BeginContext(550, 33, false);
#line 17 "D:\IIHT\Task-14\InMemory\OnlineBookReselling\Views\Home\UserInfo.cshtml"
                  Write(Html.DisplayNameFor(m => m.Email));

#line default
#line hidden
            EndContext();
            BeginContext(583, 49, true);
            WriteLiteral("</b>\r\n                </td>\r\n                <td>");
            EndContext();
            BeginContext(633, 29, false);
#line 19 "D:\IIHT\Task-14\InMemory\OnlineBookReselling\Views\Home\UserInfo.cshtml"
               Write(Html.DisplayFor(m => m.Email));

#line default
#line hidden
            EndContext();
            BeginContext(662, 89, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    <b>");
            EndContext();
            BeginContext(752, 36, false);
#line 23 "D:\IIHT\Task-14\InMemory\OnlineBookReselling\Views\Home\UserInfo.cshtml"
                  Write(Html.DisplayNameFor(m => m.Password));

#line default
#line hidden
            EndContext();
            BeginContext(788, 49, true);
            WriteLiteral("</b>\r\n                </td>\r\n                <td>");
            EndContext();
            BeginContext(838, 32, false);
#line 25 "D:\IIHT\Task-14\InMemory\OnlineBookReselling\Views\Home\UserInfo.cshtml"
               Write(Html.DisplayFor(m => m.Password));

#line default
#line hidden
            EndContext();
            BeginContext(870, 52, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    <b>");
            EndContext();
            BeginContext(923, 40, false);
#line 27 "D:\IIHT\Task-14\InMemory\OnlineBookReselling\Views\Home\UserInfo.cshtml"
                  Write(Html.DisplayNameFor(m => m.MobileNumber));

#line default
#line hidden
            EndContext();
            BeginContext(963, 49, true);
            WriteLiteral("</b>\r\n                </td>\r\n                <td>");
            EndContext();
            BeginContext(1013, 36, false);
#line 29 "D:\IIHT\Task-14\InMemory\OnlineBookReselling\Views\Home\UserInfo.cshtml"
               Write(Html.DisplayFor(m => m.MobileNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1049, 69, true);
            WriteLiteral("</td>\r\n            </tr>\r\n        </table>\r\n        <p>\r\n            ");
            EndContext();
            BeginContext(1119, 80, false);
#line 33 "D:\IIHT\Task-14\InMemory\OnlineBookReselling\Views\Home\UserInfo.cshtml"
       Write(Html.ActionLink("Shop Now", "Index", "Home", new { @class = "btn btn-primary" }));

#line default
#line hidden
            EndContext();
            BeginContext(1199, 34, true);
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineBookReselling.Entities.ApplicationUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
