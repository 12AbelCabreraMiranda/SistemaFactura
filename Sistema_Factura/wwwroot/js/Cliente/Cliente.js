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

//GUARDAR LOS DATOS EN EL MODELO
function Add() {
    var res = validate();
    if (res == false) {
        return false;
    }
    $.ajax({
        url: '/Cliente/CrearClientes',
        data: {
            //UsuarioId: $('#txtClienteId').val(),
            NombreCliente: $('#txtNombreCliente').val(),
            Nit: $('#txtNit').val()
        },
        type: 'POST',
        success: function (result) {
            loadData();
            if (result == true) {
                $('#myModal').modal('hide');
                msjExito();                
            } else {
                //$('#myModal').modal('hide');
                $("#MsjError").html("<div class='alert alert-danger' role='alert'>El NIT ya existe...!</div >");
            }
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}
//MUESTRA DATOS SELECCIONADO PARA ACTUALIZAR
function getbyID(Id) {
    $('#txtNombreCliente').css('border-color', 'lightgrey');
    $('#txtNit').css('border-color', 'lightgrey');    

    $.ajax({
        url: "/Cliente/GetCliente/" + Id,
        type: "GET",
        success: function (result) {
            $('#txtClienteId').val(result.clienteId);
            $('#txtNombreCliente').val(result.nombreCliente);
            $('#txtNit').val(result.nit);
            $('#myModal').modal('show');
            $('#btnUpdate').show();
            $('#btnAdd').hide();
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
    return false;
}

//ACTUALIZA DATOS
function Update() {
    var res = validate();
    if (res == false) {
        return false;
    }
    $.ajax({
        url: "/Cliente/ActualizarCliente",
        data: {
            ClienteId: $('#txtClienteId').val(),
            NombreCliente: $('#txtNombreCliente').val(),
            Nit: $('#txtNit').val()            
        },
        type: "POST",
        success: function (result) {
            loadData();
            if (result == true) {
                $('#myModal').modal('hide');
                $('#txtClienteId').val("");
                $('#txtNombreCliente').val("");
                $('#txtNit').val("");

                actualizadoExito();
            } else {
                //$('#myModal').modal('hide');
                $("#MsjError").html("<div class='alert alert-danger' role='alert'>El Cliente ya existe...!</div >");
            }
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}  

//ELIMINA UN REGISTRO
function Delele(ID) {           
    Confirmacion(ID,undefined, function () {
        $.ajax({
            url: "/Cliente/BorrarCliente/" + ID,
            type: "POST",
            contentType: "application/json;charset=UTF-8",
            dataType: "json",
            success: function (result) {                
                loadData();
            },
            error: function (errormessage) {
                alert(errormessage.responseText);
            }
        });
    })   
}

//LIMPIA LOS CAMPOS DE TEXTOS
function clearTextBox() {
    $('#txtClienteId').val("");
    $('#txtNombreCliente').val("");
    $('#txtNit').val("");
    $('#btnUpdate').hide();
    $('#btnAdd').show();
    $('#txtNombreCliente').css('border-color', 'lightgrey');
    $('#txtNit').css('border-color', 'lightgrey');    
}

//VALIDACIÓN DE CAMPOS DE TEXTOS
function validate() {
    var isValid = true;
    if ($('#txtNombreCliente').val().trim() == "") {
        $('#txtNombreCliente').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#txtNombreCliente').css('border-color', 'lightgrey');
    }
    if ($('#txtNit').val().trim() == "") {
        $('#txtNit').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#txtNit').css('border-color', 'lightgrey');
    }
    return isValid;
}

function msjExito() {    
    toastr.options = {
        "timeOut": 5000,
        "closeButton": true,
        "progressBar": true
    };
    toastr.success("Registro guardado con éxito!", "SUCCESSFUL");    
}
function actualizadoExito() {
    toastr.options = {
        "timeOut": 5000,
        "closeButton": true,
        "progressBar": true
    };
    toastr.success("Registro Actualizado con éxito!", "SUCCESSFUL");
}
//ALERTAS
function Error( titulo="Error",texto="Ocurrió un error") {
    Swal.fire({
        icon: 'error',
        title: titulo,
        text: texto,        
    })
}
//CONFIRMACIÓN PARA ELIMINAR EL REGISTRO SELECCIONADO
function Confirmacion(Id,texto = "¿Está seguro de eliminar este registro?", callback) {    
    $.ajax({
        url: "/Cliente/GetCliente/" + Id,
        type: "GET",
        success: function (result) {
            var datoSelected = result.nombreCliente;            
            //ALERT                      
            Swal.fire({
                title: 'Eliminar Registro',                
                html: texto + "<br/> "+ '<b>' +datoSelected + '</b>',
                icon: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#d33',
                cancelButtonColor: '#3085d6',
                confirmButtonText: 'Si, Eliminarlo.!',
                cancelButtonText: "Cancelar",
            }).then((result) => {
                if (result.isConfirmed) {
                    callback()
                    Swal.fire({
                        position: 'top-end',
                        icon: 'success',
                        title: 'Registro eliminado con éxito!',
                        showConfirmButton: false,
                        timer: 2000
                    })
                }
            })
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}