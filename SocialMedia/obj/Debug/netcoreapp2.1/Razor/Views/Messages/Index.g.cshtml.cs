#pragma checksum "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Messages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17aa229dbf981547250873b8e1089ff2ed458c47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Messages_Index), @"mvc.1.0.view", @"/Views/Messages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Messages/Index.cshtml", typeof(AspNetCore.Views_Messages_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17aa229dbf981547250873b8e1089ff2ed458c47", @"/Views/Messages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"698633f03a315c54c7c8154e4b7084ec76acc902", @"/Views/_ViewImports.cshtml")]
    public class Views_Messages_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<IndexMessage>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Messages", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Send", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-shadow btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Default profile icon.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("message-avatar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Message", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Messages\Index.cshtml"
  
    ViewData["Title"] = "Messages";

#line default
#line hidden
            BeginContext(71, 129, true);
            WriteLiteral("<br />\r\n<a class=\"glyphicon glyphicon-arrow-left text-shadow back\" href=\"back\" onClick=\"history.go(-1); return false;\">Back</a>\r\n");
            EndContext();
            BeginContext(200, 111, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d491998ce774cbd94232a368c7d6d66", async() => {
                BeginContext(295, 12, true);
                WriteLiteral("Send Message");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(311, 125, true);
            WriteLiteral("\r\n\r\n<br />\r\n<div class=\"container form-color message-container\">\r\n    <div class=\"col-lg-11 col-md-11 col-sm-11 col-xs-11\">\r\n");
            EndContext();
#line 12 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Messages\Index.cshtml"
         foreach (var message in Model)
        {

#line default
#line hidden
            BeginContext(488, 52, true);
            WriteLiteral("            <div class=\"messaage\">\r\n                ");
            EndContext();
            BeginContext(540, 824, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c8406102aaf489ba9d90255da37a75b", async() => {
                BeginContext(686, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 16 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Messages\Index.cshtml"
                     if (message.RecipientProfileImage == null)
                    {

#line default
#line hidden
                BeginContext(776, 30, true);
                WriteLiteral("                        <span>");
                EndContext();
                BeginContext(806, 70, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6b3a2322ef884cad8973c481b916f96a", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(876, 9, true);
                WriteLiteral("</span>\r\n");
                EndContext();
#line 19 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Messages\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
                BeginContext(957, 34, true);
                WriteLiteral("                        <span><img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 991, "\"", 1027, 1);
#line 22 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Messages\Index.cshtml"
WriteAttributeValue("", 997, message.RecipientProfileImage, 997, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1028, 35, true);
                WriteLiteral(" class=\"message-avatar\" /></span>\r\n");
                EndContext();
#line 23 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Messages\Index.cshtml"
                    }

#line default
#line hidden
                BeginContext(1086, 59, true);
                WriteLiteral("                    <span class=\"message-name text-shadow\">");
                EndContext();
                BeginContext(1146, 21, false);
#line 24 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Messages\Index.cshtml"
                                                      Write(message.RecipientName);

#line default
#line hidden
                EndContext();
                BeginContext(1167, 70, true);
                WriteLiteral("</span>\r\n                    <span class=\"text-shadow message-date\">• ");
                EndContext();
                BeginContext(1238, 12, false);
#line 25 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Messages\Index.cshtml"
                                                        Write(message.Date);

#line default
#line hidden
                EndContext();
                BeginContext(1250, 70, true);
                WriteLiteral("</span>\r\n                    <div class=\"message-content text-shadow\">");
                EndContext();
                BeginContext(1321, 15, false);
#line 26 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Messages\Index.cshtml"
                                                        Write(message.Content);

#line default
#line hidden
                EndContext();
                BeginContext(1336, 24, true);
                WriteLiteral("</div>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-RecepientId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 15 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Messages\Index.cshtml"
                                                                                         WriteLiteral(message.RecipientId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["RecepientId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-RecepientId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["RecepientId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 15 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Messages\Index.cshtml"
                                                                                                                                   WriteLiteral(message.SenderId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["SenderId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-SenderId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["SenderId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1364, 42, true);
            WriteLiteral("\r\n            </div>\r\n            <br />\r\n");
            EndContext();
#line 30 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Messages\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1417, 20, true);
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<IndexMessage>> Html { get; private set; }
    }
}
#pragma warning restore 1591
