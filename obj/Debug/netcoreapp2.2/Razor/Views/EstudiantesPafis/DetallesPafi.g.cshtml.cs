#pragma checksum "C:\Users\abrah\Documents\TrabajoWEBSGCFIEE\SGCFIEE\SGCFIEE\SGCFIEE\Views\EstudiantesPafis\DetallesPafi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a74f37f3650a4bd6a38c14931bea70f21b0e94d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EstudiantesPafis_DetallesPafi), @"mvc.1.0.view", @"/Views/EstudiantesPafis/DetallesPafi.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/EstudiantesPafis/DetallesPafi.cshtml", typeof(AspNetCore.Views_EstudiantesPafis_DetallesPafi))]
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
#line 1 "C:\Users\abrah\Documents\TrabajoWEBSGCFIEE\SGCFIEE\SGCFIEE\SGCFIEE\Views\_ViewImports.cshtml"
using SGCFIEE;

#line default
#line hidden
#line 2 "C:\Users\abrah\Documents\TrabajoWEBSGCFIEE\SGCFIEE\SGCFIEE\SGCFIEE\Views\_ViewImports.cshtml"
using SGCFIEE.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a74f37f3650a4bd6a38c14931bea70f21b0e94d", @"/Views/EstudiantesPafis/DetallesPafi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1225633a62ddc17bf9f6645008885b94288a8c6a", @"/Views/_ViewImports.cshtml")]
    public class Views_EstudiantesPafis_DetallesPafi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SGCFIEE.Models.TablaPafi>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\abrah\Documents\TrabajoWEBSGCFIEE\SGCFIEE\SGCFIEE\SGCFIEE\Views\EstudiantesPafis\DetallesPafi.cshtml"
  
    Layout = "~/Views/Home/Principal.cshtml";

