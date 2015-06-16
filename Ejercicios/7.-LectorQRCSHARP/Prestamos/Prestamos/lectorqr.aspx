<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="lectorqr.aspx.cs" Inherits="Prestamos.lectorqr" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<script src="js/jquery-1.9.1.min.js"></script>
<script src="js/html5-qrcode.min.js"></script>
<body>
    <form id="form1" runat="server">
    <div id="reader" style="width:300px; height:250px">
        <p>
            Datos del Código QR:
            <asp:TextBox ID="txtCodigo" runat="server" Width="371px"></asp:TextBox>
        </p>

        <br />
        </div>

    <script>
        $(document).ready(function () {
            $('#reader').html5_qrcode(function (data) {
                $('#<%=txtCodigo.ClientID%>').val(data);
            },
                function (error) {
                   
                }, function (videoError) {
                    alert("No hay cámara");
                }
            );
        });

    </script>
        
    </form>
    </body>
</html>
