#pragma checksum "C:\Users\depza\OneDrive\Documents\Study\prn221\PRN231\Asm_1_PRN231\ClientWebApi\Views\User\ListAuthor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "425384387bd81c0057a3d95de8acbbedcbc823fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_ListAuthor), @"mvc.1.0.view", @"/Views/User/ListAuthor.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"425384387bd81c0057a3d95de8acbbedcbc823fe", @"/Views/User/ListAuthor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"794791ebeba285cd4c571ca289334f4125f9b453", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_ListAuthor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BusinessObject.Models.Author>>
    #nullable disable
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
#line 3 "C:\Users\depza\OneDrive\Documents\Study\prn221\PRN231\Asm_1_PRN231\ClientWebApi\Views\User\ListAuthor.cshtml"
  
    ViewData["Title"] = "ListAuthor";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ListAuthor</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "425384387bd81c0057a3d95de8acbbedcbc823fe3853", async() => {
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
#line 16 "C:\Users\depza\OneDrive\Documents\Study\prn221\PRN231\Asm_1_PRN231\ClientWebApi\Views\User\ListAuthor.cshtml"
           Write(Html.DisplayNameFor(model => model.Author_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\depza\OneDrive\Documents\Study\prn221\PRN231\Asm_1_PRN231\ClientWebApi\Views\User\ListAuthor.cshtml"
           Write(Html.DisplayNameFor(model => model.First_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\depza\OneDrive\Documents\Study\prn221\PRN231\Asm_1_PRN231\ClientWebApi\Views\User\ListAuthor.cshtml"
           Write(Html.DisplayNameFor(model => model.Last_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\depza\OneDrive\Documents\Study\prn221\PRN231\Asm_1_PRN231\ClientWebApi\Views\User\ListAuthor.cshtml"
           Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\depza\OneDrive\Documents\Study\prn221\PRN231\Asm_1_PRN231\ClientWebApi\Views\User\ListAuthor.cshtml"
           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\depza\OneDrive\Documents\Study\prn221\PRN231\Asm_1_PRN231\ClientWebApi\Views\User\ListAuthor.cshtml"
           Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\depza\OneDrive\Documents\Study\prn221\PRN231\Asm_1_PRN231\ClientWebApi\Views\User\ListAuthor.cshtml"
           Write(Html.DisplayNameFor(model => model.Email_address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 39 "C:\Users\depza\OneDrive\Documents\Study\prn221\PRN231\Asm_1_PRN231\ClientWebApi\Views\User\ListAuthor.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 42 "C:\Users\depza\OneDrive\Documents\Study\prn221\PRN231\Asm_1_PRN231\ClientWebApi\Views\User\ListAuthor.cshtml"
           Write(Html.DisplayFor(modelItem => item.Author_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 45 "C:\Users\depza\OneDrive\Documents\Study\prn221\PRN231\Asm_1_PRN231\ClientWebApi\Views\User\ListAuthor.cshtml"
           Write(Html.DisplayFor(modelItem => item.First_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 48 "C:\Users\depza\OneDrive\Documents\Study\prn221\PRN231\Asm_1_PRN231\ClientWebApi\Views\User\ListAuthor.cshtml"
           Write(Html.DisplayFor(modelItem => item.Last_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 51 "C:\Users\depza\OneDrive\Documents\Study\prn221\PRN231\Asm_1_PRN231\ClientWebApi\Views\User\ListAuthor.cshtml"
           Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 54 "C:\Users\depza\OneDrive\Documents\Study\prn221\PRN231\Asm_1_PRN231\ClientWebApi\Views\User\ListAuthor.cshtml"
           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 57 "C:\Users\depza\OneDrive\Documents\Study\prn221\PRN231\Asm_1_PRN231\ClientWebApi\Views\User\ListAuthor.cshtml"
           Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 60 "C:\Users\depza\OneDrive\Documents\Study\prn221\PRN231\Asm_1_PRN231\ClientWebApi\Views\User\ListAuthor.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email_address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 63 "C:\Users\depza\OneDrive\Documents\Study\prn221\PRN231\Asm_1_PRN231\ClientWebApi\Views\User\ListAuthor.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BusinessObject.Models.Author>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
