<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="SimpsonsWeb.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Show Web</title>
    <link href="main.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <h1>Show Web</h1>
        <h2 class="heading">Get information about all your favorite shows</h2>
        <div class="content">
            <asp:LinkButton ID="lnkSimpsons" runat="server" PostBackUrl="~/Simpsons.aspx">Go to Simpsons Page</asp:LinkButton>
        </div>
        <%-- Create a new page and add a link to the new show or team page here --%>
    </form>
</body>
</html>
