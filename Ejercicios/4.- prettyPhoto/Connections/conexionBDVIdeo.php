<?php
# FileName="Connection_php_mysql.htm"
# Type="MYSQL"
# HTTP="true"
$hostname_conexionBDVIdeo = "localhost";
$database_conexionBDVIdeo = "basededatos";
$username_conexionBDVIdeo = "root";
$password_conexionBDVIdeo = "123";
$conexionBDVIdeo = mysql_pconnect($hostname_conexionBDVIdeo, $username_conexionBDVIdeo, $password_conexionBDVIdeo) or trigger_error(mysql_error(),E_USER_ERROR); 
?>