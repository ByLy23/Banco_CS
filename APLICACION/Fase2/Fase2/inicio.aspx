<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inicio.aspx.cs" Inherits="Fase2.inicio" %>

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
        <p>
            <asp:Label ID="Label1" runat="server" Text="Inicio Sesion"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="user" runat="server" placeholder="Usuario"></asp:TextBox>
        </p>
    <p>
        <asp:TextBox ID="pass" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
        </p>
        <p>
            <asp:DropDownList ID="lista" runat="server" DataSourceID="data" DataTextField="puesto" DataValueField="puesto">
            </asp:DropDownList>
            <asp:SqlDataSource ID="data" runat="server" ConnectionString="<%$ ConnectionStrings:Proyecto_BancoConnectionString %>" SelectCommand="SELECT [puesto] FROM [tipoEmpleado]"></asp:SqlDataSource>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Height="24px" OnClick="Button1_Click" Text="Ingresar" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Salir" />
        </p>
    </form>
    </body>
</html>
