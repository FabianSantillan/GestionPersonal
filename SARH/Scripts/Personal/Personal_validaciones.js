$(document).ready(function () {
    //$.ajax({
    //    url:"/Personal/ListadoPersonal",
    //    type: "GET",
    //    data: {},
    //    contentType: "application/json",
    //    onSuccess: crearListado,
    //    onError: undefined,
    //    showLoading: false,
    //    hideLoading: false,
    //    EnableRepit: true,
    //    ErrorCounter: 0,
    //    EnableErrorPage: true
    //});

    //$('#grid').DataTable();
    $.get("/Personal/ListadoPersonal", function (data) {
        crearListado(data);
    });

    tableSeguimiento = $('#tableAllPerson').DataTable({
        "responsive": false,
        "searching": true,
        "info": false,
        "paging": true,
        "pageLength": 10,
        "ordering": true,
        "columnDefs": [
            {
                "targets": [0],
                "visible": true,
                "searchable": true
            }
        ],
        "order": [
            [0, "asc"]
        ],
    });
});

function crearListado(data) {
    console.log(data);
    var dataSource = [];   
    for (var i = 0; i < data.length; i++) {
        //dataSource.push(new Array(data[i].nombreCompleto, DateTimeToYYYYMMDD(data[i].fechaNacimiento), data[i].RFC, data[i].Homoclave, data[i].CURP, data[i].Sexo, DateTimeToYYYYMMDD(data[i].fechaIngresoInstitucion)));         
        dataSource.push(new Array(data[i].NombreCompleto, DateTimeToYYYYMMDD(data[i].FechaNacimiento), data[i].RFC, data[i].Homoclave, data[i].CURP, data[i].Sexo, DateTimeToYYYYMMDD(data[i].FechaIngresoInstitucion)));         
        //dataSource.push(new Array(data[i].nombreCompleto, data[i].fechaNacimiento, data[i].RFC, data[i].Homoclave, data[i].CURP, data[i].Sexo, data[i].fechaIngresoInstitucion));         
    }
    //var contenido = "";
    //contenido += "<table id='tablaPersonal' class='table'>";
    //contenido += "<thead>";
    //contenido += "<tr>";
    //contenido += "<td>nombreCompleto</td>";
    //contenido += "<td>fechaNacimiento</td>";
    //contenido += "<td>RFC</td>";
    //contenido += "<td>Homoclave</td>";
    //contenido += "<td>CURP</td>";
    //contenido += "<td>Sexo</td>";
    //contenido += "<td>fechaIngresoInstitucion</td>";
    //contenido += "</tr>";
    //contenido += "</thead>";
    //contenido += "<tbody>"
    //for (var i = 0; i < data.length; i++) {
    //    contenido += "<tr>";
    //    contenido += "<td>" + data[i].nombreCompleto + "</td>"
    //    contenido += "<td>" + data[i].fechaNacimiento + "</td>"
    //    contenido += "<td>" + data[i].RFC + "</td>"
    //    contenido += "<td>" + data[i].Homoclave + "</td>"
    //    contenido += "<td>" + data[i].CURP + "</td>"
    //    contenido += "<td>" + data[i].Sexo + "</td>"
    //    contenido += "<td>" + data[i].fechaIngresoInstitucion + "</td>"
    //    contenido += "</tr>";
    //}
    //contenido += "</tbody>";
    //contenido += "</table>";

    tableSeguimiento.clear();
    tableSeguimiento.rows.add(dataSource);
    tableSeguimiento.draw();



    //document.getElementById("tabla").innerHTML = contenido;   
    //$("#tablaPersonal").DataTable();



}

function DateTimeToYYYYMMDD(date) {   
    return date.substring(8, 10) + "/" + date.substring(5, 7) + "/" + date.substring(0, 4);
}