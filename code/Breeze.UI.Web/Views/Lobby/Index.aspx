<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>
<%@ Import Namespace="Breeze.UI.Web.Utils"%>

<asp:Content ID="Content3" ContentPlaceHolderID="HeadContent" runat="server">
    <script type="text/javascript" src="../../Scripts/common.js"></script>
	<script type="text/javascript" src="../../Scripts/chat.js"></script>
	<script type="text/javascript" src="../../Scripts/drafts.js"></script>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Welcome <%= Session[SessionConsts.Nickname]%>, you are our <%= Session[SessionConsts.PlayerID] %>th player</h2>
    <div id="drafts">
        <div id="draftlist"></div>
        <button id="togglecreate">Create New Draft</button>
        <div id="draftoptions" class="hidden">
            <h2>Title</h2>
            <input id="DraftOptions.Title" value="No meaningful title"/>
            
            <h2>Packs</h2>
            <select id="DraftOptions.Pack1">
                <option value="roe">Rise of the Eldrazi</option>
            </select>
            <select id="DraftOptions.Pack2">
                <option value="roe">Rise of the Eldrazi</option>
            </select>
            <select id="DraftOptions.Pack3">
                <option value="roe">Rise of the Eldrazi</option>
            </select>
            
            <h2>Pick Time</h2>
            <input id="DraftOptions.PickTime" value="60"/>
            
            <h2>Players</h2>
            <input id="DraftOptions.Players" value="8"/>
            
            <button id="createnewdraft">Create!</button>
        </div>
    </div>
    <table id="chattable">
        <tr>
            <td>
                <table>
                <tr><td id="chatmain"></td></tr>
                <tr ><td><input id="chatline" type="text"/></td></tr>
                </table>
            </td>
            <td id="playerslistbox">
                    <p id="playerslistboxtitle"><strong>Players Online</strong></p>
                    <table id="playerslist">
                    <tr><td>Loading players...</td></tr>
                    </table>
            </td>
        </tr>
    </table>
    </div>
</asp:Content>
