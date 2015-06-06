<?php 

	header('Content-Type: image/jpg');
	
	if(isset($_GET['elid'])){
		
		
		$pdo=new PDO("mysql:dbname=basededatos;host=127.0.0.1","root","123");
		
		$statement=$pdo->prepare("SELECT * FROM archivos WHERE id=:id");
		
		$statement->execute(array("id" => $_GET['elid']));
		
		$results=$statement->fetchAll(PDO::FETCH_ASSOC);
		
		print_r($results[0]['imagen']);
	}
	

?>


