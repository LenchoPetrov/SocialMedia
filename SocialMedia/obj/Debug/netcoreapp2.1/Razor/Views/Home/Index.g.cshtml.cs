#pragma checksum "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5d152f6411e77b2e9daa36cb80960a9a9e03f6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5d152f6411e77b2e9daa36cb80960a9a9e03f6e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"698633f03a315c54c7c8154e4b7084ec76acc902", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Users", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Default profile icon.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("avatar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Pictures", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("zoom"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(67, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Home\Index.cshtml"
 if (Model.Pictures.Count() == 0)
{

#line default
#line hidden
            BeginContext(107, 39, true);
            WriteLiteral("    <div class=\"register-greeting\">Hi, ");
            EndContext();
            BeginContext(147, 18, false);
#line 8 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Home\Index.cshtml"
                                  Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(165, 32, true);
            WriteLiteral("! You can find and follow users ");
            EndContext();
            BeginContext(197, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "596dabded8e94be4a628d8b773ab2ab9", async() => {
                BeginContext(255, 4, true);
                WriteLiteral("here");
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(263, 9, true);
            WriteLiteral("!</div>\r\n");
            EndContext();
#line 9 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Home\Index.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(284, 115, true);
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"main-view text-shadow form-color col-lg-8 col-md-8 col-sm-8 col-xs-8\">\r\n");
            EndContext();
#line 14 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Home\Index.cshtml"
             foreach (var picture in Model.Pictures.OrderByDescending(p => p.PublishDate))
            {

#line default
#line hidden
            BeginContext(506, 94, true);
            WriteLiteral("                <div>\r\n                    <p class=\"my-row header\">\r\n                        ");
            EndContext();
            BeginContext(600, 636, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b94c6dca5ccf45339e30da638030bfe8", async() => {
                BeginContext(687, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 19 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Home\Index.cshtml"
                             if (picture.UserProfilePhoto == null)
                            {

#line default
#line hidden
                BeginContext(788, 38, true);
                WriteLiteral("                                <span>");
                EndContext();
                BeginContext(826, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "388d19e6fbc446438c56fcdbbddea991", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(888, 9, true);
                WriteLiteral("</span>\r\n");
                EndContext();
#line 22 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Home\Index.cshtml"

                            }
                            else
                            {

#line default
#line hidden
                BeginContext(995, 42, true);
                WriteLiteral("                                <span><img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1037, "\"", 1068, 1);
#line 26 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Home\Index.cshtml"
WriteAttributeValue("", 1043, picture.UserProfilePhoto, 1043, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1069, 27, true);
                WriteLiteral(" class=\"avatar\" /></span>\r\n");
                EndContext();
#line 27 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
                BeginContext(1127, 59, true);
                WriteLiteral("                            <span class=\"name text-shadow\">");
                EndContext();
                BeginContext(1187, 12, false);
#line 28 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Home\Index.cshtml"
                                                      Write(picture.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1199, 33, true);
                WriteLiteral("</span>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 18 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Home\Index.cshtml"
                                                                                  WriteLiteral(picture.UserId);

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
            BeginContext(1236, 47, true);
            WriteLiteral("\r\n                        <span class=\"date\">• ");
            EndContext();
            BeginContext(1284, 19, false);
#line 30 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Home\Index.cshtml"
                                        Write(picture.PublishDate);

#line default
#line hidden
            EndContext();
            BeginContext(1303, 55, true);
            WriteLiteral("</span>\r\n                    </p>\r\n                    ");
            EndContext();
            BeginContext(1358, 209, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ce3a7a68257406bb6568e8b9747cc7b", async() => {
                BeginContext(1458, 30, true);
                WriteLiteral("\r\n                        <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1488, "\"", 1508, 1);
#line 33 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Home\Index.cshtml"
WriteAttributeValue("", 1494, picture.Photo, 1494, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1509, 54, true);
                WriteLiteral(" class=\"img-responsive photo\" />\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 32 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Home\Index.cshtml"
                                                                                  WriteLiteral(picture.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1567, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1589, 498, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b81e599b268443dad2034958c538422", async() => {
                BeginContext(1654, 254, true);
                WriteLiteral("\r\n                        <textarea rows=\"1\" id=\"commentText\" class=\"comment-textarea form-control my-input text-shadow\" placeholder=\"Comment this photo....\" name=\"commentContent\"></textarea>\r\n                        <input type=\"hidden\" name=\"pictureId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1908, "\"", 1927, 1);
#line 37 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Home\Index.cshtml"
WriteAttributeValue("", 1916, picture.Id, 1916, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1928, 152, true);
                WriteLiteral(" id=\"pictureId\" />\r\n                        <input onclick=\"myFunction()\" class=\"btn btn-success\" type=\"button\" value=\"Comment\" />\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2087, 73, true);
            WriteLiteral("\r\n                    <div id=\"commentsReload\">\r\n                        ");
            EndContext();
            BeginContext(2161, 42, false);
#line 41 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Home\Index.cshtml"
                   Write(Html.Partial("Comments", picture.Comments));

#line default
#line hidden
            EndContext();
            BeginContext(2203, 78, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <br />\r\n");
            EndContext();
#line 45 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2296, 28, true);
            WriteLiteral("        </div>\r\n    </div>\r\n");
            EndContext();
#line 48 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Home\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2327, 145, true);
            WriteLiteral("<script>\r\n    function myFunction() {\r\n        var pic = $(\"#pictureId\").val();\r\n        var comment = $(\"#commentText\").val();\r\n        $.post(\"");
            EndContext();
            BeginContext(2473, 32, false);
#line 53 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Home\Index.cshtml"
           Write(Url.Action("Create", "Comments"));

#line default
#line hidden
            EndContext();
            BeginContext(2505, 148, true);
            WriteLiteral("\", { \'pictureId\': pic, \'commentContent\': comment });\r\n\r\n        location.reload();\r\n            $(\"#commentsReload\").reload();\r\n        }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
