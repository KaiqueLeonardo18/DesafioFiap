function mostrarErro(message) {
    var lblError = document.getElementById("lblError");
    lblError.style.display = "block";
    lblError.innerText = message;
}