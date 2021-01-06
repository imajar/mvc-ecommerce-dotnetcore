#pragma checksum "C:\Users\danie\source\repos\ECommerceWebsite\ECommerceWebsite\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be8bb8106514b8066dfbece79056af784b29ac21"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
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
#line 1 "C:\Users\danie\source\repos\ECommerceWebsite\ECommerceWebsite\Views\_ViewImports.cshtml"
using ECommerceWebsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\danie\source\repos\ECommerceWebsite\ECommerceWebsite\Views\_ViewImports.cshtml"
using ECommerceWebsite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be8bb8106514b8066dfbece79056af784b29ac21", @"/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60e1bb6044e2a254cdf4529f0fd05e08b27283ae", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CategoryProductsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\danie\source\repos\ECommerceWebsite\ECommerceWebsite\Views\Category\Index.cshtml"
   
    ViewData["Title"] = $"Category: {Model.CategoryName}";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"titleHeader\">Category: ");
#nullable restore
#line 6 "C:\Users\danie\source\repos\ECommerceWebsite\ECommerceWebsite\Views\Category\Index.cshtml"
                              Write(Model.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 7 "C:\Users\danie\source\repos\ECommerceWebsite\ECommerceWebsite\Views\Category\Index.cshtml"
 foreach (var product in Model.Products)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"suggestedProductContainer\">\r\n    <div style=\"display:block; width: 100%; height: auto;\">\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 323, "\"", 342, 1);
#nullable restore
#line 11 "C:\Users\danie\source\repos\ECommerceWebsite\ECommerceWebsite\Views\Category\Index.cshtml"
WriteAttributeValue("", 330, product.Url, 330, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <img class=\"suggestedProductImage\"");
            BeginWriteAttribute("src", " src=\"", 392, "\"", 415, 1);
#nullable restore
#line 12 "C:\Users\danie\source\repos\ECommerceWebsite\ECommerceWebsite\Views\Category\Index.cshtml"
WriteAttributeValue("", 398, product.ImageSrc, 398, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 416, "\"", 436, 1);
#nullable restore
#line 12 "C:\Users\danie\source\repos\ECommerceWebsite\ECommerceWebsite\Views\Category\Index.cshtml"
WriteAttributeValue("", 422, product.Title, 422, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        </a>\r\n    </div>\r\n    <div class=\"suggestedProductCategory\">");
#nullable restore
#line 15 "C:\Users\danie\source\repos\ECommerceWebsite\ECommerceWebsite\Views\Category\Index.cshtml"
                                     Write(product.BrandName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div class=\"suggestedProductName\">");
#nullable restore
#line 16 "C:\Users\danie\source\repos\ECommerceWebsite\ECommerceWebsite\Views\Category\Index.cshtml"
                                 Write(product.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 16 "C:\Users\danie\source\repos\ECommerceWebsite\ECommerceWebsite\Views\Category\Index.cshtml"
                                                Write(product.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div class=\"suggestedProductName\">$");
#nullable restore
#line 17 "C:\Users\danie\source\repos\ECommerceWebsite\ECommerceWebsite\Views\Category\Index.cshtml"
                                  Write(product.Price.ToString("N"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div class=\"suggestedProductCategory\">");
#nullable restore
#line 18 "C:\Users\danie\source\repos\ECommerceWebsite\ECommerceWebsite\Views\Category\Index.cshtml"
                                     Write(Model.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n</div>\r\n");
#nullable restore
#line 20 "C:\Users\danie\source\repos\ECommerceWebsite\ECommerceWebsite\Views\Category\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CategoryProductsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
