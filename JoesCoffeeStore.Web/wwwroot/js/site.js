// Write your JavaScript code.

// .ready()
// api.jquery.com/ready/
$(document).ready(function () {
    var b = $("#addToCartButton");
    b.on("click", function () {
        window.alert("Your coffee was added to your cart.");
    });
});
