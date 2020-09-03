$(document).ready(function () {
    $.ajax({
        type: "GET",
        url: "/Plazas/GetData",
        data: "{}",
        success: function (data) {
            var s = '<option Value="-1"> Selecciona una opción</option>';
            for (var i = 0; i < data.length; i++) {
                s += '<option value ="' + data[i].NivelPlaza + '" >' + data[i].descripcion + '</option>';
            }
            $("#dropdownlistCodigoPlaza").html(s);
        }
    });
});

function getValue() {
    var myVal = $("#dropdownlistCodigoPlaza").val();
    $("#show").val(myVal);
}