#pragma checksum "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\One2One\RelationshipEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4117329ac2c98a45c1aeb3aa38a2c11cad7fa8a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_One2One_RelationshipEdit), @"mvc.1.0.view", @"/Views/One2One/RelationshipEdit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/One2One/RelationshipEdit.cshtml", typeof(AspNetCore.Views_One2One_RelationshipEdit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4117329ac2c98a45c1aeb3aa38a2c11cad7fa8a3", @"/Views/One2One/RelationshipEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"672f5cb4d49057375a4f11678a6dd0f7c6b3d788", @"/Views/_ViewImports.cshtml")]
    public class Views_One2One_RelationshipEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<long>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(13, 23, true);
            WriteLiteral("<div class=\"p-1 m-1\">\r\n");
            EndContext();
#line 3 "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\One2One\RelationshipEdit.cshtml"
     foreach (Supplier s in ViewBag.Suppliers)
    {
        

#line default
#line hidden
#line 5 "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\One2One\RelationshipEdit.cshtml"
         if (s.Id != Model)
        {

#line default
#line hidden
            BeginContext(131, 145, true);
            WriteLiteral("            <div class=\"form-row\">\r\n                <div class=\"form-group col\">\r\n                    <input type=\"radio\" name=\"targetSupplierId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 276, "\"", 289, 1);
#line 9 "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\One2One\RelationshipEdit.cshtml"
WriteAttributeValue("", 284, s.Id, 284, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(290, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 10 "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\One2One\RelationshipEdit.cshtml"
                     if (s.Contact == null)
                    {

#line default
#line hidden
            BeginContext(363, 58, true);
            WriteLiteral("                        <input type=\"hidden\" name=\"spares\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 421, "\"", 434, 1);
#line 12 "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\One2One\RelationshipEdit.cshtml"
WriteAttributeValue("", 429, s.Id, 429, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(435, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 13 "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\One2One\RelationshipEdit.cshtml"
                    }

#line default
#line hidden
            BeginContext(463, 126, true);
            WriteLiteral("                </div>\r\n                <div class=\"form-group col-1\">\r\n                    <label class=\"form-control-label\">");
            EndContext();
            BeginContext(590, 4, false);
#line 16 "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\One2One\RelationshipEdit.cshtml"
                                                 Write(s.Id);

#line default
#line hidden
            EndContext();
            BeginContext(594, 134, true);
            WriteLiteral("</label>\r\n                </div>\r\n                <div class=\"form-group col\">\r\n                    <label class=\"form-control-label\">");
            EndContext();
            BeginContext(729, 6, false);
#line 19 "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\One2One\RelationshipEdit.cshtml"
                                                 Write(s.Name);

#line default
#line hidden
            EndContext();
            BeginContext(735, 134, true);
            WriteLiteral("</label>\r\n                </div>\r\n                <div class=\"form-group col\">\r\n                    <label class=\"form-control-label\">");
            EndContext();
            BeginContext(870, 6, false);
#line 22 "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\One2One\RelationshipEdit.cshtml"
                                                 Write(s.City);

#line default
#line hidden
            EndContext();
            BeginContext(876, 134, true);
            WriteLiteral("</label>\r\n                </div>\r\n                <div class=\"form-group col\">\r\n                    <label class=\"form-control-label\">");
            EndContext();
            BeginContext(1011, 7, false);
#line 25 "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\One2One\RelationshipEdit.cshtml"
                                                 Write(s.State);

#line default
#line hidden
            EndContext();
            BeginContext(1018, 160, true);
            WriteLiteral("</label>\r\n                </div>\r\n                <div class=\"form-group col\">\r\n                    <label class=\"form-control-label\">\r\n                        ");
            EndContext();
            BeginContext(1180, 45, false);
#line 29 "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\One2One\RelationshipEdit.cshtml"
                    Write(s.Contact == null ? "(None)" : s.Contact.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1226, 76, true);
            WriteLiteral("\r\n                    </label>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 33 "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\One2One\RelationshipEdit.cshtml"
        }

#line default
#line hidden
#line 33 "C:\Users\Sefa\Desktop\LearningEFCore\LearningEFCore\Views\One2One\RelationshipEdit.cshtml"
         
    }

#line default
#line hidden
            BeginContext(1320, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<long> Html { get; private set; }
    }
}
#pragma warning restore 1591