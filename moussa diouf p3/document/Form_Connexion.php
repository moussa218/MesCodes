 
<?php
 
$titre="index";
include '../application/header.php';
                  include "Connexion.php";
				   $form=new Connexion();
if(isset($_GET['okinscrit'])){
	echo  "<script>alert('inscription reussi cliquer sur ok pour connecter')</script>";
}
if(isset($_GET['mauvaisConnection'])){
	echo  "<script>alert('veuillez entrer une login et un mots de passe correspondant a votre compte')</script>";
}
?>

	     <div class="container">
			  <form  method="POST" action="../controller/TraitementConnexion.php" class="well col-md-6 col-md-offset-3"> <!--col-md-offset-3-->
			    <?php
			            
			           echo $form->input("login","text");
			          echo $form->input("mdp","password");
			          echo $form->submit();
			          echo $form->reset();
                        
				?>
				</form>
			</div>

 <?php
   include "../application/footer.php";
 ?>
		