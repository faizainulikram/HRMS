#pragma checksum "C:\Users\Fa'iz\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\Shared\_GoogleTagManagerBodyElement.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b34b5ae53bbedd81f50f61d159d871f59f30bfe8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__GoogleTagManagerBodyElement), @"mvc.1.0.view", @"/Views/Shared/_GoogleTagManagerBodyElement.cshtml")]
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
#line 1 "C:\Users\Fa'iz\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\_ViewImports.cshtml"
using BIA.Dashboard.Template;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Fa'iz\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\_ViewImports.cshtml"
using BIA.Dashboard.Template.Infrastructure.ApplicationUserClaims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Fa'iz\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\_ViewImports.cshtml"
using BIA.Dashboard.Template.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Fa'iz\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\_ViewImports.cshtml"
using BIA.Dashboard.Template.Models.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Fa'iz\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\Shared\_GoogleTagManagerBodyElement.cshtml"
using BIA.Dashboard.Template.Infrastructure.AppSettingsModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Fa'iz\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\Shared\_GoogleTagManagerBodyElement.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b34b5ae53bbedd81f50f61d159d871f59f30bfe8", @"/Views/Shared/_GoogleTagManagerBodyElement.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9aad1476f70009dcb1af549b701ef1c22ea6a50e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__GoogleTagManagerBodyElement : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Fa'iz\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\Shared\_GoogleTagManagerBodyElement.cshtml"
 if (!string.IsNullOrWhiteSpace(OptionsScriptTags.Value?.GoogleTagManager))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <!-- Google Tag Manager (noscript) -->\r\n    <noscript>\r\n        <iframe");
            BeginWriteAttribute("src", " src=\"", 308, "\"", 399, 2);
            WriteAttributeValue("", 314, "https://www.googletagmanager.com/ns.html?id=", 314, 44, true);
#nullable restore
#line 10 "C:\Users\Fa'iz\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\Shared\_GoogleTagManagerBodyElement.cshtml"
WriteAttributeValue("", 358, OptionsScriptTags.Value.GoogleTagManager, 358, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                height=\"0\" width=\"0\" style=\"display:none;visibility:hidden\"></iframe>\r\n    </noscript>\r\n    <!-- End Google Tag Manager (noscript) -->\r\n");
#nullable restore
#line 14 "C:\Users\Fa'iz\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\Shared\_GoogleTagManagerBodyElement.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOptions<ScriptTags> OptionsScriptTags { get; private set; }
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
