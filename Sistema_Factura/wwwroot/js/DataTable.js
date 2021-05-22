$(function () {
    
    var url = "/TemporalProducto/ProductosAgregados";

    $.get(url).done(function (data) {
        $("#dataTable").append(data);
    }).fail(manejarErrorAjax);

});




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
                                <a onclick=Agregar() class='btn btn-info text-white' style='cursor:pointer'> <i class='bi bi-cart-plus'></i></a>                       
                            </div>`

                }
            },
            

        ],
        "language": {
            "url": "//cdn.datatables.net/plug-ins/1.10.16/i18n/Spanish.json"//LENGUAJE ESPAÑOL DATATABLE
        },
        "width": "100%",
        "bLengthChange": false,//Desabilita combobox cantidad de registro a ver en la tabla
        "ordering": false,// Ordering (Sorting on Each Column)will Be Disabled
        "bAutoWidth": false,//Desactiva el ancho automatico de cada columna
        "lengthMenu": [[5, 10, 25, 50, -1], [5, 10, 25, 50, "All"]],//INICIALIZA 5 REGISTRO
       
    });
});

function Agregar() {
    
    alert($("#txtCantidad").val());
}