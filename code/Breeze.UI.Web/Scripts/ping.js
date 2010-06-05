try {
    $(document).ready(function() {
        $.ajaxSetup({
            // Disable caching of AJAX responses */
            cache: false
        });

        try {
            startPinger();
        }
        catch (e) {
            alert("FooError: " + e);
        }
    });
}
catch (e) {
    alert("Init error: " + e);
}

function startPinger() {
    var playerId = getPlayerId();
    if (playerId == null)
        return;
    
    window.setInterval(function() {
        try {
            $.post("/Chat/Ping", { playerId: playerId });
        }
        catch (e) {
            alert("Error in pinger timer: " + e);
        }
    }, 3000);
}

function getPlayerId() {
    return parseInt($('fieldset input#playerid')[0]["value"], 10);
}