#line default
#line hidden
            BeginContext(88, 486, true);
            WriteLiteral(@"
<!DOCTYPE html>

<html>
<div class=""profile-content"">
    <div class=""row"">
        <div class=""col-md-12 col-sm-12"">
            <div class=""card"">
                <div class=""card-topline-green""></div>
                <div class=""white-box"">
                    <div class=""p-rl-20"">
                        <ul class=""nav customtab nav-tabs"" role=""tablist"">
                            <li class=""nav-item""><a href=""#tab1"" class=""nav-link active show"" data-toggle=""tab"">");
            EndContext();
            BeginContext(575, 16, false);
#line 17 "C:\Users\abrah\Documents\TrabajoWEBSGCFIEE\SGCFIEE\SGCFIEE\SGCFIEE\Views\EstudiantesPafis\DetallesPafi.cshtml"
                                                                                                           Write(Model.NombrePafi);

#line default
#line hidden
            EndContext();
            BeginContext(591, 696, true);
            WriteLiteral(@"</a></li>
                        </ul>
                    </div>
                    <div class=""tab-content"">
                        <div class=""tab-pane fontawesome-demo active show"" id=""tab1"">
                            <div class=""row"">
                                <div class=""col-md-12 col-sm-12"">

                                    <div class=""card-body "" id=""bar-parent2"">
                                        <div class=""row"">
                                            <div class=""col-md-6 col-6 b-r"">
                                                <label>Profesor</label>
                                                <p id=""Matematicas"" class=""text-muted"">");
            EndContext();
            BeginContext(1288, 45, false);
#line 29 "C:\Users\abrah\Documents\TrabajoWEBSGCFIEE\SGCFIEE\SGCFIEE\SGCFIEE\Views\EstudiantesPafis\DetallesPafi.cshtml"
                                                                                  Write(Html.DisplayFor(model => model.NombreMaestro));

#line default
#line hidden
            EndContext();
            BeginContext(1333, 353, true);
            WriteLiteral(@"</p>
                                                <br>
                                            </div>
                                            <div class=""col-md-6 col-6 b-r"">
                                                <strong>Tipo Pafi</strong>
                                                <p id=""Matematicas"" class=""text-muted"">");
            EndContext();
            BeginContext(1687, 42, false);
#line 34 "C:\Users\abrah\Documents\TrabajoWEBSGCFIEE\SGCFIEE\SGCFIEE\SGCFIEE\Views\EstudiantesPafis\DetallesPafi.cshtml"
                                                                                  Write(Html.DisplayFor(model => model.ApePaterno));

#line default
#line hidden
            EndContext();
            BeginContext(1729, 353, true);
            WriteLiteral(@"</p>
                                                <br>
                                            </div>
                                            <div class=""col-md-6 col-6 b-r"">
                                                <strong>Solicitud</strong>
                                                <p id=""Matematicas"" class=""text-muted"">");
            EndContext();
            BeginContext(2083, 42, false);
#line 39 "C:\Users\abrah\Documents\TrabajoWEBSGCFIEE\SGCFIEE\SGCFIEE\SGCFIEE\Views\EstudiantesPafis\DetallesPafi.cshtml"
                                                                                  Write(Html.DisplayFor(model => model.ApePaterno));

#line default
#line hidden
            EndContext();
            BeginContext(2125, 359, true);
            WriteLiteral(@"</p>
                                                <br>
                                            </div>
                                            <div class=""col-md-6 col-6 b-r"">
                                                <strong>Número de Horas</strong>
                                                <p id=""Matematicas"" class=""text-muted"">");
            EndContext();
            BeginContext(2485, 42, false);
#line 44 "C:\Users\abrah\Documents\TrabajoWEBSGCFIEE\SGCFIEE\SGCFIEE\SGCFIEE\Views\EstudiantesPafis\DetallesPafi.cshtml"
                                                                                  Write(Html.DisplayFor(model => model.ApePaterno));

#line default
#line hidden
            EndContext();
            BeginContext(2527, 351, true);
            WriteLiteral(@"</p>
                                                <br>
                                            </div>
                                            <div class=""col-md-6 col-6 b-r"">
                                                <strong>Periodo</strong>
                                                <p id=""Matematicas"" class=""text-muted"">");
            EndContext();
            BeginContext(2879, 42, false);
#line 49 "C:\Users\abrah\Documents\TrabajoWEBSGCFIEE\SGCFIEE\SGCFIEE\SGCFIEE\Views\EstudiantesPafis\DetallesPafi.cshtml"
                                                                                  Write(Html.DisplayFor(model => model.ApePaterno));

#line default
#line hidden
            EndContext();
            BeginContext(2921, 349, true);
            WriteLiteral(@"</p>
                                                <br>
                                            </div>
                                            <div class=""col-md-6 col-6 b-r"">
                                                <strong>Salon</strong>
                                                <p id=""Matematicas"" class=""text-muted"">");
            EndContext();
            BeginContext(3271, 40, false);
#line 54 "C:\Users\abrah\Documents\TrabajoWEBSGCFIEE\SGCFIEE\SGCFIEE\SGCFIEE\Views\EstudiantesPafis\DetallesPafi.cshtml"
                                                                                  Write(Html.DisplayFor(model => model.ClvSalon));

#line default
#line hidden
            EndContext();
            BeginContext(3311, 353, true);
            WriteLiteral(@"</p>
                                                <br>
                                            </div>
                                            <div class=""col-md-6 col-6 b-r"">
                                                <strong>Número CT</strong>
                                                <p id=""Matematicas"" class=""text-muted"">");
            EndContext();
            BeginContext(3665, 42, false);
#line 59 "C:\Users\abrah\Documents\TrabajoWEBSGCFIEE\SGCFIEE\SGCFIEE\SGCFIEE\Views\EstudiantesPafis\DetallesPafi.cshtml"
                                                                                  Write(Html.DisplayFor(model => model.ApePaterno));

#line default
#line hidden
            EndContext();
            BeginContext(3707, 429, true);
            WriteLiteral(@"</p>
                                                <br>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
</html>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SGCFIEE.Models.TablaPafi> Html { get; private set; }
    }
}
#pragma warning restore 1591
