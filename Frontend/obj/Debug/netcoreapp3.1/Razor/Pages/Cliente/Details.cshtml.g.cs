#pragma checksum "C:\Users\Hector.Cruz\Desktop\Caldas\Programacion\Ciclo 3\Repositorio\Desarrollo-de-Software\Frontend\Pages\Cliente\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1dea6a53c9e535a935dba653dc8738b5a42880c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Frontend.Pages.Cliente.Pages_Cliente_Details), @"mvc.1.0.razor-page", @"/Pages/Cliente/Details.cshtml")]
namespace Frontend.Pages.Cliente
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1dea6a53c9e535a935dba653dc8738b5a42880c", @"/Pages/Cliente/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10e7216069f48c57b0b0fadbe8f10eca06aff21f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Cliente_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"justify-content-center text-center\">\r\n<h1>Detalles Cliente</h1>\r\n</div>\r\n<hr>\r\n<div class=\"row\">\r\n        <dt class=\"col-md-4\">\r\n            ");
#nullable restore
#line 11 "C:\Users\Hector.Cruz\Desktop\Caldas\Programacion\Ciclo 3\Repositorio\Desarrollo-de-Software\Frontend\Pages\Cliente\Details.cshtml"
       Write(Html.DisplayNameFor(m => m.Cliente.Registro));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd class=\"col-md-10\">\r\n            ");
#nullable restore
#line 13 "C:\Users\Hector.Cruz\Desktop\Caldas\Programacion\Ciclo 3\Repositorio\Desarrollo-de-Software\Frontend\Pages\Cliente\Details.cshtml"
       Write(Html.DisplayFor(m => m.Cliente.Registro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-md-4\">\r\n            ");
#nullable restore
#line 16 "C:\Users\Hector.Cruz\Desktop\Caldas\Programacion\Ciclo 3\Repositorio\Desarrollo-de-Software\Frontend\Pages\Cliente\Details.cshtml"
       Write(Html.DisplayNameFor(m => m.Cliente.Solicitar_Mantenimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd class=\"col-md-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\Hector.Cruz\Desktop\Caldas\Programacion\Ciclo 3\Repositorio\Desarrollo-de-Software\Frontend\Pages\Cliente\Details.cshtml"
       Write(Html.DisplayFor(m => m.Cliente.Solicitar_Mantenimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-md-4\">\r\n            ");
#nullable restore
#line 21 "C:\Users\Hector.Cruz\Desktop\Caldas\Programacion\Ciclo 3\Repositorio\Desarrollo-de-Software\Frontend\Pages\Cliente\Details.cshtml"
       Write(Html.DisplayNameFor(m => m.Cliente.Consultar_Mantenimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd class=\"col-md-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\Hector.Cruz\Desktop\Caldas\Programacion\Ciclo 3\Repositorio\Desarrollo-de-Software\Frontend\Pages\Cliente\Details.cshtml"
       Write(Html.DisplayFor(m => m.Cliente.Consultar_Mantenimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        </div>\r\n    <br>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApp.Namespace.DetailsClienteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.DetailsClienteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.DetailsClienteModel>)PageContext?.ViewData;
        public MyApp.Namespace.DetailsClienteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
