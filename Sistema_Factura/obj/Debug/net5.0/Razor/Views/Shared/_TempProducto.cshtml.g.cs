#pragma checksum "C:\Users\Abel\Documents\Visual Studio 2019\Projects\SistemaFactura\Sistema_Factura\Views\Shared\_TempProducto.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87c67f3da3d2bc90452305e0a10018a9958c61f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__TempProducto), @"mvc.1.0.view", @"/Views/Shared/_TempProducto.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87c67f3da3d2bc90452305e0a10018a9958c61f4", @"/Views/Shared/_TempProducto.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"876c075e2401f3383e257d2f056d1af02a2b0124", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__TempProducto : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Sistema_Factura.Models.TempProducto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AnularProducto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<table class=\"table table-striped table-hover\" style=\"margin-top:25px\">\r\n    <thead");
            BeginWriteAttribute("class", " class=\"", 173, "\"", 181, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <tr>\r\n            <th>CODIGO</th>\r\n            <th>NOMBRE</th>\r\n            <th>CANTIDAD</th>\r\n            <th>PRECIO UNITARIO</th>\r\n            <th>SUBTOTAL</th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 16 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\SistemaFactura\Sistema_Factura\Views\Shared\_TempProducto.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 20 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\SistemaFactura\Sistema_Factura\Views\Shared\_TempProducto.cshtml"
               Write(Html.DisplayFor(modelItem => item.Producto.CodigoProducto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 23 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\SistemaFactura\Sistema_Factura\Views\Shared\_TempProducto.cshtml"
               Write(Html.DisplayFor(modelItem => item.Producto.NombreProducto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 26 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\SistemaFactura\Sistema_Factura\Views\Shared\_TempProducto.cshtml"
               Write(Html.DisplayFor(modelItem => item.Cantidad_temp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 29 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\SistemaFactura\Sistema_Factura\Views\Shared\_TempProducto.cshtml"
               Write(Html.DisplayFor(modelItem => item.PrecioVenta_temp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 32 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\SistemaFactura\Sistema_Factura\Views\Shared\_TempProducto.cshtml"
               Write(Html.DisplayFor(modelItem => item.SubTotal_temp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87c67f3da3d2bc90452305e0a10018a9958c61f46647", async() => {
                WriteLiteral("\r\n                        <i class=\"bi bi-trash\"></i>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\SistemaFactura\Sistema_Factura\Views\Shared\_TempProducto.cshtml"
                                                     WriteLiteral(item.TempProductoId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 40 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\SistemaFactura\Sistema_Factura\Views\Shared\_TempProducto.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    </tbody>
    <thead>
        <tr>
            <td colspan=""3""></td>
            <th style=""padding-top:20px""><b style=""font-size: 20px"">TOTAL:</b></th>
            <th style=""padding-top:20px""><b style=""font-size: 20px"">Q. <label id=""total""></label></b></th>
        </tr>
    </thead>
</table>

");
            WriteLiteral("<script>\r\n    $(function () {\r\n\r\n        var url = \"");
#nullable restore
#line 57 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\SistemaFactura\Sistema_Factura\Views\Shared\_TempProducto.cshtml"
              Write(Url.Action("BuscarTempProducto", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""";
        //jQuery
        $.post(url).done(function (data) {
            //Se ejecuta si la operacion fue un éxito
            $(""#total"").html(data);
        }).fail(manejarErrorAjax).always(function () {
            //Esta funcion siempre se ejecuta
        });
    });
    function manejarErrorAjax(err) {
        console.log(err.responseText);
    }
</script>



");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Sistema_Factura.Models.TempProducto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
