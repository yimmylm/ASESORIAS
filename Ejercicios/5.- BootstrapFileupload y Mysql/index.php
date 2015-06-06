<!DOCTYPE html>
<html lang="en">
  <head>
    <meta charset="UTF-8"/>
    <title>Bootstrap File Upload</title>
        
	<link href="http://netdna.bootstrapcdn.com/bootstrap/3.3.2/css/bootstrap.min.css" rel="stylesheet">
    <link href="css/fileinput.min.css" media="all" rel="stylesheet" type="text/css" />
       
	<script src="http://ajax.googleapis.com/ajax/libs/jquery/1.11.0/jquery.min.js"></script>
    <script src="js/fileinput.min.js" type="text/javascript"></script>
    <script src="http://netdna.bootstrapcdn.com/bootstrap/3.3.2/js/bootstrap.min.js" type="text/javascript"></script>
    
	</head>
    
	<body>

	<input id="archivos" name="imagenes[]" type="file" multiple=true class="file-loading">
	</body>
	<?php 	
	$directory = "imagenes_/";      
	$images = glob($directory . "*.*");
	?>
	
	<script>
	$("#archivos").fileinput({
	uploadUrl: "upload.php", 
    uploadAsync: false,
    minFileCount: 1,
    maxFileCount: 20,
	showUpload: false, 
	showRemove: false,
	initialPreview: [
	<?php 
	
	$pdo=new PDO("mysql:dbname=basededatos;host=127.0.0.1","root","123");
	$statement=$pdo->prepare("SELECT id,info FROM archivos");
	$statement->execute();
	$results=$statement->fetchAll(PDO::FETCH_ASSOC);
		
	
	foreach($results as $result){?>
		"<img src='view.php?elid=<?php echo $result['id']; ?>' height='120px' class='file-preview-image'>",
	<?php } ?>],
    initialPreviewConfig: [<?php foreach($results as $result){ $infoImagenes=$result['info'];?>
	{caption: "<?php echo $infoImagenes;?>",  height: "120px", url: "borrar.php", key:"<?php echo $result['id'];?>"},
	<?php } ?>]
	}).on("filebatchselected", function(event, files) {
	
	$("#archivos").fileinput("upload");
	
	});
	
	</script>
</html>