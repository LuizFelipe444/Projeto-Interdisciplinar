var schedule = document.getElementById('schedule');
var botao = document.querySelector('td');

botao.addEventListener("click", function (event) {
    event.preventDefault();
    console.log('oi')
    schedule.style.display = 'none';
})