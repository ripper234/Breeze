$(document).ready(function() {
    registerButtons();
    startDraftIndicatorRefresher();
});

function startDraftIndicatorRefresher() {
    // todo
}

function registerButtons() {
    $('#togglecreate').click(function() {
        if ($(this).text() == "Cancel") {
            $(this).text("Create New Draft");
            $('#draftoptions').addClass('hidden');
            return;
        }

        $(this).text("Cancel");
        $('#draftoptions').removeClass('hidden');
    });
}