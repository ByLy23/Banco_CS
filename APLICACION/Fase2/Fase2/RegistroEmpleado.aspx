<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroEmpleado.aspx.cs" Inherits="Fase2.RegistroEmpleado" %>

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
        <asp:Label ID="Label1" runat="server" Text="Registro Empleados"></asp:Label>
        <asp:Button ID="Button1" runat="server" Text="Regresar" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Buscar" OnClick="Button2_Click" />
        <asp:Button ID="Button3" runat="server" Text="Modificar" OnClick="Button3_Click" style="width: 78px" />
        <asp:Button ID="Button4" runat="server" Text="Eliminar" OnClick="Button4_Click" />
        <asp:Button ID="Button5" runat="server" Text="Ingresar" OnClick="Button5_Click" />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:TextBox ID="dpi" runat="server" placeholder="DPI"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Nombre" runat="server" placeholder="Nombre"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="Apellido" runat="server" placeholder="Apellido"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="FechaNAc" runat="server" placeholder="FechaNac"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="correo" runat="server" placeholder="correo"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="telefono" runat="server" placeholder="telefono"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="usuario" runat="server" placeholder="usuario"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="contrasenia" runat="server" placeholder="contrasenia"></asp:TextBox>
        <br />
        <br />
&nbsp;<asp:TextBox ID="Clave" runat="server" placeholder="clave"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="rol" runat="server" DataSourceID="datos" DataTextField="puesto" DataValueField="puesto" Height="16px">
        </asp:DropDownList>
        <asp:SqlDataSource ID="datos" runat="server" ConnectionString="<%$ ConnectionStrings:Proyecto_BancoConnectionString %>" SelectCommand="SELECT [puesto] FROM [tipoEmpleado]"></asp:SqlDataSource>
        <asp:TextBox ID="Role" runat="server" placeholder="Colocar codigo rol" Enabled="False" OnTextChanged="Role_TextChanged"></asp:TextBox>
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
    </form>
</body>
</html>
