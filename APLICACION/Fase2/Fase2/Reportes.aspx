<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reportes.aspx.cs" Inherits="Fase2.Reportes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            GENERAR REPORTES DE:</div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Transferencias Interbcarias" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Servicio al Cliente" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Solicitud de Chequeras" />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Ver Chequeras disponibles" />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" Visible="False">
            <Columns>
                <asp:BoundField DataField="Reporte Transferencias" HeaderText="Reporte Transferencias" ReadOnly="True" SortExpression="Reporte Transferencias" />
            </Columns>
        </asp:GridView>
&nbsp;&nbsp;
        <asp:GridView ID="reportesac" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2">
            <Columns>
                <asp:BoundField DataField="Reporte Consultas" HeaderText="Reporte Consultas" ReadOnly="True" SortExpression="Reporte Consultas" />
            </Columns>
        </asp:GridView>
        <asp:GridView ID="reportChe" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource3">
            <Columns>
                <asp:BoundField DataField="Reporte Chequeras" HeaderText="Reporte Chequeras" ReadOnly="True" SortExpression="Reporte Chequeras" />
            </Columns>
        </asp:GridView>
        <asp:GridView ID="plus" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource4">
            <Columns>
                <asp:BoundField DataField="Chequeras Disponibles" HeaderText="Chequeras Disponibles" ReadOnly="True" SortExpression="Chequeras Disponibles" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:Proyecto_BancoConnectionString %>" SelectCommand="SELECT { fn CONCAT('Chequeras Disponibles: ', CONVERT (nvarchar(MAX), cantidadChequeras)) } AS [Chequeras Disponibles] FROM inventario"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:Proyecto_BancoConnectionString %>" SelectCommand="SELECT { fn CONCAT({ fn CONCAT('El cliente: ', { fn CONCAT(cliente.nombre, { fn CONCAT(' ', { fn CONCAT(cliente.apellido, { fn CONCAT(' Solicito la chequera con codigo: ', { fn CONCAT(historialChequera.codigoExtendido, { fn CONCAT(' en la fecha ', { fn CONCAT(CONVERT (nvarchar(MAX), historialChequera.fecha), { fn CONCAT(' y el ', { fn CONCAT(tipoEmpleado.puesto, { fn CONCAT(' ', { fn CONCAT(empleado.nombre, { fn CONCAT(' ', empleado.apellido) }) }) }) }) }) }) }) }) }) }) }) }) }, { fn CONCAT(' le dio la chequera y comento: ', historialChequera.comentario) }) } AS [Reporte Chequeras] FROM chequera INNER JOIN historialChequera ON chequera.codChequera = historialChequera.codChequera INNER JOIN cliente ON historialChequera.codCliente = cliente.idCliente INNER JOIN empleado ON historialChequera.codEmpleado = empleado.idEmpleado INNER JOIN tipoEmpleado ON empleado.idTipoEmpleado = tipoEmpleado.idTipo">
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Proyecto_BancoConnectionString %>" SelectCommand="SELECT { fn CONCAT({ fn CONCAT('El cliente: ', { fn CONCAT(cliente.nombre, { fn CONCAT(' ', { fn CONCAT(cliente.apellido, { fn CONCAT(' Realizo una consulta del tipo ', { fn CONCAT(consulta.tipoConsulta, { fn CONCAT(' en la fecha ', { fn CONCAT(CONVERT (nvarchar(MAX), historialConsulta.fecha), { fn CONCAT(' y el motivo fue:  ', { fn CONCAT(historialConsulta.motivo, { fn CONCAT(' y el ', { fn CONCAT(tipoEmpleado.puesto, { fn CONCAT(' ', { fn CONCAT(empleado.nombre, { fn CONCAT(' ', empleado.apellido) }) }) }) }) }) }) }) }) }) }) }) }) }) }) }, ' le resolvio la duda') } AS [Reporte Consultas] FROM cliente INNER JOIN historialConsulta ON cliente.idCliente = historialConsulta.idCliente INNER JOIN consulta ON historialConsulta.idConsulta = consulta.idConsulta INNER JOIN empleado ON historialConsulta.idEmpleado = empleado.idEmpleado INNER JOIN tipoEmpleado ON empleado.idTipoEmpleado = tipoEmpleado.idTipo">
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Proyecto_BancoConnectionString %>" SelectCommand="SELECT { fn CONCAT({ fn CONCAT('El cliente: ', { fn CONCAT(cliente.nombre, { fn CONCAT(' ', { fn CONCAT(cliente.apellido, { fn CONCAT(' Realizo un(a) ', { fn CONCAT(transferencia.tipoTransferencia, { fn CONCAT(' en la fecha ', { fn CONCAT(CONVERT (nvarchar(MAX), historialTransferencia.fecha), { fn CONCAT(' con un monto de: ', { fn CONCAT(CONVERT (nvarchar(MAX), historialTransferencia.monto), { fn CONCAT(' hacia el banco: ', { fn CONCAT(historialTransferencia.bancoDestino, { fn CONCAT(' y fue atendido por el ', { fn CONCAT(tipoEmpleado.puesto, { fn CONCAT(' ', { fn CONCAT(empleado.nombre, { fn CONCAT(' ', empleado.apellido) }) }) }) }) }) }) }) }) }) }) }) }) }) }) }) }) }, ' ') } AS [Reporte Transferencias] FROM cliente INNER JOIN historialTransferencia ON cliente.idCliente = historialTransferencia.idCliente INNER JOIN empleado ON historialTransferencia.idEmpleado = empleado.idEmpleado INNER JOIN tipoEmpleado ON empleado.idTipoEmpleado = tipoEmpleado.idTipo INNER JOIN transferencia ON historialTransferencia.idTransfer = transferencia.idTransferencia">
        </asp:SqlDataSource>
    </form>
</body>
</html>
