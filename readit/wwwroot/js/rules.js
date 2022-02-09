'use strict';

const rules = document.getElementById('rules');
const reply = document.getElementById('reply');
const rulesOk = document.getElementById('rulesOk');
let clicked = false;

const showingRules = function () {
    if (clicked === false) {
        rules.style.display = "block";
        clicked = true;
    }
}
const closingRules = function () {
    rules.style.display = "none";
}

reply.addEventListener('click', showingRules);
rulesOk.addEventListener('click', closingRules);