$(document).ready(function() {
    $.ajaxSetup({
        // Disable caching of AJAX responses */
        cache: false
    });

    startChatClient();
});

function startChatClient() {
    window.setInterval(function() {
        try {
            updatePlayersInLoby();
            updateChatMessages();
        }
        catch (e) {
            alert("Error updating chat: " + e);
        }

    }, 1000);

    $("#chatline").keyup(function(event) {
        var ENTER_KEYCODE = 13;
        if (event.keyCode == ENTER_KEYCODE) {
            var text = $(this).val();
            $(this).val("");
            var playerId = getPlayerId();
            $.post("/Chat/SendMessage", { playerId: playerId, text: text }, function(data) {
                updateChatMessages();
            });
            var messages = { SenderId: 0, SenderName: getPlayerName(), Text: text };
            updateChatMessagesWith(messages);
        }
    });
}

function updatePlayersInLoby() {
    $.get("/Chat/GetPlayersInLobby", function(data) {
        try {
            var draftsTable = $('<table id="playerslist"></table>');

            $.each(data, function() {
                draftsTable.append("<tr>");
                //draftsTable.append("<td>" + this["OwnerName"] + "</td>");
                draftsTable.append("<td>" + "OwnerName" + "</td>");
                draftsTable.append("</tr>");
            });

            $('#draftsList').replaceWith(playersTable);
        }
        catch (e) {
            alert("Error: " + e);
        }
    });
}

lastChatRow = 0;

function updateChatMessages() {
    var playerId = getPlayerId();
    $.get("/Chat/GetMessagesDelta", { playerId: playerId, lastChatRow: lastChatRow }, function(data) {
        try {
            if (lastChatRow != data["OldRowIndex"]) {
                // this response is stale
                return;
            }

            lastChatRow = data["NewRowIndex"];
            updateChatMessagesWith(data["Messages"]);
        }
        catch (e) {
            alert("Error: " + e);
        }
    });
}

function updateChatMessagesWith(messages) {
    var chatMain = $('#chatmain');
    var newChatMainText = chatMain.html() + messagesToText(messages);
    chatMain.html(newChatMainText);
}

function messagesToText(messages) {
    var text = "";
    $(messages).each(function() {
        if (this["SenderId"] == getPlayerId())
            return;
            
        text += "&lt;" + this["SenderName"] + "&gt; ";
        text += this["Text"];
        text += "<br/>";
    });
    return text;
}
