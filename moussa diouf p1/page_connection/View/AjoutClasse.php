<!DOCTYPE html>
<html>
<head>
	<title>AjoutClasse</title>
	<meta charset="utf-8">
	<link rel="stylesheet" type="text/css" href="./style/bootstrap-cerulean.min.css">
	<link rel="stylesheet" type="text/css" href="./style/img.css">
</head>
<body>
	<?php
		if (isset($_GET['ok'])){
			if($_GET['ok'] == true){
				echo "<div class='alert alert-success'>Classe ajoutée avec succès</div>";
			}
			else{
				echo "<div class='alert alert-danger'>Classe non ajoutée</div>";
			}
		}
	?>
	<nav class="navbar navbar-inverse" style="background-image:url('../Images/1.JPG')">
		<ul class="nav navbar-nav">
			<li><a href="ListClasse.php">Gestion des Classes</a></li>
			<li><a href="ListEtudiant.php">Gestion des Etudiants</a></li>
		</ul>
	</nav>
	<div class="container col-md-6 col-md-offset-3">
		<div class="panel panel-primary">
			<div class="panel-heading">Formulaire d'ajout de Classe</div>
			<div class="panel-body">

				<form method="POST" action="../Traitement/TAjoutClasse.php">
					<div class="form-group">
						<label>Code</label>

						<input type="text" name="code" class="form-control">
						
					</div>
					<div class="form-group">
						<label>Libelle</label>
						<input type="text" name="libelle" class="form-control">
					</div>
					<button type="submit" name="valider" class="btn btn-success">Envoyer</button>
					<button type="reset" name="annuler" class="btn btn-warning">Annuler</button>
					<a href="ListClasse.php" class="btn btn-primary">Retour</a>
				</form>
			</div>
		</div>
	</div>
</body>
</html>