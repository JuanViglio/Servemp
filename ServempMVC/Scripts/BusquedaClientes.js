
window.onload = function () {
    limpiarFiltro();
};

function limpiarFiltro()
{
    if ($('input:radio:checked').val() == 'optCodigo') {
        $('#ApellidoyNombre').val("");
        $('#Legajo').val("");
        $('#Financiera').val("");

        $("#Codigo").removeAttr("disabled");
        $("#ApellidoyNombre").attr("disabled", "disabled");
        $("#Legajo").attr("disabled", "disabled");
        $("#Financiera").attr("disabled", "disabled");
    }
    else if ($('input:radio:checked').val() == 'optNombre') {
        $('#Codigo').val("");
        $('#Legajo').val("");
        $('#Financiera').val("");

        $("#ApellidoyNombre").removeAttr("disabled");
        $("#Codigo").attr("disabled", "disabled");
        $("#Legajo").attr("disabled", "disabled");
        $("#Financiera").attr("disabled", "disabled");
    }
    else {
        $('#Codigo').val("");
        $('#ApellidoyNombre').val("");

        $("#Legajo").removeAttr("disabled", "disabled");
        $("#Financiera").removeAttr("disabled", "disabled");
        $("#Codigo").attr("disabled", "disabled");
        $("#ApellidoyNombre").attr("disabled", "disabled");
    }
}
