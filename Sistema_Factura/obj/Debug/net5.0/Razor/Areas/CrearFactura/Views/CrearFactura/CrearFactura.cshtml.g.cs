#pragma checksum "C:\Users\Abel\Documents\Visual Studio 2019\Projects\SistemaFactura\Sistema_Factura\Areas\CrearFactura\Views\CrearFactura\CrearFactura.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05ec0773ce59cd5a2db9ec6022ed453c9b1fbcad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_CrearFactura_Views_CrearFactura_CrearFactura), @"mvc.1.0.view", @"/Areas/CrearFactura/Views/CrearFactura/CrearFactura.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05ec0773ce59cd5a2db9ec6022ed453c9b1fbcad", @"/Areas/CrearFactura/Views/CrearFactura/CrearFactura.cshtml")]
    public class Areas_CrearFactura_Views_CrearFactura_CrearFactura : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/CrearFactura/CrearFactura.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/DataTable.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Abel\Documents\Visual Studio 2019\Projects\SistemaFactura\Sistema_Factura\Areas\CrearFactura\Views\CrearFactura\CrearFactura.cshtml"
  
    ViewData["Title"] = "CrearFactura";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap-icons@1.5.0/font/bootstrap-icons.css"">
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/toastr.min.css"" />


<style>
    #bordeDatos {
        border-radius: 5px;
        border: 1px solid #757878;
        padding: 20px;
    }
</style>
<h1>Crear Factura Version-2</h1>

<div class=""container"" id=""bordeDatos"">
");
            WriteLiteral("    <div class=\"modal fade bd-example-modal-lg\" id=\"myModal\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"myLargeModalLabel\" aria-hidden=\"true\">\r\n        <div class=\"modal-dialog modal-lg\">\r\n            <div class=\"modal-content\">\r\n");
            WriteLiteral(@"                <div class=""modal-header"">
                    <h4 class=""modal-title"" id=""myModalLabel"">
                        <i class=""bi bi-box-seam""></i>
                        PRODUCTOS
                    </h4>
                    <button type=""button"" class=""close"" data-dismiss=""modal"">??</button>
                </div>
");
            WriteLiteral(@"                <div class=""modal-body"">

                    <div class=""col-md-12"">
                        <table id=""DT_Load"" class=""display"" style=""width:100%"">
                            <thead class=""thead-dark"">
                                <tr>
                                    <th>CODIGO</th>
                                    <th>NOMBRE</th>
                                    <th>PRECIO</th>
                                    <th>CANTIDAD</th>
                                    <th></th>
                                </tr>
                            </thead>
                        </table>                        
                    </div>

                </div>
            </div>
        </div>
    </div>

");
            WriteLiteral(@"    <div class=""row"">
        <div class=""col-md-12"">
            <div id=""DatosCliente"">
                <form>
                    <div class=""form-row"">
                        <div class=""col-md-3 mb-3 form-group "">
                            <label class=""col-form-label"">Nit</label>
                            <div class=""input-group mb-2"">
                                <div class=""input-group-prepend"" style=""cursor:pointer"" onclick=""TextCF()"">
                                    <div class=""input-group-text""><i class=""bi bi-card-checklist""></i></div>
                                </div>
                                <input type=""text"" class=""form-control"" id=""txtNitCliente"" placeholder=""Nit"">
                            </div>
                        </div>
                        <div class=""col-md-4 mb-3"">
                            <label class=""col-form-label"">Nombre del Cliente</label>
                            <input type=""text"" class=""form-control"" readonly id=""txtNombre");
            WriteLiteral(@"Cliente"" placeholder=""Nombre del cliente"">
                        </div>
                        <div class=""col-md-5 mb-3"">
                            <label class=""col-form-label"">Direcci??n del cliente</label>
                            <div class=""input-group mb-2"">
                                <div class=""input-group-prepend"" style=""cursor:pointer"" onclick=""TextCiudad()"">
                                    <div class=""input-group-text""><i class=""bi bi-search""></i></div>
                                </div>
                                <input type=""text"" class=""form-control"" id=""txtDireccionCliente"" placeholder=""Direcci??n del Cliente"">
                            </div>
                        </div>

                        <div class=""col-md-6 mb-3"">
                            <label class=""col-form-label"">Tipo Documento</label>
                            <select class=""form-select form-control"" aria-label=""Default select example"">
                                <option sele");
            WriteLiteral(@"cted>Seleccionar</option>
                                <option value=""1"">Boleta</option>
                                <option value=""2"">Cotizaci??n</option>
                            </select>
                        </div>
                        <div class=""col-md-6 mb-3"">
                            <label class=""col-form-label"">Tipo de Pago</label>
                            <select class=""form-select form-control"" aria-label=""Default select example"">
                                <option selected>Seleccionar</option>
                                <option value=""1"">Efectivo</option>
                                <option value=""2"">Credito</option>
                            </select>
                        </div>
                    </div>
                </form>
            </div>

        </div>
    </div>
    <hr />

");
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-md-6\">\r\n");
            WriteLiteral(@"            <div class=""input-group mb-2"">
                <div class=""input-group-prepend"">
                    <div class=""input-group-text""><i class=""bi bi-search""></i></div>
                </div>
                <input type=""text"" class=""form-control"" id=""inlineFormInputGroup"" placeholder=""Buscar por c??digo de barra"">
            </div>
        </div>
");
            WriteLiteral(@"        <div class=""col-md-6"">
            <div class=""float-right"">
                <button class=""btn btn-outline-info"" data-toggle=""modal"" data-target="".bd-example-modal-lg"">
                    <i class=""bi bi-search""></i>
                    Buscar producto
                </button>
                <button class=""btn btn-outline-dark"">
                    <i class=""bi bi-card-checklist""></i>
                    Crear Nit
                </button>
                <button class=""btn btn-outline-success"">
                    <i class=""bi bi-printer-fill""></i>
                    Cotizaci??n
                </button>
                <button class=""btn btn-outline-success"">
                    <i class=""bi bi-printer""></i>
                    Imprimir
                </button>
            </div>
        </div>
    </div>
</div>
<hr />
");
            WriteLiteral(@"<div class=""container"">
    <div class=""col-md-12"">
        <h3 class=""text-center"">PRODUCTOS AGREGADOS</h3>

    </div>
</div>



<script src=""https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/toastr.min.js""></script>
<script type=???text/javascript??? src=???toastr/toastr.js???></script>

<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
<script src=""https://cdn.datatables.net/1.10.20/js/jquery.dataTables.min.js""></script>



");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05ec0773ce59cd5a2db9ec6022ed453c9b1fbcad10819", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05ec0773ce59cd5a2db9ec6022ed453c9b1fbcad11859", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
