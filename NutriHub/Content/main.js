// $(document).ready(function()
// {
//   $('#example').DataTable();
// });
//
// $(document).ready(function()
// {
//   $('#example2').DataTable();
// });

$(document).ready(function()
{
  $('#example').DataTable(
  {
  "language": {
              "lengthMenu": "Mostrar _MENU_ registros",
              "zeroRecords": "No se encontraron resultados",
              "info": "Mostrando registros del _START_al_END_ de un total de _TOTAL_ registros",
              "infoEmpty": "Mostrando registros del 0 al 0 de un total de _MAX_ registros)",
              "sSearch": "Buscar",
              "oPaginate":
              {
                "sFirst":"Primero",
                "sLast":"Último",
                "sNext": "Siguiente",
                "sPrevious": "Anterior"

              },
              "sProcessing:":"Procesando...",
            }
  });
});
