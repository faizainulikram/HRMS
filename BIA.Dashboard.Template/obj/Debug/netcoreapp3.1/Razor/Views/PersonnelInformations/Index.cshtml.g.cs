#pragma checksum "C:\Users\Fa'iz\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "095e435d5a3623ed0537428eff94978c2a07de5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PersonnelInformations_Index), @"mvc.1.0.view", @"/Views/PersonnelInformations/Index.cshtml")]
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
#line 1 "C:\Users\Fa'iz\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Fa'iz\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"095e435d5a3623ed0537428eff94978c2a07de5e", @"/Views/PersonnelInformations/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9aad1476f70009dcb1af549b701ef1c22ea6a50e", @"/Views/_ViewImports.cshtml")]
    public class Views_PersonnelInformations_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PaginatedList<BIA.Dashboard.Template.Models.PersonnelInformation>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-item nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Verify", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AuditLog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "PersonnelInformations", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Fa'iz\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<nav class=""navbar navbar-horizontal navbar-expand-md navbar-dark bg-default rounded"">
    <button class=""navbar-toggler navbar-toggler-right"" type=""button"" data-toggle=""collapse"" data-target=""#navbarNavAltMarkup"" aria-controls=""navbarNavAltMarkup"" aria-expanded=""false"" aria-label=""Toggle navigation"">
        <span class=""navbar-toggler-icon""></span>
    </button>
    <div class=""collapse navbar-collapse"" id=""navbarNavAltMarkup"">
        <div class=""navbar-collapse-header"">
            <div class=""row"">
                <div class=""col-6 collapse-close"">
                    <button class=""navbar-toggler navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarNavAltMarkup"" aria-controls=""navbarNavAltMarkup"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                        <span></span>
                        <span></span>
                    </button>
                </div>
            </div>
        </div>
        <div class=""navbar-nav nav-fill w-100"">
         ");
            WriteLiteral("   <a class=\"nav-item nav-link\"");
            BeginWriteAttribute("href", " href=\"", 1355, "\"", 1382, 1);
