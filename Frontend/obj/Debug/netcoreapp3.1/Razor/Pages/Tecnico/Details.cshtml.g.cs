#pragma checksum "C:\Users\Hector.Cruz\Desktop\Caldas\Programacion\Ciclo 3\Repositorio\Desarrollo-de-Software\Frontend\Pages\Tecnico\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "079e09aa539934ed5da9a6e700ff4089a34f1759"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Frontend.Pages.Tecnico.Pages_Tecnico_Details), @"mvc.1.0.razor-page", @"/Pages/Tecnico/Details.cshtml")]
namespace Frontend.Pages.Tecnico
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"079e09aa539934ed5da9a6e700ff4089a34f1759", @"/Pages/Tecnico/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1864ae33000be3f3b251118b425f84120520c9fe", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Tecnico_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"justify-content-center text-center\">\n<h1>Detalles Tecnico</h1>\n</div>\n<hr>\n<div class=\"row\">\n        <dt class=\"col-md-4\">\n            ");
#nullable restore
#line 11 "C:\Users\Hector.Cruz\Desktop\Caldas\Programacion\Ciclo 3\Repositorio\Desarrollo-de-Software\Frontend\Pages\Tecnico\Details.cshtml"
       Write(Html.DisplayNameFor(m => m.Tecnico.Registrar_Mantenimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\n        <dd class=\"col-md-10\">\n            ");
#nullable restore
#line 13 "C:\Users\Hector.Cruz\Desktop\Caldas\Programacion\Ciclo 3\Repositorio\Desarrollo-de-Software\Frontend\Pages\Tecnico\Details.cshtml"
       Write(Html.DisplayFor(m => m.Tecnico.Registrar_Mantenimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-md-4\">\n            ");
#nullable restore
#line 16 "C:\Users\Hector.Cruz\Desktop\Caldas\Programacion\Ciclo 3\Repositorio\Desarrollo-de-Software\Frontend\Pages\Tecnico\Details.cshtml"
       Write(Html.DisplayNameFor(m => m.Tecnico.Realizar_Mantenimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\n        <dd class=\"col-md-10\">\n            ");
#nullable restore
#line 18 "C:\Users\Hector.Cruz\Desktop\Caldas\Programacion\Ciclo 3\Repositorio\Desarrollo-de-Software\Frontend\Pages\Tecnico\Details.cshtml"
       Write(Html.DisplayFor(m => m.Tecnico.Realizar_Mantenimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-md-4\">\n            ");
#nullable restore
#line 21 "C:\Users\Hector.Cruz\Desktop\Caldas\Programacion\Ciclo 3\Repositorio\Desarrollo-de-Software\Frontend\Pages\Tecnico\Details.cshtml"
       Write(Html.DisplayNameFor(m => m.Tecnico.Instalar_Repuestos));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\n        <dd class=\"col-md-10\">\n            ");
#nullable restore
#line 23 "C:\Users\Hector.Cruz\Desktop\Caldas\Programacion\Ciclo 3\Repositorio\Desarrollo-de-Software\Frontend\Pages\Tecnico\Details.cshtml"
       Write(Html.DisplayFor(m => m.Tecnico.Instalar_Repuestos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-md-4\">\n            ");
#nullable restore
#line 26 "C:\Users\Hector.Cruz\Desktop\Caldas\Programacion\Ciclo 3\Repositorio\Desarrollo-de-Software\Frontend\Pages\Tecnico\Details.cshtml"
       Write(Html.DisplayNameFor(m => m.Tecnico.Consultar_Mantenimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\n        <dd class=\"col-md-10\">\n            ");
#nullable restore
#line 28 "C:\Users\Hector.Cruz\Desktop\Caldas\Programacion\Ciclo 3\Repositorio\Desarrollo-de-Software\Frontend\Pages\Tecnico\Details.cshtml"
       Write(Html.DisplayFor(m => m.Tecnico.Consultar_Mantenimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-md-4\">\n            ");
#nullable restore
#line 31 "C:\Users\Hector.Cruz\Desktop\Caldas\Programacion\Ciclo 3\Repositorio\Desarrollo-de-Software\Frontend\Pages\Tecnico\Details.cshtml"
       Write(Html.DisplayNameFor(m => m.Tecnico.Placa_Carro));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\n        <dd class=\"col-md-10\">\n            ");
#nullable restore
#line 33 "C:\Users\Hector.Cruz\Desktop\Caldas\Programacion\Ciclo 3\Repositorio\Desarrollo-de-Software\Frontend\Pages\Tecnico\Details.cshtml"
       Write(Html.DisplayFor(m => m.Tecnico.Placa_Carro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        </div>\n    <br>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApp.Namespace.DetailsTecnicoModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.DetailsTecnicoModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.DetailsTecnicoModel>)PageContext?.ViewData;
        public MyApp.Namespace.DetailsTecnicoModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
