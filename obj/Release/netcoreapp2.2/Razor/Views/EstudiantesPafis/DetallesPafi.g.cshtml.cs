#pragma checksum "C:\Users\abrah\Documents\TrabajoWEBSGCFIEE\SGCFIEE\SGCFIEE\SGCFIEE\Views\EstudiantesPafis\DetallesPafi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa3431cb72980b28a965fccaba59e7b934944b53"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa3431cb72980b28a965fccaba59e7b934944b53", @"/Views/EstudiantesPafis/DetallesPafi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1225633a62ddc17bf9f6645008885b94288a8c6a", @"/Views/_ViewImports.cshtml")]
    public class Views_EstudiantesPafis_DetallesPafi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SGCFIEE.Models.InformacionPafiCompleta>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\abrah\Documents\TrabajoWEBSGCFIEE\SGCFIEE\SGCFIEE\SGCFIEE\Views\EstudiantesPafis\DetallesPafi.cshtml"
  
    Layout = "~/Views/Home/Principal.cshtml";

#line default
#line hidden
            BeginContext(102, 486, true);
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
            BeginContext(589, 16, false);
#line 17 "C:\Users\abrah\Documents\TrabajoWEBSGCFIEE\SGCFIEE\SGCFIEE\SGCFIEE\Views\EstudiantesPafis\DetallesPafi.cshtml"
                                                                                                           Write(Model.nombrePafi);

#line default
#line hidden
            EndContext();
            BeginContext(605, 710, true);
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
                                                <strong>Nombre del academico</strong>
                                                <p id=""Matematicas"" class=""text-muted"">");
            EndContext();
            BeginContext(1316, 45, false);
#line 29 "C:\Users\abrah\Documents\TrabajoWEBSGCFIEE\SGCFIEE\SGCFIEE\SGCFIEE\Views\EstudiantesPafis\DetallesPafi.cshtml"
                                                                                  Write(Html.DisplayFor(model => model.nombreMaestro));

#line default
#line hidden
            EndContext();
            BeginContext(1361, 360, true);
            WriteLiteral(@"</p>
                                                <br>
                                            </div>
                                            <div class=""col-md-6 col-6 b-r"">
                                                <strong>Apellido paterno</strong>
                                                <p id=""Matematicas"" class=""text-muted"">");
            EndContext();
            BeginContext(1722, 42, false);
#line 34 "C:\Users\abrah\Documents\TrabajoWEBSGCFIEE\SGCFIEE\SGCFIEE\SGCFIEE\Views\EstudiantesPafis\DetallesPafi.cshtml"
                                                                                  Write(Html.DisplayFor(model => model.ApePaterno));

#line default
#line hidden
            EndContext();
            BeginContext(1764, 360, true);
            WriteLiteral(@"</p>
                                                <br>
                                            </div>
                                            <div class=""col-md-6 col-6 b-r"">
                                                <strong>Apellido materno</strong>
                                                <p id=""Matematicas"" class=""text-muted"">");
            EndContext();
            BeginContext(2125, 42, false);
#line 39 "C:\Users\abrah\Documents\TrabajoWEBSGCFIEE\SGCFIEE\SGCFIEE\SGCFIEE\Views\EstudiantesPafis\DetallesPafi.cshtml"
                                                                                  Write(Html.DisplayFor(model => model.ApePaterno));

#line default
#line hidden
            EndContext();
            BeginContext(2167, 359, true);
            WriteLiteral(@"</p>
                                                <br>
                                            </div>
                                            <div class=""col-md-6 col-6 b-r"">
                                                <strong>Número de Horas</strong>
                                                <p id=""Matematicas"" class=""text-muted"">");
            EndContext();
            BeginContext(2527, 40, false);
#line 44 "C:\Users\abrah\Documents\TrabajoWEBSGCFIEE\SGCFIEE\SGCFIEE\SGCFIEE\Views\EstudiantesPafis\DetallesPafi.cshtml"
                                                                                  Write(Html.DisplayFor(model => model.totHoras));

#line default
#line hidden
            EndContext();
            BeginContext(2567, 349, true);
            WriteLiteral(@"</p>
                                                <br>
                                            </div>
                                            <div class=""col-md-6 col-6 b-r"">
                                                <strong>Salon</strong>
                                                <p id=""Matematicas"" class=""text-muted"">");
            EndContext();
            BeginContext(2917, 43, false);
#line 49 "C:\Users\abrah\Documents\TrabajoWEBSGCFIEE\SGCFIEE\SGCFIEE\SGCFIEE\Views\EstudiantesPafis\DetallesPafi.cshtml"
                                                                                  Write(Html.DisplayFor(model => model.clave_salon));

#line default
#line hidden
            EndContext();
            BeginContext(2960, 359, true);
            WriteLiteral(@"</p>
                                                <br>
                                            </div>
                                            <div class=""col-md-6 col-6 b-r"">
                                                <strong>Numero de horas</strong>
                                                <p id=""Matematicas"" class=""text-muted"">");
            EndContext();
            BeginContext(3320, 40, false);
#line 54 "C:\Users\abrah\Documents\TrabajoWEBSGCFIEE\SGCFIEE\SGCFIEE\SGCFIEE\Views\EstudiantesPafis\DetallesPafi.cshtml"
                                                                                  Write(Html.DisplayFor(model => model.totHoras));

#line default
#line hidden
            EndContext();
            BeginContext(3360, 350, true);
            WriteLiteral(@"</p>
                                                <br>
                                            </div>
                                            <div class=""col-md-6 col-6 b-r"">
                                                <strong>Estado</strong>
                                                <p id=""Matematicas"" class=""text-muted"">");
            EndContext();
            BeginContext(3711, 35, false);
#line 59 "C:\Users\abrah\Documents\TrabajoWEBSGCFIEE\SGCFIEE\SGCFIEE\SGCFIEE\Views\EstudiantesPafis\DetallesPafi.cshtml"
                                                                                  Write(Html.DisplayFor(model => model.edo));

#line default
#line hidden
            EndContext();
            BeginContext(3746, 429, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SGCFIEE.Models.InformacionPafiCompleta> Html { get; private set; }
    }
}
#pragma warning restore 1591