#pragma checksum "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Followers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42ac08d273c63df3856623456d7c5bdf980acdab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Followers_Index), @"mvc.1.0.view", @"/Views/Followers/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Followers/Index.cshtml", typeof(AspNetCore.Views_Followers_Index))]
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
#line 1 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\_ViewImports.cshtml"
using SocialMedia;

#line default
#line hidden
#line 3 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\_ViewImports.cshtml"
using SocialMedia.Models;

#line default
#line hidden
#line 4 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\_ViewImports.cshtml"
using SocialMedia.Models.AccountViewModels;

#line default
#line hidden
#line 5 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\_ViewImports.cshtml"
using SocialMedia.Models.ManageViewModels;

#line default
#line hidden
#line 6 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\_ViewImports.cshtml"
using SocialMedia.Infrastructure;

#line default
#line hidden
#line 7 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\_ViewImports.cshtml"
using SocialMedia.Services.Common.Models;

#line default
#line hidden
#line 8 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\_ViewImports.cshtml"
using SocialMedia.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42ac08d273c63df3856623456d7c5bdf980acdab", @"/Views/Followers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"698633f03a315c54c7c8154e4b7084ec76acc902", @"/Views/_ViewImports.cshtml")]
    public class Views_Followers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Followers>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Default profile icon.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("message-avatar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(24, 115, true);
            WriteLiteral("\r\n<div class=\"container form-color message-container\">\r\n    <div class=\"col-lg-11 col-md-11 col-sm-11 col-xs-11\">\r\n");
            EndContext();
#line 5 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Followers\Index.cshtml"
         foreach (var user in Model)
        {

#line default
#line hidden
            BeginContext(188, 72, true);
            WriteLiteral("            <div class=\"user search-profile col-lg-6\">\r\n                ");
            EndContext();
            BeginContext(260, 633, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c11c65e9fba46b18223643dde5b6dd1", async() => {
                BeginContext(340, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 9 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Followers\Index.cshtml"
                     if (user.UserProfileImage == null)
                    {

#line default
#line hidden
                BeginContext(422, 30, true);
                WriteLiteral("                        <span>");
                EndContext();
                BeginContext(452, 70, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a79d2a4883554d57967f8204ce99814d", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(522, 9, true);
                WriteLiteral("</span>\r\n");
                EndContext();
#line 12 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Followers\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
                BeginContext(603, 34, true);
                WriteLiteral("                        <span><img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 637, "\"", 665, 1);
#line 15 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Followers\Index.cshtml"
WriteAttributeValue("", 643, user.UserProfileImage, 643, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(666, 35, true);
                WriteLiteral(" class=\"message-avatar\" /></span>\r\n");
                EndContext();
#line 16 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Followers\Index.cshtml"
                    }

#line default
#line hidden
                BeginContext(724, 54, true);
                WriteLiteral("                    <span class=\"user-name text-main\">");
                EndContext();
                BeginContext(779, 9, false);
#line 17 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Followers\Index.cshtml"
                                                 Write(user.Name);

#line default
#line hidden
                EndContext();
                BeginContext(788, 62, true);
                WriteLiteral("</span>\r\n                    <span class=\"username text-main\">");
                EndContext();
                BeginContext(851, 13, false);
#line 18 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Followers\Index.cshtml"
                                                Write(user.Username);

#line default
#line hidden
                EndContext();
                BeginContext(864, 25, true);
                WriteLiteral("</span>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 8 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Followers\Index.cshtml"
                                                                          WriteLiteral(user.Id);

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
            BeginContext(893, 22, true);
            WriteLiteral("\r\n            </div>\r\n");
            EndContext();
#line 21 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Followers\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(926, 18, true);
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Followers>> Html { get; private set; }
    }
}
#pragma warning restore 1591
