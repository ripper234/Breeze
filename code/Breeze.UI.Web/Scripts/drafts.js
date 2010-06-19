$(document).ready(function() {
    registerButtons();
    startDraftIndicatorRefresher();
});

function startDraftIndicatorRefresher() {
    window.setInterval(function() {
        try {
            updateOngoingDrafts();
        }
        catch (e) {
            alert("Error updating draft: " + e);
        }

    }, 5000);
}

function updateOngoingDrafts() {
    $.get("/Draft/GetDrafts", function(data) {
        try {
            if ($(data).size() == 0)
                return;

            $(data).each(function(jsonRow) {
                var row = $('<tr class="draftsrow">').appendTo($('#table'));
                row.append($('<td>').append($('<strong>').text(feature.featureDescription)));
                $.each(feature.comparisonValues, function(j, comparisonValue) {
                    row.append($('<td>').text(comparisonValue));
                });
            });
            
            $('#draftlist').text($(data).size() + " drafts");
        }
        catch (e) {
            alert("Error parsing drafts data: " + e);
        }

    });
}

function registerButtons() {
    $('#togglecreate').click(function() {
        if ($(this).text() == "Cancel") {
            hideCreateDraftDialog();
            return;
        }

        $(this).text("Cancel");
        $('#draftoptions').removeClass('hidden');
    });
    $('#createnewdraft').click(function() {
        var ownerId = getPlayerId();
        var options = null; // todo

        $('#createnewdraft').attr("disabled", true);
        try {
            $.post("/Draft/Create", { ownerId: ownerId, options: options }, function(data) {
                $('#createnewdraft').attr("disabled", false);
                hideCreateDraftDialog();
                updateOngoingDrafts();
            });
        }
        catch (e) {
            alert("Error creating draft: " + e);
        }
    });
}

function hideCreateDraftDialog() {
    $('#togglecreate').text("Create New Draft");
    $('#draftoptions').addClass('hidden');            
}