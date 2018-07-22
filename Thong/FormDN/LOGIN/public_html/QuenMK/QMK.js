var CORRECT_USER3 = 'PhanthongIT';
var CORRECT_USER4 = 'VanKhoaIT';
var passall = '';
var inputUsername1 = document.getElementById('username');
var inputPassword1 = document.getElementById('password');
var inputAgian = document.getElementById('password1');
var formLogin = document.getElementById('form-login1');
if (formLogin.attachEvent) {
    formLogin.attachEvent('submit', onFormSubmit1);

} else {
    formLogin.addEventListener('submit', onFormSubmit1);
}
function onFormSubmit1(e) {
    var username1 = inputUsername1.value;
    var pass1 = inputPassword1.value;
    var passAgain = inputAgian.value;
    if (username1 == CORRECT_USER3 || username1 == CORRECT_USER4) {
        if (pass1 == passAgain) {
            passall = pass1;
        } else {
            e.alert('Kiểm tra lại  mật khẩu!');
        }
    } else {
        e.alert('Kiểm tra lại tài khoản đăng nhập.!');
    }

}


