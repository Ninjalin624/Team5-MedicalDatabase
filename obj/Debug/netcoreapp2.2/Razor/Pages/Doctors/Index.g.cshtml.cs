#pragma checksum "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\Doctors\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3af58f256178d7d32229afecbba23c3d03d7ba6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ClinicWeb.Pages.Doctors.Pages_Doctors_Index), @"mvc.1.0.razor-page", @"/Pages/Doctors/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Doctors/Index.cshtml", typeof(ClinicWeb.Pages.Doctors.Pages_Doctors_Index), null)]
namespace ClinicWeb.Pages.Doctors
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
#line 7 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\Doctors\Index.cshtml"
using ClinicWeb.Security;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3af58f256178d7d32229afecbba23c3d03d7ba6a", @"/Pages/Doctors/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1402308e72288a91f4404363d32cb61e5bad5508", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Doctors_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\Doctors\Index.cshtml"
  
    ViewData["Title"] = "Doctors";

#line default
#line hidden
            BeginContext(93, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(122, 82, true);
            WriteLiteral("\r\n<div class=\"card\">\r\n    <div class=\"card-body\">\r\n        <h3 class=\"card-title\">");
            EndContext();
            BeginContext(205, 17, false);
#line 11 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\Doctors\Index.cshtml"
                          Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(222, 7, true);
            WriteLiteral("</h3>\r\n");
            EndContext();
#line 12 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\Doctors\Index.cshtml"
         if (SessionIsAdmin())
        {

#line default
#line hidden
            BeginContext(272, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(284, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3af58f256178d7d32229afecbba23c3d03d7ba6a5134", async() => {
                BeginContext(305, 17, true);
                WriteLiteral("Create New Doctor");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(326, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 15 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\Doctors\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(339, 503, true);
            WriteLiteral(@"        <table class=""table"">
            <thead>
                <tr>
                    <th>First Name</th>
                    <th>Last Name</th>
                    <th>Phone</th>
                    <th>Street Address</th>
                    <th>City</th>
                    <th>State</th>
                    <th>Postal Code</th>
                    <th>Doctor ID</th>
                    <th>Specialization ID</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 31 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\Doctors\Index.cshtml"
                 foreach (var doctor in Model.Doctor)
                {

#line default
#line hidden
            BeginContext(916, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(963, 23, false);
#line 34 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\Doctors\Index.cshtml"
                   Write(doctor.Person.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(986, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1018, 22, false);
#line 35 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\Doctors\Index.cshtml"
                   Write(doctor.Person.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1040, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1072, 19, false);
#line 36 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\Doctors\Index.cshtml"
                   Write(doctor.Person.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(1091, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1123, 35, false);
#line 37 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\Doctors\Index.cshtml"
                   Write(doctor.Person.Address.StreetAddress);

#line default
#line hidden
            EndContext();
            BeginContext(1158, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1190, 26, false);
#line 38 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\Doctors\Index.cshtml"
                   Write(doctor.Person.Address.City);

#line default
#line hidden
            EndContext();
            BeginContext(1216, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1248, 27, false);
#line 39 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\Doctors\Index.cshtml"
                   Write(doctor.Person.Address.State);

#line default
#line hidden
            EndContext();
            BeginContext(1275, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1307, 32, false);
#line 40 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\Doctors\Index.cshtml"
                   Write(doctor.Person.Address.PostalCode);

#line default
#line hidden
            EndContext();
            BeginContext(1339, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1371, 15, false);
#line 41 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\Doctors\Index.cshtml"
                   Write(doctor.DoctorId);

#line default
#line hidden
            EndContext();
            BeginContext(1386, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1418, 23, false);
#line 42 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\Doctors\Index.cshtml"
                   Write(doctor.SpecializationId);

#line default
#line hidden
            EndContext();
            BeginContext(1441, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 43 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\Doctors\Index.cshtml"
                     if (SessionIsAdmin())
                    {

#line default
#line hidden
            BeginContext(1515, 24, true);
            WriteLiteral("                    <td>");
            EndContext();
            BeginContext(1539, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3af58f256178d7d32229afecbba23c3d03d7ba6a11947", async() => {
                BeginContext(1592, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 45 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\Doctors\Index.cshtml"
                                               WriteLiteral(doctor.DoctorId);

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
            BeginContext(1600, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 46 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\Doctors\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1630, 23, true);
            WriteLiteral("                </tr>\r\n");
            EndContext();
#line 48 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\Doctors\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1672, 62, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(1896, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
#line 54 "D:\Documents\Classes\Current\Design of Files and Database Systems\Database Project\Team5-MedicalDatabase\Pages\Doctors\Index.cshtml"
            
    bool SessionIsAdmin()
    {
        return new AuthService().GetSessionAccount(HttpContext).GetAccessLevel() >= AccessLevel.Admin;
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClinicWeb.Pages.Doctors.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ClinicWeb.Pages.Doctors.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ClinicWeb.Pages.Doctors.IndexModel>)PageContext?.ViewData;
        public ClinicWeb.Pages.Doctors.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
