$(function () {

    //$("#btnAgregarProducto").click(function () {
        var url = "/TemporalProducto/ProductosAgregados";

        $.get(url).done(function (data) {
            $("#dataTable").append(data);
        }).fail(manejarErrorAjax);
    //});
});
