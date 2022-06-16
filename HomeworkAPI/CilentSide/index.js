GetList = () => {
  $(document).ready(function () {
    ShowAllReservations();

    function ShowAllReservations() {
      $("table tbody").html("");
      $.ajax({
        url: "https://localhost:5001/api/Reservations",
        type: "get",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (result, status, xhr) {
          console.log(xhr);
          $.each(result, function (index, value) {
            $("tbody").append($("<tr>"));
            appendElement = $("tbody tr").last();
            appendElement.append($("<td>").html(value["id"]));
            appendElement.append($("<td>").html(value["name"]));
            appendElement.append($("<td>").html(value["startLocation"]));
            appendElement.append($("<td>").html(value["endLocation"]));
            appendElement.append(
              $("<td>").html(
                '<a href="UpdateReservationPatch.html?id=' +
                  value["id"] +
                  '">Update</a>'
              )
            );
            appendElement.append($("<td>").html('<a href="$">Delete</a>'));
          });
        },
        error: function (xhr, status, error) {
          console.log(xhr);
        },
      });
    }

    $("table").on("click", "img.delete", function () {
      var reservationId = $(this).parent("tr").find("td:nth-child(1)").text();

      $.ajax({
        url: "https://localhost:5001/api/Reservations/" + reservationId,
        type: "delete",
        contentType: "application/json",
        success: function (result, status, xhr) {
          ShowAllReservations();
        },
        error: function (xhr, status, error) {
          console.log(xhr);
        },
      });
    });
  });
};

GetById = () => {
  $(document).ready(function () {
    $("#GetButton").click(function (e) {
      $("table tbody").html("");
      $.ajax({
        url: "https://localhost:5001/api/Reservations/" + $("#Id").val(),
        type: "get",
        contentType: "application/json",
        success: function (result, status, xhr) {
          $("#resultDiv").show();
          if (typeof result !== "undefined") {
            var str = "<tr><td>" + result["id"] + "</td>";
            str += "<td>" + result["name"] + "</td>";
            str += "<td>" + result["startLocation"] + "</td>";
            str += "<td>" + result["endLocation"] + "</td>";
            str +=
              '<td><a href="UpdateReservation.html?id=' +
              result["id"] +
              '">Update</a></td>';
            str += "<td><a>Delete</a></tr>";
            $("table tbody").append(str);
          } else {
            $("table tbody").append("<td colspan='4'>No Reservation</td>");
          }
        },
        error: function (xhr, status, error) {
          console.log(xhr);
        },
      });
    });
  });

  $("table").on("click", "img.delete", function () {
    var reservationId = $(this).parents("tr").find("td:nth-child(1)").text();

    $.ajax({
      url: "https://localhost:5001/api/Reservation?id=" + reservationId,
      type: "delete",
      contentType: "application/json",
      success: function (result, status, xhr) {
        window.location.reload();
      },
      error: function (xhr, status, error) {
        console.log(xhr);
      },
    });
  });
};

AddReservation = () => {};
