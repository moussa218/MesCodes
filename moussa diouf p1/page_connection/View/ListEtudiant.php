<!DOCTYPE html>
<html>
<head>
	<title>ListEtudiant</title>
	<meta charset="utf-8">
	<link rel="stylesheet" type="text/css" href="./style/bootstrap-cerulean.min.css">
	<link rel="stylesheet" type="text/css" href="./style/style.css">
	<link rel="stylesheet" type="text/css" href="./style/imgLE.css">
	<script type="text/javascript" src="./script/script.js"></script>
</head>
<body>
	<nav class="navbar navbar-inverse" >
		<ul class="nav navbar-nav">
			<li><a href="ListClasse.php">Gestion des Classes</a></li>
			<li><a href="ListEtudiant.php">Gestion des Etudiants</a></li>
		</ul>
	</nav>
	<div class="container col-md-6 col-md-offset-3 spacer" >
		<div class="panel panel-primary" >
			<div class="panel-heading" align="center">Liste des Etudiants</div>
			<div class="panel-body">
				<a href="AjoutEtudiant.php" class="btn btn-success">Ajout Etudiant</a>

				<table class="table table-bordered table-striped">
					<tr>
						<th>MATRICULE</th>
						<th>NOM</th>
						<th>PRENOM</th>
						<th>SEXE</th>
						<th>DATE</th>
						<th>CLASSE</th>
						<th>ACTION</th>
						<th>ACTION</th>
					</tr>
					<tr>
						<?php
							$f = fopen("../Classeur/etudiant.csv", "r");
							while ($tab = fgetcsv($f, 1000, ";")) {
								echo "<tr>";
									for ($i=0; $i < count($tab); $i++) { 
										echo "<td>".$tab[$i]."</td>";
									}
									echo "<td><a href='ModifEtudiant.php?ok=$tab[0]' class='btn btn-info btn-block'>Modifier</a></td>
									      <td><a href='../Traitement/TSuppEtudiant.php?ok=$tab[0]' class='btn btn-warning btn-block'
									      		onclick='return
									      		confirmartion();'>Supprimer</a></td>";
								echo "</tr>";
							}
						?>
					</tr>
				</table>
				<a href="../index.php" class="btn btn-primary">Retour</a>
			</div>
		</div>
	</div>
</body>
</html>