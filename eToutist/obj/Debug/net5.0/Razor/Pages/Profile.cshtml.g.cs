#pragma checksum "C:\Users\Ognjen\Desktop\NBP\eTourist\eTourist\eToutist\Pages\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44ce241ccb19b723e35f94a69c8123340c9f5869"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(NBP.Pages.Pages_Profile), @"mvc.1.0.razor-page", @"/Pages/Profile.cshtml")]
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
#line 1 "C:\Users\Ognjen\Desktop\NBP\eTourist\eTourist\eToutist\Pages\_ViewImports.cshtml"
using NBP;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44ce241ccb19b723e35f94a69c8123340c9f5869", @"/Pages/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fd7b9b9d6234a21043257786692be7b6b71b229", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Profile : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/AddAranzman", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<section class=""w3l-content-with-photo-11"">
	<div class=""contentwithphoto-11 py-5"">
		<div class=""container py-md-3"">
            <div style=""margin-bottom:10px;""class=""tabelaRez-info"">
                <div class=""tab"">
                    <button class=""tablinks"" onclick=""openTable(event, 'Reservations')"">Reservations</button>
                    <button class=""tablinks"" onclick=""openTable(event, 'Offers')"">Offers</button>
                    <button class=""tablinks"" onclick=""openTable(event, 'Rooms')"">Rooms</button>
                </div>

                <div id=""Reservations"" class=""tabcontent"">
                    <h4 class=""predstojece-rez"">Reservations</h4>
                    <div>
                        <select id=""sobaOznaka"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44ce241ccb19b723e35f94a69c8123340c9f58694399", async() => {
                WriteLiteral("Room");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 21 "C:\Users\Ognjen\Desktop\NBP\eTourist\eTourist\eToutist\Pages\Profile.cshtml"
                             for(int i = 0; i<@Model.sobe.Count; i++){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44ce241ccb19b723e35f94a69c8123340c9f58695848", async() => {
#nullable restore
#line 22 "C:\Users\Ognjen\Desktop\NBP\eTourist\eTourist\eToutist\Pages\Profile.cshtml"
                                                                           Write(Model.sobe.ElementAt(i).oznaka);

#line default
#line hidden
#nullable disable
                WriteLiteral(" (");
#nullable restore
#line 22 "C:\Users\Ognjen\Desktop\NBP\eTourist\eTourist\eToutist\Pages\Profile.cshtml"
                                                                                                            Write(Model.sobe.ElementAt(i).brojMesta);

#line default
#line hidden
#nullable disable
                WriteLiteral(")");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 22 "C:\Users\Ognjen\Desktop\NBP\eTourist\eTourist\eToutist\Pages\Profile.cshtml"
                                   WriteLiteral(Model.sobe.ElementAt(i).oznaka);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
#nullable restore
#line 22 "C:\Users\Ognjen\Desktop\NBP\eTourist\eTourist\eToutist\Pages\Profile.cshtml"
                                                                                                                                                             }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </select>
                        <button type=""submit"" onclick=""vratiRez()"">See availability</button>
                        <div style=""overflow-y:scroll; height:500px; margin-top:20px;"">
                            <table id=""offers1"" class=""table"" style=""width:95%;"">
                                <thead>
                                    <tr>
                                        <th>Date of reservation</th>
                                        <th>Status</th>
                                        <th>Start date</th>
                                        <th>End date</th>
                                    </tr>
                                </thead>
                                <tbody id=""soba"">
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
                
                <div id=""Offers"" class=""tabcontent"">
                    <");
            WriteLiteral("h4 class=\"predstojece-rez\">Offers</h4>\r\n                    <button >");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44ce241ccb19b723e35f94a69c8123340c9f58699559", async() => {
                WriteLiteral(" Add offer");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-hotelId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "C:\Users\Ognjen\Desktop\NBP\eTourist\eTourist\eToutist\Pages\Profile.cshtml"
                                                              WriteLiteral(Model.hotel.Id.ToString());

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["hotelId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-hotelId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["hotelId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</button>\r\n");
#nullable restore
#line 45 "C:\Users\Ognjen\Desktop\NBP\eTourist\eTourist\eToutist\Pages\Profile.cshtml"
                     if(Model.aranzmani.Count==0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <label class=\"nema-rez\">There are no offers!</label>\r\n");
#nullable restore
#line 48 "C:\Users\Ognjen\Desktop\NBP\eTourist\eTourist\eToutist\Pages\Profile.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div style=""overflow-y:scroll; height:500px;"">
                            <table id=""offers1"" class=""table"" style=""width:95%;"">
                                <thead>
                                    <tr>
                                        <th>Start date</th>
                                        <th>End date</th>
                                        <th>Price</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 61 "C:\Users\Ognjen\Desktop\NBP\eTourist\eTourist\eToutist\Pages\Profile.cshtml"
                                     foreach(var a in @Model.aranzmani)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>");
#nullable restore
#line 64 "C:\Users\Ognjen\Desktop\NBP\eTourist\eTourist\eToutist\Pages\Profile.cshtml"
                                           Write(a.pocetak.ToString("dd.MM.yyyy."));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 65 "C:\Users\Ognjen\Desktop\NBP\eTourist\eTourist\eToutist\Pages\Profile.cshtml"
                                           Write(a.kraj.ToString("dd.MM.yyyy."));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 66 "C:\Users\Ognjen\Desktop\NBP\eTourist\eTourist\eToutist\Pages\Profile.cshtml"
                                           Write(a.cena);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        </tr>\r\n");
#nullable restore
#line 68 "C:\Users\Ognjen\Desktop\NBP\eTourist\eTourist\eToutist\Pages\Profile.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n                        </div>\r\n");
#nullable restore
#line 72 "C:\Users\Ognjen\Desktop\NBP\eTourist\eTourist\eToutist\Pages\Profile.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n\r\n                <div id=\"Rooms\" class=\"tabcontent\">\r\n                    <h4 class=\"predstojece-rez\">Rooms</h4>\r\n");
#nullable restore
#line 77 "C:\Users\Ognjen\Desktop\NBP\eTourist\eTourist\eToutist\Pages\Profile.cshtml"
                         if(Model.sobe.Count==0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <label class=\"nema-rez\">There are no rooms!</label>\r\n");
#nullable restore
#line 80 "C:\Users\Ognjen\Desktop\NBP\eTourist\eTourist\eToutist\Pages\Profile.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div style=""overflow-y:scroll; height:500px;"">
                                <table id=""offers1"" class=""table"" style=""width:95%;"">
                                    <thead>
                                        <tr>
                                            <th>Name</th>
                                            <th>Num. of beds</th>
                                        </tr>
                                    </thead>
                                    <tbody>
");
#nullable restore
#line 92 "C:\Users\Ognjen\Desktop\NBP\eTourist\eTourist\eToutist\Pages\Profile.cshtml"
                                         foreach(var s in @Model.sobe)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n                                                <td>");
#nullable restore
#line 95 "C:\Users\Ognjen\Desktop\NBP\eTourist\eTourist\eToutist\Pages\Profile.cshtml"
                                               Write(s.oznaka);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 96 "C:\Users\Ognjen\Desktop\NBP\eTourist\eTourist\eToutist\Pages\Profile.cshtml"
                                               Write(s.brojMesta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            </tr>\r\n");
#nullable restore
#line 98 "C:\Users\Ognjen\Desktop\NBP\eTourist\eTourist\eToutist\Pages\Profile.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </tbody>\r\n                                </table>\r\n                            </div>\r\n");
#nullable restore
#line 102 "C:\Users\Ognjen\Desktop\NBP\eTourist\eTourist\eToutist\Pages\Profile.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>    
            </div>    
        </div>
    </div>
</section>

<script>
   function openTable(evt, cityName) {
        var i, tabcontent, tablinks;
        tabcontent = document.getElementsByClassName(""tabcontent"");
        for (i = 0; i < tabcontent.length; i++) {
            tabcontent[i].style.display = ""none"";
        }
        tablinks = document.getElementsByClassName(""tablinks"");
        for (i = 0; i < tablinks.length; i++) {
            tablinks[i].className = tablinks[i].className.replace("" active"", """");
        }
        document.getElementById(cityName).style.display = ""block"";
        evt.currentTarget.className += "" active"";
    }
</script>

<script>
function vratiRez(){
    var soba = document.getElementById('sobaOznaka').value;
    console.log(soba);
    $.ajax({
        type: ""GET"",
        url: '/Profile?handler=Soba',
        beforeSend: function (xhr) {
        xhr.setRequestHeader(""XSRF-TOKEN"",
            $('input:hidden[name=""__Req");
            WriteLiteral(@"uestVerificationToken""]').val());
        },
        data: {oznaka:soba},
        success: function (response) {
            $(""#soba"").empty();
            if(response.length!=0){
                var body = document.getElementById('soba');
                for(var i = 0; i < response.datum.length; i++)
                {
                    var red = document.createElement(""tr"");
                    body.appendChild(red);
                    var celija1 = document.createElement(""td"");
                    celija1.innerHTML = response.datum[i];
                    red.appendChild(celija1);
                    var celija2 = document.createElement(""td"");
                    celija2.innerHTML = response.status[i];
                    red.appendChild(celija2);
                    var celija3 = document.createElement(""td"");
                    celija3.innerHTML = response.pocetak[i];
                    red.appendChild(celija3);
                    var celija4 = document.createElement(""td"");
    ");
            WriteLiteral(@"                celija4.innerHTML = response.kraj[i];
                    red.appendChild(celija4);
                }
            }
        }
    })
}
</script>
<script
  src=""https://code.jquery.com/jquery-2.2.4.min.js""
  integrity=""sha256-BbhdlvQf/xTY9gja0Dq3HiwQF8LaCRTXxZKRutelT44=""
  crossorigin=""anonymous""></script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApp.Namespace.ProfileModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.ProfileModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.ProfileModel>)PageContext?.ViewData;
        public MyApp.Namespace.ProfileModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
