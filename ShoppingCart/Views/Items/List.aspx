<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index.aspx
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <section>
        <ul>
            <% foreach(var hero in (ViewData["heroes"] as List<ShoppingCart.Models.Hero>)){ %>
            <li>
                <h3><a href="/Items/Detail/<%= hero.getName() %>"><%= hero.getName() %></a></h3>
                <h4><%= hero.getPublisher() %></h4>
                <button>Add</button>
            </li>
            <% } %>
        </ul>
    </section>

</asp:Content>
