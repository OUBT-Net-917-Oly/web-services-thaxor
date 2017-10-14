<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Simpsons.aspx.cs" Inherits="SimpsonsWeb.Simpsons" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Simpsons Web Client</title>
    <link href="main.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <h1>Simpsons Web Client</h1>
        <h2 class="heading">
            <asp:Label ID="lblMessage" runat="server" Text="Message"></asp:Label>
        </h2>
        <div class="content">
            <asp:Button ID="btnGetAll" runat="server" Text="Get All" OnClick="btnGetAll_Click" /><br />
            <asp:Label ID="lblCharacters" runat="server" Text=""></asp:Label>
        </div>
        <br />
        <br />
        <div>
            LastName: <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnFindByLast" runat="server" Text="Find by Last Name" OnClick="btnFindByLast_Click" /> <br />
            <asp:Label ID="lblLastMatch" runat="server" Text=""></asp:Label>
        </div>
        <br />
        <br />
    </form>
</body>
</html>
