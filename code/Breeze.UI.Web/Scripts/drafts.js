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
    updateOngoingDrafts();
}

function updateOngoingDrafts() {
    $.get("/Draft/GetDrafts", function(data) {
        try {
            if ($(data).size() == 0)
                return;

            var draftsTable = $('<table id="draftstable"></table>');
            var headerRow = '<tr><th>Boosters</th><th>Organizer</th></tr>';
            draftsTable.append(headerRow);
            $.each(data, function() {
                var row = "<tr>";
                row += "<td>" + this["BoosterAcronyms"].join(", ") + "</td>";
                row += "<td>" + this["Owner"] + "</td>";
                row += ("</tr>");
                draftsTable.append($(row));
            });

            $('#draftlist').html("");
            $('#draftlist').append("<h2>Ongoing Drafts</h2>");
            $('#draftlist').append(draftsTable);
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
        var serialized = $('#createdraft').serialize();
        var ownerId = getPlayerId();
        var options =
        {
            Title: $('#DraftOptions.Title').text(),
            PickTime: $('#DraftOptions.PickTime').text(),
            Players: $('#DraftOptions.Players').text(),
            Packs: getPacks()
        };

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

function getPacks() {
    return {
        Pack: $('DraftOptions.Pack1').data(),
        Pack: $('DraftOptions.Pack2').data(),
        Pack: $('DraftOptions.Pack3').data()
    }
}