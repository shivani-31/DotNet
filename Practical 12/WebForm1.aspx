<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Practical_12.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enable and disable textbox:
            <asp:TextBox ID="txtEnableDisable" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnEnableDisable" runat="server" OnClick="btnEnableDisable_Click" Text="Enable/Disable" />
            <br />
            Change width of textbox:
            <asp:TextBox ID="TextBox1" runat="server" Width="117px"></asp:TextBox>
            <asp:Button ID="btnChangeWidth" runat="server" OnClick="btnChangeWidth_Click" Text="Change Width" />
        </div>
    </form>
</body>
</html>
