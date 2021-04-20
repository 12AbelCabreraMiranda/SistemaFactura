/*$(function () {

    //$("#btnAgregarProducto").click(function () {
        var url = "/TemporalProducto/ProductosAgregados";

        $.get(url).done(function (data) {
            $("#dataTable").append(data);
        }).fail(manejarErrorAjax);
    //});
});
*/

var dataTable;
$(document).ready(function () {
    //alert("hello");
    dataTable = $('#DT_Load').DataTable({
        "ajax": {
            "url": "/TemporalProducto/DataTable",
            "type": "GET",
            "datatype": "json"
        },
        "columns": [           
            {
                "data": "codigoProducto",
                "width": "10%"
            },
            {
                "data": "nombreProducto",
                "width": "20%"
            },
            {
                "data": "cantidad_temp",
                "width": "10%"
            },
            {
                "data": "precioVenta_temp",
                "width": "10%"
            },
            {
                "data": "subTotal_temp",
                "width": "10%"
            },            
            {
                "data": "tempProductoId",
                "width": "10%",
                "render": function (data) {
                          return `<div class='text-center'>                    
                                    <a onclick=Delete('/Product/DeleteByDataApiJson?TempProductoId='+${data}) class='btn btn-danger text-white' style='cursor:pointer'>Delete</a>                       
                                 </div>`

                }
            }

        ],
        "language": {
            "emptyTable": "Not Found Data"
        },
        "width": "100%"

    });
});