<!DOCTYPE html>
<html>
<head>
	<title>inscription</title>
	<meta charset="utf-8">
	<link rel="stylesheet" type="text/css" href="style/bootstrap-cerulean.min.css">
      <link rel="stylesheet" href="style/bootstrap-theme.min.css">

</head>
<body>
      <div class="row" >
        <div class="col-md-4"> </div>
        <div class="col-md-4">
          <?php
                           if(isset($_GET['resultat'])){
                                ?>
                                      <h3>inscription reussi</h3> 
                                <?php
                           }
                      ?>
        	  <div class="panel panel-success">
                     <div class="panel-heading">INSCRIPTION</div>
                     <div class="panel-body">

               <form method="POST" action="traitementIns.php" class="well col-md-12 col-md-offset" autocomplete="off">
              	 <div class="form-group">
                  <label class="control-label">NOM</label>
                  <input type="text" name="nom" class="form-control" placeholder="nom"  >
                 </div>
                  <div class="form-group">
                  <label class="control-label">PRENOM</label>
                  <input type="text" name="prenom" class="form-control" placeholder="prenom" >
                 </div>
                 <div class="form-group">
                  <label class="control-label">TELEPHONE</label>
                  <input type="text" name="telephone" class="form-control" placeholder="telephone"  >
                 </div>
                  <div class="form-group">
                  <label class="control-label">EMAIL</label>
                  <input type="email" name="email" class="form-control" placeholder="email"  >
                 </div>
                  <div class="form-group">
                  <label class="control-label">login</label>
                  <input type="text" name="login" class="form-control" placeholder="login" >
                 </div>
                  <div class="form-group">
                  <label class="control-label"  >mot de passe</label>
                  <input type="password" name="mdp" class="form-control" placeholder="mot de passe">
                 </div>
                          <button type="submit" name="valider" class="btn btn-primary" >Inscriptionr</button>
                          <a href="Connexion.php" name="annuler" class="btn btn-success" >Connection</a>
                          </form>
                      </div>
                  </div>
              </div>
</div>
    </div>
</body>
</html>