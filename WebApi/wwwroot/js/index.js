console.log("test");

$("#ingresar_palabra").submit(function (e) {

    var url = "http://localhost:49207/api/values"; // the script where you handle the form input.

    $.ajax({
        type: "GET",
        url: url,
        success: function (data) {
            alert(data); // show response from the php script.
        }
    });

    e.preventDefault(); // avoid to execute the actual submit of the form.
});