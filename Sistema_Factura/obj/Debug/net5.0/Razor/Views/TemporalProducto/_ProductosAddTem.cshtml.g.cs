#pragma checksum "C:\Users\Abel\Documents\Visual Studio 2019\Projects\SistemaFactura\Sistema_Factura\Views\TemporalProducto\_ProductosAddTem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f5440b1830f5d5c116d0b4e0944bac4c993bd12"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TemporalProducto__ProductosAddTem), @"mvc.1.0.view", @"/Views/TemporalProducto/_ProductosAddTem.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\SistemaFactura\Sistema_Factura\Views\_ViewImports.cshtml"
using Sistema_Factura;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\SistemaFactura\Sistema_Factura\Views\_ViewImports.cshtml"
using Sistema_Factura.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f5440b1830f5d5c116d0b4e0944bac4c993bd12", @"/Views/TemporalProducto/_ProductosAddTem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"876c075e2401f3383e257d2f056d1af02a2b0124", @"/Views/_ViewImports.cshtml")]
    public class Views_TemporalProducto__ProductosAddTem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Sistema_Factura.ViewModels.AgregarProducto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>CODIGO</th>\r\n            <th>NOMBRE</th>\r\n            <th>PRECIO</th>\r\n            <th>CANTIDAD</th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 13 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\SistemaFactura\Sistema_Factura\Views\TemporalProducto\_ProductosAddTem.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 17 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\SistemaFactura\Sistema_Factura\Views\TemporalProducto\_ProductosAddTem.cshtml"
               Write(Html.DisplayFor(modelItem => item.CodigoProducto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 20 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\SistemaFactura\Sistema_Factura\Views\TemporalProducto\_ProductosAddTem.cshtml"
               Write(Html.DisplayFor(modelItem => item.NombreProducto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 23 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\SistemaFactura\Sistema_Factura\Views\TemporalProducto\_ProductosAddTem.cshtml"
               Write(Html.DisplayFor(modelItem => item.PrecioProductoCompra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 26 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\SistemaFactura\Sistema_Factura\Views\TemporalProducto\_ProductosAddTem.cshtml"
               Write(Html.DisplayFor(modelItem => item.Cantidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>                              \r\n            </tr>\r\n");
#nullable restore
#line 29 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\SistemaFactura\Sistema_Factura\Views\TemporalProducto\_ProductosAddTem.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Sistema_Factura.ViewModels.AgregarProducto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
