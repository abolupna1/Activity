#pragma checksum "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Sociologist\Views\SchedulingTripDetails\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0f4b77a82e1aba07e630d5674cacf5a68b47d36"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Sociologist_Views_SchedulingTripDetails_Index), @"mvc.1.0.view", @"/Areas/Sociologist/Views/SchedulingTripDetails/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Sociologist/Views/SchedulingTripDetails/Index.cshtml", typeof(AspNetCore.Areas_Sociologist_Views_SchedulingTripDetails_Index))]
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
#line 1 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Sociologist\Views\_ViewImports.cshtml"
using AActivity;

#line default
#line hidden
#line 2 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Sociologist\Views\_ViewImports.cshtml"
using AActivity.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0f4b77a82e1aba07e630d5674cacf5a68b47d36", @"/Areas/Sociologist/Views/SchedulingTripDetails/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8711de3d765a7b2bba5beade351e7d2616bcfba7", @"/Areas/Sociologist/Views/_ViewImports.cshtml")]
    public class Areas_Sociologist_Views_SchedulingTripDetails_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AActivity.Models.SchedulingTripDetail>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn  btn-outline-gold btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DetailsMore", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn  btn-outline-primary btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Sociologist\Views\SchedulingTripDetails\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#line 7 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Sociologist\Views\SchedulingTripDetails\Index.cshtml"
 if (Model.Any())
{

#line default
#line hidden
            BeginContext(171, 206, true);
            WriteLiteral("    <ul class=\"list-group list-group-horizontal mt-5 mb-4 text-center \">\r\n        <li class=\"list-group-item bg-primary text-white\">السنة الدراسية  </li>\r\n        <li class=\"list-group-item \">\r\n            ");
            EndContext();
            BeginContext(378, 54, false);
#line 12 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Sociologist\Views\SchedulingTripDetails\Index.cshtml"
       Write(Model.FirstOrDefault().SchedulingTripHead.AcademicYear);

#line default
#line hidden
            EndContext();
            BeginContext(432, 140, true);
            WriteLiteral("\r\n        </li>\r\n        <li class=\"list-group-item bg-primary text-white\"> الفصل  </li>\r\n        <li class=\"list-group-item\">\r\n            ");
            EndContext();
            BeginContext(573, 50, false);
#line 16 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Sociologist\Views\SchedulingTripDetails\Index.cshtml"
       Write(Model.FirstOrDefault().SchedulingTripHead.Semester);

#line default
#line hidden
            EndContext();
            BeginContext(623, 143, true);
            WriteLiteral("\r\n        </li>\r\n        <li class=\"list-group-item bg-primary text-white\"> من تاريخ  </li>\r\n        <li class=\"list-group-item\">\r\n            ");
            EndContext();
            BeginContext(767, 77, false);
#line 20 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Sociologist\Views\SchedulingTripDetails\Index.cshtml"
       Write(Model.FirstOrDefault().SchedulingTripHead.FromDate.ToString("dd / MM / yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(844, 144, true);
            WriteLiteral("\r\n        </li>\r\n        <li class=\"list-group-item bg-primary text-white\"> الى تاريخ  </li>\r\n        <li class=\"list-group-item\">\r\n            ");
            EndContext();
            BeginContext(989, 75, false);
#line 24 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Sociologist\Views\SchedulingTripDetails\Index.cshtml"
       Write(Model.FirstOrDefault().SchedulingTripHead.ToDate.ToString("dd / MM / yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1064, 30, true);
            WriteLiteral("\r\n        </li>\r\n\r\n    </ul>\r\n");
            EndContext();
#line 28 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Sociologist\Views\SchedulingTripDetails\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1097, 23, true);
            WriteLiteral("    <div class=\"row\">\r\n");
            EndContext();
#line 30 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Sociologist\Views\SchedulingTripDetails\Index.cshtml"
         if (Model.Any())
        {
            int i = 1;
            

#line default
#line hidden
#line 33 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Sociologist\Views\SchedulingTripDetails\Index.cshtml"
             foreach (var s in Model)
            {


#line default
#line hidden
            BeginContext(1238, 259, true);
            WriteLiteral(@"                <div class=""col-md-6 "">
                    <div class=""card  mb-5 "">
                        <div class=""card-header text-white bg-primary "">
                            # <span class=""badge badge-pill badge-light font-weight-bolder p-1 "">");
            EndContext();
            BeginContext(1498, 1, false);
#line 39 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Sociologist\Views\SchedulingTripDetails\Index.cshtml"
                                                                                            Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1499, 44, true);
            WriteLiteral("</span>\r\n                            رحلة   ");
            EndContext();
            BeginContext(1544, 15, false);
#line 40 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Sociologist\Views\SchedulingTripDetails\Index.cshtml"
                              Write(s.TripType.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1559, 154, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"card-body\">\r\n\r\n                            <div class=\"card-title\">الجهةالتعليمية : ");
            EndContext();
            BeginContext(1714, 22, false);
#line 44 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Sociologist\Views\SchedulingTripDetails\Index.cshtml"
                                                                Write(s.EducationalBody.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1736, 75, true);
            WriteLiteral("</div>\r\n                            <div class=\"card-title\">تاريخ الرحلة : ");
            EndContext();
            BeginContext(1812, 37, false);
#line 45 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Sociologist\Views\SchedulingTripDetails\Index.cshtml"
                                                              Write(s.TripDate.ToString("dd - MM - yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1849, 339, true);
            WriteLiteral(@"</div>
                            <div class=""card-title"">
                                الحالة :
                                جاهزة / غير جاهزة / مستمرة / منتهية/لايمكن الطلب
                            </div>


                        </div>
                        <div class="" card-footer "">
                            ");
            EndContext();
            BeginContext(2188, 145, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0f4b77a82e1aba07e630d5674cacf5a68b47d3611326", async() => {
                BeginContext(2274, 55, true);
                WriteLiteral(" <i class=\"fas fa-info-circle\"></i> تفاصيل اكثر للرحلة ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 54 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Sociologist\Views\SchedulingTripDetails\Index.cshtml"
                                                                                               WriteLiteral(s.Id);

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
            BeginContext(2333, 92, true);
            WriteLiteral("\r\n\r\n                        </div>\r\n\r\n                    </div>\r\n\r\n                </div>\r\n");
            EndContext();
#line 61 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Sociologist\Views\SchedulingTripDetails\Index.cshtml"

                i++;
            }

#line default
#line hidden
#line 63 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Sociologist\Views\SchedulingTripDetails\Index.cshtml"
             

        }
        else
        {

#line default
#line hidden
            BeginContext(2502, 313, true);
            WriteLiteral(@"                <div class=""col"">
                    <div class=""card text-white mb-3"">
                        <div class=""card-header bg-primary "">
                            لاتوجدرحلات نشطة  
                        </div>
                        <div class=""card-body"">

                            ");
            EndContext();
            BeginContext(2815, 148, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0f4b77a82e1aba07e630d5674cacf5a68b47d3614787", async() => {
                BeginContext(2900, 59, true);
                WriteLiteral(" <i class=\"fas fa-info-circle\"></i>الرجوع للقائمة الرئيسية ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2963, 88, true);
            WriteLiteral("\r\n\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 80 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Sociologist\Views\SchedulingTripDetails\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(3062, 16, true);
            WriteLiteral("\r\n\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AActivity.Models.SchedulingTripDetail>> Html { get; private set; }
    }
}
#pragma warning restore 1591