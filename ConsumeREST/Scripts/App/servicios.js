$(document).ready(function () {

    let service = 3;

    $("#BtnEmpresa").click(function () {
        $.ajax({
            type: 'GET',
            url: '/Servicios/ConsumirConceptos',
            contentType: 'application/json',
            dataType: 'json',
            data: {
                "service": service
            }
        }).done(function (data) {
            console.log(data);
        }).fail(function () {
            console.log("Consumo Fallido");
        });
    });

});