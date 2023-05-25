const carousel = document.querySelector('.carousel');
const inner = document.querySelector('.carousel-inner');
const prevBtn = document.querySelector('.prev');
const nextBtn = document.querySelector('.next');

let currentIndex = 0;
let itemWidth = carousel.offsetWidth;


prevBtn.addEventListener('click', () => {
  currentIndex--;
  if (currentIndex < 0) {
    currentIndex = inner.children.length - 1;
  }
  move();
});


nextBtn.addEventListener('click', () => {
  currentIndex++;
  if (currentIndex >= inner.children.length) {
    currentIndex = 0;
  }
  move();
});


function move() {
  const x = -currentIndex * itemWidth;
  inner.style.transform = `translateX(${x}px)`;
}


window.addEventListener('resize', () => {
  itemWidth = carousel.offsetWidth;
  move();
});
