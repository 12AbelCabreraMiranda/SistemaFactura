//FUNCION QUE INICIALIZA LOS DATOS EN LA TABLA
var dataTable;//VARIABLE GLOBAL PARA PODER INVOCARLO EN OTROS METODOS Y RECARGAR SUS DATOS
$(document).ready(function () {    
        
        dataTable = $('#TBodyCliente').DataTable({
            "ajax": {
                "url": "/Cliente/GetClientes",
                "type": "GET",
                "datatype": "json"
            },            

            "columns": [
               
                {
                    "data": "clienteId",
                    "width": "10%"
                },
                {
                    "data": "fechaRegistrado",                    
                    "width": "25%"                    
                },
                {
                    "data": "nombreCliente",
                    "width": "25%"
                },
                {
                    "data": "nit",
                    "width": "15%"
                },
                {
                    "data": "clienteId",
                    "width": "25%",
                    "render": function (data) {
                        return "<a onclick='getbyID(" + data + ")' class='btn btn-info text-white'  style='cursor:pointer'> <i class='bi bi-check2-square'></i> Editar </a>" + " "+
                               "<a onclick='Delele(" + data + ")' class='btn btn-danger text-white'  style='cursor:pointer'> <i class='bi bi-trash'></i> Eliminar </a>" 
                    },
               

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
                dataTable.ajax.reload();
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
            //loadData();
            dataTable.ajax.reload();
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
                dataTable.ajax.reload();
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

//CONFIRMACIÓN PARA ELIMINAR EL REGISTRO SELECCIONADO
function Confirmacion(Id,texto = "¿Está seguro de eliminar este registro?", callback) {    
    $.ajax({
        url: "/Cliente/GetCliente/" + Id,
        type: "GET",
        success: function (result) {
            var datoSelected = result.nombreCliente;     
            AlertConfirmarDeleted(texto, datoSelected, callback);           
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}
function AlertConfirmarDeleted(texto,datoSelected,callback){
    Swal.fire({
        title: 'Eliminar Registro',
        html: texto + "<br/> " + '<b>' + datoSelected + '</b>',
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#d33',
        cancelButtonColor: '#3085d6',
        confirmButtonText: 'Si, Eliminarlo.!',
        cancelButtonText: "Cancelar",
    }).then((result) => {
        if (result.isConfirmed) {
            callback()
            MensajeEliminado();//TRAE LA FUNCION DESDE GENERICO
        }
    })
}