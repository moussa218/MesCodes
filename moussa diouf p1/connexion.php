         
<!DOCTYPE html>
<html>
<head>
	<title>page1</title>
	<meta charset="utf-8">
	<link rel="stylesheet" type="text/css" href="style/bootstrap-cerulean.min.css">
</head>

<body>
  <div class="alerter">
  <div class="row">
      <div class="col-md-4"> </div>
      <?php
            if(isset($_GET['erreur'])){
            echo "merci d entrer les bonnes information pour pouvoir se connecter";
          }
      ?>
</div>
  </div>
      <div class="row" >
        <div class="col-md-4"> </div>
        <div class="col-md-4">
            <div class="panel panel-success">
           <div class="panel-heading">INSCRIPTION</div>
           <div class="panel-body">
            <link rel="stylesheet" type="text/css" href="style/style.css">
             <form data-parsley-validate method="POST" class="well col-md-8 col-md-offset-2" autocomplete="off" action="traitementConnexion.php"> 
             
                  <div class="form-group">
                  <label class="control-label" >login</label>
                  <input type="text" name="login" class="form-control" placeholder="login" value="<?php  $login ?>" >
                 </div>
                  <div class="form-group">
                  <label class="control-label"  >mot de passe</label>
                  <input type="password"  name="mdp" class="form-control" placeholder="mot de passe">
                 </div>
                  <div class="form-group">
                  <label class="control-label"  >profil</label>
                   <select name="profil" >
                     <option  value="">selectionnner</option>
                         <option value="Administrateur">Administrateur</option>
                          <option value="User">User</option>
                         </select>
                         </div>
                             <!--     <button type="submit" name="valider" class="btn btn-primary" >Inscriptionr</button> -->
                             <button type="submit" name="connect" class="btn btn-primary" >Connecter</button> 
                        <!--   <a  href="loccar"  name="connect" class="btn btn-success">Connexion</a> -->
                </form>
              </div>
           </div>

</div>
    </div>
</body>
</html>