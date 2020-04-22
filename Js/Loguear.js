function LoguearUsuario() {
    var user = document.getElementById("username").value;
    var password = document.getElementById("password").value;

    llamarVistaParcial(user, password);
}

function validarURL(url, user, password) {
    userAgregado = url.replace(/[0]/gi, user);
    urlcompleta = userAgregado.replace(/[1]/gi, password);

    return urlcompleta;
}

function llamarVistaParcial(user, password) {
    var urlCompleta = validarURL('http://localhost:52477/OperacionUsuarios/LoguearUsuario?username=0&password=1', user, password); 
    
    var request = $.ajax({
        url: urlCompleta, 
        type: 'GET', 
        dataType: 'json'
    })

    request.done(function (response) {
        if (response) {
            window.location.href = '/Home/Menu';
        } else {
            document.getElementById("ErrorLogueo").innerHTML = "Los datos ingresados son invalidos";
        }
    })  
    request.fail(function (jqXHR, textStatus) {
        alert("Hubo un error: " + textStatus);
    })
}










