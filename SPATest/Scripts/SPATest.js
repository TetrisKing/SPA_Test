$(document).ready(function () {
    $("[data-psda-action]").on("click", function (e) {
        e.preventDefault();
        $("#EventCommand").val($(this).attr("data-psda-action"));
        $("form").submit();
    });
})