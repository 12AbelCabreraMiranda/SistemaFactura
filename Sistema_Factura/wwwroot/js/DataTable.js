$(function () {
    alert("hello");
    //var url = "@Url.Action("MostrarFactura", "TemporalProducto")";
    var url = "/TemporalProducto/MostrarFactura";

    $.get(url).done(function (data) {
        $("#dataTable").append(data);
    }).fail(manejarErrorAjax);
});