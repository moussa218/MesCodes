<?php
if (isset($_POST['valider'])) {
	$c=$_GET['code']; //cest la variable code apres modification
	$code=$_POST['code'];
	$libelle=$_POST['libelle'];
	$obj=$code.";".$libelle."\n";// contenu du fichier classe.csv
		$f = fopen("../Classeur/classe.csv","r");
		$tmp =fopen("../Classeur/tmp.csv","w");
		while ($tab = fgetcsv($f,1000,";")) {
			if ($tab[0] != $c) {
				$svg= $tab[0].";".$tab[1]."\n";// contenu du fichier tmp.csv
				fputs($tmp, $svg);
			}
		}
				fputs($tmp, $obj);
				fclose($f);
				fclose($tmp);
				copy("../Classeur/tmp.csv", "../Classeur/classe.csv");//copy dun fichier dans un autre fichier
				unlink("../Classeur/tmp.csv");//supression fichier
				header("location:../View/ListClasse.php");

}
?>