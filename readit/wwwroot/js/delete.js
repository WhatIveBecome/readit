'use strict';

const btnDelete = document.querySelector('aw');
const confirmWindow = document.querySelector('.confirm');
const overlay = document.querySelector('.overlay');
const btnNo = document.getElementById('no');

//var el = document.querySelectorAll(".the_class")
//for (var i = 0, ilen = el.length - 1; i < ilen; i++) {
//    el[i].className = "a_new_class"
//}

const showConfirm = function () {
    console.log('hi');
    confirmWindow.classList.remove('hidden');
    overlay.classList.remove('hidden');
};

const closeConfirm = function () {
    confirmWindow.classList.add('hidden');
    overlay.classList.add('hidden');
};

btnDelete.addEventListener('click', showConfirm);
btnNo.addEventListener('click', closeConfirm);
console.log('hi');