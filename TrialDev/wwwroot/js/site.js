﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
showPopup = (url, title) => {
    $.ajax({
        type: 'GET',
        url: url,
        success: function (res) {
            $('#modal-default .modal-body').html(res);
            $('#modal-default .modal-title').html(title);
            $('#modal-default').modal('show');
        }
    })
}