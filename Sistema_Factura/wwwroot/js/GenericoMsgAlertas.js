//SweetAlert REGISTRO NUEVO GUARDADO
function msjExito() {
    toastr.options = {
        "timeOut": 5000,
        "closeButton": true,
        "progressBar": true
    };
    toastr.success("Registro guardado con éxito!", "SUCCESSFUL");
}
//SweetAlert REGISTRO ACTUALIZADO
function actualizadoExito() {
    toastr.options = {
        "timeOut": 5000,
        "closeButton": true,
        "progressBar": true
    };
    toastr.success("Registro Actualizado con éxito!", "SUCCESSFUL");
}
//SweetAlert REGISTRO SELECCIONADO ELIMINADO
function MensajeEliminado() {
    Swal.fire({
        position: 'top-end',
        icon: 'success',
        title: 'Registro eliminado con éxito!',
        showConfirmButton: false,
        timer: 2000
    })
}
//SweetAlert MENSAJE DE ERROR
function Error(titulo = "Error", texto = "Ocurrió un error") {
    Swal.fire({
        icon: 'error',
        title: titulo,
        text: texto,
    })
}