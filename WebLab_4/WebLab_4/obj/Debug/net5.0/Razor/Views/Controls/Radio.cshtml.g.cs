#pragma checksum "C:\Users\User\source\repos\WebLab_4\WebLab_4\Views\Controls\Radio.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85f377331e74306055afe07f71784dfbfda3aacd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Controls_Radio), @"mvc.1.0.view", @"/Views/Controls/Radio.cshtml")]
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
#line 1 "C:\Users\User\source\repos\WebLab_4\WebLab_4\Views\_ViewImports.cshtml"
using WebLab_4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\WebLab_4\WebLab_4\Views\_ViewImports.cshtml"
using WebLab_4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85f377331e74306055afe07f71784dfbfda3aacd", @"/Views/Controls/Radio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f6eb8019e25c679caadb52e878d0fe5ed482520", @"/Views/_ViewImports.cshtml")]
    public class Views_Controls_Radio : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin: 5px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\User\source\repos\WebLab_4\WebLab_4\Views\Controls\Radio.cshtml"
  
    ViewData["Title"] = "Radio";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>");
#nullable restore
#line 5 "C:\Users\User\source\repos\WebLab_4\WebLab_4\Views\Controls\Radio.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85f377331e74306055afe07f71784dfbfda3aacd4257", async() => {
                WriteLiteral("\n    <div class=\"m-2\"><b>Month</b></div>\n    ");
#nullable restore
#line 9 "C:\Users\User\source\repos\WebLab_4\WebLab_4\Views\Controls\Radio.cshtml"
Write(Html.RadioButton("result", "Январь"));

#line default
#line hidden
#nullable disable
                WriteLiteral("<label style=\"margin-left: 5px\">January</label><br />\n    ");
#nullable restore
#line 10 "C:\Users\User\source\repos\WebLab_4\WebLab_4\Views\Controls\Radio.cshtml"
Write(Html.RadioButton("result", "Февраль"));

#line default
#line hidden
#nullable disable
                WriteLiteral("<label style=\"margin-left: 5px\">February</label><br />\n    ");
#nullable restore
#line 11 "C:\Users\User\source\repos\WebLab_4\WebLab_4\Views\Controls\Radio.cshtml"
Write(Html.RadioButton("result", "Март"));

#line default
#line hidden
#nullable disable
                WriteLiteral("<label style=\"margin-left: 5px\">March</label><br />\n    ");
#nullable restore
#line 12 "C:\Users\User\source\repos\WebLab_4\WebLab_4\Views\Controls\Radio.cshtml"
Write(Html.RadioButton("result", "Апрель"));

#line default
#line hidden
#nullable disable
                WriteLiteral("<label style=\"margin-left: 5px\">April</label><br />\n    ");
#nullable restore
#line 13 "C:\Users\User\source\repos\WebLab_4\WebLab_4\Views\Controls\Radio.cshtml"
Write(Html.RadioButton("result", "Май"));

#line default
#line hidden
#nullable disable
                WriteLiteral("<label style=\"margin-left: 5px\">May</label><br />\n    ");
#nullable restore
#line 14 "C:\Users\User\source\repos\WebLab_4\WebLab_4\Views\Controls\Radio.cshtml"
Write(Html.RadioButton("result", "Июнь"));

#line default
#line hidden
#nullable disable
                WriteLiteral("<label style=\"margin-left: 5px\">June</label><br />\n    ");
#nullable restore
#line 15 "C:\Users\User\source\repos\WebLab_4\WebLab_4\Views\Controls\Radio.cshtml"
Write(Html.RadioButton("result", "Июль"));

#line default
#line hidden
#nullable disable
                WriteLiteral("<label style=\"margin-left: 5px\">July</label><br />\n    ");
#nullable restore
#line 16 "C:\Users\User\source\repos\WebLab_4\WebLab_4\Views\Controls\Radio.cshtml"
Write(Html.RadioButton("result", "Август"));

#line default
#line hidden
#nullable disable
                WriteLiteral("<label style=\"margin-left: 5px\">August</label><br />\n    ");
#nullable restore
#line 17 "C:\Users\User\source\repos\WebLab_4\WebLab_4\Views\Controls\Radio.cshtml"
Write(Html.RadioButton("result", "Сентябрь"));

#line default
#line hidden
#nullable disable
                WriteLiteral("<label style=\"margin-left: 5px\">September</label><br />\n    ");
#nullable restore
#line 18 "C:\Users\User\source\repos\WebLab_4\WebLab_4\Views\Controls\Radio.cshtml"
Write(Html.RadioButton("result", "Октябрь"));

#line default
#line hidden
#nullable disable
                WriteLiteral("<label style=\"margin-left: 5px\">October</label><br />\n    ");
#nullable restore
#line 19 "C:\Users\User\source\repos\WebLab_4\WebLab_4\Views\Controls\Radio.cshtml"
Write(Html.RadioButton("result", "Ноябрь"));

#line default
#line hidden
#nullable disable
                WriteLiteral("<label style=\"margin-left: 5px\">November</label><br />\n    ");
#nullable restore
#line 20 "C:\Users\User\source\repos\WebLab_4\WebLab_4\Views\Controls\Radio.cshtml"
Write(Html.RadioButton("result", "Декабрь"));

#line default
#line hidden
#nullable disable
                WriteLiteral("<label style=\"margin-left: 5px\">December</label><br />\n    <p>\n        <input type=\"submit\" class=\"btn btn-outline-dark\"  value=\"Submit\" style=\"margin-top: 5px\"/>\n    </p>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591