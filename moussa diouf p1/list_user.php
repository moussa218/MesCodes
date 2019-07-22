<!DOCTYPE html>
<html>
<head>
	<title>inscription</title>
	<meta charset="utf-8">
	<link rel="stylesheet" type="text/css" href="style/bootstrap-cerulean.min.css">
              <link rel="stylesheet" type="text/css" href="style/style.css">
</head>
<body>
  <div class="row"> 
  <div class="col-md-3"></div>
  <div class="col-md-6">
         <div class="nav navbar-inverse">
    <div class="container-fluid">
      <ul class="nav navbar-nav">
        <li><a href="loccar/index.php">Accueil</a></li>
        <li><a href="#">RECHERCHE USE</a></li>
        <li><a href="#">RECHERCHE ADMINISTRATEUR</a></li>
      </ul>
      
    </div>
  </div>


  </div>
</div>
  
      <div class="row" >
        <div class="col-md-2"> </div>
        <div class="col-md-8 ">
        	  <div class="panel panel-success">
                     <div class="panel-heading">LISTE DES USER</div>
                     <div class="panel-body">
                               <table class="table table-bordered table-striped">
      <tr>
        <th>iD USER</th>
        <th>user NOM</th>
        <th>user PRENOM</th>
         <th>user TELEPHONE</th>
        <th>user EMAIL</th>
        <th>user LOGIN</th>
         <th>user PWD</th>
        <th >ACTION</th>
        <th >ACTION</th>
      </tr>
      <tr>
        <?php
                    require_once 'db.php';
                         $liste=list_user();
                            while ($user=mysqli_fetch_row($liste)) {
                              echo "<tr>
                                         <td>$user[0]</td>
                                        <td>$user[1]</td>
                                       <td>$user[2]</td>
                                        <td>$user[3]</td>
                                         <td>$user[4]</td>
                                          <td>$user[5]</td>
                                           <td>$user[6]</td>
                                       <td><a href='#' class='btn btn-info btn-block' >SUPPRIMER</a></td>
                                  <td><a href='#' class='btn btn-warning btn-block'  >MODIFIER</a></td>
                                    </tr>";
                                      

                         }
        ?>
      </tr>
      </table>
                      </div>
                  </div>
            
     </div>
    
</body>
</html>