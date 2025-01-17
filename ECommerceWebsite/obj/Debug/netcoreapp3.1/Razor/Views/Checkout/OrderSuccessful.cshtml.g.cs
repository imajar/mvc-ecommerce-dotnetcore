#pragma checksum "C:\Users\danie\source\repos\ECommerceWebsite\ECommerceWebsite\Views\Checkout\OrderSuccessful.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01db201308a55fc691a9d2dcab460c521d2a4e30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Checkout_OrderSuccessful), @"mvc.1.0.view", @"/Views/Checkout/OrderSuccessful.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01db201308a55fc691a9d2dcab460c521d2a4e30", @"/Views/Checkout/OrderSuccessful.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60e1bb6044e2a254cdf4529f0fd05e08b27283ae", @"/Views/_ViewImports.cshtml")]
    public class Views_Checkout_OrderSuccessful : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderSuccessfulViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/icon-pack/png/icon-green-tick.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Order successful"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\danie\source\repos\ECommerceWebsite\ECommerceWebsite\Views\Checkout\OrderSuccessful.cshtml"
  
    ViewData["Title"] = "Order Successful";
    string orderNumber = (Model.Id.ToString("D").Length + 5).ToString();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <div class=\"marginBot10\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "01db201308a55fc691a9d2dcab460c521d2a4e304638", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        <div id=""orderPlacedText"" class=""titleHeader"">Your order has been placed!</div>
    </div>

    <div id=""orderSuccessful"" class=""formDetails"">
        <div id=""orderSuccessfulHeader"" class=""formHeader purpleBlueGrad"">Order Information</div>

        <div class=""padding10"">
            <div>Order Number: ");
#nullable restore
#line 17 "C:\Users\danie\source\repos\ECommerceWebsite\ECommerceWebsite\Views\Checkout\OrderSuccessful.cshtml"
                          Write(orderNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div style=\"color:green;\">Arriving on ");
#nullable restore
#line 18 "C:\Users\danie\source\repos\ECommerceWebsite\ECommerceWebsite\Views\Checkout\OrderSuccessful.cshtml"
                                             Write(Model.ArrivalDate.ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div>Reference Number: ");
#nullable restore
#line 19 "C:\Users\danie\source\repos\ECommerceWebsite\ECommerceWebsite\Views\Checkout\OrderSuccessful.cshtml"
                              Write(Model.ReferenceNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"orderInformation\">\r\n                Use your Reference Number to track your order <a");
            BeginWriteAttribute("href", " href=\'", 905, "\'", 945, 1);
#nullable restore
#line 21 "C:\Users\danie\source\repos\ECommerceWebsite\ECommerceWebsite\Views\Checkout\OrderSuccessful.cshtml"
WriteAttributeValue("", 912, Url.ActionLink("Index", "Track"), 912, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">here</a>.\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderSuccessfulViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
