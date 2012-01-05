<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<Movies.Models.Movie>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Delete
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<fieldset>
    <legend>Movie</legend>

    <div class="display-label">Title</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Title) %>
    </div>

    <div class="display-label">ReleaseDate</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.ReleaseDate) %>
    </div>

    <div class="display-label">Genre</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Genre) %>
    </div>

    <div class="display-label">Price</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Price) %>
    </div>
</fieldset>
<% using (Html.BeginForm()) { %>
    <p>
        <input type="submit" value="Delete" /> |
        <%: Html.ActionLink("Back to List", "Index") %>
    </p>
<% } %>

</asp:Content>
