#pragma checksum "/Users/sierragriffin/OneDrive - BYU Office 365/IS413/OnlineBookStore copy 4/OnlineBookStore/Pages/Admin/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e67c4af0cf0c0fb888341a5a73411b2df91304f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OnlineBookStore.Pages.Admin.Pages_Admin_Index), @"mvc.1.0.razor-page", @"/Pages/Admin/Index.cshtml")]
namespace OnlineBookStore.Pages.Admin
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
#line 3 "/Users/sierragriffin/OneDrive - BYU Office 365/IS413/OnlineBookStore copy 4/OnlineBookStore/Pages/_ViewImports.cshtml"
using OnlineBookStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/sierragriffin/OneDrive - BYU Office 365/IS413/OnlineBookStore copy 4/OnlineBookStore/Pages/Admin/Index.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/admin")]
#nullable restore
#line 4 "/Users/sierragriffin/OneDrive - BYU Office 365/IS413/OnlineBookStore copy 4/OnlineBookStore/Pages/Admin/Index.cshtml"
           [Authorize]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e67c4af0cf0c0fb888341a5a73411b2df91304f", @"/Pages/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f7bf63d5f95d8b12d185d704ee7f4192c6fab48", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ComponentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n");
            WriteLiteral("\n<!DOCTYPE html>\n\n<html>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e67c4af0cf0c0fb888341a5a73411b2df91304f3882", async() => {
                WriteLiteral("\n    <link href=\"~lib/css/bootstrap.min/css\" rel=\"stylesheet\"/>\n    <base href=\"/\"/> <!--base tag specifies the base URL and/or target for all relative URLs-->\n");
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
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e67c4af0cf0c0fb888341a5a73411b2df91304f4999", async() => {
                WriteLiteral("\n\n");
                WriteLiteral("    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("component", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8e67c4af0cf0c0fb888341a5a73411b2df91304f5293", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ComponentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper);
#nullable restore
#line 22 "/Users/sierragriffin/OneDrive - BYU Office 365/IS413/OnlineBookStore copy 4/OnlineBookStore/Pages/Admin/Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.ComponentType = typeof(Routed);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("type", __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.ComponentType, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 22 "/Users/sierragriffin/OneDrive - BYU Office 365/IS413/OnlineBookStore copy 4/OnlineBookStore/Pages/Admin/Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.RenderMode = global::Microsoft.AspNetCore.Mvc.Rendering.RenderMode.Server;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("render-mode", __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.RenderMode, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    <script src=\"/_framework/blazor.server.js\"></script>\n\n");
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
            WriteLiteral("\n\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineBookStore.Pages.Admin.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OnlineBookStore.Pages.Admin.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OnlineBookStore.Pages.Admin.IndexModel>)PageContext?.ViewData;
        public OnlineBookStore.Pages.Admin.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
