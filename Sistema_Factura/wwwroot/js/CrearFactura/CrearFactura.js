//Para su funcionamiento, agregar la librería(link) Ajax
$("#txtNitCliente").keypress(function (e) {
    if (e.which == 13) {
        e.preventDefault();
        
    }
});

function TextCF() {
    $("#txtNitCliente").val('CF');
    NotificacionNit();
}
function TextCiudad() {
    $("#txtDireccionCliente").val('Ciudad');
}


function NotificacionNit() {    
    // Override global options
    toastr.error('El NIT ingresado no está registrado en nuestro sistema!');
    toastr.options.extendedTimeOut = 3000; // How long the toast will display after a user hovers over it
    toastr.options.timeOut = 10000; // How long the toast will display without user interaction

    toastr.options.progressBar = true;
   

}