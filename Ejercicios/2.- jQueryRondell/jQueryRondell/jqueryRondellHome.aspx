<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="jqueryRondellHome.aspx.cs" Inherits="jQueryRondell.jqueryRondellHome" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

    <script src="js/modernizr-2.0.6.min.js"></script>
    <script src="js/jquery-1.10.2.min.js"></script>
    <script src="js/jquery.mousewheel-3.0.6.min.js"></script>
    <script src="js/jquery.rondell.min.js"></script>

    <link href="css/jquery.rondell.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
    <div id="rondellCarousel">
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <a href="<%# Container.DataItem %>">
                    <img src="<%# Container.DataItem %>" />
                </a>
            </ItemTemplate>
        </asp:Repeater>
    </div>
    </form>
    <script type="text/javascript">
        $(function () {
            $("#rondellCarousel").rondell({
                preset: "carousel",
            });
        });
    </script>
</body>
</html>
