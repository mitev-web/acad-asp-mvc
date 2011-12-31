<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<Movies.Models.Movie>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Details</h2>

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
<p>

    <%: Html.ActionLink("Edit", "Edit", new { id=Model.ID }) %> |
    <%: Html.ActionLink("Back to List", "Index") %>
</p>

</asp:Content>
