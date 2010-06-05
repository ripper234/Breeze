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
            updateChatMessage();
        }
        catch (e) {
            alert("Error updating chat: " + e);
        }

    }, 1000);

    $("#chatline").keyup(function(event) {
        if (event.keyCode == 13) {
            var text = $(this).val();
            $(this).val("");
            $.post("/Chat/SendMessage", { playerId: getPlayerId(), text: text });
        }
    });
}

function updatePlayersInLoby() {
    $.get("/Chat/GetPlayersInLobby", function(data) {
        try {
            var playersTable = $('<table id="playerslist"></table>');

            $.each(data["Players"], function() {
                playersTable.append("<tr><td>" + this["Nick"] + "</td></tr>");
            });

            $('#playerslist').replaceWith(playersTable);
        }
        catch (e) {
            alert("Error: " + e);
        }
    });
}

lastChatRow = 0;

function updateChatMessage() {
    var playerId = getPlayerId();
    $.get("/Chat/GetMessagesDelta", { playerId: playerId, lastChatRow: lastChatRow }, function(data) {
        try {
            if (lastChatRow != data["OldRowIndex"]) {
                // this response is stale
                return;
            }
            
            lastChatRow = data["NewRowIndex"];
            var chatMain = $('#chatmain');
            var newChatMainText = chatMain.html() + messagesToText(data["Messages"]);
            chatMain.html(newChatMainText);
        }
        catch (e) {
            alert("Error: " + e);
        }
    });
}

function messagesToText(messages) {
    var text = "";
    $(messages).each(function() {
        text += "&lt;" + this["Sender"] + "&gt; ";
        text += this["Text"];
        text += "<br/>";
    });
    return text;
}
function getPlayerId() {
    return parseInt($('fieldset input#playerid')[0]["value"], 10);
}