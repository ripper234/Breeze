$(document).ready(function() {
    $.ajaxSetup({
        // Disable caching of AJAX responses */
        cache: false
    });

    startChatClient();
});

function startChatClient() {
    window.setInterval(function() {
        var players = $.get("/Chat/GetPlayersInLobby", function(data) {
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

    }, 1000);
}