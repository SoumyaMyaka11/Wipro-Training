// JavaScript source code
document.getElementById('clickBtn').addEventListener('click', function () {

    document.getElementById('message').textContent = 'You clicked the button';
});

document.getElementById('contactForm').addEventListener('submit', function (e) {
    e.preventDefault();

    document.getElementById('formMessage').textContent = 'Thanks for your message';
    this.reset();
});
