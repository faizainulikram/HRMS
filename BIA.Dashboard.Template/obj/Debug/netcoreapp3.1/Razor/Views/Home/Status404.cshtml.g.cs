#pragma checksum "C:\Users\Fa'iz\Desktop\HRMS_2\hrms_2\BIA.Dashboard.Template\Views\Home\Status404.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "995f82f3bcb5e7441495b458269f16766f7f62b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Status404), @"mvc.1.0.view", @"/Views/Home/Status404.cshtml")]
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
#line 1 "C:\Users\Fa'iz\Desktop\HRMS_2\hrms_2\BIA.Dashboard.Template\Views\_ViewImports.cshtml"
using BIA.Dashboard.Template;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Fa'iz\Desktop\HRMS_2\hrms_2\BIA.Dashboard.Template\Views\_ViewImports.cshtml"
using BIA.Dashboard.Template.Infrastructure.ApplicationUserClaims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Fa'iz\Desktop\HRMS_2\hrms_2\BIA.Dashboard.Template\Views\_ViewImports.cshtml"
using BIA.Dashboard.Template.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Fa'iz\Desktop\HRMS_2\hrms_2\BIA.Dashboard.Template\Views\_ViewImports.cshtml"
using BIA.Dashboard.Template.Models.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"995f82f3bcb5e7441495b458269f16766f7f62b3", @"/Views/Home/Status404.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9aad1476f70009dcb1af549b701ef1c22ea6a50e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Status404 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Fa'iz\Desktop\HRMS_2\hrms_2\BIA.Dashboard.Template\Views\Home\Status404.cshtml"
  
    ViewData["Title"] = ViewBag.StatusCodeDescription ?? ViewBag.StatusCode.ToString();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row justify-content-center\">\r\n    <div class=\"col-lg-5 col-md-7 text-center\">\r\n        <h1 class=\"text-white\">");
#nullable restore
#line 7 "C:\Users\Fa'iz\Desktop\HRMS_2\hrms_2\BIA.Dashboard.Template\Views\Home\Status404.cshtml"
                          Write(ViewBag.StatusCode);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 7 "C:\Users\Fa'iz\Desktop\HRMS_2\hrms_2\BIA.Dashboard.Template\Views\Home\Status404.cshtml"
                                                Write(ViewBag.StatusCodeDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <a class=\"text-light\"");
            BeginWriteAttribute("href", " href=\"", 308, "\"", 354, 1);
#nullable restore
#line 8 "C:\Users\Fa'iz\Desktop\HRMS_2\hrms_2\BIA.Dashboard.Template\Views\Home\Status404.cshtml"
WriteAttributeValue("", 315, Url.Action("","PersonnelInformations"), 315, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"Go Home\">Go Home</a>\r\n    </div>\r\n</div>");
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
