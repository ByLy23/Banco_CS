<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="menuTransfers.aspx.cs" Inherits="Fase2.menuTransfers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Transferencia interbancaria" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Atencion de servicio al cliente" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="solicitud de chequeras" />
        <asp:Label ID="turs" runat="server" Text="Label"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>tyhth</asp:ListItem>
            <asp:ListItem>tyhtyh</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="prueba" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
