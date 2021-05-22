//TECLA ENTER NIT, ENVIAR FUNCION
$("#txtNitCliente").keypress(function (e) {
    if (e.which == 13) {
        e.preventDefault();
        NitIncorrecto();
    }
});

//SOBRESCRIBE TEXTO: CF
function TextCF() {
    $("#txtNitCliente").val('CF');    
}
//SOBRESCRIBE TEXTO: CIUDAD
function TextCiudad() {
    $("#txtDireccionCliente").val('Ciudad');
}

//NOTIFICACION NIT INCORRECTO
function NitIncorrecto() {       
    toastr.options = {
        "timeOut": 15000,
        "closeButton": true,
        "progressBar": true
    };
    toastr.error("El NIT ingresado es inválido o no está registrado en nuestro sistema!", "NIT NO RECONOCIDO");  
}