#nullable restore
#line 27 "C:\Users\Fa'iz\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
WriteAttributeValue("", 1362, Url.Action("Index"), 1362, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Directory</a>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "095e435d5a3623ed0537428eff94978c2a07de5e9030", async() => {
                WriteLiteral("Personnel Information");
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
#nullable restore
#line 28 "C:\Users\Fa'iz\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
                                                               WriteLiteral(userManager.GetUserId(User));

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n");
#nullable restore
#line 29 "C:\Users\Fa'iz\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
             if ((await AuthorizationService.AuthorizeAsync(User, "PersonnelInformationHR")).Succeeded)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "095e435d5a3623ed0537428eff94978c2a07de5e11683", async() => {
                WriteLiteral("HR Verification");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "095e435d5a3623ed0537428eff94978c2a07de5e12947", async() => {
                WriteLiteral("Audit Log");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 33 "C:\Users\Fa'iz\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</nav>\r\n<div class=\"row\">\r\n    <div class=\"col\">\r\n        <div class=\"card-header border-0\">\r\n            <h1 class=\"mb-5 text-center\">Directory</h1>\r\n");
            WriteLiteral("            <div class=\"form-group\" asp-controller=\"PersonnelInformations\" asp-action=\"Index\" method=\"get\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "095e435d5a3623ed0537428eff94978c2a07de5e14780", async() => {
                WriteLiteral("\r\n");
                WriteLiteral(@"                    <div class=""input-group"">
                        <div class=""input-group-prepend"">
                            <span class=""input-group-text""><i class=""ni ni-zoom-split-in""></i></span>
                        </div>
                        <input class=""form-control mr-2"" type=""text"" name=""SearchString"">
                        <button type=""submit"" class=""btn btn-primary btn-md mr-2"" value=""Filter"">Search</button>
                        <button type=""button"" class=""btn btn-secondary btn-md mr-2"" value=""Return to Index""");
                BeginWriteAttribute("onclick", " onclick=\"", 2928, "\"", 3001, 3);
                WriteAttributeValue("", 2938, "window.location=\'", 2938, 17, true);
#nullable restore
#line 52 "C:\Users\Fa'iz\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
WriteAttributeValue("", 2955, Url.Action("Index", "PersonnelInformations"), 2955, 45, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3000, "\'", 3000, 1, true);
                EndWriteAttribute();
                WriteLiteral(">Return to Index</button>\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 56 "C:\Users\Fa'iz\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
             if ((await AuthorizationService.AuthorizeAsync(User, "PersonnelInformationHR")).Succeeded)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <button class=\"btn btn-success btn-md\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3276, "\"", 3350, 3);
            WriteAttributeValue("", 3286, "window.location=\'", 3286, 17, true);
#nullable restore
#line 58 "C:\Users\Fa'iz\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
WriteAttributeValue("", 3303, Url.Action("Create", "PersonnelInformations"), 3303, 46, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3349, "\'", 3349, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Add</button>\r\n");
#nullable restore
#line 59 "C:\Users\Fa'iz\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
        <div class=""table-responsive"">
            <table class=""table align-items-center table-flush"">
                <thead class=""thead-flush"">
                    <tr>
                        <th scope=""col"" width=""20%"">Name</th>
                        <th scope=""col"" width=""20%"">Extension Number</th>
                        <th scope=""col"" width=""20%"">Position</th>
                        <th scope=""col"" width=""20%"">Division</th>
                        <th scope=""col"" width=""15%""></th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 73 "C:\Users\Fa'iz\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr");
            BeginWriteAttribute("id", " id=\"", 4083, "\"", 4109, 2);
            WriteAttributeValue("", 4088, "row_", 4088, 4, true);
#nullable restore
#line 75 "C:\Users\Fa'iz\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
WriteAttributeValue("", 4092, item.PersonnelId, 4092, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <td>");
#nullable restore
#line 76 "C:\Users\Fa'iz\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 77 "C:\Users\Fa'iz\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.ExtensionNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 78 "C:\Users\Fa'iz\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.CurrentPosition));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 79 "C:\Users\Fa'iz\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Division));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                            <td>\r\n");
#nullable restore
#line 82 "C:\Users\Fa'iz\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
                                 if ((await AuthorizationService.AuthorizeAsync(User, "PersonnelInformationHR")).Succeeded || (await AuthorizationService.AuthorizeAsync(User, "PersonnelInformationHOD")).Succeeded)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "095e435d5a3623ed0537428eff94978c2a07de5e22363", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 84 "C:\Users\Fa'iz\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
                                                              WriteLiteral(item.PersonnelId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 85 "C:\Users\Fa'iz\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "C:\Users\Fa'iz\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
                                 if ((await AuthorizationService.AuthorizeAsync(User, "PersonnelInformationHR")).Succeeded)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5122, "\"", 5164, 3);
            WriteAttributeValue("", 5132, "ConfirmDelete(", 5132, 14, true);
#nullable restore
#line 88 "C:\Users\Fa'iz\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
WriteAttributeValue("", 5146, item.PersonnelId, 5146, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5163, ")", 5163, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-warning\">Delete</a>\r\n");
#nullable restore
#line 89 "C:\Users\Fa'iz\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 92 "C:\Users\Fa'iz\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n        <div class=\"d-flex card-footer flex-row-reverse\">\r\n\r\n");
#nullable restore
#line 98 "C:\Users\Fa'iz\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
              
                var prevDisabled = !Model.HasPreviousPage ? "disabled" : "";
                var nextDisabled = !Model.HasNextPage ? "disabled" : "";
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"p-2\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "095e435d5a3623ed0537428eff94978c2a07de5e26983", async() => {
                WriteLiteral("\r\n                    Previous\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 104 "C:\Users\Fa'iz\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
                            WriteLiteral(ViewData["CurrentSort"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 105 "C:\Users\Fa'iz\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
                              WriteLiteral(Model.PageIndex - 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 106 "C:\Users\Fa'iz\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
                                WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5943, "btn", 5943, 3, true);
            AddHtmlAttributeValue(" ", 5946, "btn-default", 5947, 12, true);
            AddHtmlAttributeValue(" ", 5958, "btn-sm", 5959, 7, true);
#nullable restore
#line 107 "C:\Users\Fa'iz\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
AddHtmlAttributeValue(" ", 5965, prevDisabled, 5966, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "095e435d5a3623ed0537428eff94978c2a07de5e31446", async() => {
                WriteLiteral("\r\n                    Next\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 111 "C:\Users\Fa'iz\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
                            WriteLiteral(ViewData["CurrentSort"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 112 "C:\Users\Fa'iz\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
                              WriteLiteral(Model.PageIndex + 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 113 "C:\Users\Fa'iz\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
                                WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6306, "btn", 6306, 3, true);
            AddHtmlAttributeValue(" ", 6309, "btn-default", 6310, 12, true);
            AddHtmlAttributeValue(" ", 6321, "btn-sm", 6322, 7, true);
#nullable restore
#line 114 "C:\Users\Fa'iz\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
AddHtmlAttributeValue(" ", 6328, nextDisabled, 6329, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

            </div>
        </div>
    </div>
</div>
<div class=""modal fade"" id=""myModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h3 class=""modal-title"" id=""myModalLabel"">Delete Personnel</h3>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <h4>Are you sure you want to remove this personnel?</h4>

            </div>
            <div class=""modal-footer"">
                <a href=""#"" class=""btn btn-default"" data-dismiss=""modal"">Cancel</a>
                <a href=""#"" class=""btn btn-warning"" onclick=""DeletePersonnel()"">Confirm</a>
            </div>
        </div>
    </div>
</div>
<div class=""modal fade"" id=""spi");
            WriteLiteral(@"nnerModal"" data-backdrop=""static"" data-keyboard=""false"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog modal-dialog-centered justify-content-center"" role=""document"">
        <span class=""fa fa-spinner fa-spin fa-3x""></span>
    </div>
</div>
<input type=""hidden"" id=""hiddenPersonnelId"" />
");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 149 "C:\Users\Fa'iz\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <script type=""text/javascript"">

        var ConfirmDelete = function (PersonnelId) {
            $(""#hiddenPersonnelId"").val(PersonnelId);
            $(""#myModal"").modal('show');
        }

        var DeletePersonnel = function () {
            var personnelId = $(""#hiddenPersonnelId"").val();
            //alert(personnelId)
            $.ajax({
                beforeSend: function (request) {
                    $(""#myModal"").modal(""hide"");
                    $(""#spinnerModal"").modal(""show"");
                    request.setRequestHeader(""RequestVerificationToken"", $(""[name='__RequestVerificationToken']"").val());
                },
                type: 'POST',
                url: '/PersonnelInformations/Delete',
                data: {
                    id: personnelId
                },
                success: function () {
                    $(""#spinnerModal"").modal(""hide"");
                    $(""#row_"" + personnelId).remove();
                    window.location.reloa");
                WriteLiteral("d();\r\n                }\r\n            })\r\n        }\r\n    </script>\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAuthorizationService AuthorizationService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PaginatedList<BIA.Dashboard.Template.Models.PersonnelInformation>> Html { get; private set; }
    }
}
#pragma warning restore 1591