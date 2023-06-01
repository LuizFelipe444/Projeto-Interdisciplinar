
var itensSelecionados = document.querySelectorAll(".menu-item  a");

itensSelecionados.forEach(function (item) {
    item.addEventListener("click", function (event) {
    itensSelecionados.forEach(function(itemSelecionado) {
        itemSelecionado.style.borderBottom = "none";
        itemSelecionado.style.color = "white";
    });
        item.style.color = "yellow";
    item.style.paddingBottom = "35px";
    item.style.borderBottom = "2px solid yellow"; 
  });
});
