#pragma checksum "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Shared\Comments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b59643a75afcd633f79bd10148f36fcc649de762"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Comments), @"mvc.1.0.view", @"/Views/Shared/Comments.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Comments.cshtml", typeof(AspNetCore.Views_Shared_Comments))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b59643a75afcd633f79bd10148f36fcc649de762", @"/Views/Shared/Comments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"698633f03a315c54c7c8154e4b7084ec76acc902", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Comments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CommentsAndSection>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Default profile icon.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("comment-avatar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Comments", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Shared\Comments.cshtml"
 if (Model.Comments.Count() != 0)
{

#line default
#line hidden
            BeginContext(65, 36, true);
            WriteLiteral("    <div class=\"form-color stuck\">\r\n");
            EndContext();
#line 5 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Shared\Comments.cshtml"
         foreach (var comment in Model.Comments)
        {

#line default
#line hidden
            BeginContext(162, 43, true);
            WriteLiteral("        <div class=\"comment\">\r\n            ");
            EndContext();
            BeginContext(205, 788, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0052373ccb124b0ea2169191fa32acef", async() => {
                BeginContext(292, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 9 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Shared\Comments.cshtml"
                 if (comment.UserProfileImage == null)
                {

#line default
#line hidden
                BeginContext(369, 26, true);
                WriteLiteral("                    <span>");
                EndContext();
                BeginContext(395, 70, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2a8e2c01e91d46d7b0b81d7feeb1054a", async() => {
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
                BeginContext(465, 9, true);
                WriteLiteral("</span>\r\n");
                EndContext();
#line 12 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Shared\Comments.cshtml"
                }
                else
                {

#line default
#line hidden
                BeginContext(534, 30, true);
                WriteLiteral("                    <span><img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 564, "\"", 595, 1);
#line 15 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Shared\Comments.cshtml"
WriteAttributeValue("", 570, comment.UserProfileImage, 570, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(596, 35, true);
                WriteLiteral(" class=\"comment-avatar\" /></span>\r\n");
                EndContext();
#line 16 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Shared\Comments.cshtml"
                }

#line default
#line hidden
                BeginContext(650, 16, true);
                WriteLiteral("                ");
                EndContext();
#line 17 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Shared\Comments.cshtml"
                 if (Model.IsHomePage == true)
                {

#line default
#line hidden
                BeginContext(717, 80, true);
                WriteLiteral("                    <span class=\"comment-name text-main comment-hide-long-name\">");
                EndContext();
                BeginContext(798, 12, false);
#line 19 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Shared\Comments.cshtml"
                                                                           Write(comment.Name);

#line default
#line hidden
                EndContext();
                BeginContext(810, 9, true);
                WriteLiteral("</span>\r\n");
                EndContext();
#line 20 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Shared\Comments.cshtml"
                }
                else
                {

#line default
#line hidden
                BeginContext(879, 57, true);
                WriteLiteral("                    <span class=\"comment-name text-main\">");
                EndContext();
                BeginContext(937, 12, false);
#line 23 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Shared\Comments.cshtml"
                                                    Write(comment.Name);

#line default
#line hidden
                EndContext();
                BeginContext(949, 9, true);
                WriteLiteral("</span>\r\n");
                EndContext();
#line 24 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Shared\Comments.cshtml"
                }

#line default
#line hidden
                BeginContext(977, 12, true);
                WriteLiteral("            ");
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
#line 8 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Shared\Comments.cshtml"
                                                                      WriteLiteral(comment.UserId);

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
            BeginContext(993, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 26 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Shared\Comments.cshtml"
             if (Model.IsHomePage == true)
            {

#line default
#line hidden
            BeginContext(1054, 68, true);
            WriteLiteral("                <span class=\"text-main comment-date comment-name\">• ");
            EndContext();
            BeginContext(1123, 19, false);
#line 28 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Shared\Comments.cshtml"
                                                               Write(comment.PublishDate);

#line default
#line hidden
            EndContext();
            BeginContext(1142, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 29 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Shared\Comments.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1199, 55, true);
            WriteLiteral("                <span class=\"text-main comment-date\">• ");
            EndContext();
            BeginContext(1255, 19, false);
#line 32 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Shared\Comments.cshtml"
                                                  Write(comment.PublishDate);

#line default
#line hidden
            EndContext();
            BeginContext(1274, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 33 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Shared\Comments.cshtml"
            }

#line default
#line hidden
            BeginContext(1298, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 35 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Shared\Comments.cshtml"
             if (User.Identity.Name == comment.PictureOwnerUserName || User.Identity.Name == comment.UserName || User.IsInRole(GlobalConstants.AdministratorRole))
            {

#line default
#line hidden
            BeginContext(1479, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1495, 356, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ab97f652d8c454eb08009419fac4c77", async() => {
                BeginContext(1561, 43, true);
                WriteLiteral("\r\n                    <button type=\"button\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 1604, "\"", 1680, 7);
                WriteAttributeValue("", 1614, "deleteComment(", 1614, 14, true);
#line 38 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Shared\Comments.cshtml"
WriteAttributeValue("", 1628, Model.SectionNumber, 1628, 20, false);

#line default
#line hidden
                WriteAttributeValue("", 1648, ",", 1648, 1, true);
#line 38 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Shared\Comments.cshtml"
WriteAttributeValue("", 1649, comment.Id, 1649, 11, false);

#line default
#line hidden
                WriteAttributeValue("", 1660, ",", 1660, 1, true);
#line 38 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Shared\Comments.cshtml"
WriteAttributeValue("", 1661, comment.PictureId, 1661, 18, false);

#line default
#line hidden
                WriteAttributeValue("", 1679, ")", 1679, 1, true);
                EndWriteAttribute();
                BeginContext(1681, 163, true);
                WriteLiteral(" class=\"close delete-comment\" aria-label=\"Close\">\r\n                        <span aria-hidden=\"true\">&times;</span>\r\n                    </button>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1851, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 42 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Shared\Comments.cshtml"
            }

#line default
#line hidden
            BeginContext(1868, 51, true);
            WriteLiteral("            <div class=\"comment-content text-main\">");
            EndContext();
            BeginContext(1920, 15, false);
#line 43 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Shared\Comments.cshtml"
                                              Write(comment.Content);

#line default
#line hidden
            EndContext();
            BeginContext(1935, 44, true);
            WriteLiteral("</div>\r\n        </div>\r\n            <br />\r\n");
            EndContext();
#line 46 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Shared\Comments.cshtml"
        }

#line default
#line hidden
            BeginContext(1990, 12, true);
            WriteLiteral("    </div>\r\n");
            EndContext();
#line 48 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Shared\Comments.cshtml"
}

#line default
#line hidden
            BeginContext(2005, 161, true);
            WriteLiteral("\r\n<script>\r\n    function deleteComment(sectionNumber, commentId, pictureId) {\r\n        var searchComRel = \"#commentsReload-\" + sectionNumber;\r\n          $.post(\"");
            EndContext();
            BeginContext(2167, 32, false);
#line 53 "E:\Softuni Zadachi\ASP.NET Projects\SocialMedia\SocialMedia\Views\Shared\Comments.cshtml"
             Write(Url.Action("Delete", "Comments"));

#line default
#line hidden
            EndContext();
            BeginContext(2199, 305, true);
            WriteLiteral(@""", { 'CommentId': commentId, 'PictureId': pictureId},
              function () {
                  reloadFunctionByPictureId(searchComRel);
            });
    }

    function reloadFunctionByPictureId(searchComRel) {
        location.reload();
        $(searchComRel).reload();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CommentsAndSection> Html { get; private set; }
    }
}
#pragma warning restore 1591
