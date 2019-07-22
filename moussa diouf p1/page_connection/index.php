<!DOCTYPE html>
<html>
<head>
	<title>Index</title>
	<meta charset="utf-8">
	<link rel="stylesheet" type="text/css" href="View/style/bootstrap-cerulean.min.css">
 <link rel="stylesheet" type="text/css" href="View/style/style11.css">
 <link rel="stylesheet" type="text/css" href="View/style/img5.css">
</head>
<body>
	<nav class="navbar navbar-inverse" style="background-image:url('Images/1.JPG')">
	<ul class="nav navbar-nav">
      
    </ul>
   
	</nav>
<!--CALENDAR -->
        <div style="float: center; width: 100%">
      <div style="height: 520px; padding: 50px; -webkit-border-radius: 12px; -moz-border-radius: 12px; margin-right: 10px">
        <div style="float: left; width: 100%">
        <h3 style="text-align: center; opacity: 13%; -webkit-border-radius: 30px; -moz-border-radius: 30px; margin-top: -40px;  padding: 1px; color: white;">
          <marquee >Bienvenue Dans La Gestion School  Gestion School permet la bonne gouvernance a un etablissement Universitaire et la Gestion des principales activites scolaires de l'incription des Etudiants a la publication des resultats en passant par la saisie des Notes

  </marquee>
                    </h3>
         </div>

<div style="float: left; width: 60%">
        <h3 style="text-align: center;   margin-top: 15px;  padding: 50px; width: 40%;float: right;">
           <ul class="nav navbar-nav">
      <li><a href="View/ListClasse.php" class='btn btn-info btn-block' >GESTION DES CLASSES</a></li>
    </ul>
         </h3>
         </div>


<div style="float: left; width: 60%">
        <h3 style="text-align: center;   margin-top: 15px;  padding: 50px; width: 40%;float: right;">
           <ul class="nav navbar-nav">
      <li><a href="View/ListEtudiant.php" class='btn btn-info btn-block' >GESTION DES ETUDIANTS</a></li>
    </ul>
         </h3>
         </div>



        </div>
          </div>



 <div style="float: left; width: 100%">
        <h3 style="text-align: center; opacity: 13%; -webkit-border-radius: 30px; -moz-border-radius: 30px; margin-top: -40px;  padding: 1px; color: white;">
           <marquee>
            <?php
$date = date("d-m-Y");
$format = 'd-m-y   H:i:s';
$date = date($format);
echo "Nous Sommes Le $date";
?>
</marquee>
         </h3>
         </div>
</body>
</html>