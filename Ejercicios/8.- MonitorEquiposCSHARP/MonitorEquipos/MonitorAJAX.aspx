<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MonitorAJAX.aspx.cs" Inherits="MonitorEquipos.MonitorAJAX" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Timer ID="Timer1" runat="server" OnTick="Timer1_Tick">
                </asp:Timer>
                <asp:Repeater ID="Repeater1" runat="server" DataSourceID="OrigenDatos">
                    <ItemTemplate>
                        
                        <span>
                            <img src="<%#(Convert.ToInt32(Eval("Estatus"))==0)?"PCoff.png":"PCon.png"%>" />
                        <%# Eval("Nombre")%>
                        </span>
                        
                    </ItemTemplate>
                </asp:Repeater>
                <asp:SqlDataSource ID="OrigenDatos" runat="server" ConnectionString="<%$ ConnectionStrings:ConesionSistemaMonitor %>" SelectCommand="SELECT * FROM [Equipos]"></asp:SqlDataSource>
                <br />
            </ContentTemplate>
        </asp:UpdatePanel>
    
    </div>
    </form>
</body>
</html>
