<?php
		require_once'genererMat.php';
	if(isset($_POST['valider'])){
		//Recuperation des donnees du formulaire
		$nom = $_POST['nom'];
		$prenom = $_POST['prenom'];
		$sexe = $_POST['sexe'];
		$naiss = $_POST['naiss'];
		$classe = $_POST['classe'];
		$mat = generer($prenom, $nom, $date);
		$f = fopen("../Classeur/etudiant.csv", "a");
		$obj = $mat.";".$nom.";".$prenom.";".$sexe.";".$naiss.";".$classe."\n"; //contenu
		fputs($f, $obj);

		header("location:../View/ListEtudiant.php?ok=true");
	}
?>