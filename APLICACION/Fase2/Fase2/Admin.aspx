<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="Fase2.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Admin
        </div>
        <asp:Button ID="Moduloregistro" runat="server" OnClick="Button1_Click" Text="Controlar empleados" />
        <asp:Button ID="Button1" runat="server" Text="Controlar Clientes" OnClick="Button1_Click1" />
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Generar Reportes" />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Actualizar Inventario" OnClick="Button2_Click" />
        <br />
        <br />
        <asp:TextBox ID="cant" runat="server" OnTextChanged="TextBox1_TextChanged" placeholder="Ingreso Chequeras"></asp:TextBox>
    </form>
</body>
</html>
