//FUNCION MUESTRA DATOS DE LA TABLA TEMPORAL
$(function () {
    
    var url = "/TemporalProducto/ProductosAgregados";

    $.get(url).done(function (data) {
        $("#dataTable").append(data);
    }).fail(manejarErrorAjax);

});



//FUNCION DATATABLE PRODUCTOS
var dataTable;
$(document).ready(function () {    
    dataTable = $('#DT_Load').DataTable({
        "ajax": {
            "url": "/CrearFactura/DataTable",
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
                "width": "50%"
            },
            {
                "data": "precioProductoCompra",
                "width": "10%"
            },
            {
                //"data": "productoId",
                "width": "5%",
                "render": function (data) {
                    return `<div class='text-center'>
                                <input type='text' class='form-control' value='1' id='txtCantidad' placeholder='Cantidad'>                                    
                            </div>`

                }
            },
            {
                "data": "productoId",
                "width": "10%",
                "render": function (data) {
                    return `<div class='text-center'>                                    
                                <a onclick=Agregar('/Product/DeleteByDataApiJson?TempProductoId='+${data})  class='btn btn-info text-white' id='idProducto' style='cursor:pointer'> <i class='bi bi-check2-square'></i></a>                       
                            </div>`

                }
            },
            

        ],
        "language": {
            "url": "//cdn.datatables.net/plug-ins/1.10.16/i18n/Spanish.json"//LENGUAJE ESPAÑOL DATATABLE
        },
        "width": "100%",
        "bLengthChange": false,//Disable select record quantity to view in table
        "ordering": false,// Ordering (Sorting on Each Column)will Be Disabled
        "bAutoWidth": false,//Disable the automatic width of each column
        "lengthMenu": [[5, 10, 25, 50, -1], [5, 10, 25, 50, "All"]],//Initialize view of 5 records in table
       
    });
});

//FUNCION AGREGAR PRODUCTOS A TABLA TEMPORAL
function Agregar() {
    
    alert($("#txtCantidad").val());
}