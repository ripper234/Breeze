function getPlayerId() {
    return parseInt($('fieldset input#playerid')[0]["value"], 10);
}
function getPlayerName() {
    return $('fieldset input#playername')[0]["value"];
}