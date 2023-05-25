const campeonatosMenu = document.getElementById("campeonatos-menu");
const campeonatosBtn = document.getElementById("campeonatos-btn");
const TimesBtn = document.getElementById("times-btn");
const timesMenu = document.getElementById("times-menu");
campeonatosBtn.addEventListener("click", function (event) {
    event.preventDefault();
    campeonatosMenu.classList.toggle("show");
    timesMenu.classList.remove("show2")
});

TimesBtn.addEventListener("click", function (event) {
    event.preventDefault();
    timesMenu.classList.toggle("show2")
    campeonatosMenu.classList.remove("show")
});