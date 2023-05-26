
const transferenciasbtn = document.getElementById('trans-btn')
const transferencias = document.getElementById('transferencias')
transferenciasbtn.addEventListener('click', function(event) {
    transferencias.style.display = 'block'
    noticia.style.display = 'none'
});

const noticiabtn = document.getElementById('noticia-btn');
const noticia = document.getElementById('noticia');
noticiabtn.addEventListener('click', function(event) {
    noticia.style.display = 'block'
    transferencias.style.display = 'none'
    
});

