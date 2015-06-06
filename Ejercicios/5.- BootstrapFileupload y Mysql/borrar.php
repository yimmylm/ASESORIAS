<?php 
$carpetaAdjunta="imagenes_/";

if($_SERVER['REQUEST_METHOD']=="DELETE"){

			parse_str(file_get_contents("php://input"),$datosDELETE);

			$key= $datosDELETE['key'];
			
			$pdo=new PDO("mysql:dbname=basededatos;host=127.0.0.1","root","123");
			$statement = $pdo->prepare("DELETE FROM archivos  WHERE id=:id");
			$statement->execute(array("id" => $key));


			//unlink($carpetaAdjunta.$key);
			
			echo 0;
}

?>
