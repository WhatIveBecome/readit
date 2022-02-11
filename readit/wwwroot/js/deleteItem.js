'use strict';

const btnDelete = document.querySelectorAll('.del');
const confirmWindow = document.querySelector('.confirm');
const overlay = document.querySelector('.overlay');
const btnNo = document.getElementById('no');

const showConfirm = function () {
    confirmWindow.classList.remove('hidden');
    overlay.classList.remove('hidden');
};

for (let i = 0; i < btnDelete.length; i++) {
    btnDelete[i].addEventListener('click', showConfirm);
}

const closeConfirm = function () {
    confirmWindow.classList.add('hidden');
    overlay.classList.add('hidden');
};

btnNo.addEventListener('click', closeConfirm);
