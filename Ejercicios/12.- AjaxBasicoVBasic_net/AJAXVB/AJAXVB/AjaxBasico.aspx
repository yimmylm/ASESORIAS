<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="AjaxBasico.aspx.vb" Inherits="AJAXVB.AjaxBasico" %>

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
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                Valor a:
                <asp:TextBox ID="a" runat="server"></asp:TextBox>
<br />
                Valor b:<asp:TextBox ID="b" runat="server"></asp:TextBox>
<br />
                Resultado de la suma es:
                <asp:Label ID="resultado" runat="server" Text="Label"></asp:Label>
<br />
                <asp:Button ID="Button1" runat="server" Text="Sumar" />
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>
