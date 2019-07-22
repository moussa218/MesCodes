<?php
	if (isset($_GET['ok'])){
		$matricule = $_GET['ok'];
		$f = fopen("../Classeur/etudiant.csv", "r");
		while ($tab = fgetcsv($f, 1000, ";")) {
			if ($matricule == $tab[0]){
				$prenom = $tab[1];
			}
		}
	}
?>
<!DOCTYPE html>
<html>
<head>
	<title>ModifClasse</title>
	<meta charset="utf-8">
	<link rel="stylesheet" type="text/css" href="./style/bootstrap-cerulean.min.css">
	<link rel="stylesheet" type="text/css" href="./style/imgCE.css">
</head>
<body>
	<nav class="navbar navbar-inverse" style="background-image:url('../Images/1.JPG')">
		<ul class="nav navbar-nav">
			<li><a href="ListClasse.php">Gestion des Classes</a></li>
			<li><a href="ListEtudiant.php">Gestion des Etudiants</a></li>
		</ul>
	</nav>
	<div class="container col-md-6 col-md-offset-3">
		<div class="panel panel-primary">
			<div class="panel-heading">Formulaire de Modification</div>
			<div class="panel-body">
				<form method="POST" action="../Traitement/TModifEtudiant.php?matricule=<?php echo 
				$matricule?>">
					<div class="form-group">
						<label>Matricule</label>
						<input type="text" name="matricule" class="form-control" value="<?php echo $matricule;?>">
					</div>
					<div class="form-group">
						<label>Prenom</label>
						<input type="text" name="prenom" class="form-control" value="<?php echo $prenom;?>">
					</div>
					<button type="submit" name="valider" class="btn btn-success">Envoyer</button>
					<button type="reset" name="annuler" class="btn btn-warning">Annuler</button>
					<a href="ListEtudiant.php" class="btn btn-primary">Retour</a>
				</form>
			</div>
		</div>
	</div>
</body>
</html>