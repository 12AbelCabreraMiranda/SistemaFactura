#pragma checksum "C:\Users\Abel\Documents\Visual Studio 2019\Projects\Sistema_Factura\Sistema_Factura\Views\TemporalProducto\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e481987e0d4d578eccdd8a426aae495d1409f107"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TemporalProducto_Index), @"mvc.1.0.view", @"/Views/TemporalProducto/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e481987e0d4d578eccdd8a426aae495d1409f107", @"/Views/TemporalProducto/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"876c075e2401f3383e257d2f056d1af02a2b0124", @"/Views/_ViewImports.cshtml")]
    public class Views_TemporalProducto_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Sistema_Factura.Models.TempProducto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("btnNitCliente"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "TemporalProducto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GuardarFactura", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn bg-success "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BuscarProducto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn bg-danger "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AnularFactura", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\Sistema_Factura\Sistema_Factura\Views\TemporalProducto\Index.cshtml"
  
    ViewData["Title"] = "Index";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link rel=""stylesheet"" type=""text/css"" href=""//maxcdn.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap.min.css"">
<script type=""text/javascript"" src=""//maxcdn.bootstrapcdn.com/bootstrap/3.2.0/js/bootstrap.min.js""></script>
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>

<h1 class=""text-center"">Factura</h1>

<div class=""row"">
    <div class=""container"">
        <div class=""col-md-4"">
            <div class=""alert alert-success"" role=""alert"">
                
                <p>NOMBRE CLIENTE: <a href=""#"" id=""nombreCliente"" class=""alert-link""> Nombre del Cliente</a>.</p>
                <p>NIT CLIENTE: <a href=""#"" id=""nitCliente"" class=""alert-link""> Nit del Cliente</a>.</p>
                
            </div>
            
        </div>
        
    </div>
</div>

<div class=""row"">
    <div class=""col-md-12"">
        <div class=""col-md-3"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e481987e0d4d578eccdd8a426aae495d1409f1077439", async() => {
                WriteLiteral("Guardar Factura");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-3\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e481987e0d4d578eccdd8a426aae495d1409f1079241", async() => {
                WriteLiteral("Agregar más producto");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-3\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e481987e0d4d578eccdd8a426aae495d1409f10710559", async() => {
                WriteLiteral("Anular Factura");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<br />\r\n<br />\r\n");
            WriteLiteral(@"<table class=""table table-bordered"">
    <thead class=""thead-dark"">
        <tr>
            <th>CODIGO</th>
            <th>NOMBRE</th>
            <th>CANTIDAD</th>
            <th>PRECIO UNITARIO</th>
            <th>SUBTORAL</th>
            
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 57 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\Sistema_Factura\Sistema_Factura\Views\TemporalProducto\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 61 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\Sistema_Factura\Sistema_Factura\Views\TemporalProducto\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Producto.CodigoProducto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 64 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\Sistema_Factura\Sistema_Factura\Views\TemporalProducto\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Producto.NombreProducto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 67 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\Sistema_Factura\Sistema_Factura\Views\TemporalProducto\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Cantidad_temp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 70 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\Sistema_Factura\Sistema_Factura\Views\TemporalProducto\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PrecioVenta_temp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 73 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\Sistema_Factura\Sistema_Factura\Views\TemporalProducto\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.SubTotal_temp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 76 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\Sistema_Factura\Sistema_Factura\Views\TemporalProducto\Index.cshtml"
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
<div>
");
#nullable restore
#line 89 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\Sistema_Factura\Sistema_Factura\Views\TemporalProducto\Index.cshtml"
     if (TempData["messageNoFactura"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-warning alert-dismissible fase show\" role=\"alert\">\r\n            ");
#nullable restore
#line 92 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\Sistema_Factura\Sistema_Factura\Views\TemporalProducto\Index.cshtml"
       Write(TempData["messageNoFactura"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n                <span aria-hidden=\"true\">&times;</span>\r\n            </button>\r\n        </div>\r\n");
#nullable restore
#line 97 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\Sistema_Factura\Sistema_Factura\Views\TemporalProducto\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
            WriteLiteral("<script>\r\n    $(function () {\r\n\r\n        var url = \"");
#nullable restore
#line 104 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\Sistema_Factura\Sistema_Factura\Views\TemporalProducto\Index.cshtml"
              Write(Url.Action("BuscarTempProducto", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""";

            //jQuery
            $.post(url).done(function (data) {
                //Se ejecuta si la operacion fue un éxito
                $(""#total"").html(data);
                //$(""#txtPrecio"").html(data);
            }).fail(manejarErrorAjax).always(function () {
                //Esta funcion siempre se ejecuta
            });
    });
    function manejarErrorAjax(err) {
        console.log(err.responseText);
    }
</script>

");
            WriteLiteral("<script>\r\n    $(function () {\r\n\r\n    var url = \"");
#nullable restore
#line 124 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\Sistema_Factura\Sistema_Factura\Views\TemporalProducto\Index.cshtml"
          Write(Url.Action("MostrarNombreCliente", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""";

    //jQuery
    $.post(url).done(function (data) {
        //Se ejecuta si la operacion fue un éxito
        $(""#nombreCliente"").html(data);
        //$(""#txtPrecio"").html(data);
    }).fail(manejarErrorAjax).always(function () {
        //Esta funcion siempre se ejecuta
    });

        function manejarErrorAjax(err) {
    console.log(err.responseText);
        }
    });
</script>

");
            WriteLiteral("<script>\r\n    $(function () {\r\n\r\n    var url = \"");
#nullable restore
#line 145 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\Sistema_Factura\Sistema_Factura\Views\TemporalProducto\Index.cshtml"
          Write(Url.Action("MostrarNit", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""";

    //jQuery
    $.post(url).done(function (data) {
        //Se ejecuta si la operacion fue un éxito
        $(""#nitCliente"").html(data);
        //$(""#txtPrecio"").html(data);
    }).fail(manejarErrorAjax).always(function () {
        //Esta funcion siempre se ejecuta
    });

        function manejarErrorAjax(err) {
    console.log(err.responseText);
        }
    });
</script>");
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
