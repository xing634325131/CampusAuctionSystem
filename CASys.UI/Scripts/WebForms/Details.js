$(function () {
    $(".div_price").attr("readonly", true);
    var oldprice = $("#oldprice").html().substring(1, $("#oldprice").html().length);
    var range = $("#price_range").html().substring(1, $("#price_range").html().length);
    var nowprice = $("#nowprice").html().substring(1, $("#nowprice").html().length);
    var wantprice = Number(nowprice) + Number(range);
    $(".div_price").val("￥" + wantprice);
    $(".div_right_btn_add").click(function () {
        var price = $(".div_price").val().substring(1, $(".div_price").val().length);
        var pricenow = Number(price) + Number(range);
        $(".div_price").val("￥" + pricenow);
    })
    $(".div_right_btn_sub").click(function () {
        var price = $(".div_price").val().substring(1, $(".div_price").val().length);
        if (Number(price) > wantprice) {
            var pricenow = Number(price) - Number(range);
            $(".div_price").val("￥" + pricenow);
        }
    });
});