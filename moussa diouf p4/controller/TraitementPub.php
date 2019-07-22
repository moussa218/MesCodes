<?php 
require_once '../document/classe_pub.php';
$obj=new Publication();
       if (isset($_POST['post_pub'])) {
       	 if (isset($_POST['pub'])) {
       	 	$pub=$_POST['pub'];
       	 	$nom=$_POST['nom'];
       	 	if($obj->savePublication($pub,$nom)){
       	 	 		header("location:./../PAGE/Les_Publication.php?afterPub");
       	 	}else{
       	 		echo "error de publication";
       	 	}
       	 }
       }
 ?>