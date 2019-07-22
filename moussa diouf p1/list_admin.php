<!DOCTYPE html>
<html>
<head>
	<title>inscription</title>
	<meta charset="utf-8">
              <link rel="stylesheet" type="text/css" href="style/style.css">
	<link rel="stylesheet" type="text/css" href="style/bootstrap-cerulean.min.css">
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
                     <div class="panel-heading">LISTE DES Administrateur</div>
                     <div class="panel-body">
                              
      <tr>
        <th>Id Admin</th>
        <th>NomComplet Admin</th>
        <th>Login Admin</th>
         <th>Mdp Admin</th>
        <th >ACTION</th>
        <th >ACTION</th>
      </tr>
      <tr>
        <?php
                    require_once 'db.php';
                         $liste=list_admin();
                            while ($admin=mysqli_fetch_row($liste)) {
                              echo "<tr>
                                         <td>$admin[0]</td>
                                        <td>$admin[1]</td>
                                       <td>$admin[2]</td>
                                        <td>$admin[3]</td>
                                    
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