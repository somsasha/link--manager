#pragma checksum "C:\Users\somsa\Documents\GitHub\link--manager\LinkManager\Views\Links\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f27aba500370663b51aef5ec30578e3021ca0357"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Links_Index), @"mvc.1.0.view", @"/Views/Links/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Links/Index.cshtml", typeof(AspNetCore.Views_Links_Index))]
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
#line 1 "C:\Users\somsa\Documents\GitHub\link--manager\LinkManager\Views\_ViewImports.cshtml"
using LinkManager;

#line default
#line hidden
#line 2 "C:\Users\somsa\Documents\GitHub\link--manager\LinkManager\Views\_ViewImports.cshtml"
using LinkManager.Models;

#line default
#line hidden
#line 1 "C:\Users\somsa\Documents\GitHub\link--manager\LinkManager\Views\Links\Index.cshtml"
using LinkManager.DAL.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f27aba500370663b51aef5ec30578e3021ca0357", @"/Views/Links/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6aab877ca137163525bcbca047d8b47b3c68c378", @"/Views/_ViewImports.cshtml")]
    public class Views_Links_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LinkManager.ViewModels.LinkIndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline md-form form-sm mt-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("justify-content: center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(81, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\somsa\Documents\GitHub\link--manager\LinkManager\Views\Links\Index.cshtml"
  
    Layout = "/Views/Home/_Layout.cshtml";
    var currentPage = (int)ViewData["Page"];

#line default
#line hidden
            BeginContext(180, 174, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-3 px-5\" style=\"justify-content: center\">\r\n        <div class=\"row py-4\">\r\n            <div class=\"col-12\" style=\"text-align: center\">");
            EndContext();
            BeginContext(354, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f27aba500370663b51aef5ec30578e3021ca03576173", async() => {
                BeginContext(409, 7, true);
                WriteLiteral("Add new");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(420, 282, true);
            WriteLiteral(@"</div>
        </div>
        <div class=""row py-4"" style=""justify-content: center"">
            <div class=""col-6"" style=""border:black;border-width:1px;border-style:solid;border-radius:2rem;"">
                <div class=""row"" style=""justify-content: center"">Tags search</div>
");
            EndContext();
#line 17 "C:\Users\somsa\Documents\GitHub\link--manager\LinkManager\Views\Links\Index.cshtml"
                 foreach (var tag in Model.Tags)
                {

#line default
#line hidden
            BeginContext(771, 113, true);
            WriteLiteral("                    <div class=\"row\" style=\"justify-content: center\"><a class=\"btn btn-outline-info tag-cntrl-lg\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 884, "\"", 901, 1);
#line 19 "C:\Users\somsa\Documents\GitHub\link--manager\LinkManager\Views\Links\Index.cshtml"
WriteAttributeValue("", 892, tag.Name, 892, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 902, "\"", 923, 2);
            WriteAttributeValue("", 909, "?tagId=", 909, 7, true);
#line 19 "C:\Users\somsa\Documents\GitHub\link--manager\LinkManager\Views\Links\Index.cshtml"
WriteAttributeValue("", 916, tag.Id, 916, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(924, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(926, 8, false);
#line 19 "C:\Users\somsa\Documents\GitHub\link--manager\LinkManager\Views\Links\Index.cshtml"
                                                                                                                                                     Write(tag.Name);

#line default
#line hidden
            EndContext();
            BeginContext(934, 12, true);
            WriteLiteral("</a></div>\r\n");
            EndContext();
#line 20 "C:\Users\somsa\Documents\GitHub\link--manager\LinkManager\Views\Links\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(965, 180, true);
            WriteLiteral("                <div class=\"row\" style=\"height: 1rem\"></div>\r\n            </div>\r\n        </div>\r\n        <div class=\"row py-4\">\r\n            <div class=\"col-12\">\r\n                ");
            EndContext();
            BeginContext(1145, 327, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f27aba500370663b51aef5ec30578e3021ca035710002", async() => {
                BeginContext(1224, 241, true);
                WriteLiteral("\r\n                    <input class=\"form-control form-control-sm mr-3 w-50\" type=\"text\" name=\"extSearch\" placeholder=\"Search\" aria-label=\"Search\">\r\n                    <i class=\"fas fa-search active\" aria-hidden=\"true\"></i>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1472, 199, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-8\">\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1672, 63, false);
#line 38 "C:\Users\somsa\Documents\GitHub\link--manager\LinkManager\Views\Links\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Link.FirstOrDefault().Order));

#line default
#line hidden
            EndContext();
            BeginContext(1735, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1815, 61, false);
#line 41 "C:\Users\somsa\Documents\GitHub\link--manager\LinkManager\Views\Links\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Link.FirstOrDefault().Url));

#line default
#line hidden
            EndContext();
            BeginContext(1876, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1956, 69, false);
#line 44 "C:\Users\somsa\Documents\GitHub\link--manager\LinkManager\Views\Links\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Link.FirstOrDefault().Description));

#line default
#line hidden
            EndContext();
            BeginContext(2025, 228, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th style=\"width: 40%\">\r\n                        Tags\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 53 "C:\Users\somsa\Documents\GitHub\link--manager\LinkManager\Views\Links\Index.cshtml"
                 foreach (var item in Model.Link)
                {

#line default
#line hidden
            BeginContext(2323, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2408, 40, false);
#line 57 "C:\Users\somsa\Documents\GitHub\link--manager\LinkManager\Views\Links\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Order));

#line default
#line hidden
            EndContext();
            BeginContext(2448, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2540, 38, false);
#line 60 "C:\Users\somsa\Documents\GitHub\link--manager\LinkManager\Views\Links\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Url));

#line default
#line hidden
            EndContext();
            BeginContext(2578, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2670, 46, false);
#line 63 "C:\Users\somsa\Documents\GitHub\link--manager\LinkManager\Views\Links\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(2716, 121, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            <div style=\"max-width: 70%\">\r\n");
            EndContext();
#line 67 "C:\Users\somsa\Documents\GitHub\link--manager\LinkManager\Views\Links\Index.cshtml"
                                 foreach (var tag in item.LinkTags?.Select(_ => _.Tag) ?? new List<Tag>())
                                {

#line default
#line hidden
            BeginContext(2980, 80, true);
            WriteLiteral("                                    <a class=\"btn btn-outline-primary tag-cntrl\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 3060, "\"", 3077, 1);
#line 69 "C:\Users\somsa\Documents\GitHub\link--manager\LinkManager\Views\Links\Index.cshtml"
WriteAttributeValue("", 3068, tag.Name, 3068, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 3078, "\"", 3099, 2);
            WriteAttributeValue("", 3085, "?tagId=", 3085, 7, true);
#line 69 "C:\Users\somsa\Documents\GitHub\link--manager\LinkManager\Views\Links\Index.cshtml"
WriteAttributeValue("", 3092, tag.Id, 3092, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3100, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3102, 8, false);
#line 69 "C:\Users\somsa\Documents\GitHub\link--manager\LinkManager\Views\Links\Index.cshtml"
                                                                                                                    Write(tag.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3110, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 70 "C:\Users\somsa\Documents\GitHub\link--manager\LinkManager\Views\Links\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(3151, 125, true);
            WriteLiteral("                            </div>\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3276, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f27aba500370663b51aef5ec30578e3021ca035717557", async() => {
                BeginContext(3321, 4, true);
                WriteLiteral("Edit");
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
#line 74 "C:\Users\somsa\Documents\GitHub\link--manager\LinkManager\Views\Links\Index.cshtml"
                                                   WriteLiteral(item.Id);

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
            BeginContext(3329, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(3330, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f27aba500370663b51aef5ec30578e3021ca035719896", async() => {
                BeginContext(3377, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 74 "C:\Users\somsa\Documents\GitHub\link--manager\LinkManager\Views\Links\Index.cshtml"
                                                                                                           WriteLiteral(item.Id);

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
            BeginContext(3387, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 77 "C:\Users\somsa\Documents\GitHub\link--manager\LinkManager\Views\Links\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(3466, 130, true);
            WriteLiteral("            </tbody>\r\n            <tfoot>\r\n                <tr>\r\n                    <td colspan=\"5\" style=\"text-align: center\">\r\n");
            EndContext();
#line 82 "C:\Users\somsa\Documents\GitHub\link--manager\LinkManager\Views\Links\Index.cshtml"
                         if (currentPage > 0)
                        {

#line default
#line hidden
            BeginContext(3670, 30, true);
            WriteLiteral("                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3700, "\"", 3731, 2);
            WriteAttributeValue("", 3707, "?page=", 3707, 6, true);
#line 84 "C:\Users\somsa\Documents\GitHub\link--manager\LinkManager\Views\Links\Index.cshtml"
WriteAttributeValue("", 3713, currentPage - 1, 3713, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3732, 106, true);
            WriteLiteral(">\r\n                                <i class=\"fas fa-chevron-left\"></i>\r\n                            </a>\r\n");
            EndContext();
#line 87 "C:\Users\somsa\Documents\GitHub\link--manager\LinkManager\Views\Links\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(3865, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(3890, 11, false);
#line 88 "C:\Users\somsa\Documents\GitHub\link--manager\LinkManager\Views\Links\Index.cshtml"
                   Write(currentPage);

#line default
#line hidden
            EndContext();
            BeginContext(3901, 28, true);
            WriteLiteral("\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3929, "\"", 3960, 2);
            WriteAttributeValue("", 3936, "?page=", 3936, 6, true);
#line 89 "C:\Users\somsa\Documents\GitHub\link--manager\LinkManager\Views\Links\Index.cshtml"
WriteAttributeValue("", 3942, currentPage + 1, 3942, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3961, 211, true);
            WriteLiteral(">\r\n                            <i class=\"fas fa-chevron-right\"></i>\r\n                        </a>\r\n                    </td>\r\n                </tr>\r\n            </tfoot>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LinkManager.ViewModels.LinkIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
