document.getElementById('loginForm').addEventListener('submit', function (event) {
    const email = document.getElementById('email').value;
    const password = document.getElementById('password').value;

    if (!email || !password) {
        alert('Por favor, complete todos los campos.');
        event.preventDefault();
    }

    // Validación de correo electrónico básica
    const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    if (!emailRegex.test(email)) {
        alert('Por favor, ingrese un correo válido.');
        event.preventDefault();
    }
});
