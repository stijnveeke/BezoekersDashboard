#pragma checksum "C:\Users\Stijn\source\repos\BezoekersDashboard\BezoekersDashboard\Views\Visitors\VisitZipFilter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d60e738e3e325e9e811c049eb52505a50ed2565"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Visitors_VisitZipFilter), @"mvc.1.0.view", @"/Views/Visitors/VisitZipFilter.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Visitors/VisitZipFilter.cshtml", typeof(AspNetCore.Views_Visitors_VisitZipFilter))]
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
#line 1 "C:\Users\Stijn\source\repos\BezoekersDashboard\BezoekersDashboard\Views\_ViewImports.cshtml"
using BezoekersDashboard;

#line default
#line hidden
#line 2 "C:\Users\Stijn\source\repos\BezoekersDashboard\BezoekersDashboard\Views\_ViewImports.cshtml"
using BezoekersDashboard.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d60e738e3e325e9e811c049eb52505a50ed2565", @"/Views/Visitors/VisitZipFilter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c3f769554b599178d53cf613ff7fe7a1f89ef5a", @"/Views/_ViewImports.cshtml")]
    public class Views_Visitors_VisitZipFilter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BezoekersDashboard.Models.Visitors>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Navbar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Stijn\source\repos\BezoekersDashboard\BezoekersDashboard\Views\Visitors\VisitZipFilter.cshtml"
  
    ViewData["Title"] = "Visit_Origin";

