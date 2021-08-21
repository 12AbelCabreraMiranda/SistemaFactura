//FUNCION QUE INICIALIZA LOS DATOS EN LA TABLA
$(document).ready(function () {
    loadData();
});

//FUNCION LISTA DE DATOS EN TABLA
function loadData() {
    $.ajax({
        url: "/Cliente/GetClientes",
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            var html = '';
            $.each(result, function (key, item) {
                html += '<tr>';
                html += '<td>' + item.clienteId + '</td>';
                html += '<td>' + item.nombreCliente + '</td>';
                html += '<td>' + item.nit + '</td>';                
                html += '<td><a style="color:white" type="button" class="btn btn-info" onclick="return getbyID(' + item.clienteId + ')"><i class="bi bi-pencil-square"></i>&nbsp;Editar</a>  <a style="color:white" type="button" class="btn btn-danger" onclick="Delele(' + item.clienteId + ')"><i class="bi bi-trash"></i>&nbsp;Eliminar</a></td>';
                html += '</tr>';
            });
            $('.TBodyCliente').html(html);
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}
//FUNCION CREAR CLIENTE

