#pragma checksum "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\One2One\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0aed79d101aad2a86f6d78c56c9591926b407606"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_One2One_Index), @"mvc.1.0.view", @"/Views/One2One/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/One2One/Index.cshtml", typeof(AspNetCore.Views_One2One_Index))]
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
#line 1 "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\_ViewImports.cshtml"
using LearningEFCore;

#line default
#line hidden
#line 2 "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\_ViewImports.cshtml"
using LearningEFCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0aed79d101aad2a86f6d78c56c9591926b407606", @"/Views/One2One/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"672f5cb4d49057375a4f11678a6dd0f7c6b3d788", @"/Views/_ViewImports.cshtml")]
    public class Views_One2One_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LearningEFCore.Models.ContactDetails>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(58, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\One2One\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(101, 244, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<table class=\"table table-striped table-sm\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>Name</th>\r\n        <th>Phone</th>\r\n        <th></th>\r\n        <th class=\"table-dark text-center\" colspan=\"4\">Supplier</th>\r\n    </tr>\r\n");
            EndContext();
#line 17 "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\One2One\Index.cshtml"
     foreach (var s in Model)
    {

#line default
#line hidden
            BeginContext(383, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(414, 4, false);
#line 20 "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\One2One\Index.cshtml"
           Write(s.Id);

#line default
#line hidden
            EndContext();
            BeginContext(418, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(442, 6, false);
#line 21 "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\One2One\Index.cshtml"
           Write(s.Name);

#line default
#line hidden
            EndContext();
            BeginContext(448, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(472, 7, false);
#line 22 "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\One2One\Index.cshtml"
           Write(s.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(479, 41, true);
            WriteLiteral("</td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(520, 221, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5168e305f88742eb9ba19566206c23b6", async() => {
                BeginContext(526, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(548, 168, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c13deb074454688a51d061bab975474", async() => {
                    BeginContext(655, 52, true);
                    WriteLiteral("\r\n                        Edit\r\n                    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 26 "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\One2One\Index.cshtml"
                                                WriteLiteral(s.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(716, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(741, 21, true);
            WriteLiteral("\r\n            </td>\r\n");
            EndContext();
#line 31 "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\One2One\Index.cshtml"
             if (s.Supplier != null)
            {

#line default
#line hidden
            BeginContext(815, 39, true);
            WriteLiteral("                <td class=\"table-dark\">");
            EndContext();
            BeginContext(855, 13, false);
#line 33 "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\One2One\Index.cshtml"
                                  Write(s.Supplier.Id);

#line default
#line hidden
            EndContext();
            BeginContext(868, 46, true);
            WriteLiteral("</td>\r\n                <td class=\"table-dark\">");
            EndContext();
            BeginContext(915, 15, false);
#line 34 "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\One2One\Index.cshtml"
                                  Write(s.Supplier.Name);

#line default
#line hidden
            EndContext();
            BeginContext(930, 46, true);
            WriteLiteral("</td>\r\n                <td class=\"table-dark\">");
            EndContext();
            BeginContext(977, 15, false);
#line 35 "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\One2One\Index.cshtml"
                                  Write(s.Supplier.City);

#line default
#line hidden
            EndContext();
            BeginContext(992, 46, true);
            WriteLiteral("</td>\r\n                <td class=\"table-dark\">");
            EndContext();
            BeginContext(1039, 16, false);
#line 36 "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\One2One\Index.cshtml"
                                  Write(s.Supplier.State);

#line default
#line hidden
            EndContext();
            BeginContext(1055, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 37 "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\One2One\Index.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1110, 129, true);
            WriteLiteral("                <td colspan=\"4\" class=\"table-dark text-center\">\r\n                    No Related Supplier\r\n                </td>\r\n");
            EndContext();
#line 43 "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\One2One\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1254, 15, true);
            WriteLiteral("        </tr>\r\n");
            EndContext();
#line 45 "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\One2One\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1276, 10, true);
            WriteLiteral("</table>\r\n");
            EndContext();
            BeginContext(1286, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd5633bf87be46d29ea1b55c6b3e6414", async() => {
                BeginContext(1333, 6, true);
                WriteLiteral("Create");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LearningEFCore.Models.ContactDetails>> Html { get; private set; }
    }
}
#pragma warning restore 1591