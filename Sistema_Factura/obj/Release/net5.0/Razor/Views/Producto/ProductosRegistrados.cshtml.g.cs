#pragma checksum "C:\Users\Abel\Documents\Visual Studio 2019\Projects\Sistema_Factura\Sistema_Factura\Views\Producto\ProductosRegistrados.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5de861897d293f37f8f6572f3636e6ba7e5b5be2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Producto_ProductosRegistrados), @"mvc.1.0.view", @"/Views/Producto/ProductosRegistrados.cshtml")]
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
#line 1 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\Sistema_Factura\Sistema_Factura\Views\_ViewImports.cshtml"
using Sistema_Factura;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\Sistema_Factura\Sistema_Factura\Views\_ViewImports.cshtml"
using Sistema_Factura.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5de861897d293f37f8f6572f3636e6ba7e5b5be2", @"/Views/Producto/ProductosRegistrados.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"876c075e2401f3383e257d2f056d1af02a2b0124", @"/Views/_ViewImports.cshtml")]
    public class Views_Producto_ProductosRegistrados : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Sistema_Factura.Models.Producto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NuevoProducto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\Sistema_Factura\Sistema_Factura\Views\Producto\ProductosRegistrados.cshtml"
  
    ViewData["Title"] = "ProductosRegistrados";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-center\">ProductosRegistrados</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5de861897d293f37f8f6572f3636e6ba7e5b5be24288", async() => {
                WriteLiteral("Crear Nuevo");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<div>\r\n");
#nullable restore
#line 12 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\Sistema_Factura\Sistema_Factura\Views\Producto\ProductosRegistrados.cshtml"
     if (TempData["mensajeProductoRegistrado"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-success alert-dismissible fase show\" role=\"alert\">\r\n            ");
#nullable restore
#line 15 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\Sistema_Factura\Sistema_Factura\Views\Producto\ProductosRegistrados.cshtml"
       Write(TempData["mensajeProductoRegistrado"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n                <span aria-hidden=\"true\">&times;</span>\r\n            </button>\r\n        </div>\r\n");
#nullable restore
#line 20 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\Sistema_Factura\Sistema_Factura\Views\Producto\ProductosRegistrados.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>

<table class=""table table-bordered"">
    <thead class=""thead-dark"">
        <tr>
            <th>CODIGO PRODUCTO</th>
            <th>NOMBRE</th>          
            <th>FECHA DE INGRESO</th>
            <th>PRECIO DE COMPRA</th>                        
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 33 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\Sistema_Factura\Sistema_Factura\Views\Producto\ProductosRegistrados.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 37 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\Sistema_Factura\Sistema_Factura\Views\Producto\ProductosRegistrados.cshtml"
               Write(Html.DisplayFor(modelItem => item.CodigoProducto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 40 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\Sistema_Factura\Sistema_Factura\Views\Producto\ProductosRegistrados.cshtml"
               Write(Html.DisplayFor(modelItem => item.NombreProducto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>                \r\n                <td>\r\n                    ");
#nullable restore
#line 43 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\Sistema_Factura\Sistema_Factura\Views\Producto\ProductosRegistrados.cshtml"
               Write(Html.DisplayFor(modelItem => item.FechaIngreso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 46 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\Sistema_Factura\Sistema_Factura\Views\Producto\ProductosRegistrados.cshtml"
               Write(Html.DisplayFor(modelItem => item.PrecioProductoCompra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>               \r\n            </tr>\r\n");
#nullable restore
#line 49 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\Sistema_Factura\Sistema_Factura\Views\Producto\ProductosRegistrados.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<div class=""alert alert-success"" role=""alert"" style=""margin-top:20px"">
    <b>NOTA: </b>
    <p>
        El valor del precio de compra del producto, es cuando lo compramos(registramos en el sistema)
    </p>    
    <p>Al venderlo, el precio del producto es mayor. Lo he programado para ganarle el 10% del valor de compra de cada producto</p>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Sistema_Factura.Models.Producto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
