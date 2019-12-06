<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MaetStore.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox runat="server" ID="username" placeholder="Username" ></asp:TextBox>
            <asp:TextBox runat="server" ID="password" placeholder="Password" TextMode="Password" ></asp:TextBox>
            <asp:Button runat="server" OnClick="ProceedLogin" Text="Login"/>
        </div>
    </form>
</body>
</html>
