<?php
require_once "../application/Fonction.php";
if(isset($_POST['OK'])){
	$login=$_POST['login'];
	$mdp=$_POST['mdp'];
	if(verifieUser($login,$mdp)==true){
	 	 if($_SESSION["CURRENT_USER"]["type"]!="admin"){
	 	 	header("location:./../PAGE/Les_Publication.php");
		 	 }else{
				 	 	if($_SESSION["CURRENT_USER"]=true){
			             header("location:./../PAGE/index_user.php");
			        }else{
			        	echo "Inscription non valide";
			        }
		 	 	}
	 	 }else{
	 	 	header("location:./../document/Form_Connexion.php?mauvaisConnection");
	 	 }
		}else{
			echo "l utilisateur n existe pas dans la base";
		}



