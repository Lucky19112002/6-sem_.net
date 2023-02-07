<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Redireact_Demo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 347px; top: 146px; position: absolute" TextMode="Password"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 354px; top: 87px; position: absolute"></asp:TextBox>
        </p>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 245px; top: 87px; position: absolute" Text="Username"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 242px; top: 148px; position: absolute" Text="Password"></asp:Label>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 337px; top: 211px; position: absolute" Text="login" />
    </form>
    
</body>
</html>
