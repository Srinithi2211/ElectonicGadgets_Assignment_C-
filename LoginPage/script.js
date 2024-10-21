document.getElementById('loginForm').addEventListener('submit', function(event) {
    event.preventDefault();
    
    const username = document.getElementById('username').value;
    const password = document.getElementById('password').value;
    const errorMessage = document.getElementById('error-message');

    // Simple validation
    if (username === '' || password === '') {
        errorMessage.textContent = 'Both fields are required!';
        return;
    }

    // Sample validation logic (replace with actual authentication logic)
    if (username === 'admin' && password === 'password123') {
        errorMessage.textContent = '';
        alert('Login Successful!');
    } else {
        errorMessage.textContent = 'Invalid Username or Password!';
    }
});
