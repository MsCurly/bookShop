#pragma checksum "C:\Users\zuley\Desktop\Turkcell Geleceği Yazanlar\Ödevler\bookShop\bookShop\Views\Products\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b52a0e9cd24828277c1bb348d5e7ed72fb55a012"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Details), @"mvc.1.0.view", @"/Views/Products/Details.cshtml")]
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
#line 1 "C:\Users\zuley\Desktop\Turkcell Geleceği Yazanlar\Ödevler\bookShop\bookShop\Views\_ViewImports.cshtml"
using bookShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\zuley\Desktop\Turkcell Geleceği Yazanlar\Ödevler\bookShop\bookShop\Views\_ViewImports.cshtml"
using bookShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b52a0e9cd24828277c1bb348d5e7ed72fb55a012", @"/Views/Products/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7be4aaeda0fc7a3134a44ff87a8298134bd65968", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<bookShop.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\zuley\Desktop\Turkcell Geleceği Yazanlar\Ödevler\bookShop\bookShop\Views\Products\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Prdouct</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\zuley\Desktop\Turkcell Geleceği Yazanlar\Ödevler\bookShop\bookShop\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\zuley\Desktop\Turkcell Geleceği Yazanlar\Ödevler\bookShop\bookShop\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\zuley\Desktop\Turkcell Geleceği Yazanlar\Ödevler\bookShop\bookShop\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Yazar));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\zuley\Desktop\Turkcell Geleceği Yazanlar\Ödevler\bookShop\bookShop\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.Yazar));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\zuley\Desktop\Turkcell Geleceği Yazanlar\Ödevler\bookShop\bookShop\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Çevirmen));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\zuley\Desktop\Turkcell Geleceği Yazanlar\Ödevler\bookShop\bookShop\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.Çevirmen));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\zuley\Desktop\Turkcell Geleceği Yazanlar\Ödevler\bookShop\bookShop\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Yayınevi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\zuley\Desktop\Turkcell Geleceği Yazanlar\Ödevler\bookShop\bookShop\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.Yayınevi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\zuley\Desktop\Turkcell Geleceği Yazanlar\Ödevler\bookShop\bookShop\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\zuley\Desktop\Turkcell Geleceği Yazanlar\Ödevler\bookShop\bookShop\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\zuley\Desktop\Turkcell Geleceği Yazanlar\Ödevler\bookShop\bookShop\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\zuley\Desktop\Turkcell Geleceği Yazanlar\Ödevler\bookShop\bookShop\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\zuley\Desktop\Turkcell Geleceği Yazanlar\Ödevler\bookShop\bookShop\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\zuley\Desktop\Turkcell Geleceği Yazanlar\Ödevler\bookShop\bookShop\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\zuley\Desktop\Turkcell Geleceği Yazanlar\Ödevler\bookShop\bookShop\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Discount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Users\zuley\Desktop\Turkcell Geleceği Yazanlar\Ödevler\bookShop\bookShop\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.Discount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\Users\zuley\Desktop\Turkcell Geleceği Yazanlar\Ödevler\bookShop\bookShop\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ImageUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 1953, "\"", 1974, 1);
#nullable restore
#line 65 "C:\Users\zuley\Desktop\Turkcell Geleceği Yazanlar\Ödevler\bookShop\bookShop\Views\Products\Details.cshtml"
WriteAttributeValue("", 1959, Model.ImageUrl, 1959, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1975, "\"", 1999, 1);
#nullable restore
#line 65 "C:\Users\zuley\Desktop\Turkcell Geleceği Yazanlar\Ödevler\bookShop\bookShop\Views\Products\Details.cshtml"
WriteAttributeValue("", 1981, Model.Description, 1981, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "C:\Users\zuley\Desktop\Turkcell Geleceği Yazanlar\Ödevler\bookShop\bookShop\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CategoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "C:\Users\zuley\Desktop\Turkcell Geleceği Yazanlar\Ödevler\bookShop\bookShop\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.Category.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b52a0e9cd24828277c1bb348d5e7ed72fb55a01211552", async() => {
                WriteLiteral("Ürünü Güncelle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "C:\Users\zuley\Desktop\Turkcell Geleceği Yazanlar\Ödevler\bookShop\bookShop\Views\Products\Details.cshtml"
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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b52a0e9cd24828277c1bb348d5e7ed72fb55a01213731", async() => {
                WriteLiteral("Ürün Listesine Geri Dön!");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<bookShop.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591