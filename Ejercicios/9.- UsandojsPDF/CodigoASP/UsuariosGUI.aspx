<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UsuariosGUI.aspx.cs" Inherits="ABCEjemplo.GUI.UsuariosGUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="jquery-2.1.4.min.js"></script>
    <script src="jspdf.debug.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        Id:<asp:TextBox ID="txtId" runat="server"></asp:TextBox>
        <br />
        Nombre:
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <br />
        Tipo:<asp:TextBox ID="txttipo" runat="server"></asp:TextBox>
        <br />
        Login:<asp:TextBox ID="txtlogin" runat="server"></asp:TextBox>
        <br />
        Password:<asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>
        <br />
        Correo:
        <asp:TextBox ID="txtcorreo" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" Text="Agregar" />
        <asp:Button ID="btnModificar" runat="server" Text="Modificar" OnClick="btnModificar_Click" />
        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
        <br />
        <br />
    
    </div>

<div id="Reporte">
        
        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnSelectedIndexChanging="GridView1_SelectedIndexChanging">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
    <input type="button" onclick="DescargarPDF('Reporte','ReporteASP')" value="Decargar Reporte"/>

</div>


    </form>
    <script>
        function DescargarPDF(ContenidoID, nombre) {

            var pdf = new jsPDF('p', 'pt', 'letter');

            html = $('#' + ContenidoID).html();

            specialElementHandlers = {};

            margins = { top: 10, bottom: 20, left: 20, width: 522 };

            pdf.fromHTML(html, margins.left, margins.top, { 'width': margins.width }, function (dispose) { pdf.save(nombre + '.pdf'); }, margins);

        }


    </script>
</body>
</html>
