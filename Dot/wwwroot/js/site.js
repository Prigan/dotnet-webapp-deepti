﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(function () {
    $('[data-toggle="tooltip"]').tooltip()

    $(".card").mouseenter(function () {
        $(this).find(".stats").find(".del").toggleClass("hidden");
        $(this).toggleClass("highlight");
    }).mouseleave(function () {
        $(this).find(".stats").find(".del").toggleClass("hidden");
        $(this
        ).toggleClass("highlight");
    });

    KeepBootstrapTooltipOpen();
});

function KeepBootstrapTooltipOpen() {
    //indicates whether the mouse is over the tooltip
    var hover = false;
    var a = 0;

    var $TT = $('.followersLi');
    $TT.tooltip({
        selector: "a[rel=tooltip]",
        placement: "right"
    })

    $('body').on('mouseenter', '.tooltip,a[rel=tooltip]', function () {
        hover = true;
    });

    $('a').on('mouseenter', function () {
        hover = false;
        $('.tooltip').hide();
    })

    //if it is true hover prevents the tooltip close
    $TT.on('hide.bs.tooltip', function () {
        return !hover;
    })
}

function PostAddUserForm(formId) {
    var userForm = $("#" + formId);

    $.ajax({
        method: "POST",
        url: "/Home/AddUser/",
        data: userForm.serialize(),
        dataType: "text",
        success: function (msg) {
            userForm.find(".btn").addClass("active").addClass("bg-success").val(msg); // provide feeback to the user
        },
        error: function (err) {
            console.log("err", err); // keep the user informed about the error
        }
    });
}