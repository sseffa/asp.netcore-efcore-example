#pragma checksum "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\Suppliers\RelationshipEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c45d24951bf6b3f3fa6ee788c41cfae893c9fa3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Suppliers_RelationshipEdit), @"mvc.1.0.view", @"/Views/Suppliers/RelationshipEdit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Suppliers/RelationshipEdit.cshtml", typeof(AspNetCore.Views_Suppliers_RelationshipEdit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c45d24951bf6b3f3fa6ee788c41cfae893c9fa3", @"/Views/Suppliers/RelationshipEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"672f5cb4d49057375a4f11678a6dd0f7c6b3d788", @"/Views/_ViewImports.cshtml")]
    public class Views_Suppliers_RelationshipEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ValueTuple<Supplier, IEnumerable<Supplier>>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Change", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\Suppliers\RelationshipEdit.cshtml"
  
    int counter = 0;

#line default
#line hidden
            BeginContext(81, 1706, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c579f191fd5e4248ade8cbc1dd7444f0", async() => {
                BeginContext(121, 36, true);
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"Id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 157, "\"", 180, 1);
#line 6 "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\Suppliers\RelationshipEdit.cshtml"
WriteAttributeValue("", 165, Model.Item1.Id, 165, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(181, 41, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"Name\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 222, "\"", 247, 1);
#line 7 "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\Suppliers\RelationshipEdit.cshtml"
WriteAttributeValue("", 230, Model.Item1.Name, 230, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(248, 41, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"City\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 289, "\"", 314, 1);
#line 8 "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\Suppliers\RelationshipEdit.cshtml"
WriteAttributeValue("", 297, Model.Item1.City, 297, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(315, 42, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"State\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 357, "\"", 383, 1);
#line 9 "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\Suppliers\RelationshipEdit.cshtml"
WriteAttributeValue("", 365, Model.Item1.State, 365, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(384, 5, true);
                WriteLiteral(" />\r\n");
                EndContext();
#line 10 "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\Suppliers\RelationshipEdit.cshtml"
     foreach (Product p in Model.Item1.Products)
    {

#line default
#line hidden
                BeginContext(446, 28, true);
                WriteLiteral("        <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 474, "\"", 502, 3);
                WriteAttributeValue("", 481, "Products[", 481, 9, true);
#line 12 "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\Suppliers\RelationshipEdit.cshtml"
WriteAttributeValue("", 490, counter, 490, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 498, "].Id", 498, 4, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 503, "\"", 516, 1);
#line 12 "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\Suppliers\RelationshipEdit.cshtml"
WriteAttributeValue("", 511, p.Id, 511, 5, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(517, 33, true);
                WriteLiteral(" />\r\n        <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 550, "\"", 580, 3);
                WriteAttributeValue("", 557, "Products[", 557, 9, true);
#line 13 "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\Suppliers\RelationshipEdit.cshtml"
WriteAttributeValue("", 566, counter, 566, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 574, "].Name", 574, 6, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 581, "\"", 596, 1);
#line 13 "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\Suppliers\RelationshipEdit.cshtml"
WriteAttributeValue("", 589, p.Name, 589, 7, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(597, 33, true);
                WriteLiteral(" />\r\n        <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 630, "\"", 664, 3);
                WriteAttributeValue("", 637, "Products[", 637, 9, true);
#line 14 "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\Suppliers\RelationshipEdit.cshtml"
WriteAttributeValue("", 646, counter, 646, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 654, "].Category", 654, 10, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", "\r\n               value=\"", 665, "\"", 700, 1);
#line 15 "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\Suppliers\RelationshipEdit.cshtml"
WriteAttributeValue("", 689, p.Category, 689, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(701, 33, true);
                WriteLiteral(" />\r\n        <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 734, "\"", 765, 3);
                WriteAttributeValue("", 741, "Products[", 741, 9, true);
#line 16 "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\Suppliers\RelationshipEdit.cshtml"
WriteAttributeValue("", 750, counter, 750, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 758, "].Price", 758, 7, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 766, "\"", 782, 1);
#line 16 "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\Suppliers\RelationshipEdit.cshtml"
WriteAttributeValue("", 774, p.Price, 774, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(783, 5, true);
                WriteLiteral(" />\r\n");
                EndContext();
                BeginContext(790, 56, true);
                WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col\">");
                EndContext();
                BeginContext(847, 6, false);
#line 19 "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\Suppliers\RelationshipEdit.cshtml"
                        Write(p.Name);

#line default
#line hidden
                EndContext();
                BeginContext(853, 37, true);
                WriteLiteral("</div>\r\n            <div class=\"col\">");
                EndContext();
                BeginContext(891, 10, false);
#line 20 "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\Suppliers\RelationshipEdit.cshtml"
                        Write(p.Category);

#line default
#line hidden
                EndContext();
                BeginContext(901, 62, true);
                WriteLiteral("</div>\r\n            <div class=\"col\">\r\n                <select");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 963, "\"", 999, 3);
                WriteAttributeValue("", 970, "Products[", 970, 9, true);
#line 22 "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\Suppliers\RelationshipEdit.cshtml"
WriteAttributeValue("", 979, counter, 979, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 987, "].SupplierId", 987, 12, true);
                EndWriteAttribute();
                BeginContext(1000, 3, true);
                WriteLiteral(">\r\n");
                EndContext();
#line 23 "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\Suppliers\RelationshipEdit.cshtml"
                     foreach (Supplier s in Model.Item2)
                    {
                        if (p.Supplier == s)
                        {

#line default
#line hidden
                BeginContext(1157, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(1185, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3addf1bc861c48dcbec94279a737077c", async() => {
                    BeginContext(1217, 6, false);
#line 27 "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\Suppliers\RelationshipEdit.cshtml"
                                                      Write(s.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
#line 27 "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\Suppliers\RelationshipEdit.cshtml"
                                        WriteLiteral(s.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1232, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 28 "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\Suppliers\RelationshipEdit.cshtml"
                        }
                        else
                        {

#line default
#line hidden
                BeginContext(1318, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(1346, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c222ce6844343fda24f46fdf21f7baa", async() => {
                    BeginContext(1369, 6, false);
#line 31 "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\Suppliers\RelationshipEdit.cshtml"
                                             Write(s.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 31 "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\Suppliers\RelationshipEdit.cshtml"
                               WriteLiteral(s.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1384, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 32 "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\Suppliers\RelationshipEdit.cshtml"
                        }
                    }

#line default
#line hidden
                BeginContext(1436, 63, true);
                WriteLiteral("                </select>\r\n            </div>\r\n        </div>\r\n");
                EndContext();
#line 37 "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\Suppliers\RelationshipEdit.cshtml"

        counter++;
    }

#line default
#line hidden
                BeginContext(1528, 157, true);
                WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col text-center m-1\">\r\n            <button class=\"btn btn-sm btn-danger\" type=\"submit\">Save</button>\r\n            ");
                EndContext();
                BeginContext(1685, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5a324a70f5542898137c436e52ee951", async() => {
                    BeginContext(1740, 6, true);
                    WriteLiteral("Cancel");
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
                BeginContext(1750, 30, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1787, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ValueTuple<Supplier, IEnumerable<Supplier>>> Html { get; private set; }
    }
}
#pragma warning restore 1591
