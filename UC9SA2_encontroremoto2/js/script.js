$(document).ready(function() {

    let slideAtual = 1;
    let listaSlides = ["banner-c", "banner-ti", "banner-d"]

    setInterval(mudarSlide, 1000)

    function mudarSlide() {
        console.log("Slide atual:", slideAtual);
       
        // Remove o slide anterior
        if (slideAtual > 0) {
            $("#carrosel").removeClass(listaSlides[slideAtual -1])
        } else if (slideAtual == 0) {
            $("#carrosel").removeClass(listaSlides[ (listaSlides.lenght) -1])
        }
    
        // Adiciona o slide atual
        $("#carrosel").addClass(listaSlides[slideAtual]);
    
        // Indica o slide atual
        slideAtual++

        if(slideAtual > (listaSlides.length) -1) {
            slideAtual = 0;
        }

}
})

function cadastroEnviado() {
    alert("Formulário enviado com sucesso")
}

function cadastrarNewsletter() {

    let email = document.getElementById("email-newsletter").value;

    alert("e-mail cadastrado com sucesso")

    console.log(email)
}