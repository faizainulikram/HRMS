#pragma checksum "C:\Users\MISU Dev\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6213dbdb24a8d7abef412c8b79d232eb9e29ace"
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
#line 1 "C:\Users\MISU Dev\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\_ViewImports.cshtml"
using BIA.Dashboard.Template;

#line default
#line hidden
#line 2 "C:\Users\MISU Dev\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\_ViewImports.cshtml"
using BIA.Dashboard.Template.Infrastructure.ApplicationUserClaims;

#line default
#line hidden
#line 3 "C:\Users\MISU Dev\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\_ViewImports.cshtml"
using BIA.Dashboard.Template.Models;

#line default
#line hidden
#line 4 "C:\Users\MISU Dev\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\_ViewImports.cshtml"
using BIA.Dashboard.Template.Models.Identity;

#line default
#line hidden
#line 1 "C:\Users\MISU Dev\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 3 "C:\Users\MISU Dev\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6213dbdb24a8d7abef412c8b79d232eb9e29ace", @"/Views/PersonnelInformations/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d03475a17aebe9d9bfc99d7023b287f6467a8242", @"/Views/_ViewImports.cshtml")]
    public class Views_PersonnelInformations_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PaginatedList<BIA.Dashboard.Template.Models.PersonnelInformation>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-item nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Verify", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "PersonnelInformations", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 7 "C:\Users\MISU Dev\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            WriteLiteral("\r\n<nav class=\"navbar navbar-horizontal navbar-expand-lg navbar-dark bg-default rounded\">\r\n    <div class=\"collapse navbar-collapse\" id=\"navbarNavAltMarkup\">\r\n        <div class=\"navbar-nav nav-fill w-100\">\r\n            <a class=\"nav-item nav-link\"");
            BeginWriteAttribute("href", " href=\"", 547, "\"", 574, 1);
