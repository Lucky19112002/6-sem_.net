<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="First_Web.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        function test(x) {
            var n = parseInt(x);
            if (n < 5000) {
                alert("Value shoud be above 5000");
            }
        }
    </script>
    <style type="text/css">
        #Button1 {
            z-index: 1;
            left: 383px;
            top: 170px;
            position: absolute;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            &nbsp;</p>
        <asp:Button ID="Button2" runat="server" Text="Server Button" style="position: absolute; z-index: 1; left: 580px; top: 171px" OnClick="Button2_Click" />
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 461px; top: 79px; position: absolute; height: 32px; width: 204px;"></asp:TextBox>
    </form>
            <input id="Button1" onclick="test(TextBox1.value)" type="button" value="HTML BUTTON" />
</body>
</html>
