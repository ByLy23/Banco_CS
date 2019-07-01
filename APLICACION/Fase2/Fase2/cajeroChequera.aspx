<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cajeroChequera.aspx.cs" Inherits="Fase2.cajeroChequera" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            <asp:Button ID="Button1" runat="server" Text="Buscar Cliente" OnClick="Button1_Click1" />
            <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Actualizar" />
            <br />
            <br />
            <asp:TextBox ID="elde" runat="server" placeholder="DPI Cliente"></asp:TextBox>
            <br />
            Nombre Cliente:
            <asp:Label ID="nomclie" runat="server" Text="Nombre Cliente"></asp:Label>
            <br />
            Codigo Cliente:
            <asp:Label ID="corrcli" runat="server" Text="Correo"></asp:Label>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Codigo de Empleado: "></asp:Label>
            <asp:Label ID="codEm" runat="server" Text="0"></asp:Label>
            <br />
            Turno:
            <asp:DropDownList ID="torn" runat="server">
            </asp:DropDownList>
            <br />
            codigo solicitud Chequera:
            <asp:Label ID="comrp" runat="server" Text="codigo Comprobante"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="comentario" runat="server" Height="131px" OnTextChanged="TextBox1_TextChanged" TextMode="MultiLine" Width="392px" placeholder="comentario"></asp:TextBox>
            <br />
            <asp:Button ID="Button3" runat="server"  Text="Registrar CLiente" OnClick="Button3_Click" />
            <br />
            <br />
        <div>
            <asp:Button ID="Button2" runat="server" Text="Aceptar" Height="26px" OnClick="Button2_Click"/>
            <br />
            <br />
            <asp:Label ID="enco" runat="server" Text="Busqueda"></asp:Label>
            <br />
            <asp:TextBox ID="busqueda" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Imprimir" />
            <asp:Button ID="Button6" runat="server" OnClick="Button6_Click1" Text="Entregar" />
            <br />
            <br />
            <br />
            <asp:Button ID="Button4" runat="server" Text="Verificar Chequeras" OnClick="Button4_Click" />
            <br />
            <br />
            <asp:ListBox ID="verificacion" runat="server" Height="106px" Width="453px"></asp:ListBox>
        </div>
    </form>
</body>
</html>
