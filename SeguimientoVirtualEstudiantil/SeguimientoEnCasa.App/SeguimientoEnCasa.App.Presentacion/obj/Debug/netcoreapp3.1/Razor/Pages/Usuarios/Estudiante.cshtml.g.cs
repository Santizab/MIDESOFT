#pragma checksum "C:\U\Hospitalizacion\MIDESOFT\SeguimientoVirtualEstudiantil\SeguimientoEnCasa.App\SeguimientoEnCasa.App.Presentacion\Pages\Usuarios\Estudiante.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6039a4e638d32c23b1ed9056f40e4a73e96992b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SeguimientoEnCasa.App.Presentacion.Pages.Usuarios.Pages_Usuarios_Estudiante), @"mvc.1.0.razor-page", @"/Pages/Usuarios/Estudiante.cshtml")]
namespace SeguimientoEnCasa.App.Presentacion.Pages.Usuarios
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
#line 1 "C:\U\Hospitalizacion\MIDESOFT\SeguimientoVirtualEstudiantil\SeguimientoEnCasa.App\SeguimientoEnCasa.App.Presentacion\Pages\_ViewImports.cshtml"
using SeguimientoEnCasa.App.Presentacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6039a4e638d32c23b1ed9056f40e4a73e96992b", @"/Pages/Usuarios/Estudiante.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfb3f944ea715ba27f6b3c9dd60f0cabd00f3fbc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Usuarios_Estudiante : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Lista Estudiantes</h1>\r\n<table>\r\n    <tr>\r\n        <th scope=\"col\">Nombre</th>\r\n        <th scope=\"col\">Apellidos</th>\r\n        <th scope=\"col\">Numero de Telefono</th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 13 "C:\U\Hospitalizacion\MIDESOFT\SeguimientoVirtualEstudiantil\SeguimientoEnCasa.App\SeguimientoEnCasa.App.Presentacion\Pages\Usuarios\Estudiante.cshtml"
     foreach (var p in Model.Estudiantes)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 16 "C:\U\Hospitalizacion\MIDESOFT\SeguimientoVirtualEstudiantil\SeguimientoEnCasa.App\SeguimientoEnCasa.App.Presentacion\Pages\Usuarios\Estudiante.cshtml"
           Write(p.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 17 "C:\U\Hospitalizacion\MIDESOFT\SeguimientoVirtualEstudiantil\SeguimientoEnCasa.App\SeguimientoEnCasa.App.Presentacion\Pages\Usuarios\Estudiante.cshtml"
           Write(p.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 18 "C:\U\Hospitalizacion\MIDESOFT\SeguimientoVirtualEstudiantil\SeguimientoEnCasa.App\SeguimientoEnCasa.App.Presentacion\Pages\Usuarios\Estudiante.cshtml"
           Write(p.NumeroTelefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 20 "C:\U\Hospitalizacion\MIDESOFT\SeguimientoVirtualEstudiantil\SeguimientoEnCasa.App\SeguimientoEnCasa.App.Presentacion\Pages\Usuarios\Estudiante.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SeguimientoEnCasa.App.Presentacion.Pages.EstudianteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SeguimientoEnCasa.App.Presentacion.Pages.EstudianteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SeguimientoEnCasa.App.Presentacion.Pages.EstudianteModel>)PageContext?.ViewData;
        public SeguimientoEnCasa.App.Presentacion.Pages.EstudianteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
