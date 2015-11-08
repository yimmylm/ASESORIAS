<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="UasandoGoogleBlockly.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    
    <script src="js/blockly_compressed.js"></script>
    <script src="js/blocks_compressed.js"></script>
    <script src="js/javascript_compressed.js"></script> 
    <script src="js/es.js"></script>

</head>
<body>
    <form id="form1" runat="server">
    <div id="DivBlockly" style="width:700px; height:400px"></div>
        <input type="button" onclick="MostrarCodigo()" value="MostrarCodigo"/>
        <textarea id="CodigoResultante"></textarea>

        <xml id="toolbox" style="display: none">
               <category name="sentencia if">
                    <block type="controls_if"></block>
                </category>
             <category name="sentencia ciclos">
                <block type="controls_repeat_ext"></block>
              </category>
            <category name="Otras Sentencias ">
                <block type="logic_compare"></block>
                <block type="math_number"></block>
                <block type="math_arithmetic"></block>
                <block type="text"></block>
                <block type="text_print"></block>
                </category>
        </xml>


        <script>
            var EspacioTrabajo = Blockly.inject('DivBlockly', { toolbox: document.getElementById('toolbox') });
            function MostrarCodigo() {
                var codigo = Blockly.JavaScript.workspaceToCode(EspacioTrabajo);
                document.getElementById('CodigoResultante').innerHTML = codigo;
            }
        </script>

    </form>
</body>
</html>
