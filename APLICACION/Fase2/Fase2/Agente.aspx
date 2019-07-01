<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Agente.aspx.cs" Inherits="Fase2.Agente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Buscar Cliente" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:TextBox ID="elde" runat="server" placeholder="DPI Cliente"></asp:TextBox>
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Registrar Cliente" />
            <br />
            <asp:Label ID="nomclie" runat="server" Text="Nombre Cliente"></asp:Label>
            <br />
            <asp:Label ID="corrcli" runat="server" Text="Correo"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Turno: "></asp:Label>
            <asp:Label ID="num" runat="server" Text="#Turno"></asp:Label>
            <br />
            <br />
            <asp:DropDownList ID="cojun" runat="server" DataSourceID="banco" DataTextField="tipoConsulta" DataValueField="tipoConsulta">
            </asp:DropDownList>
            <asp:SqlDataSource ID="banco" runat="server" ConnectionString="<%$ ConnectionStrings:Proyecto_BancoConnectionString %>" SelectCommand="SELECT [tipoConsulta] FROM [consulta]"></asp:SqlDataSource>
            &nbsp;<br />
            <asp:Label ID="Label3" runat="server" Text="Codigo de empleado: "></asp:Label>
            <asp:Label ID="codEm" runat="server" Text="0"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="motivo" runat="server" Height="144px" TextMode="MultiLine" Width="608px" placeholder="Descripcion Problema"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Aceptar" OnClick="Button2_Click" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
&nbsp;</div>
    </form>
</body>
</html>
