<?php
	if(isset($_POST['valider'])){
		//Recuperation des donnees du formulaire
		$code = $_POST['code'];
		$libelle = $_POST['libelle'];

		$f = fopen("../Classeur/classe.csv", "a");
		$obj = $code.";".$libelle."\n"; //contenu
		fputs($f, $obj);

		header("location:../View/ListClasse.php?ok=true");
	}
?>