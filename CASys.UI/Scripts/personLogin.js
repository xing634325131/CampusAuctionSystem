window.onload = function () {
    var oDiv1 = document.getElementById('infor');
    var oUl2 = document.getElementById('ul2');
    var oDiv2 = document.getElementById('manage');
    var oUl3 = document.getElementById('ul3');
    var oDiv3 = document.getElementById('myReq');
    var oUl4 = document.getElementById('ul4');
    oDiv1.onclick = function () {
        oUl2.style.display = 'block';
        oDiv2.style.marginTop = oDiv2.offsetTop + 50 + 'px';
        oDiv3.style.marginTop = oDiv3.offsetTop + 50 + 'px';
        oDiv1.onclick = function () {
            return false;
        };
    };
    oDiv2.onclick = function () {
        oUl3.style.display = 'block';
        oDiv3.style.marginTop = oDiv3.offsetTop + 50 + 'px';
        oDiv2.onclick = function () {
            return false;
        };
    };
    oDiv3.onclick = function () {
        oUl4.style.display = 'block';
        oDiv3.onclick = function () {
            return false;
        };
    };
};