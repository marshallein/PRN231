#pragma checksum "F:\work-study\PRN231\Project\PRN231\Asm_1_PRN231\ClientWebApi\Views\User\ListBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f76cbfaf17ffacfc4e942153804240759b498a48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_ListBook), @"mvc.1.0.view", @"/Views/User/ListBook.cshtml")]
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
#line 1 "F:\work-study\PRN231\Project\PRN231\Asm_1_PRN231\ClientWebApi\Views\_ViewImports.cshtml"
using ClientWebApi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\work-study\PRN231\Project\PRN231\Asm_1_PRN231\ClientWebApi\Views\_ViewImports.cshtml"
using ClientWebApi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f76cbfaf17ffacfc4e942153804240759b498a48", @"/Views/User/ListBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"794791ebeba285cd4c571ca289334f4125f9b453", @"/Views/_ViewImports.cshtml")]
    public class Views_User_ListBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BusinessObject.Models.Book>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "F:\work-study\PRN231\Project\PRN231\Asm_1_PRN231\ClientWebApi\Views\User\ListBook.cshtml"
  
    ViewData["Title"] = "ListBook";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ListBook</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f76cbfaf17ffacfc4e942153804240759b498a483717", async() => {
                WriteLiteral("Back to Update");
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
#line 16 "F:\work-study\PRN231\Project\PRN231\Asm_1_PRN231\ClientWebApi\Views\User\ListBook.cshtml"
           Write(Html.DisplayNameFor(model => model.Book_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "F:\work-study\PRN231\Project\PRN231\Asm_1_PRN231\ClientWebApi\Views\User\ListBook.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "F:\work-study\PRN231\Project\PRN231\Asm_1_PRN231\ClientWebApi\Views\User\ListBook.cshtml"
           Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "F:\work-study\PRN231\Project\PRN231\Asm_1_PRN231\ClientWebApi\Views\User\ListBook.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "F:\work-study\PRN231\Project\PRN231\Asm_1_PRN231\ClientWebApi\Views\User\ListBook.cshtml"
           Write(Html.DisplayNameFor(model => model.Advance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "F:\work-study\PRN231\Project\PRN231\Asm_1_PRN231\ClientWebApi\Views\User\ListBook.cshtml"
           Write(Html.DisplayNameFor(model => model.Royalty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "F:\work-study\PRN231\Project\PRN231\Asm_1_PRN231\ClientWebApi\Views\User\ListBook.cshtml"
           Write(Html.DisplayNameFor(model => model.Ytd_sales));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "F:\work-study\PRN231\Project\PRN231\Asm_1_PRN231\ClientWebApi\Views\User\ListBook.cshtml"
           Write(Html.DisplayNameFor(model => model.Notes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "F:\work-study\PRN231\Project\PRN231\Asm_1_PRN231\ClientWebApi\Views\User\ListBook.cshtml"
           Write(Html.DisplayNameFor(model => model.Publisher_date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "F:\work-study\PRN231\Project\PRN231\Asm_1_PRN231\ClientWebApi\Views\User\ListBook.cshtml"
           Write(Html.DisplayNameFor(model => model.Pub_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 48 "F:\work-study\PRN231\Project\PRN231\Asm_1_PRN231\ClientWebApi\Views\User\ListBook.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 51 "F:\work-study\PRN231\Project\PRN231\Asm_1_PRN231\ClientWebApi\Views\User\ListBook.cshtml"
           Write(Html.DisplayFor(modelItem => item.Book_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 54 "F:\work-study\PRN231\Project\PRN231\Asm_1_PRN231\ClientWebApi\Views\User\ListBook.cshtml"
           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 57 "F:\work-study\PRN231\Project\PRN231\Asm_1_PRN231\ClientWebApi\Views\User\ListBook.cshtml"
           Write(Html.DisplayFor(modelItem => item.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 60 "F:\work-study\PRN231\Project\PRN231\Asm_1_PRN231\ClientWebApi\Views\User\ListBook.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 63 "F:\work-study\PRN231\Project\PRN231\Asm_1_PRN231\ClientWebApi\Views\User\ListBook.cshtml"
           Write(Html.DisplayFor(modelItem => item.Advance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 66 "F:\work-study\PRN231\Project\PRN231\Asm_1_PRN231\ClientWebApi\Views\User\ListBook.cshtml"
           Write(Html.DisplayFor(modelItem => item.Royalty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 69 "F:\work-study\PRN231\Project\PRN231\Asm_1_PRN231\ClientWebApi\Views\User\ListBook.cshtml"
           Write(Html.DisplayFor(modelItem => item.Ytd_sales));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 72 "F:\work-study\PRN231\Project\PRN231\Asm_1_PRN231\ClientWebApi\Views\User\ListBook.cshtml"
           Write(Html.DisplayFor(modelItem => item.Notes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 75 "F:\work-study\PRN231\Project\PRN231\Asm_1_PRN231\ClientWebApi\Views\User\ListBook.cshtml"
           Write(Html.DisplayFor(modelItem => item.Publisher_date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 78 "F:\work-study\PRN231\Project\PRN231\Asm_1_PRN231\ClientWebApi\Views\User\ListBook.cshtml"
           Write(Html.DisplayFor(modelItem => item.Pub_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 81 "F:\work-study\PRN231\Project\PRN231\Asm_1_PRN231\ClientWebApi\Views\User\ListBook.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BusinessObject.Models.Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
