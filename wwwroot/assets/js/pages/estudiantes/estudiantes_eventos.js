$("#tipo").on('change', function () {
    var url = @url. ACCION("MostrarEventosEspecificos","EstudiantesEventos");
    var tipo_evento = $("#seleccionarCatEvento").val();
    $.get(url, tipo_evento).done(function (vista) {
        $("#contenedorEventos").html(arguments[0]);
    }).fail(manejarErrorAjax)
});

function manejarErrorAjax(err) {
    console.log(err.responseText);
}
        