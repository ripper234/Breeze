<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Home Page
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>To start, choose a nick:</h2>
    
    <form action="/Account/ChooseNick" >
        <fieldset>
        <input type="text" name="nickname"/>
        <input type="submit" name="submit" value="Choose"/>
        </fieldset>
    </form>
</asp:Content>
