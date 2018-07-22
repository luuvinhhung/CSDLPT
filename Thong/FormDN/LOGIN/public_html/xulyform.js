var CORRECT_USER1 = 'PhanthongIT';
var CORRECT_USER2 = 'VanKhoaIT';
var CORRECT_PASS = '123';
var inputUsername =  document.getElementById('username')
var inputPassword = document.getElementById('password');
var formLogin = document.getElementById('form-login');
if(formLogin.attachEvent){
    formLogin.attachEvent('submit',onFormSubmit);
    
}else{
    formLogin.addEventListener('submit',onFormSubmit);
}

function onFormSubmit(e){
    var username = inputUsername.value;
    var password = inputPassword.value;
    if(username == CORRECT_USER1 ||  username == CORRECT_USER2 && password == CORRECT_PASS){
        alert('Đăng nhập tài khoản thành công!');
    }else{
        alert('Đăng nhập thất bại! Kiểm tra tài khoản');
    }
}