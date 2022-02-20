const save = document.querySelector('.save');

//function checked() {
//    if (!this.form.checkbox.checked) {
//        alert('You must agree to the rules first.');
//        return false;
//    }
//}

save.addEventListener('click', function (event) {
    if (!this.form.checkbox.checked) {
        event.preventDefault();
        alert('You must agree to the rules first.');
        return false;
    }
});