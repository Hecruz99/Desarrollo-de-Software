#pragma checksum "C:\Users\Hector.Cruz\Desktop\Caldas\Programacion\Ciclo 3\Repositorio\Desarrollo-de-Software\Frontend\Pages\Carros\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bdc595b8ffafef3569191e23dbc2441b16191ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Frontend.Pages.Carros.Pages_Carros_Details), @"mvc.1.0.razor-page", @"/Pages/Carros/Details.cshtml")]
namespace Frontend.Pages.Carros
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bdc595b8ffafef3569191e23dbc2441b16191ae", @"/Pages/Carros/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1864ae33000be3f3b251118b425f84120520c9fe", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Carros_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" <div class=\"justify-content-center text-center\"></div>\n    <h1>Detalles Carros</h1>\n    <br><br>\n       <div class=\"row\">\n        <dt class=\"col-md-4\">\n            ");
#nullable restore
#line 10 "C:\Users\Hector.Cruz\Desktop\Caldas\Programacion\Ciclo 3\Repositorio\Desarrollo-de-Software\Frontend\Pages\Carros\Details.cshtml"
       Write(Html.DisplayNameFor(m => m.Carro.Marca));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\n        <dd class=\"col-md-10\">\n            ");
#nullable restore
#line 12 "C:\Users\Hector.Cruz\Desktop\Caldas\Programacion\Ciclo 3\Repositorio\Desarrollo-de-Software\Frontend\Pages\Carros\Details.cshtml"
       Write(Html.DisplayFor(m => m.Carro.Marca));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-md-4\">\n            ");
#nullable restore
#line 15 "C:\Users\Hector.Cruz\Desktop\Caldas\Programacion\Ciclo 3\Repositorio\Desarrollo-de-Software\Frontend\Pages\Carros\Details.cshtml"
       Write(Html.DisplayNameFor(m => m.Carro.Modelo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\n        <dd class=\"col-md-10\">\n            ");
#nullable restore
#line 17 "C:\Users\Hector.Cruz\Desktop\Caldas\Programacion\Ciclo 3\Repositorio\Desarrollo-de-Software\Frontend\Pages\Carros\Details.cshtml"
       Write(Html.DisplayFor(m => m.Carro.Modelo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-md-4\">\n            ");
#nullable restore
#line 20 "C:\Users\Hector.Cruz\Desktop\Caldas\Programacion\Ciclo 3\Repositorio\Desarrollo-de-Software\Frontend\Pages\Carros\Details.cshtml"
       Write(Html.DisplayNameFor(m => m.Carro.Color));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\n        <dd class=\"col-md-10\">\n            ");
#nullable restore
#line 22 "C:\Users\Hector.Cruz\Desktop\Caldas\Programacion\Ciclo 3\Repositorio\Desarrollo-de-Software\Frontend\Pages\Carros\Details.cshtml"
       Write(Html.DisplayFor(m => m.Carro.Color));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-md-4\">\n            ");
#nullable restore
#line 25 "C:\Users\Hector.Cruz\Desktop\Caldas\Programacion\Ciclo 3\Repositorio\Desarrollo-de-Software\Frontend\Pages\Carros\Details.cshtml"
       Write(Html.DisplayNameFor(m => m.Carro.Placa));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\n        <dd class=\"col-md-10\">\n            ");
#nullable restore
#line 27 "C:\Users\Hector.Cruz\Desktop\Caldas\Programacion\Ciclo 3\Repositorio\Desarrollo-de-Software\Frontend\Pages\Carros\Details.cshtml"
       Write(Html.DisplayFor(m => m.Carro.Placa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-md-4\">\n            ");
#nullable restore
#line 30 "C:\Users\Hector.Cruz\Desktop\Caldas\Programacion\Ciclo 3\Repositorio\Desarrollo-de-Software\Frontend\Pages\Carros\Details.cshtml"
       Write(Html.DisplayNameFor(m => m.Carro.Tipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\n        <dd class=\"col-md-10\">\n            ");
#nullable restore
#line 32 "C:\Users\Hector.Cruz\Desktop\Caldas\Programacion\Ciclo 3\Repositorio\Desarrollo-de-Software\Frontend\Pages\Carros\Details.cshtml"
       Write(Html.DisplayFor(m => m.Carro.Tipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-md-4\">\n            ");
#nullable restore
#line 35 "C:\Users\Hector.Cruz\Desktop\Caldas\Programacion\Ciclo 3\Repositorio\Desarrollo-de-Software\Frontend\Pages\Carros\Details.cshtml"
       Write(Html.DisplayNameFor(m => m.Carro.Cilindraje));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\n        <dd class=\"col-md-10\">\n            ");
#nullable restore
#line 37 "C:\Users\Hector.Cruz\Desktop\Caldas\Programacion\Ciclo 3\Repositorio\Desarrollo-de-Software\Frontend\Pages\Carros\Details.cshtml"
       Write(Html.DisplayFor(m => m.Carro.Cilindraje));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-md-4\">\n            ");
#nullable restore
#line 40 "C:\Users\Hector.Cruz\Desktop\Caldas\Programacion\Ciclo 3\Repositorio\Desarrollo-de-Software\Frontend\Pages\Carros\Details.cshtml"
       Write(Html.DisplayNameFor(m => m.Carro.Diagnostico));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\n        <dd class=\"col-md-10\">\n            ");
#nullable restore
#line 42 "C:\Users\Hector.Cruz\Desktop\Caldas\Programacion\Ciclo 3\Repositorio\Desarrollo-de-Software\Frontend\Pages\Carros\Details.cshtml"
       Write(Html.DisplayFor(m => m.Carro.Diagnostico));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </div>\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApp.Namespace.DetailsCarModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.DetailsCarModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.DetailsCarModel>)PageContext?.ViewData;
        public MyApp.Namespace.DetailsCarModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
