#pragma checksum "C:\Users\depza\OneDrive\Documents\Study\prn221\PRN231\Asm_1_PRN231\ClientWebApi\Views\Publisher\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9f2b23128af5e65a5aa9808c84c7bd0d35e4413"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Publisher_Index), @"mvc.1.0.view", @"/Views/Publisher/Index.cshtml")]
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
#line 1 "C:\Users\depza\OneDrive\Documents\Study\prn221\PRN231\Asm_1_PRN231\ClientWebApi\Views\_ViewImports.cshtml"
using ClientWebApi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\depza\OneDrive\Documents\Study\prn221\PRN231\Asm_1_PRN231\ClientWebApi\Views\_ViewImports.cshtml"
using ClientWebApi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9f2b23128af5e65a5aa9808c84c7bd0d35e4413", @"/Views/Publisher/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"794791ebeba285cd4c571ca289334f4125f9b453", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Publisher_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BusinessObject.Models.Publisher>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\depza\OneDrive\Documents\Study\prn221\PRN231\Asm_1_PRN231\ClientWebApi\Views\Publisher\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>List of Publishers</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9f2b23128af5e65a5aa9808c84c7bd0d35e44133860", async() => {
                WriteLiteral("Create New Publisher");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\depza\OneDrive\Documents\Study\prn221\PRN231\Asm_1_PRN231\ClientWebApi\Views\Publisher\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Pub_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\depza\OneDrive\Documents\Study\prn221\PRN231\Asm_1_PRN231\ClientWebApi\Views\Publisher\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Publisher_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\depza\OneDrive\Documents\Study\prn221\PRN231\Asm_1_PRN231\ClientWebApi\Views\Publisher\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\depza\OneDrive\Documents\Study\prn221\PRN231\Asm_1_PRN231\ClientWebApi\Views\Publisher\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\depza\OneDrive\Documents\Study\prn221\PRN231\Asm_1_PRN231\ClientWebApi\Views\Publisher\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 34 "C:\Users\depza\OneDrive\Documents\Study\prn221\PRN231\Asm_1_PRN231\ClientWebApi\Views\Publisher\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\depza\OneDrive\Documents\Study\prn221\PRN231\Asm_1_PRN231\ClientWebApi\Views\Publisher\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Pub_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\depza\OneDrive\Documents\Study\prn221\PRN231\Asm_1_PRN231\ClientWebApi\Views\Publisher\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Publisher_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\depza\OneDrive\Documents\Study\prn221\PRN231\Asm_1_PRN231\ClientWebApi\Views\Publisher\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\depza\OneDrive\Documents\Study\prn221\PRN231\Asm_1_PRN231\ClientWebApi\Views\Publisher\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\depza\OneDrive\Documents\Study\prn221\PRN231\Asm_1_PRN231\ClientWebApi\Views\Publisher\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\depza\OneDrive\Documents\Study\prn221\PRN231\Asm_1_PRN231\ClientWebApi\Views\Publisher\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { pub_id = item.Pub_id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 53 "C:\Users\depza\OneDrive\Documents\Study\prn221\PRN231\Asm_1_PRN231\ClientWebApi\Views\Publisher\Index.cshtml"
           Write(Html.ActionLink("Delete", "DeletePublisher", new { pub_id = item.Pub_id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 56 "C:\Users\depza\OneDrive\Documents\Study\prn221\PRN231\Asm_1_PRN231\ClientWebApi\Views\Publisher\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BusinessObject.Models.Publisher>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
