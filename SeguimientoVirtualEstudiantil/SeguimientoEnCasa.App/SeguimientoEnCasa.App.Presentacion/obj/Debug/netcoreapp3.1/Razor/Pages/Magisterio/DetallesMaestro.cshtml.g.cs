#pragma checksum "C:\U\Hospitalizacion\MIDESOFT\SeguimientoVirtualEstudiantil\SeguimientoEnCasa.App\SeguimientoEnCasa.App.Presentacion\Pages\Magisterio\DetallesMaestro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ebb00d796e4f44e996dcc16a501838c2f56b79f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SeguimientoEnCasa.App.Presentacion.Pages.Magisterio.Pages_Magisterio_DetallesMaestro), @"mvc.1.0.razor-page", @"/Pages/Magisterio/DetallesMaestro.cshtml")]
namespace SeguimientoEnCasa.App.Presentacion.Pages.Magisterio
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebb00d796e4f44e996dcc16a501838c2f56b79f4", @"/Pages/Magisterio/DetallesMaestro.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfb3f944ea715ba27f6b3c9dd60f0cabd00f3fbc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Magisterio_DetallesMaestro : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Maestro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>");
#nullable restore
#line 5 "C:\U\Hospitalizacion\MIDESOFT\SeguimientoVirtualEstudiantil\SeguimientoEnCasa.App\SeguimientoEnCasa.App.Presentacion\Pages\Magisterio\DetallesMaestro.cshtml"
Write(Model.Maestro.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<div>\r\n    Id: ");
#nullable restore
#line 7 "C:\U\Hospitalizacion\MIDESOFT\SeguimientoVirtualEstudiantil\SeguimientoEnCasa.App\SeguimientoEnCasa.App.Presentacion\Pages\Magisterio\DetallesMaestro.cshtml"
   Write(Model.Maestro.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Nombre: ");
#nullable restore
#line 10 "C:\U\Hospitalizacion\MIDESOFT\SeguimientoVirtualEstudiantil\SeguimientoEnCasa.App\SeguimientoEnCasa.App.Presentacion\Pages\Magisterio\DetallesMaestro.cshtml"
       Write(Model.Maestro.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Apellidos: ");
#nullable restore
#line 13 "C:\U\Hospitalizacion\MIDESOFT\SeguimientoVirtualEstudiantil\SeguimientoEnCasa.App\SeguimientoEnCasa.App.Presentacion\Pages\Magisterio\DetallesMaestro.cshtml"
          Write(Model.Maestro.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Numero de Telefono: ");
#nullable restore
#line 16 "C:\U\Hospitalizacion\MIDESOFT\SeguimientoVirtualEstudiantil\SeguimientoEnCasa.App\SeguimientoEnCasa.App.Presentacion\Pages\Magisterio\DetallesMaestro.cshtml"
                   Write(Model.Maestro.NumeroTelefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Genero: ");
#nullable restore
#line 19 "C:\U\Hospitalizacion\MIDESOFT\SeguimientoVirtualEstudiantil\SeguimientoEnCasa.App\SeguimientoEnCasa.App.Presentacion\Pages\Magisterio\DetallesMaestro.cshtml"
       Write(Model.Maestro.Genero);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Direccion: ");
#nullable restore
#line 22 "C:\U\Hospitalizacion\MIDESOFT\SeguimientoVirtualEstudiantil\SeguimientoEnCasa.App\SeguimientoEnCasa.App.Presentacion\Pages\Magisterio\DetallesMaestro.cshtml"
          Write(Model.Maestro.Asignatura);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Latitud: ");
#nullable restore
#line 25 "C:\U\Hospitalizacion\MIDESOFT\SeguimientoVirtualEstudiantil\SeguimientoEnCasa.App\SeguimientoEnCasa.App.Presentacion\Pages\Magisterio\DetallesMaestro.cshtml"
        Write(Model.Maestro.Curso);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Longitud: ");
#nullable restore
#line 28 "C:\U\Hospitalizacion\MIDESOFT\SeguimientoVirtualEstudiantil\SeguimientoEnCasa.App\SeguimientoEnCasa.App.Presentacion\Pages\Magisterio\DetallesMaestro.cshtml"
         Write(Model.Maestro.Registro);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ebb00d796e4f44e996dcc16a501838c2f56b79f46925", async() => {
                WriteLiteral("\r\nVolver\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SeguimientoEnCasa.App.Presentacion.Pages.Magisterio.DetallesMaestroModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SeguimientoEnCasa.App.Presentacion.Pages.Magisterio.DetallesMaestroModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SeguimientoEnCasa.App.Presentacion.Pages.Magisterio.DetallesMaestroModel>)PageContext?.ViewData;
        public SeguimientoEnCasa.App.Presentacion.Pages.Magisterio.DetallesMaestroModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
