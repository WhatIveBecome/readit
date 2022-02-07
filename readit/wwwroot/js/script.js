var url = window.location.pathname;
var id = url.substring(url.lastIndexOf('/') + 1);
console.log(id);

document.querySelector('.inputId').value = id;