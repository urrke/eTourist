#pragma checksum "C:\Users\Ognjen\Desktop\eToutist\Pages\Destinations.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "867b8f2316d97e0d2ae750af1adf75e606ff8b42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(NBP.Pages.Pages_Destinations), @"mvc.1.0.razor-page", @"/Pages/Destinations.cshtml")]
namespace NBP.Pages
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
#line 1 "C:\Users\Ognjen\Desktop\eToutist\Pages\_ViewImports.cshtml"
using NBP;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"867b8f2316d97e0d2ae750af1adf75e606ff8b42", @"/Pages/Destinations.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fd7b9b9d6234a21043257786692be7b6b71b229", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Destinations : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Hotels", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<!-- //covers -->\r\n<!---728x90--->\r\n\r\n<section class=\"w3l-features-8\">\r\n       <!-- /features -->\r\n           <div class=\"features py-5\" id=\"services\">\r\n\t\t\t<div class=\"container py-md-3\">\r\n\r\n");
#nullable restore
#line 14 "C:\Users\Ognjen\Desktop\eToutist\Pages\Destinations.cshtml"
         foreach (var drzava in Model.listaDrzava)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<div class=\"heading text-center mx-auto\">\r\n\t\t\t\t<h3 class=\"head\">");
#nullable restore
#line 17 "C:\Users\Ognjen\Desktop\eToutist\Pages\Destinations.cshtml"
                            Write(drzava.naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\t\t\t\t\r\n\t\t \t</div>\r\n");
            WriteLiteral("\t\t\t   <div class=\"fea-gd-vv text-center row mt-5 pt-3\" style=\"padding-bottom: 3rem\">\r\n\t\t\t\t   \t\r\n");
#nullable restore
#line 23 "C:\Users\Ognjen\Desktop\eToutist\Pages\Destinations.cshtml"
                     foreach (var grad in drzava.gradovi)
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<div class=\"float-top col-lg-4 col-md-6\">\t\r\n\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "867b8f2316d97e0d2ae750af1adf75e606ff8b424372", async() => {
                WriteLiteral("<img");
                BeginWriteAttribute("src", " src=\"", 702, "\"", 719, 1);
#nullable restore
#line 26 "C:\Users\Ognjen\Desktop\eToutist\Pages\Destinations.cshtml"
WriteAttributeValue("", 708, grad.slika, 708, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"img-responsive\"");
                BeginWriteAttribute("alt", " alt=\"", 743, "\"", 749, 0);
                EndWriteAttribute();
                WriteLiteral(">");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-grad", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 26 "C:\Users\Ognjen\Desktop\eToutist\Pages\Destinations.cshtml"
                                   WriteLiteral(grad.naziv);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["grad"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-grad", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["grad"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 26 "C:\Users\Ognjen\Desktop\eToutist\Pages\Destinations.cshtml"
                                                                  WriteLiteral(drzava.naziv);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["drzava"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-drzava", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["drzava"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t<div class=\"float-lt feature-gd\">\t\r\n\t\t\t\t\t\t\t\t\t<h3>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "867b8f2316d97e0d2ae750af1adf75e606ff8b427821", async() => {
#nullable restore
#line 28 "C:\Users\Ognjen\Desktop\eToutist\Pages\Destinations.cshtml"
                                                                                                                       Write(grad.naziv);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-grad", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "C:\Users\Ognjen\Desktop\eToutist\Pages\Destinations.cshtml"
                                               WriteLiteral(grad.naziv);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["grad"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-grad", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["grad"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "C:\Users\Ognjen\Desktop\eToutist\Pages\Destinations.cshtml"
                                                                              WriteLiteral(drzava.naziv);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["drzava"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-drzava", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["drzava"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </h3>\r\n\t\t\t\t\t\t\t\t\t\t<p> ");
#nullable restore
#line 29 "C:\Users\Ognjen\Desktop\eToutist\Pages\Destinations.cshtml"
                                       Write(grad.opis);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\t\t\t\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 32 "C:\Users\Ognjen\Desktop\eToutist\Pages\Destinations.cshtml"
					}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t \t\t\t\t \r\n\t\t     \t</div>  \r\n");
#nullable restore
#line 36 "C:\Users\Ognjen\Desktop\eToutist\Pages\Destinations.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\r\n\t\t    </div>\r\n          </div>\r\n      <!-- //features -->\r\n</section>\r\n<!---728x90--->\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApp.Namespace.DestinationsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.DestinationsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.DestinationsModel>)PageContext?.ViewData;
        public MyApp.Namespace.DestinationsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
