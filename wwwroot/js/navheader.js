
const transferenciasbtn = document.getElementById('trans-btn')
const transferencias = document.getElementById('transferencias')
transferenciasbtn.addEventListener('click', function(event) {
    transferencias.style.display = 'block'
    noticia.style.display = 'none'
    jogo.style.display = 'none'
});

const noticiabtn = document.getElementById('noticia-btn');
const noticia = document.getElementById('noticia');
noticiabtn.addEventListener('click', function(event) {
    noticia.style.display = 'block'
    transferencias.style.display = 'none'
    jogo.style.display = 'none'
});

const jogobtn = document.getElementById('jogos-btn')
const jogo = document.getElementById('jogo')
jogobtn.addEventListener('click', function (event) {
    jogo.style.display = 'block'
    noticia.style.display = 'none'
    transferencias.style.display = 'none'
})

