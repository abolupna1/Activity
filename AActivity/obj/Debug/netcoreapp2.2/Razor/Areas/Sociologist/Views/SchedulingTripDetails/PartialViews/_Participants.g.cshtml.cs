#pragma checksum "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Sociologist\Views\SchedulingTripDetails\PartialViews\_Participants.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88b296b069cce05c772baa06fd0d0554b325add5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Sociologist_Views_SchedulingTripDetails_PartialViews__Participants), @"mvc.1.0.view", @"/Areas/Sociologist/Views/SchedulingTripDetails/PartialViews/_Participants.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Sociologist/Views/SchedulingTripDetails/PartialViews/_Participants.cshtml", typeof(AspNetCore.Areas_Sociologist_Views_SchedulingTripDetails_PartialViews__Participants))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88b296b069cce05c772baa06fd0d0554b325add5", @"/Areas/Sociologist/Views/SchedulingTripDetails/PartialViews/_Participants.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8711de3d765a7b2bba5beade351e7d2616bcfba7", @"/Areas/Sociologist/Views/_ViewImports.cshtml")]
    public class Areas_Sociologist_Views_SchedulingTripDetails_PartialViews__Participants : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AActivity.Models.SchedulingTripDetail>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 6, true);
            WriteLiteral("<li>\r\n");
            EndContext();
            BeginContext(56, 732, true);
            WriteLiteral(@"
    <i class=""fa fa-users bg-blue""></i>
    <div class=""timeline-item"">

        <h3 class=""timeline-header"">
            <i class=""fas fa-users""></i>

            المشاركين في الرحلة
        </h3>

        <div class=""timeline-body"">
            <div class=""row"">

                <div class=""col"">
                    <div class=""info-box"">
                        <span class=""info-box-icon bg-primary ""><i class=""fa fa-users text-white""></i></span>
                        <div class=""info-box-content text-center"">
                            <span class=""info-box-text mb-2 "">الطلاب </span>
                            <span class=""info-box-number font-weight-bolder mb-2"">
                                ");
            EndContext();
            BeginContext(789, 8, false);
#line 22 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Sociologist\Views\SchedulingTripDetails\PartialViews\_Participants.cshtml"
                           Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(797, 1430, true);
            WriteLiteral(@"
                            </span>
                            <a href="""">تفاصيل</a>
                        </div>
                    </div>
                </div>



                <div class=""col"">
                    <div class=""info-box"">
                        <span class=""info-box-icon bg-primary ""><i class=""fa fa-users text-white""></i></span>
                        <div class=""info-box-content text-center"">
                            <span class=""info-box-text mb-2 "">منتدبين الجهة </span>
                            <span class=""info-box-number font-weight-bolder mb-2"">4</span>
                            <a href="""">تفاصيل</a>
                        </div>
                    </div>
                </div>





                <div class=""col"">
                    <div class=""info-box"">
                        <span class=""info-box-icon bg-primary ""><i class=""fa fa-users text-white""></i></span>
                        <div class=""info-box-content text-center"">
      ");
            WriteLiteral(@"                      <span class=""info-box-text mb-2 "">منتدبين العمادة </span>
                            <span class=""info-box-number font-weight-bolder mb-2"">4</span>
                            <a href="""" class=""btn btn-sm btn-outline-success"">تفاصيل</a>
                        </div>
                    </div>
                </div>


            </div>
        </div>

    </div>
</li>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AActivity.Models.SchedulingTripDetail> Html { get; private set; }
    }
}
#pragma warning restore 1591
