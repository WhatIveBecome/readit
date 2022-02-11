const form = document.forms[0];
form.addEventListener("submit", async event => {
    event.preventDefault();
    const formData = new FormData(form);
    const response = await fetch("/api/forum", {
        method: "POST",
        body: formData,
    });
    alert(`Received response: ${response.status} ${response.statusText}`);
});