#line default
#line hidden
            BeginContext(106, 58, true);
            WriteLiteral("\r\n<h1>Visit_Origin</h1>\r\n\r\n<div class=\"data_holder\">\r\n    ");
            EndContext();
            BeginContext(164, 24, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5d60e738e3e325e9e811c049eb52505a50ed25655040", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(188, 386, true);
            WriteLiteral(@"
    <div class=""chart_holder"" width=""400"" height=""200"">
        <canvas id=""visitorbarchart"" class=""chart""></canvas>
    </div>
    <div class=""chart_holder"" width=""400"" height=""200"">
        <canvas id=""visitorlinechart"" class=""chart""></canvas>
    </div>
    <div></div>
    <table class=""table"">
        <thead>
            <tr>
                <th>
                    ");
            EndContext();
            BeginContext(575, 43, false);
#line 22 "C:\Users\Stijn\source\repos\BezoekersDashboard\BezoekersDashboard\Views\Visitors\VisitZipFilter.cshtml"
               Write(Html.DisplayNameFor(model => model.Zipcode));

#line default
#line hidden
            EndContext();
            BeginContext(618, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(686, 42, false);
#line 25 "C:\Users\Stijn\source\repos\BezoekersDashboard\BezoekersDashboard\Views\Visitors\VisitZipFilter.cshtml"
               Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(728, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(796, 40, false);
#line 28 "C:\Users\Stijn\source\repos\BezoekersDashboard\BezoekersDashboard\Views\Visitors\VisitZipFilter.cshtml"
               Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(836, 106, true);
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 34 "C:\Users\Stijn\source\repos\BezoekersDashboard\BezoekersDashboard\Views\Visitors\VisitZipFilter.cshtml"
              
                int count = 0;
            

#line default
#line hidden
            BeginContext(1005, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 38 "C:\Users\Stijn\source\repos\BezoekersDashboard\BezoekersDashboard\Views\Visitors\VisitZipFilter.cshtml"
             foreach (var item in Model)
            {
                count++;

                

#line default
#line hidden
#line 42 "C:\Users\Stijn\source\repos\BezoekersDashboard\BezoekersDashboard\Views\Visitors\VisitZipFilter.cshtml"
                 if (count < 5)
                {

#line default
#line hidden
            BeginContext(1144, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1229, 42, false);
#line 46 "C:\Users\Stijn\source\repos\BezoekersDashboard\BezoekersDashboard\Views\Visitors\VisitZipFilter.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Zipcode));

#line default
#line hidden
            EndContext();
            BeginContext(1271, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1363, 41, false);
#line 49 "C:\Users\Stijn\source\repos\BezoekersDashboard\BezoekersDashboard\Views\Visitors\VisitZipFilter.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(1404, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1496, 39, false);
#line 52 "C:\Users\Stijn\source\repos\BezoekersDashboard\BezoekersDashboard\Views\Visitors\VisitZipFilter.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1535, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1626, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d60e738e3e325e9e811c049eb52505a50ed256510530", async() => {
                BeginContext(1671, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 55 "C:\Users\Stijn\source\repos\BezoekersDashboard\BezoekersDashboard\Views\Visitors\VisitZipFilter.cshtml"
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
            BeginContext(1679, 32, true);
            WriteLiteral(" |\r\n                            ");
            EndContext();
            BeginContext(1711, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d60e738e3e325e9e811c049eb52505a50ed256512923", async() => {
                BeginContext(1759, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 56 "C:\Users\Stijn\source\repos\BezoekersDashboard\BezoekersDashboard\Views\Visitors\VisitZipFilter.cshtml"
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
            BeginContext(1770, 32, true);
            WriteLiteral(" |\r\n                            ");
            EndContext();
            BeginContext(1802, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d60e738e3e325e9e811c049eb52505a50ed256515322", async() => {
                BeginContext(1849, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 57 "C:\Users\Stijn\source\repos\BezoekersDashboard\BezoekersDashboard\Views\Visitors\VisitZipFilter.cshtml"
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
            BeginContext(1859, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 60 "C:\Users\Stijn\source\repos\BezoekersDashboard\BezoekersDashboard\Views\Visitors\VisitZipFilter.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1979, 114, true);
            WriteLiteral("                    <tr style=\"visibility: collapse;\">\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2094, 42, false);
#line 65 "C:\Users\Stijn\source\repos\BezoekersDashboard\BezoekersDashboard\Views\Visitors\VisitZipFilter.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Zipcode));

#line default
#line hidden
            EndContext();
            BeginContext(2136, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2228, 41, false);
#line 68 "C:\Users\Stijn\source\repos\BezoekersDashboard\BezoekersDashboard\Views\Visitors\VisitZipFilter.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(2269, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2361, 39, false);
#line 71 "C:\Users\Stijn\source\repos\BezoekersDashboard\BezoekersDashboard\Views\Visitors\VisitZipFilter.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
            EndContext();
            BeginContext(2400, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2491, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d60e738e3e325e9e811c049eb52505a50ed256519645", async() => {
                BeginContext(2536, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 74 "C:\Users\Stijn\source\repos\BezoekersDashboard\BezoekersDashboard\Views\Visitors\VisitZipFilter.cshtml"
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
            BeginContext(2544, 32, true);
            WriteLiteral(" |\r\n                            ");
            EndContext();
            BeginContext(2576, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d60e738e3e325e9e811c049eb52505a50ed256522038", async() => {
                BeginContext(2624, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 75 "C:\Users\Stijn\source\repos\BezoekersDashboard\BezoekersDashboard\Views\Visitors\VisitZipFilter.cshtml"
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
            BeginContext(2635, 32, true);
            WriteLiteral(" |\r\n                            ");
            EndContext();
            BeginContext(2667, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d60e738e3e325e9e811c049eb52505a50ed256524437", async() => {
                BeginContext(2714, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 76 "C:\Users\Stijn\source\repos\BezoekersDashboard\BezoekersDashboard\Views\Visitors\VisitZipFilter.cshtml"
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
            BeginContext(2724, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 79 "C:\Users\Stijn\source\repos\BezoekersDashboard\BezoekersDashboard\Views\Visitors\VisitZipFilter.cshtml"
                }

#line default
#line hidden
#line 79 "C:\Users\Stijn\source\repos\BezoekersDashboard\BezoekersDashboard\Views\Visitors\VisitZipFilter.cshtml"
                 
            }

#line default
#line hidden
            BeginContext(2818, 355, true);
            WriteLiteral(@"            </tbody>
    </table>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.6.0/Chart.min.js""></script>
    <script>
    (function ($) {

        var visitorbarchart = document.getElementById(""visitorbarchart"").getContext('2d');
        var visitorlinechart = document.getElementById(""visitorlinechart"").getContext('2d');
");
            EndContext();
#line 89 "C:\Users\Stijn\source\repos\BezoekersDashboard\BezoekersDashboard\Views\Visitors\VisitZipFilter.cshtml"
                          
                            var input_year = ViewData["input_year"];
                            var input_month = ViewData["input_month"];
                            var input_day = ViewData["input_date"];

                            List<object> ls = new List<object>();
                            var labelstring = "";
                            List<int> lsdata = new List<int>();

                            if (input_year == null && input_month == null && input_day == null)
                            {
                                foreach (var value in Model)
                                {
                                    if (ls.Contains(value.Date.Year))
                                    {
                                        var index = ls.IndexOf(value.Date.Year);
                                        lsdata[index] += value.Amount;
                                    }
                                    else
                                    {
                                        ls.Add(value.Date.Year);
                                        if (labelstring == "")
                                        {
                                            lsdata.Add(value.Amount);
                                            labelstring = value.Date.Year.ToString();
                                        }
                                        else
                                        {
                                            lsdata.Add(value.Amount);
                                            labelstring += " " + value.Date.Year.ToString();
                                        }
                                    }
                                }
                            }else
                            {
                                if(input_year != null)
                                {
                                    foreach (var value in Model)
                                    {
                                        if (ls.Contains(value.Date.Month))
                                        {
                                            var index = ls.IndexOf(value.Date.Month);
                                            lsdata[index] += value.Amount;
                                        }
                                        else
                                        {
                                            ls.Add(value.Date.Month);
                                            if (labelstring == "")
                                            {
                                                lsdata.Add(value.Amount);
                                                labelstring = value.Date.Month.ToString();
                                            }
                                            else
                                            {
                                                lsdata.Add(value.Amount);
                                                labelstring += " " + value.Date.Month.ToString();
                                            }
                                        }
                                    }
                                }

                                if(input_month != null)
                                {
                                    foreach (var value in Model)
                                    {
                                        if (ls.Contains(value.Date.Day))
                                        {
                                            var index = ls.IndexOf(value.Date.Day);
                                            lsdata[index] += value.Amount;
                                        }
                                        else
                                        {
                                            ls.Add(value.Date.Day);
                                            if (labelstring == "")
                                            {
                                                lsdata.Add(value.Amount);
                                                labelstring = value.Date.Day.ToString();
                                            }
                                            else
                                            {
                                                lsdata.Add(value.Amount);
                                                labelstring += " " + value.Date.Day.ToString();
                                            }
                                        }
                                    }
                                }

                                if(input_day != null)
                                {
                                    foreach (var value in Model)
                                    {
                                        if (ls.Contains(value.Date.Hour))
                                        {
                                            var index = ls.IndexOf(value.Date.Hour);
                                            lsdata[index] += value.Amount;
                                        }
                                        else
                                        {
                                            ls.Add(value.Date.Hour);
                                            if (labelstring == "")
                                            {
                                                lsdata.Add(value.Amount);
                                                labelstring = value.Date.Hour.ToString();
                                            }
                                            else
                                            {
                                                lsdata.Add(value.Amount);
                                                labelstring += " " + value.Date.Hour.ToString();
                                            }
                                        }
                                    }
                                }
                            }

                            var datastring = "";
                            foreach (var value in lsdata)
                            {
                                if (datastring == "")
                                {
                                    datastring = value.ToString();
                                }else
                                {
                                    datastring += " " + value.ToString();
                                }
                            }
                        

#line default
#line hidden
            BeginContext(9916, 25, true);
            WriteLiteral("        var dataobject = ");
            EndContext();
            BeginContext(9942, 26, false);
#line 215 "C:\Users\Stijn\source\repos\BezoekersDashboard\BezoekersDashboard\Views\Visitors\VisitZipFilter.cshtml"
                    Write(Json.Serialize(datastring));

#line default
#line hidden
            EndContext();
            BeginContext(9968, 29, true);
            WriteLiteral(";\r\n        var labelobject = ");
            EndContext();
            BeginContext(9998, 27, false);
#line 216 "C:\Users\Stijn\source\repos\BezoekersDashboard\BezoekersDashboard\Views\Visitors\VisitZipFilter.cshtml"
                     Write(Json.Serialize(labelstring));

#line default
#line hidden
            EndContext();
            BeginContext(10025, 1513, true);
            WriteLiteral(@";
        var dataar = dataobject.split("" "");
        var labelar = labelobject.split("" "");
        var data = [""test"", ""123""];
        //arstring = ""'"" + arstring;
        //var stringar = [arstring.split("", "")];
        console.log(dataar);
        var chartdata = {
            labels: labelar,
                datasets: [
                    {
                        fillColor: ""rgba(220,220,220,0.8)"",
                        strokeColor: ""rgba(220,220,220,0.8)"",
                        highlightFill: ""rgba(220,220,220,0.75)"",
                        highlightStroke: ""rgba(220,220,220,1)"",
                        data: dataar
                    }
                ]

            };

        var visitorbarchart = new Chart(visitorbarchart,{
            type: 'bar',
            data: chartdata,
            options: {
                scales: {
                    yAxes: [{
                        ticks: {
                            beginAtZero: true
                        }
     ");
            WriteLiteral(@"               }]
                }
            }
        });

        var visitorlinechart = new Chart(visitorlinechart, {
            type: 'line',
            data: chartdata,
            options: {
                scales: {
                    yAxes: [{
                        ticks: {
                            beginAtZero: true
                        }
                    }]
                }
            }
        });

    }(jQuery))
    </script>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BezoekersDashboard.Models.Visitors>> Html { get; private set; }
    }
}
#pragma warning restore 1591
