$(document).ready(function () {
    GetProducts();
});

$('#btnSearch').click(function () {
    GetProducts($('#inputSearch').val().trim());
});


$('#inputSearch').keypress(function (event) {
    if (event.keyCode == '13') GetProducts($('#inputSearch').val().trim());
});

function GetProducts(searchString) {
    //Clear product list
    $('li.item:not(.headers').remove();
    //
    $.ajax({
        url: "https://localhost:44319/api/Product",
        contentType: "application/json",
        data: { searchString },
        dataType: 'json',
        beforeSend: function () {
            $.blockUI({ message: "<h1>Please wait...</h1>" });
        }
    })
        .done(function (result) {
            let products = '';
            $.each(result, function (index, item) {
                products += `<li class="item"><span>${item.name}</span><span>${item.description}</span><span>${item.family}</span><span>${item.price} €</span></li>`;
            });
            $('.headers').after(products);

        })
        .always(function () {
            $.unblockUI();
        })
}

$('#form_create_product').submit(function (e) {
    e.preventDefault();
    $.ajax({
        type: "POST",
        url: "https://localhost:44319/api/Product",
        contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
        data: $(this).serialize(),
        dataType: "json",
        beforeSend: function () {
            $.blockUI({ message: "<h1>Please wait...</h1>" });
        }
    })
        .done(function (result) {
            $('#form_create_product').before(`<div class="alert alert-success" role="alert">
                The product has been added successfully. Please click <a href="/" class="alert-link">here</a> if you are not redirected in a few seconds.</div>`);
            setTimeout(function () { window.location = "/"; }, 3000);
        })
        .fail(function (error) {
            $('#form_create_product').before(`<div class="alert alert-danger alert-dismissible fade show" role="alert">
                ${error.responseText}<button type="button" class="close" data-dismiss="alert" aria-label="Close"><span aria-hidden="true">&times;</span></button></div>`);
        })
        .always(function () {
            $.unblockUI();
        })
})