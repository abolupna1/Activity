#pragma checksum "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Admin\Views\Users\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b835631ebe12574413d4636918a38d3ccc4d2ee8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Users_Delete), @"mvc.1.0.view", @"/Areas/Admin/Views/Users/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Users/Delete.cshtml", typeof(AspNetCore.Areas_Admin_Views_Users_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b835631ebe12574413d4636918a38d3ccc4d2ee8", @"/Areas/Admin/Views/Users/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8711de3d765a7b2bba5beade351e7d2616bcfba7", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Users_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AActivity.Areas.Admin.ModelViews.UserCreate>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn  btn-outline-primary btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Admin\Views\Users\Delete.cshtml"
  
    ViewData["Title"] = "تفاصيل";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(143, 180, true);
            WriteLiteral("\r\n\r\n<div class=\"card mt-5 mb-3\">\r\n    <h5 class=\"card-header bg-primary-bold \">\r\n        <i class=\"fas fa-trash\"></i>\r\n        تأكيد الحذف\r\n    </h5>\r\n    <div class=\"card-body\">\r\n");
            EndContext();
#line 15 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Admin\Views\Users\Delete.cshtml"
         if (ViewBag.successMsg != null)
        {

#line default
#line hidden
            BeginContext(376, 179, true);
            WriteLiteral("            <div class=\"alert alert-dismissible alert-danger\">\r\n                <button type=\"button\" class=\"close\" data-dismiss=\"alert\">&times;</button>\r\n                <strong>");
            EndContext();
            BeginContext(556, 18, false);
#line 19 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Admin\Views\Users\Delete.cshtml"
                   Write(ViewBag.successMsg);

#line default
#line hidden
            EndContext();
            BeginContext(574, 33, true);
            WriteLiteral(" </strong> \r\n            </div>\r\n");
            EndContext();
#line 21 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Admin\Views\Users\Delete.cshtml"
        }

#line default
#line hidden
            BeginContext(618, 142, true);
            WriteLiteral("        <ul class=\"list-group list-group-flush\">\r\n            <li class=\"list-group-item\">\r\n                <strong class=\"font-weight-bold\"> ");
            EndContext();
            BeginContext(761, 44, false);
#line 24 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Admin\Views\Users\Delete.cshtml"
                                             Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(805, 36, true);
            WriteLiteral(" :</strong>\r\n                <span> ");
            EndContext();
            BeginContext(842, 40, false);
#line 25 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Admin\Views\Users\Delete.cshtml"
                  Write(Html.DisplayFor(model => model.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(882, 121, true);
            WriteLiteral("</span>\r\n            </li>\r\n            <li class=\"list-group-item\">\r\n                <strong class=\"font-weight-bold\">  ");
            EndContext();
            BeginContext(1004, 44, false);
#line 28 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Admin\Views\Users\Delete.cshtml"
                                              Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(1048, 38, true);
            WriteLiteral(" :</strong>\r\n                <span>   ");
            EndContext();
            BeginContext(1087, 40, false);
#line 29 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Admin\Views\Users\Delete.cshtml"
                    Write(Html.DisplayFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(1127, 121, true);
            WriteLiteral("</span>\r\n            </li>\r\n            <li class=\"list-group-item\">\r\n                <strong class=\"font-weight-bold\">  ");
            EndContext();
            BeginContext(1249, 41, false);
#line 32 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Admin\Views\Users\Delete.cshtml"
                                              Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1290, 42, true);
            WriteLiteral(" :</strong>\r\n                <span>       ");
            EndContext();
            BeginContext(1333, 37, false);
#line 33 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Admin\Views\Users\Delete.cshtml"
                        Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1370, 128, true);
            WriteLiteral(" </span>\r\n            </li>\r\n            <li class=\"list-group-item\">\r\n                <strong class=\"font-weight-bold\">        ");
            EndContext();
            BeginContext(1499, 47, false);
#line 36 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Admin\Views\Users\Delete.cshtml"
                                                    Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1546, 43, true);
            WriteLiteral(" :</strong>\r\n                <span>        ");
            EndContext();
            BeginContext(1590, 43, false);
#line 37 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Admin\Views\Users\Delete.cshtml"
                         Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1633, 146, true);
            WriteLiteral("</span>\r\n            </li>\r\n            <li class=\"list-group-item\">\r\n                <strong class=\"font-weight-bold\">       الأدوار :</strong>\r\n");
            EndContext();
#line 41 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Admin\Views\Users\Delete.cshtml"
                 foreach (var role in Model.UserRoles)
                {

#line default
#line hidden
            BeginContext(1854, 95, true);
            WriteLiteral("                    <span class=\"badge badge-primary badge-pill p-2\">\r\n                        ");
            EndContext();
            BeginContext(1950, 16, false);
#line 44 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Admin\Views\Users\Delete.cshtml"
                   Write(role.Role.ArName);

#line default
#line hidden
            EndContext();
            BeginContext(1966, 31, true);
            WriteLiteral("\r\n                    </span>\r\n");
            EndContext();
#line 46 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Admin\Views\Users\Delete.cshtml"

                }

#line default
#line hidden
            BeginContext(2018, 180, true);
            WriteLiteral("\r\n            </li>\r\n        </ul>\r\n\r\n\r\n\r\n        <div class=\" col-12 mt-5\">\r\n            <h5 class=\" text-danger font-weight-bold mb-3\">هل تريد الحذف بالفعل ؟</h5>\r\n\r\n            ");
            EndContext();
            BeginContext(2198, 384, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b835631ebe12574413d4636918a38d3ccc4d2ee811815", async() => {
                BeginContext(2224, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(2242, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b835631ebe12574413d4636918a38d3ccc4d2ee812216", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 58 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Admin\Views\Users\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2278, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(2296, 137, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b835631ebe12574413d4636918a38d3ccc4d2ee814055", async() => {
                    BeginContext(2385, 44, true);
                    WriteLiteral(" <i class=\"fas fa-share-square\"></i> تراجع  ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 59 "C:\Users\edom\source\repos\AActivity\AActivity\Areas\Admin\Views\Users\Delete.cshtml"
                                                                                  WriteLiteral(Model.Id);

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
                BeginContext(2433, 142, true);
                WriteLiteral("\r\n\r\n                <button class=\"btn  btn-outline-danger btn-lg\" type=\"submit\"><i class=\"fas fa-trash\"></i> نعم إحذف </button>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2582, 42, true);
            WriteLiteral("\r\n\r\n\r\n        </div>\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AActivity.Areas.Admin.ModelViews.UserCreate> Html { get; private set; }
    }
}
#pragma warning restore 1591
