 
<?php
 
$titre="formInscr";
include '../application/header.php';
                  include "Inscription.php";
				   $form=new Inscription();

?>
	     <div class="container">
			  <form  method="POST" action="../controller/TraitementInscription.php" class="well col-md-6 col-md-offset-3" autocomplete="off"> <!--col-md-offset-3-->
			    <?php
			            
			          echo $form->input("nom","text");
			          echo $form->input("prenom","text");
			          echo $form->input("email","email");
			          echo $form->input("login","text");
			          echo $form->input("mdp","password");
			          echo $form->submit();
			          echo $form->fconn();

				?>
				</form>
   </div>
 <?php
   include "../application/footer.php";
 ?>
		