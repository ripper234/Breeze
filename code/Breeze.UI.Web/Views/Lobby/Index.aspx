<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>
<%@ Import Namespace="Breeze.UI.Web.Utils"%>

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
                    <div id="playerslist">
                    ripper234<br />
                    Avish<br />
                    chaoticdawn<br />
                    </div>
            </td>
        </tr>
    </table>
    <div id="chatline"></div>
</asp:Content>
