//Para su funcionamiento, agregar la librería(link) Ajax
$("#txtNitCliente").keypress(function (e) {
    if (e.which == 13) {
        e.preventDefault();
        alert("presionaste tecla enter, congratulation..  ;) ");
    }
});

function TextCF() {
    $("#txtNitCliente").val('CF');
}
function TextCiudad() {
    $("#txtDireccionCliente").val('Ciudad');
}