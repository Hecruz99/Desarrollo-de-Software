#pragma checksum "C:\Users\Hector.Cruz\Desktop\Caldas\Programacion\Ciclo 3\Repositorio\Desarrollo-de-Software\Frontend\Pages\Personas\list.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a79445f89f904f8511cdfd545c32cd877f77d06b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Frontend.Pages.Personas.Pages_Personas_list), @"mvc.1.0.razor-page", @"/Pages/Personas/list.cshtml")]
namespace Frontend.Pages.Personas
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
#line 1 "C:\Users\Hector.Cruz\Desktop\Caldas\Programacion\Ciclo 3\Repositorio\Desarrollo-de-Software\Frontend\Pages\_ViewImports.cshtml"
using Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a79445f89f904f8511cdfd545c32cd877f77d06b", @"/Pages/Personas/list.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10e7216069f48c57b0b0fadbe8f10eca06aff21f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Personas_list : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""justify-content-center text-center"">
<h1>Listado Personas Registradas</h1>
<br>
</div>
<div>
    <table class=""table"">
        <tr>
            <th>Id</th>
            <th>Nombres</th>
            <th>Apellidos</th>
            <th>Edad</th>
            <th>Cedula</th>
        </tr>
");
#nullable restore
#line 18 "C:\Users\Hector.Cruz\Desktop\Caldas\Programacion\Ciclo 3\Repositorio\Desarrollo-de-Software\Frontend\Pages\Personas\list.cshtml"
         foreach(var persona in Model.Personas){

#line default
#line hidden
#nullable disable
            WriteLiteral("          <tr>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\Hector.Cruz\Desktop\Caldas\Programacion\Ciclo 3\Repositorio\Desarrollo-de-Software\Frontend\Pages\Personas\list.cshtml"
           Write(persona.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\Hector.Cruz\Desktop\Caldas\Programacion\Ciclo 3\Repositorio\Desarrollo-de-Software\Frontend\Pages\Personas\list.cshtml"
           Write(persona.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\Hector.Cruz\Desktop\Caldas\Programacion\Ciclo 3\Repositorio\Desarrollo-de-Software\Frontend\Pages\Personas\list.cshtml"
           Write(persona.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\Hector.Cruz\Desktop\Caldas\Programacion\Ciclo 3\Repositorio\Desarrollo-de-Software\Frontend\Pages\Personas\list.cshtml"
           Write(persona.Edad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\Hector.Cruz\Desktop\Caldas\Programacion\Ciclo 3\Repositorio\Desarrollo-de-Software\Frontend\Pages\Personas\list.cshtml"
           Write(persona.Cedula);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          </tr>  \r\n");
#nullable restore
#line 26 "C:\Users\Hector.Cruz\Desktop\Caldas\Programacion\Ciclo 3\Repositorio\Desarrollo-de-Software\Frontend\Pages\Personas\list.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApp.Namespace.listModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.listModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.listModel>)PageContext?.ViewData;
        public MyApp.Namespace.listModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
