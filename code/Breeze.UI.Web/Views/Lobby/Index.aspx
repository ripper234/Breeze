<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>
<%@ Import Namespace="Breeze.UI.Web.Utils"%>

<asp:Content ID="Content3" ContentPlaceHolderID="HeadContent" runat="server">
	<script type="text/javascript" src="../../Scripts/chat.js"></script>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Welcome <%= Session[SessionConsts.Nickname]%>, you are our <%= Session[SessionConsts.PlayerID] %>th player</h2>
    <div id="drafts"></div>
    <table id="chattable">
        <tr>
            <td id="chatmain">Some chat lines</td>
            <td id="playerslistbox">
                    <p id="playerslistboxtitle"><strong>Players Online</strong></p>
                    <table id="playerslist">
                    <tr><td>ripper234</td></tr>
                    <tr><td>Avish</td></tr>
                    <tr><td>chaoticdawn</td></tr>
                    </table>
            </td>
        </tr>
    </table>
    <div id="chatline"></div>
</asp:Content>
