<!DOCTYPE html>
<html>
<head>
	<title>AjoutEtudiant</title>
	<meta charset="utf-8">
	<link rel="stylesheet" type="text/css" href="./style/bootstrap-cerulean.min.css">
	<link rel="stylesheet" type="text/css" href="./style/imgCE.css">
</head>
<body>
	<?php
		if (isset($_GET['ok'])){
			if($_GET['ok'] == true){
				echo "<div class='alert alert-success'>Etudiant ajoutée avec succès</div>";
			}
			else{
				echo "<div class='alert alert-danger'>Etudiant non ajoutée</div>";
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
			<div class="panel-heading">Formulaire d'ajout d'Etudiant</div>
			<div class="panel-body">

				<form method="POST" action="../Traitement/TAjoutEtudiant.php">
					<div class="form-group">
						<label>Nom</label>
						<input type="text" name="prenom" class="form-control">
					</div>
					<div class="form-group">
						<label>Prenom</label>

						<input type="text" name="nom" class="form-control">
						
					</div>
					<div class="form-group">
						<label>Sexe</label><br>

						<label class="radio-inline"><input type="radio" name="sexe" value="Masculin">Masculin</label>
						<label class="radio-inline"><input type="radio" name="sexe" value="Feminin">Feminin</label>
					</div>
					<div class="form-group">
						<label>Date de naissance</label>

						<input type="date" name="naiss" class="form-control">
						
					</div>
					<div class="form-group">
						<label>Classe</label>
						<select name="classe">
							<option value="">Faite Votre Choix</option>
								<?php
									$f = fopen("../Classeur/classe.csv", "r");
									while($tab =fgetcsv($f,1000,";")){
									echo "<option value='$tab[0]'>$tab[0]</option>";
								}
								?>
						</select>
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