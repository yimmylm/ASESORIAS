<?php 
$carpetaAdjunta="imagenes_/";
// Contar envían por el plugin
$Imagenes = count($_FILES['imagenes']['name']);

for($i = 0; $i < $Imagenes; $i++) {

	// El nombre y nombre temporal del archivo que vamos para adjuntar
	$nombreArchivo=$_FILES['imagenes']['name'][$i];
	$nombreTemporal=$_FILES['imagenes']['tmp_name'][$i];
	
	$rutaArchivo=$carpetaAdjunta.$nombreArchivo;
	
	


	$pdo=new PDO("mysql:dbname=basededatos;host=127.0.0.1","root","123");
	$statement = $pdo->prepare("INSERT INTO  archivos(id,info,imagen) VALUES(NULL,:info,:texto);");
	$statement->execute(array("info" => $_FILES['imagenes']['name'][$i],"texto" => file_get_contents($_FILES['imagenes']['tmp_name'][$i])));

	
    
		
	
	move_uploaded_file($nombreTemporal,$rutaArchivo);
	
	$infoImagenesSubidas[$i]=array("caption"=>"$nombreArchivo","height"=>"120px","url"=>"borrar.php");
	$ImagenesSubidas[$i]="<img  height='120px'  src='$rutaArchivo' class='file-preview-image'>";
	
	}

$arr = array("file_id"=>0,"overwriteInitial"=>true,"initialPreviewConfig"=>$infoImagenesSubidas,
			 "initialPreview"=>$ImagenesSubidas);
echo json_encode($arr);print_r($ID);
?>