#line 14 "C:\Users\MISU Dev\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
WriteAttributeValue("", 554, Url.Action("Index"), 554, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">Directory</a>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6213dbdb24a8d7abef412c8b79d232eb9e29ace7578", async() => {
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
#line 15 "C:\Users\MISU Dev\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
                                                               WriteLiteral(userManager.GetUserId(User));

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
            WriteLiteral("\r\n");
#line 16 "C:\Users\MISU Dev\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
             if ((await AuthorizationService.AuthorizeAsync(User, "PersonnelInformationHR")).Succeeded)
            {

#line default
#line hidden
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6213dbdb24a8d7abef412c8b79d232eb9e29ace10161", async() => {
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
            WriteLiteral("\r\n");
#line 19 "C:\Users\MISU Dev\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
            }

#line default
#line hidden
            WriteLiteral("        </div>\r\n    </div>\r\n</nav>\r\n<div class=\"row\">\r\n    <div class=\"col\">\r\n        <div class=\"card-header border-0\">\r\n            <h1 class=\"mb-5 text-center\">Directory</h1>\r\n");
            WriteLiteral("            <div class=\"form-group\" asp-controller=\"PersonnelInformations\" asp-action=\"Index\" method=\"get\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6213dbdb24a8d7abef412c8b79d232eb9e29ace11965", async() => {
                WriteLiteral("\r\n");
                WriteLiteral(@"                    <div class=""input-group"">
                        <div class=""input-group-prepend"">
                            <span class=""input-group-text""><i class=""ni ni-zoom-split-in""></i></span>
                        </div>
                        <input class=""form-control mr-2"" type=""text"" name=""SearchString"">
                        <button type=""submit"" class=""btn btn-primary btn-md mr-2"" value=""Filter"">Search</button>
                        <button type=""button"" class=""btn btn-secondary btn-md mr-2"" value=""Return to Index""");
                BeginWriteAttribute("onclick", " onclick=\"", 2038, "\"", 2111, 3);
                WriteAttributeValue("", 2048, "window.location=\'", 2048, 17, true);
#line 38 "C:\Users\MISU Dev\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
WriteAttributeValue("", 2065, Url.Action("Index", "PersonnelInformations"), 2065, 45, false);

#line default
#line hidden
                WriteAttributeValue("", 2110, "\'", 2110, 1, true);
                EndWriteAttribute();
                WriteLiteral(">Return to Index</button>\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n");
#line 42 "C:\Users\MISU Dev\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
             if ((await AuthorizationService.AuthorizeAsync(User, "PersonnelInformationHR")).Succeeded)
            {

#line default
#line hidden
            WriteLiteral("                <button class=\"btn btn-success btn-md\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2386, "\"", 2460, 3);
            WriteAttributeValue("", 2396, "window.location=\'", 2396, 17, true);
#line 44 "C:\Users\MISU Dev\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
WriteAttributeValue("", 2413, Url.Action("Create", "PersonnelInformations"), 2413, 46, false);

#line default
#line hidden
            WriteAttributeValue("", 2459, "\'", 2459, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Add</button>\r\n");
#line 45 "C:\Users\MISU Dev\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
            }

#line default
#line hidden
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
#line 59 "C:\Users\MISU Dev\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            WriteLiteral("                        <tr");
            BeginWriteAttribute("id", " id=\"", 3193, "\"", 3219, 2);
            WriteAttributeValue("", 3198, "row_", 3198, 4, true);
#line 61 "C:\Users\MISU Dev\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
WriteAttributeValue("", 3202, item.PersonnelId, 3202, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <td>");
#line 62 "C:\Users\MISU Dev\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            WriteLiteral("</td>\r\n                            <td>");
#line 63 "C:\Users\MISU Dev\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.ExtensionNumber));

#line default
#line hidden
            WriteLiteral("</td>\r\n                            <td>");
#line 64 "C:\Users\MISU Dev\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.CurrentPosition));

#line default
#line hidden
            WriteLiteral("</td>\r\n                            <td>");
#line 65 "C:\Users\MISU Dev\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Division));

#line default
#line hidden
            WriteLiteral("</td>\r\n\r\n                            <td>\r\n");
#line 68 "C:\Users\MISU Dev\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
                                 if ((await AuthorizationService.AuthorizeAsync(User, "PersonnelInformationHR")).Succeeded || (await AuthorizationService.AuthorizeAsync(User, "PersonnelInformationHOD")).Succeeded)
                                {

#line default
#line hidden
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6213dbdb24a8d7abef412c8b79d232eb9e29ace19163", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 70 "C:\Users\MISU Dev\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
                                                              WriteLiteral(item.PersonnelId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#line 71 "C:\Users\MISU Dev\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
                                }

#line default
#line hidden
#line 72 "C:\Users\MISU Dev\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
                                 if ((await AuthorizationService.AuthorizeAsync(User, "PersonnelInformationHR")).Succeeded)
                                {

#line default
#line hidden
            WriteLiteral("                                    <a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4232, "\"", 4274, 3);
            WriteAttributeValue("", 4242, "ConfirmDelete(", 4242, 14, true);
#line 74 "C:\Users\MISU Dev\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
WriteAttributeValue("", 4256, item.PersonnelId, 4256, 17, false);

#line default
#line hidden
            WriteAttributeValue("", 4273, ")", 4273, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-warning\">Delete</a>\r\n");
#line 75 "C:\Users\MISU Dev\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
                                }

#line default
#line hidden
            WriteLiteral("                            </td>\r\n                        </tr>\r\n");
#line 78 "C:\Users\MISU Dev\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
                    }

#line default
#line hidden
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n        <div class=\"d-flex card-footer flex-row-reverse\">\r\n\r\n");
#line 84 "C:\Users\MISU Dev\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
              
                var prevDisabled = !Model.HasPreviousPage ? "disabled" : "";
                var nextDisabled = !Model.HasNextPage ? "disabled" : "";
            

#line default
#line hidden
            WriteLiteral("            <div class=\"p-2\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6213dbdb24a8d7abef412c8b79d232eb9e29ace23538", async() => {
                WriteLiteral("\r\n                    Previous\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 90 "C:\Users\MISU Dev\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
                            WriteLiteral(ViewData["CurrentSort"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 91 "C:\Users\MISU Dev\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
                              WriteLiteral(Model.PageIndex - 1);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 92 "C:\Users\MISU Dev\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
                                WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5053, "btn", 5053, 3, true);
            AddHtmlAttributeValue(" ", 5056, "btn-default", 5057, 12, true);
            AddHtmlAttributeValue(" ", 5068, "btn-sm", 5069, 7, true);
#line 93 "C:\Users\MISU Dev\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
AddHtmlAttributeValue(" ", 5075, prevDisabled, 5076, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6213dbdb24a8d7abef412c8b79d232eb9e29ace27857", async() => {
                WriteLiteral("\r\n                    Next\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 97 "C:\Users\MISU Dev\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
                            WriteLiteral(ViewData["CurrentSort"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 98 "C:\Users\MISU Dev\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
                              WriteLiteral(Model.PageIndex + 1);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 99 "C:\Users\MISU Dev\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
                                WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5416, "btn", 5416, 3, true);
            AddHtmlAttributeValue(" ", 5419, "btn-default", 5420, 12, true);
            AddHtmlAttributeValue(" ", 5431, "btn-sm", 5432, 7, true);
#line 100 "C:\Users\MISU Dev\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
AddHtmlAttributeValue(" ", 5438, nextDisabled, 5439, 13, false);

#line default
#line hidden
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
#line 135 "C:\Users\MISU Dev\Desktop\HRMS\hrms\BIA.Dashboard.Template\Views\PersonnelInformations\Index.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
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
                }
            })
      ");
                WriteLiteral("  }\r\n    </script>\r\n");
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
