<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cajero.aspx.cs" Inherits="Fase2.Cajero" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            <asp:Button ID="Button1" runat="server" Text="Buscar Cliente" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:TextBox ID="elde" runat="server" placeholder="DPI Cliente"></asp:TextBox>
            <br />
            <asp:Label ID="nomclie" runat="server" Text="Nombre Cliente"></asp:Label>
            <br />
            <asp:Label ID="corrcli" runat="server" Text="Correo"></asp:Label>
            <br />
            <br />
            <br />
        <asp:SqlDataSource ID="day" runat="server" ConnectionString="<%$ ConnectionStrings:Proyecto_BancoConnectionString %>" SelectCommand="SELECT [tipoTransferencia] FROM [transferencia]"></asp:SqlDataSource>
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="day" DataTextField="tipoTransferencia" DataValueField="tipoTransferencia">
        </asp:DropDownList>
            <asp:SqlDataSource ID="banco" runat="server" ConnectionString="<%$ ConnectionStrings:Proyecto_BancoConnectionString %>" SelectCommand="SELECT [tipoTransferencia] FROM [transferencia]"></asp:SqlDataSource>
            <asp:Label ID="Label2" runat="server" Text="Turno: "></asp:Label>
            <asp:DropDownList ID="Turnos" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Codigo de Empleado: "></asp:Label>
            <asp:Label ID="codEm" runat="server" Text="0"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="bans" runat="server" OnTextChanged="TextBox1_TextChanged" placeholder="Banco"></asp:TextBox>
            <br />
            <br />
            <asp:TextBox ID="dinero" runat="server" placeholder="monto"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Registrar CLiente" />
            <br />
            <br />
        <div>
            <asp:Button ID="Button2" runat="server" Text="Aceptar" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>
