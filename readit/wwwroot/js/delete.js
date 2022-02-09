'use strict';

const btnDel = document.getElementById('del');
const confirmWindow = document.querySelector('.confirm');
const overlay = document.querySelector('.overlay');
const btnNo = document.getElementById('no');

const showConfirm = function () {
    confirmWindow.classList.remove('hidden');
    overlay.classList.remove('hidden');
};

const closeConfirm = function () {
    confirmWindow.classList.add('hidden');
    overlay.classList.add('hidden');
};

btnDel.addEventListener('click', showConfirm);
btnNo.addEventListener('click', closeConfirm);
