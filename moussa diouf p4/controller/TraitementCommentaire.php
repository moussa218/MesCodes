<?php 
 
require_once '../document/classe_commentaire.php';
$obj=new Commentaire();
       if (isset($_POST['commente'])) {
       	 if (isset($_POST['commentaire'])) {
       	 	$commentaire=$_POST['commentaire'];
       	 	$idpub=$_POST['idpub'];
       	 	if($obj->saveCommmentaire($commentaire,$idpub)){
       	 	 		header("location:./../PAGE/Les_Publication.php?afterCom");
       	 	}else{
       	 		echo "error de Commentaire";
       	 	}
       	 }
       }
 ?>