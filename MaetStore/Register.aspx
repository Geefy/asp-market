<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="MaetStore.Register" %>

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
            <asp:Button runat="server" OnClick="ProceedRegister" Text="Register"/>
        </div>
    </form>
</body>
</html>
