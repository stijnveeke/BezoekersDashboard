#pragma checksum "C:\Users\Stijn\source\repos\BezoekersDashboard\BezoekersDashboard\Views\Visitors\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22cb43d278285ca1a55cc7bd81fd82e63a56f993"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Visitors_Index), @"mvc.1.0.view", @"/Views/Visitors/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Visitors/Index.cshtml", typeof(AspNetCore.Views_Visitors_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22cb43d278285ca1a55cc7bd81fd82e63a56f993", @"/Views/Visitors/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c3f769554b599178d53cf613ff7fe7a1f89ef5a", @"/Views/_ViewImports.cshtml")]
    public class Views_Visitors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BezoekersDashboard.Models.Visitors>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Chart.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(69, 34, true);
            WriteLiteral("\r\n<h1>Visitors</h1>\r\n\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(103, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22cb43d278285ca1a55cc7bd81fd82e63a56f9934240", async() => {
                BeginContext(126, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(140, 8, true);
            WriteLiteral("\r\n</p>\r\n");
            EndContext();
            BeginContext(148, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22cb43d278285ca1a55cc7bd81fd82e63a56f9935622", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(185, 1527, true);
            WriteLiteral(@"
<p>
    <div class=""data_holder"">
        <div id=""filter_holder"">
            <div id=""filter_nav_holder"">
                <button id=""btn_year"" class=""nav_btn nav_active"" filter_id=""input_year"">Jaar</button>
                <input type=""text"" id=""input_year"" class=""nav_input nav_active"" />
                <button id=""btn_month"" class=""nav_btn"" filter_id=""input_month"">Maand</button>
                <input type=""text"" id=""input_month"" class=""nav_input"" />
                <button id=""btn_day"" class=""nav_btn"" filter_id=""input_date"">Dag</button>
                <input type=""date"" id=""input_date"" class=""nav_input"" />
                <button id=""btn_zipcode"" class=""nav_toggle_btn"" filter_id=""input_zip"">Postcode</button>
                <input type=""text"" id=""input_zip"" />
            </div>
            <div id=""filter_input_holder"">
            </div>
            <div id=""filter_submit_holder"">
                <button id=""submit_filter"">Search</button>
            </div>
        </div>
       ");
            WriteLiteral(@" <div class=""chart_holder"" width=""400"" height=""200"">
            <canvas id=""visitorbarchart"" class=""chart""></canvas>
        </div>
        <div class=""chart_holder"" width=""400"" height=""200"">
            <canvas id=""visitorlinechart"" class=""chart""></canvas>
        </div>
        <div id='map' class=""custom_map"" style='width: 400px; height: 300px;'></div>
        <table class=""table custom_table"">
            <thead>
                <tr>
                    <th>
                        ");
            EndContext();
            BeginContext(1713, 42, false);
#line 45 "C:\Users\Stijn\source\repos\BezoekersDashboard\BezoekersDashboard\Views\Visitors\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(1755, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1835, 43, false);
#line 48 "C:\Users\Stijn\source\repos\BezoekersDashboard\BezoekersDashboard\Views\Visitors\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Zipcode));

#line default
#line hidden
            EndContext();
            BeginContext(1878, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1958, 40, false);
#line 51 "C:\Users\Stijn\source\repos\BezoekersDashboard\BezoekersDashboard\Views\Visitors\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1998, 95, true);
            WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 56 "C:\Users\Stijn\source\repos\BezoekersDashboard\BezoekersDashboard\Views\Visitors\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(2158, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2231, 41, false);
#line 60 "C:\Users\Stijn\source\repos\BezoekersDashboard\BezoekersDashboard\Views\Visitors\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(2272, 81, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2353, "\"", 2419, 2);
            WriteAttributeValue("", 2360, "Visitors/GetZip/", 2360, 16, true);
#line 63 "C:\Users\Stijn\source\repos\BezoekersDashboard\BezoekersDashboard\Views\Visitors\Index.cshtml"
WriteAttributeValue("", 2376, Html.DisplayFor(modelItem => item.Zipcode), 2376, 43, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2420, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2422, 42, false);
#line 63 "C:\Users\Stijn\source\repos\BezoekersDashboard\BezoekersDashboard\Views\Visitors\Index.cshtml"
                                                                                         Write(Html.DisplayFor(modelItem => item.Zipcode));

#line default
#line hidden
            EndContext();
            BeginContext(2464, 85, true);
            WriteLiteral("</a>\r\n                    </td>\r\n                    <td>\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2549, "\"", 2613, 2);
            WriteAttributeValue("", 2556, "Visitors/GetDate/", 2556, 17, true);
#line 66 "C:\Users\Stijn\source\repos\BezoekersDashboard\BezoekersDashboard\Views\Visitors\Index.cshtml"
WriteAttributeValue("", 2573, Html.DisplayFor(modelItem => item.Date), 2573, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2614, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2616, 39, false);
#line 66 "C:\Users\Stijn\source\repos\BezoekersDashboard\BezoekersDashboard\Views\Visitors\Index.cshtml"
                                                                                       Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
            EndContext();
            BeginContext(2655, 57, true);
            WriteLiteral("</a>\r\n                    </td> \r\n                </tr>\r\n");
            EndContext();
#line 69 "C:\Users\Stijn\source\repos\BezoekersDashboard\BezoekersDashboard\Views\Visitors\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2731, 2595, true);
            WriteLiteral(@"            </tbody>
        </table>
    </div>
    <script>
        //interactive filter bar script for search
        (function ($) {
            $(document).ready(function () {
                $('body').off('click', '.nav_btn').on('click', '.nav_btn', function () {
                    $('.nav_btn').each(function () {
                        $(this).removeClass('nav_active');
                    })
                    $(this).addClass('nav_active');
                    var filter_id = $(this).attr('filter_id');
                    $('.nav_input').each(function () {
                        $(this).removeClass('nav_active')
                    })
                    $('#' + filter_id).addClass('nav_active');
                })

                //interaction for filtering on zipcodes
                $('body').off('click', '.nav_toggle_btn').on('click', '.nav_toggle_btn', function () {

                    var filter_id = $(this).attr('filter_id');
                    if ($('#' + filter_");
            WriteLiteral(@"id).hasClass('nav_active')) {
                        $('#' + filter_id).removeClass('nav_active');
                        $(this).removeClass('nav_active')
                    } else {
                        $('#' + filter_id).addClass('nav_active');
                        $(this).addClass('nav_active')
                    }
                });

                $('body').off('click', '#submit_filter').on('click', '#submit_filter', function () {
                    var values = """";
                    var value = """";
                    $('input.nav_active').each(function () {
                        value = $(this).val();
                        values += ""/""+$(this).attr('id')+""/""+value;
                    });
                    window.location.replace(""/Visitors"" + values);
                });
            });
        }(jQuery));
    </script>
    <script>
        mapboxgl.accessToken = 'pk.eyJ1IjoiZDI1MjIxNSIsImEiOiJjanZud252d3QxbXMwNDNuemVzNGR1OXd4In0.buef45ACfL9QD2pc8nXWsA';
 ");
            WriteLiteral(@"       var map = new mapboxgl.Map({
            container: 'map',
            style: 'mapbox://styles/mapbox/streets-v11',
            center: [4.4126, 51.5094],
            zoom: 11
        });
    </script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.6.0/Chart.min.js""></script>
    <script>
        (function ($) {

            var visitorbarchart = document.getElementById(""visitorbarchart"").getContext('2d');
            var visitorlinechart = document.getElementById(""visitorlinechart"").getContext('2d');
");
            EndContext();
#line 129 "C:\Users\Stijn\source\repos\BezoekersDashboard\BezoekersDashboard\Views\Visitors\Index.cshtml"
                              
                               List<object> ls = new List<object>();
                               var labelstring = "";
                               List<int> lsdata = new List<int>();
                               foreach (var value in Model)
                               {
                                   if (ls.Contains(value.Zipcode)) {
                                       var index = ls.IndexOf(value.Zipcode);
                                       lsdata[index] += value.Amount;
                                   } else
                                   {
                                       ls.Add(value.Zipcode);
                                       if (labelstring == "")
                                       {
                                           lsdata.Add(value.Amount);
                                           labelstring = value.Zipcode.ToString();
                                       }else
                                       {
                                           lsdata.Add(value.Amount);
                                           labelstring += " " + value.Zipcode.ToString();
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
            BeginContext(7209, 29, true);
            WriteLiteral("            var dataobject = ");
            EndContext();
            BeginContext(7239, 26, false);
#line 165 "C:\Users\Stijn\source\repos\BezoekersDashboard\BezoekersDashboard\Views\Visitors\Index.cshtml"
                        Write(Json.Serialize(datastring));

#line default
#line hidden
            EndContext();
            BeginContext(7265, 33, true);
            WriteLiteral(";\r\n            var labelobject = ");
            EndContext();
            BeginContext(7299, 27, false);
#line 166 "C:\Users\Stijn\source\repos\BezoekersDashboard\BezoekersDashboard\Views\Visitors\Index.cshtml"
                         Write(Json.Serialize(labelstring));

#line default
#line hidden
            EndContext();
            BeginContext(7326, 1709, true);
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
                        yAxes: [");
            WriteLiteral(@"{
                            ticks: {
                                beginAtZero: true
                            }
                        }]
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
</p>");
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
