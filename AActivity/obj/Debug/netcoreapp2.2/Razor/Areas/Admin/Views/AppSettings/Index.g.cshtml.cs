#pragma checksum "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Admin\Views\AppSettings\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d36fd40270a5d79702aefa38420938927e18b43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AppSettings_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/AppSettings/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/AppSettings/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_AppSettings_Index))]
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
#line 1 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Admin\Views\_ViewImports.cshtml"
using AActivity;

#line default
#line hidden
#line 2 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Admin\Views\_ViewImports.cshtml"
using AActivity.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d36fd40270a5d79702aefa38420938927e18b43", @"/Areas/Admin/Views/AppSettings/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8711de3d765a7b2bba5beade351e7d2616bcfba7", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AppSettings_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AActivity.Models.AppSetting>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn  btn-outline-primary btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-lg btn-outline-gold"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Admin\Views\AppSettings\Index.cshtml"
  
    ViewData["Title"] = "الإعدادات";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(143, 238, true);
            WriteLiteral("\r\n<style>\r\n    .text-gold {\r\n        color: #c0a05f !important\r\n    }\r\n</style>\r\n\r\n\r\n<div class=\"card mt-5\">\r\n    <h5 class=\"card-header bg-primary-bold \">\r\n        <i class=\"fas fa-cogs\"></i>\r\n        ضبط الإعدادات\r\n    </h5>\r\n\r\n</div>\r\n");
            EndContext();
