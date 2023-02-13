<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Form_Server_Side_Valideator.WebForm1" %>

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
            Name:
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        </p>
        <p>
            Meal Preferences:
            <asp:CheckBox ID="chk1" runat="server" Text="Snacks" />
        </p>
        <p style="margin-left: 120px">
            <asp:CheckBox ID="chk2" runat="server" Text="Thali" />
        </p>
        <p style="margin-left: 120px">
            <asp:CheckBox ID="chk3" runat="server" Text="Mini Thali" />
        </p>
      
        <br />
        Vaccinated:
        &nbsp;
      &nbsp;
      &nbsp;
         &nbsp;<asp:RadioButtonList ID="RadioButtonList1" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
            <asp:ListItem>Dose1</asp:ListItem>
            <asp:ListItem>Dose2</asp:ListItem>
            <asp:ListItem>Applied</asp:ListItem>
            <asp:ListItem>Not Applied</asp:ListItem>
        </asp:RadioButtonList>
&nbsp;<p>
            Vaccine Name:
            <asp:DropDownList ID="ddlVaccineName" runat="server">
                <asp:ListItem>Covaxin</asp:ListItem>
                <asp:ListItem>Covishield</asp:ListItem>
                <asp:ListItem>Not Applicable</asp:ListItem>
            </asp:DropDownList>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Display Details" />
    </form>
</body>
</html>
