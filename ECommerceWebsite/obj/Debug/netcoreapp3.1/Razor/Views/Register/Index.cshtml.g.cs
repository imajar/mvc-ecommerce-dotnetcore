#pragma checksum "C:\Users\danie\source\repos\ECommerceWebsite\ECommerceWebsite\Views\Register\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cba55071beba2dda6eba81c755abf63a7f22db62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Register_Index), @"mvc.1.0.view", @"/Views/Register/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cba55071beba2dda6eba81c755abf63a7f22db62", @"/Views/Register/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60e1bb6044e2a254cdf4529f0fd05e08b27283ae", @"/Views/_ViewImports.cshtml")]
    public class Views_Register_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegisterViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\danie\source\repos\ECommerceWebsite\ECommerceWebsite\Views\Register\Index.cshtml"
 using (Html.BeginForm("Register", "Register", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"formDetails\" onkeyup=\"checkRegisterForm()\">\r\n        <div class=\"formHeader purpleBlueGrad\">Register</div>\r\n\r\n        ");
#nullable restore
#line 8 "C:\Users\danie\source\repos\ECommerceWebsite\ECommerceWebsite\Views\Register\Index.cshtml"
   Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        <div class=\"padding10\">\r\n            <div>\r\n                <div class=\"formLabel floatLeft\">\r\n                    ");
#nullable restore
#line 13 "C:\Users\danie\source\repos\ECommerceWebsite\ECommerceWebsite\Views\Register\Index.cshtml"
               Write(Html.LabelFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"required\">*</span>\r\n                </div>\r\n                <div class=\"formInput floatLeft\">\r\n                    ");
#nullable restore
#line 16 "C:\Users\danie\source\repos\ECommerceWebsite\ECommerceWebsite\Views\Register\Index.cshtml"
               Write(Html.TextBoxFor(m => m.Email, new { @required = "required" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"clearBoth\"></div>\r\n            </div>\r\n\r\n            <div>\r\n                <div class=\"formLabel floatLeft\">\r\n                    ");
#nullable restore
#line 23 "C:\Users\danie\source\repos\ECommerceWebsite\ECommerceWebsite\Views\Register\Index.cshtml"
               Write(Html.LabelFor(m => m.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"required\">*</span>\r\n                </div>\r\n                <div class=\"formInput floatLeft\">\r\n                    ");
#nullable restore
#line 26 "C:\Users\danie\source\repos\ECommerceWebsite\ECommerceWebsite\Views\Register\Index.cshtml"
               Write(Html.TextBoxFor(m => m.FirstName, new { @required = "required" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"clearBoth\"></div>\r\n            </div>\r\n\r\n            <div>\r\n                <div class=\"formLabel floatLeft\">\r\n                    ");
#nullable restore
#line 33 "C:\Users\danie\source\repos\ECommerceWebsite\ECommerceWebsite\Views\Register\Index.cshtml"
               Write(Html.LabelFor(m => m.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"required\">*</span>\r\n                </div>\r\n                <div class=\"formInput floatLeft\">\r\n                    ");
#nullable restore
#line 36 "C:\Users\danie\source\repos\ECommerceWebsite\ECommerceWebsite\Views\Register\Index.cshtml"
               Write(Html.TextBoxFor(m => m.LastName, new { @required = "required" } ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"clearBoth\"></div>\r\n            </div>\r\n\r\n            <div>\r\n                <div class=\"formLabel floatLeft\">\r\n                    ");
#nullable restore
#line 43 "C:\Users\danie\source\repos\ECommerceWebsite\ECommerceWebsite\Views\Register\Index.cshtml"
               Write(Html.LabelFor(m => m.DateOfBirthDay));

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"required\">*</span>\r\n                </div>\r\n                <div class=\"floatLeft\">\r\n                    ");
#nullable restore
#line 46 "C:\Users\danie\source\repos\ECommerceWebsite\ECommerceWebsite\Views\Register\Index.cshtml"
               Write(Html.TextBoxFor(m => m.DateOfBirthDay, new { @class = "inlineBlock dobInputSmall", @maxlength = "2", @placeholder = "DD", @required = "required", onkeyup = "moveToMonth();", id= "dobDay" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 47 "C:\Users\danie\source\repos\ECommerceWebsite\ECommerceWebsite\Views\Register\Index.cshtml"
               Write(Html.TextBoxFor(m => m.DateOfBirthMonth, new { @class = "inlineBlock dobInputSmall", @maxlength = "2", @placeholder = "MM", @required = "required", onkeyup = "moveToYear();", id = "dobMonth" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 48 "C:\Users\danie\source\repos\ECommerceWebsite\ECommerceWebsite\Views\Register\Index.cshtml"
               Write(Html.TextBoxFor(m => m.DateOfBirthYear, new { @class = "inlineBlock dobInputMedium", @maxlength = "4", @placeholder = "YYYY", @required = "required", id = "dobYear" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"clearBoth\"></div>\r\n            </div>\r\n\r\n            <div>\r\n                <div class=\"formLabel floatLeft\">\r\n                    ");
#nullable restore
#line 55 "C:\Users\danie\source\repos\ECommerceWebsite\ECommerceWebsite\Views\Register\Index.cshtml"
               Write(Html.LabelFor(m => m.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"required\">*</span>\r\n                </div>\r\n                <div class=\"formInput floatLeft\">\r\n                    ");
#nullable restore
#line 58 "C:\Users\danie\source\repos\ECommerceWebsite\ECommerceWebsite\Views\Register\Index.cshtml"
               Write(Html.TextBoxFor(m => m.Password, new { @type = "password", @required = "required" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"clearBoth\"></div>\r\n            </div>\r\n\r\n            <div>\r\n                <div class=\"formLabel floatLeft\">\r\n                    ");
#nullable restore
#line 65 "C:\Users\danie\source\repos\ECommerceWebsite\ECommerceWebsite\Views\Register\Index.cshtml"
               Write(Html.LabelFor(m => m.ConfirmPassword, new { @type = "password" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"required\">*</span>\r\n                </div>\r\n                <div class=\"formInput floatLeft\">\r\n                    ");
#nullable restore
#line 68 "C:\Users\danie\source\repos\ECommerceWebsite\ECommerceWebsite\Views\Register\Index.cshtml"
               Write(Html.TextBoxFor(m => m.ConfirmPassword, new { @type = "password", @required = "required" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"clearBoth\"></div>\r\n            </div>\r\n\r\n            <div>\r\n                <div class=\"formLabel floatLeft\">\r\n                    ");
#nullable restore
#line 75 "C:\Users\danie\source\repos\ECommerceWebsite\ECommerceWebsite\Views\Register\Index.cshtml"
               Write(Html.LabelFor(m => m.IsSubscribed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"formInput floatLeft subscribeCheckbox\">\r\n                    ");
#nullable restore
#line 78 "C:\Users\danie\source\repos\ECommerceWebsite\ECommerceWebsite\Views\Register\Index.cshtml"
               Write(Html.CheckBoxFor(m => m.IsSubscribed));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
                <div class=""clearBoth""></div>

                <div class=""subscribeInfo marginBot10"">
                    Subscribed to get the latest news, seassonal offers, giveaways and more!
                </div>
            </div>

            <div>
                <div class=""width50 floatRight""> 
                    <input id=""btnSubmit"" class=""disabledButton"" disabled value=""Sign up"" type=""submit"" />
                </div>
                <div class=""clearBoth""></div>
            </div>
        </div>
    </div>
");
#nullable restore
#line 95 "C:\Users\danie\source\repos\ECommerceWebsite\ECommerceWebsite\Views\Register\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
