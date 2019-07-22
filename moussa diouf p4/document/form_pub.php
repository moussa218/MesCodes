 
<?php
 


 

$titre="publication";
include '../application/header.php';
                  require_once "classe_pub.php";
				   $form=new Publication();

?>

	     <div class="container">
			  <form  method="POST" action="../controller/TraitementPub.php" class="well col-md-6 col-md-offset-3"> <!--col-md-offset-3-->
			    <?php
			            echo $form->input("nom","text");
			           echo $form->space_pub("pub");
			          echo $form->submit();
			         
                        
				?>
				</form>
			</div>

 <?php
   include "../application/footer.php";
 ?>