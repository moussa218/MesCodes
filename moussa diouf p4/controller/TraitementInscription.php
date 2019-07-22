<?php
require '../application/Fonction.php';
if(isset($_POST['valider'])){
	$nom=$_POST['nom'];
	$prenom=$_POST['prenom'];
	$email=$_POST['email'];
	$login=$_POST['login'];
	$mdp=$_POST['mdp'];

	if(saveUser($nom,$prenom,$email,$login,$mdp)){
			header("location:./../document/Form_Connexion.php?okinscrit");
	}

}

	if(isset($_POST['valider_ins'])){
		$id=$_POST['id'];
		if(valider_inscri($id)){
			 	header("location:./../page/index_admin.php?afterValid");
		}else{
			echo "erreur de validation";
		}
	}


?>