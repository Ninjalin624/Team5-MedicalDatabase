#pragma checksum "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\MedicalDiagnosis\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd26fa1e7f38a3687197b507776e26c62670b16a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ClinicWeb.Pages.MedicalDiagnosis.Pages_MedicalDiagnosis_Edit), @"mvc.1.0.razor-page", @"/Pages/MedicalDiagnosis/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/MedicalDiagnosis/Edit.cshtml", typeof(ClinicWeb.Pages.MedicalDiagnosis.Pages_MedicalDiagnosis_Edit), null)]
namespace ClinicWeb.Pages.MedicalDiagnosis
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\_ViewImports.cshtml"
using ClinicWeb;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd26fa1e7f38a3687197b507776e26c62670b16a", @"/Pages/MedicalDiagnosis/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1402308e72288a91f4404363d32cb61e5bad5508", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MedicalDiagnosis_Edit : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\MedicalDiagnosis\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
            BeginContext(98, 72, true);
            WriteLiteral("\r\n<h1>Edit</h1>\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        ");
            EndContext();
            BeginContext(170, 1816, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd26fa1e7f38a3687197b507776e26c62670b16a5215", async() => {
                BeginContext(190, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(204, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd26fa1e7f38a3687197b507776e26c62670b16a5609", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 11 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\MedicalDiagnosis\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(270, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(284, 55, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fd26fa1e7f38a3687197b507776e26c62670b16a7465", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 12 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\MedicalDiagnosis\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Diagnosis.DiagnosisId);

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
                BeginContext(339, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(353, 55, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fd26fa1e7f38a3687197b507776e26c62670b16a9370", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 13 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\MedicalDiagnosis\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Diagnosis.ConditionId);

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
                BeginContext(408, 56, true);
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                ");
                EndContext();
                BeginContext(465, 89, false);
#line 15 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\MedicalDiagnosis\Edit.cshtml"
           Write(Html.LabelFor(m => m.Diagnosis.Condition.ConditionName, new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(554, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(573, 56, false);
#line 16 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\MedicalDiagnosis\Edit.cshtml"
           Write(Html.EditorFor(m => m.Diagnosis.Condition.ConditionName));

#line default
#line hidden
                EndContext();
                BeginContext(629, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(648, 67, false);
#line 17 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\MedicalDiagnosis\Edit.cshtml"
           Write(Html.ValidationMessageFor(m => m.Diagnosis.Condition.ConditionName));

#line default
#line hidden
                EndContext();
                BeginContext(715, 76, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
                EndContext();
                BeginContext(792, 96, false);
#line 20 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\MedicalDiagnosis\Edit.cshtml"
           Write(Html.LabelFor(m => m.Diagnosis.Condition.ConditionDescription, new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(888, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(907, 63, false);
#line 21 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\MedicalDiagnosis\Edit.cshtml"
           Write(Html.EditorFor(m => m.Diagnosis.Condition.ConditionDescription));

#line default
#line hidden
                EndContext();
                BeginContext(970, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(989, 74, false);
#line 22 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\MedicalDiagnosis\Edit.cshtml"
           Write(Html.ValidationMessageFor(m => m.Diagnosis.Condition.ConditionDescription));

#line default
#line hidden
                EndContext();
                BeginContext(1063, 76, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
                EndContext();
                BeginContext(1140, 73, false);
#line 25 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\MedicalDiagnosis\Edit.cshtml"
           Write(Html.LabelFor(m => m.Diagnosis.Details, new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(1213, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1232, 40, false);
#line 26 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\MedicalDiagnosis\Edit.cshtml"
           Write(Html.EditorFor(m => m.Diagnosis.Details));

#line default
#line hidden
                EndContext();
                BeginContext(1272, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1291, 51, false);
#line 27 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\MedicalDiagnosis\Edit.cshtml"
           Write(Html.ValidationMessageFor(m => m.Diagnosis.Details));

#line default
#line hidden
                EndContext();
                BeginContext(1342, 115, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label>Doctor</label>\r\n                ");
                EndContext();
                BeginContext(1457, 285, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd26fa1e7f38a3687197b507776e26c62670b16a15899", async() => {
                    BeginContext(1494, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 32 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\MedicalDiagnosis\Edit.cshtml"
                     foreach (var doctor in Model.Doctor)
                    {

#line default
#line hidden
                    BeginContext(1578, 24, true);
                    WriteLiteral("                        ");
                    EndContext();
                    BeginContext(1602, 90, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd26fa1e7f38a3687197b507776e26c62670b16a16719", async() => {
                        BeginContext(1636, 23, false);
#line 34 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\MedicalDiagnosis\Edit.cshtml"
                                                    Write(doctor.Person.FirstName);

#line default
#line hidden
                        EndContext();
                        BeginContext(1659, 1, true);
                        WriteLiteral(" ");
                        EndContext();
                        BeginContext(1661, 22, false);
#line 34 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\MedicalDiagnosis\Edit.cshtml"
                                                                             Write(doctor.Person.LastName);

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#line 34 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\MedicalDiagnosis\Edit.cshtml"
                           WriteLiteral(doctor.DoctorId);

#line default
#line hidden
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
                    EndContext();
                    BeginContext(1692, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 35 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\MedicalDiagnosis\Edit.cshtml"
                    }

#line default
#line hidden
                    BeginContext(1717, 16, true);
                    WriteLiteral("                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 31 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\MedicalDiagnosis\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Diagnosis.DoctorId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1742, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1761, 52, false);
#line 37 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\MedicalDiagnosis\Edit.cshtml"
           Write(Html.ValidationMessageFor(m => m.Diagnosis.DoctorId));

#line default
#line hidden
                EndContext();
                BeginContext(1813, 166, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Save\" class=\"btn btn-primary\" />\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1986, 22, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClinicWeb.Pages.MedicalDiagnosis.EditModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ClinicWeb.Pages.MedicalDiagnosis.EditModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ClinicWeb.Pages.MedicalDiagnosis.EditModel>)PageContext?.ViewData;
        public ClinicWeb.Pages.MedicalDiagnosis.EditModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
