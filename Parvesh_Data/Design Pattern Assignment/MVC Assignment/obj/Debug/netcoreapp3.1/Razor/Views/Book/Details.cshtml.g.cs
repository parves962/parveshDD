#pragma checksum "D:\MVC Assignment\MVC Assignment\Views\Book\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c25f72bc8eb69e3862e9be5cdb332da4aac97c05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Details), @"mvc.1.0.view", @"/Views/Book/Details.cshtml")]
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
#nullable restore
#line 1 "D:\MVC Assignment\MVC Assignment\Views\_ViewImports.cshtml"
using MVC_Assignment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MVC Assignment\MVC Assignment\Views\_ViewImports.cshtml"
using MVC_Assignment.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c25f72bc8eb69e3862e9be5cdb332da4aac97c05", @"/Views/Book/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b05e3f456cb7a24d8fc230081490d890f1de6c2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityModel.EventModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\MVC Assignment\MVC Assignment\Views\Book\Details.cshtml"
  
    ViewBag.Title = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\MVC Assignment\MVC Assignment\Views\Book\Details.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c25f72bc8eb69e3862e9be5cdb332da4aac97c055291", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Details</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c25f72bc8eb69e3862e9be5cdb332da4aac97c055648", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c25f72bc8eb69e3862e9be5cdb332da4aac97c056826", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c25f72bc8eb69e3862e9be5cdb332da4aac97c058708", async() => {
                WriteLiteral("\r\n    <div class=\"container\">\r\n        <div>\r\n            <h4>EventModel</h4>\r\n            <hr />\r\n            <dl class=\"row\">\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 27 "D:\MVC Assignment\MVC Assignment\Views\Book\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 30 "D:\MVC Assignment\MVC Assignment\Views\Book\Details.cshtml"
               Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 33 "D:\MVC Assignment\MVC Assignment\Views\Book\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 36 "D:\MVC Assignment\MVC Assignment\Views\Book\Details.cshtml"
               Write(Html.DisplayFor(model => model.Date));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 39 "D:\MVC Assignment\MVC Assignment\Views\Book\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Location));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 42 "D:\MVC Assignment\MVC Assignment\Views\Book\Details.cshtml"
               Write(Html.DisplayFor(model => model.Location));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 45 "D:\MVC Assignment\MVC Assignment\Views\Book\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.StartTime));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 48 "D:\MVC Assignment\MVC Assignment\Views\Book\Details.cshtml"
               Write(Html.DisplayFor(model => model.StartTime));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 51 "D:\MVC Assignment\MVC Assignment\Views\Book\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 54 "D:\MVC Assignment\MVC Assignment\Views\Book\Details.cshtml"
               Write(Html.DisplayFor(model => model.Type));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 57 "D:\MVC Assignment\MVC Assignment\Views\Book\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Duration));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 60 "D:\MVC Assignment\MVC Assignment\Views\Book\Details.cshtml"
               Write(Html.DisplayFor(model => model.Duration));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 63 "D:\MVC Assignment\MVC Assignment\Views\Book\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 66 "D:\MVC Assignment\MVC Assignment\Views\Book\Details.cshtml"
               Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 69 "D:\MVC Assignment\MVC Assignment\Views\Book\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.OtherDetails));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 72 "D:\MVC Assignment\MVC Assignment\Views\Book\Details.cshtml"
               Write(Html.DisplayFor(model => model.OtherDetails));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 75 "D:\MVC Assignment\MVC Assignment\Views\Book\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.InvitedBy));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 78 "D:\MVC Assignment\MVC Assignment\Views\Book\Details.cshtml"
               Write(Html.DisplayFor(model => model.InvitedBy));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 81 "D:\MVC Assignment\MVC Assignment\Views\Book\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.UserId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 84 "D:\MVC Assignment\MVC Assignment\Views\Book\Details.cshtml"
               Write(Html.DisplayFor(model => model.UserId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 87 "D:\MVC Assignment\MVC Assignment\Views\Book\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.RegistereEmail));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 90 "D:\MVC Assignment\MVC Assignment\Views\Book\Details.cshtml"
               Write(Html.DisplayFor(model => model.RegistereEmail));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n        </div>\r\n        <div>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c25f72bc8eb69e3862e9be5cdb332da4aac97c0516538", async() => {
                    WriteLiteral("Edit");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 95 "D:\MVC Assignment\MVC Assignment\Views\Book\Details.cshtml"
                                   WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
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
                WriteLiteral(" |\r\n            ");
#nullable restore
#line 96 "D:\MVC Assignment\MVC Assignment\Views\Book\Details.cshtml"
       Write(Html.ActionLink("Back to MyEvent", "MyEvent"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n\r\n");
#nullable restore
#line 99 "D:\MVC Assignment\MVC Assignment\Views\Book\Details.cshtml"
         if (Model.Comment.Count != 0)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <h3>Previous Comments</h3>\r\n");
#nullable restore
#line 102 "D:\MVC Assignment\MVC Assignment\Views\Book\Details.cshtml"
             foreach (var cmd in Model.Comment)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                <div class=""row-sm-6"">
                    <div class=""container"">
                        <div class=""card"" style=""background-color:whitesmoke"">
                            <div class=""card-body"">
                                <h5 class=""card-title"">");
#nullable restore
#line 108 "D:\MVC Assignment\MVC Assignment\Views\Book\Details.cshtml"
                                                  Write(cmd.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                                <p class=\"card-text\">");
#nullable restore
#line 109 "D:\MVC Assignment\MVC Assignment\Views\Book\Details.cshtml"
                                                Write(cmd.Timestamp);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                <p class=\"card-text\">");
#nullable restore
#line 110 "D:\MVC Assignment\MVC Assignment\Views\Book\Details.cshtml"
                                                Write(cmd.Comment);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 115 "D:\MVC Assignment\MVC Assignment\Views\Book\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 115 "D:\MVC Assignment\MVC Assignment\Views\Book\Details.cshtml"
             

        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <div class=\"container\">\r\n            <div class=\"col-md-12\" align=\"center\" style=\"width: 50%\">\r\n");
#nullable restore
#line 121 "D:\MVC Assignment\MVC Assignment\Views\Book\Details.cshtml"
                 using (Html.BeginForm("AddComment", "Comment", new { EventId = Model.Id }))
                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <div class=""form-group"">
                        <div class=""row"">
                            <div class=""col-sm-9"">
                                <p>
                                    <a class=""float-left"">
                                        <strong class=""text-success"">Anonymous</strong>
                                    </a>
                                </p>
                            </div>
                            <div class=""col-sm-9"">
                                <textarea class=""form-control"" name=""comment"" id=""comment"" rows=""5""></textarea>
                            </div>
                        </div>
                    </div>
                    <div class=""form-group"">
                        <div class=""col-sm-offset-2 col-sm-10"">
                            <button class=""btn btn-success btn-circle text-uppercase"" type=""submit"" value=""Post"" id=""submitComment"">
                                Post Comment
                            <");
                WriteLiteral("/button>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 144 "D:\MVC Assignment\MVC Assignment\Views\Book\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n        </div>\r\n\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityModel.EventModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