#line 22 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Admin\Views\AppSettings\Index.cshtml"
 if (Model.Any())
{
    

#line default
#line hidden
#line 24 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Admin\Views\AppSettings\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(444, 218, true);
            WriteLiteral("<ul class=\"list-group \">\r\n    <li class=\"list-group-item text-primary\">\r\n\r\n        <div class=\"row \">\r\n            <i class=\"fa fa-calendar-alt fa-2x text-left  col-1\"></i>\r\n            <h5 class=\"col-10 text-right \"> ");
            EndContext();
            BeginContext(663, 47, false);
#line 31 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Admin\Views\AppSettings\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.BookingTime));

#line default
#line hidden
            EndContext();
            BeginContext(710, 122, true);
            WriteLiteral("</h5>\r\n            <h5 class=\"col-1 text-right\">\r\n                <span class=\" font-weight-bolder\">\r\n                    ");
            EndContext();
            BeginContext(833, 46, false);
#line 34 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Admin\Views\AppSettings\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.BookingTime));

#line default
#line hidden
            EndContext();
            BeginContext(879, 254, true);
            WriteLiteral("\r\n                </span>\r\n            </h5>\r\n        </div>\r\n    </li>\r\n    <li class=\"list-group-item text-success\">\r\n        <div class=\"row\">\r\n            <i class=\"fa fa-users fa-2x text-left  col-1\"></i>\r\n            <h5 class=\"col-10 text-right\"> ");
            EndContext();
            BeginContext(1134, 56, false);
#line 42 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Admin\Views\AppSettings\Index.cshtml"
                                      Write(Html.DisplayNameFor(model => model.QtyDeanshipDelegates));

#line default
#line hidden
            EndContext();
            BeginContext(1190, 121, true);
            WriteLiteral("</h5>\r\n            <h4 class=\"col-1 text-right\">\r\n                <span class=\"font-weight-bolder\">\r\n                    ");
            EndContext();
            BeginContext(1312, 55, false);
#line 45 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Admin\Views\AppSettings\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.QtyDeanshipDelegates));

#line default
#line hidden
            EndContext();
            BeginContext(1367, 253, true);
            WriteLiteral("\r\n                </span>\r\n            </h4>\r\n        </div>\r\n    </li>\r\n    <li class=\"list-group-item text-success\">\r\n        <div class=\"row\">\r\n            <i class=\"fa fa-users fa-2x text-left col-1\"></i>\r\n            <h5 class=\"col-10 text-right\"> ");
            EndContext();
            BeginContext(1621, 58, false);
#line 53 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Admin\Views\AppSettings\Index.cshtml"
                                      Write(Html.DisplayNameFor(model => model.QtyInstitutesDelegates));

#line default
#line hidden
            EndContext();
            BeginContext(1679, 121, true);
            WriteLiteral("</h5>\r\n            <h4 class=\"col-1 text-right\">\r\n                <span class=\"font-weight-bolder\">\r\n                    ");
            EndContext();
            BeginContext(1801, 57, false);
#line 56 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Admin\Views\AppSettings\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.QtyInstitutesDelegates));

#line default
#line hidden
            EndContext();
            BeginContext(1858, 255, true);
            WriteLiteral("\r\n                </span>\r\n            </h4>\r\n        </div>\r\n\r\n    </li>\r\n    <li class=\"list-group-item text-success\">\r\n        <div class=\"row\">\r\n            <i class=\"fa fa-users fa-2x text-left col-1\"></i>\r\n            <h5 class=\"col-10 text-right\"> ");
            EndContext();
            BeginContext(2114, 56, false);
#line 65 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Admin\Views\AppSettings\Index.cshtml"
                                      Write(Html.DisplayNameFor(model => model.QtyCollegesDelegates));

#line default
#line hidden
            EndContext();
            BeginContext(2170, 121, true);
            WriteLiteral("</h5>\r\n            <h4 class=\"col-1 text-right\">\r\n                <span class=\"font-weight-bolder\">\r\n                    ");
            EndContext();
            BeginContext(2292, 55, false);
#line 68 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Admin\Views\AppSettings\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.QtyCollegesDelegates));

#line default
#line hidden
            EndContext();
            BeginContext(2347, 256, true);
            WriteLiteral(@"
                </span>
            </h4>
        </div>
    </li>
    <li class=""list-group-item text-success"">

        <div class=""row"">
            <i class=""fa fa-users fa-2x text-left  col-1""></i>
            <h5 class=""col-10 text-right""> ");
            EndContext();
            BeginContext(2604, 57, false);
#line 77 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Admin\Views\AppSettings\Index.cshtml"
                                      Write(Html.DisplayNameFor(model => model.QtyPassengersInOneBus));

#line default
#line hidden
            EndContext();
            BeginContext(2661, 121, true);
            WriteLiteral("</h5>\r\n            <h4 class=\"col-1 text-right\">\r\n                <span class=\"font-weight-bolder\">\r\n                    ");
            EndContext();
            BeginContext(2783, 56, false);
#line 80 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Admin\Views\AppSettings\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.QtyPassengersInOneBus));

#line default
#line hidden
            EndContext();
            BeginContext(2839, 262, true);
            WriteLiteral(@"
                </span>
            </h4>
        </div>
    </li>
    <li class=""list-group-item text-warning"">

        <div class=""row"">
            <i class=""fa fa-credit-card fa-2x text-left  col-1""></i>
            <h5 class=""col-10 text-right""> ");
            EndContext();
            BeginContext(3102, 62, false);
#line 89 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Admin\Views\AppSettings\Index.cshtml"
                                      Write(Html.DisplayNameFor(model => model.AmountExternalCreditToTrip));

#line default
#line hidden
            EndContext();
            BeginContext(3164, 121, true);
            WriteLiteral("</h5>\r\n            <h4 class=\"col-1 text-right\">\r\n                <span class=\"font-weight-bolder\">\r\n                    ");
            EndContext();
            BeginContext(3286, 61, false);
#line 92 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Admin\Views\AppSettings\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.AmountExternalCreditToTrip));

#line default
#line hidden
            EndContext();
            BeginContext(3347, 264, true);
            WriteLiteral(@"
                </span>
            </h4>
        </div>
    </li>

    <li class=""list-group-item text-warning"">

        <div class=""row"">
            <i class=""fa fa-credit-card fa-2x text-left  col-1""></i>
            <h5 class=""col-10 text-right""> ");
            EndContext();
            BeginContext(3612, 62, false);
#line 102 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Admin\Views\AppSettings\Index.cshtml"
                                      Write(Html.DisplayNameFor(model => model.AmountInternalCreditToTrip));

#line default
#line hidden
            EndContext();
            BeginContext(3674, 121, true);
            WriteLiteral("</h5>\r\n            <h4 class=\"col-1 text-right\">\r\n                <span class=\"font-weight-bolder\">\r\n                    ");
            EndContext();
            BeginContext(3796, 61, false);
#line 105 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Admin\Views\AppSettings\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.AmountInternalCreditToTrip));

#line default
#line hidden
            EndContext();
            BeginContext(3857, 264, true);
            WriteLiteral(@"
                </span>
            </h4>
        </div>
    </li>

    <li class=""list-group-item text-warning"">

        <div class=""row"">
            <i class=""fa fa-credit-card fa-2x text-left  col-1""></i>
            <h5 class=""col-10 text-right""> ");
            EndContext();
            BeginContext(4122, 59, false);
#line 115 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Admin\Views\AppSettings\Index.cshtml"
                                      Write(Html.DisplayNameFor(model => model.AmountOmrahCreditToTrip));

#line default
#line hidden
            EndContext();
            BeginContext(4181, 121, true);
            WriteLiteral("</h5>\r\n            <h4 class=\"col-1 text-right\">\r\n                <span class=\"font-weight-bolder\">\r\n                    ");
            EndContext();
            BeginContext(4303, 58, false);
#line 118 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Admin\Views\AppSettings\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.AmountOmrahCreditToTrip));

#line default
#line hidden
            EndContext();
            BeginContext(4361, 262, true);
            WriteLiteral(@"
                </span>
            </h4>
        </div>
    </li>

    <li class=""list-group-item text-dark"">

        <div class=""row"">
            <i class=""fa fa-calendar-day fa-2x text-left  col-1""></i>
            <h5 class=""col-10 text-right""> ");
            EndContext();
            BeginContext(4624, 55, false);
#line 128 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Admin\Views\AppSettings\Index.cshtml"
                                      Write(Html.DisplayNameFor(model => model.QtyExternalDaysTrip));

#line default
#line hidden
            EndContext();
            BeginContext(4679, 121, true);
            WriteLiteral("</h5>\r\n            <h4 class=\"col-1 text-right\">\r\n                <span class=\"font-weight-bolder\">\r\n                    ");
            EndContext();
            BeginContext(4801, 54, false);
#line 131 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Admin\Views\AppSettings\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.QtyExternalDaysTrip));

#line default
#line hidden
            EndContext();
            BeginContext(4855, 252, true);
            WriteLiteral("\r\n                </span>\r\n            </h4>\r\n        </div>\r\n    </li>\r\n\r\n    <li class=\"list-group-item\">\r\n\r\n        <div class=\"row\">\r\n            <i class=\"fa fa-calendar-day fa-2x text-left  col-1\"></i>\r\n            <h5 class=\"col-10 text-right\"> ");
            EndContext();
            BeginContext(5108, 55, false);
#line 141 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Admin\Views\AppSettings\Index.cshtml"
                                      Write(Html.DisplayNameFor(model => model.QtyInternalDaysTrip));

#line default
#line hidden
            EndContext();
            BeginContext(5163, 121, true);
            WriteLiteral("</h5>\r\n            <h4 class=\"col-1 text-right\">\r\n                <span class=\"font-weight-bolder\">\r\n                    ");
            EndContext();
            BeginContext(5285, 54, false);
#line 144 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Admin\Views\AppSettings\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.QtyInternalDaysTrip));

#line default
#line hidden
            EndContext();
            BeginContext(5339, 252, true);
            WriteLiteral("\r\n                </span>\r\n            </h4>\r\n        </div>\r\n    </li>\r\n\r\n    <li class=\"list-group-item\">\r\n\r\n        <div class=\"row\">\r\n            <i class=\"fa fa-calendar-day fa-2x text-left  col-1\"></i>\r\n            <h5 class=\"col-10 text-right\"> ");
            EndContext();
            BeginContext(5592, 52, false);
#line 154 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Admin\Views\AppSettings\Index.cshtml"
                                      Write(Html.DisplayNameFor(model => model.QtyOmrahDaysTrip));

#line default
#line hidden
            EndContext();
            BeginContext(5644, 121, true);
            WriteLiteral("</h5>\r\n            <h4 class=\"col-1 text-right\">\r\n                <span class=\"font-weight-bolder\">\r\n                    ");
            EndContext();
            BeginContext(5766, 51, false);
#line 157 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Admin\Views\AppSettings\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.QtyOmrahDaysTrip));

#line default
#line hidden
            EndContext();
            BeginContext(5817, 117, true);
            WriteLiteral("\r\n                </span>\r\n            </h4>\r\n        </div>\r\n    </li>\r\n\r\n    <li class=\"list-group-item\">\r\n        ");
            EndContext();
            BeginContext(5934, 131, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d36fd40270a5d79702aefa38420938927e18b4319652", async() => {
                BeginContext(6018, 43, true);
                WriteLiteral(" <i class=\"fas fa-share-square\"></i> تراجع ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6065, 12, true);
            WriteLiteral("\r\n\r\n        ");
            EndContext();
            BeginContext(6077, 98, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d36fd40270a5d79702aefa38420938927e18b4321367", async() => {
                BeginContext(6158, 13, true);
                WriteLiteral("ضبط الإعدادات");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 166 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Admin\Views\AppSettings\Index.cshtml"
                                                                   WriteLiteral(item.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(6175, 24, true);
            WriteLiteral("\r\n\r\n\r\n    </li>\r\n</ul>\r\n");
            EndContext();
#line 171 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Admin\Views\AppSettings\Index.cshtml"
 
}

#line default
#line hidden
#line 172 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Admin\Views\AppSettings\Index.cshtml"
 
}else{

#line default
#line hidden
            BeginContext(6213, 79, true);
            WriteLiteral("    <ul class=\"list-group\">\r\n        <li class=\"list-group-item\">\r\n            ");
            EndContext();
            BeginContext(6292, 131, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d36fd40270a5d79702aefa38420938927e18b4324331", async() => {
                BeginContext(6376, 43, true);
                WriteLiteral(" <i class=\"fas fa-share-square\"></i> تراجع ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6423, 16, true);
            WriteLiteral("\r\n\r\n            ");
            EndContext();
            BeginContext(6439, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d36fd40270a5d79702aefa38420938927e18b4326050", async() => {
                BeginContext(6498, 14, true);
                WriteLiteral("ضبط الإعدادات ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6516, 30, true);
            WriteLiteral("\r\n\r\n        </li>\r\n    </ul>\r\n");
            EndContext();
#line 182 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Admin\Views\AppSettings\Index.cshtml"
   
}

#line default
#line hidden
            BeginContext(6554, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AActivity.Models.AppSetting>> Html { get; private set; }
    }
}
#pragma warning restore 1591
