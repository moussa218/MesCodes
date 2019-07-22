
<?php
session_start();
$titre="index_pub";
require_once "../application/header.php";

require_once "../document/classe_pub.php";
require_once "../document/classe_commentaire.php";

$obj=new Publication();


$toutPub=$obj->getAllPub();


if (isset($_GET['afterPub'])) {
	//echo  "<script>alert('valider avec success')</script>";
	?>
     <span style="color: green ">votre pub a ete bien poste</span>
	 <?php
}

if (isset($_GET['afterCom'])) {
	//echo  "<script>alert('valider avec success')</script>";
	?>
     <span style='color:blue'>votre commentaire a ete bien poste</span>
	 <?php
}
 ?>
 
		 <div class="row">
		 	<div class="col-md-3"> </div>
		 	<div class="col-md-6">
		 		<nav class="navbar navbar-expand-lg navbar-light bg-light">
  <a style="background-color: #fea" class="navbar-brand" href="">facebook.com</a>
		       <h1 style="font-style: italic; font-weight: bolder; text-align: center; color: #fea;" >Page des Publication</h1>
		       </nav>
		       </div>
		</div>
	


<div class="container">
	<table class="table table-bordered " >
			<?php  foreach ($toutPub as $key => $value) : ?>
			
		       <tr>
		        
				<th><?php echo $value["nom"];  ?></th>
			</tr>
	<tr>
		<td style='color:white'><?php echo $value["pub"];  ?></td>

	</tr>
			<tr>
						<td> 
								<div class="row">
									<div class="col-md-2"></div>
									<div class="col-md-3">

										<table class="table table-bordered table-striped">
											<?php

											$objcom=new Commentaire();

											$comment=$objcom->getCommentaireByPub($value["idpub"]);
											foreach ($comment as $key => $cm) : ?>
											
													<tr>
														<td><?php echo $cm["commentaire"]."<br/>";  ?></td>
													</tr>

											 <?php		endforeach; ?>
											 
										
											
										</table>
										
									</div>
								</div>

								 <div class="row">
								 	<div class="col-md-2"></div>
								  		<form method="POST" action="../controller/TraitementCommentaire.php">
								 	     <textarea  name="commentaire" placeholder="commentez ici ..." required='true'></textarea>
								 	     <input type="hidden" name="idpub" value=<?= $value["idpub"]; ?> >
								 	     <button class="btn btn-success" name="commente">commentaire</button>
								 </form>
								 </div>
					 </td>
			 </tr>
         	<?php 	endforeach;  ?>
	 </table>
	 <a href="../document/form_pub.php" class="btn btn-info">AddPub</a>
</div>
<?php
require_once "../application/footer.php";
?>