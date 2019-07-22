
<?php
session_start();
$titre="index_admin";
require_once "../application/header.php";
require_once "../application/Fonction.php";
$toutUser=getAllUser();

if (isset($_GET['afterValid'])) {
	echo  "<script>alert('valider avec success')</script>";
}

?>

<div class="container">
	<table class="table table-bordered table-striped">
		<thead>
			<tr>
				 <th>Id</th>
				<th>Prenom</th>
				<th>Nom</th>
				<th>Email</th>
				<th>Login</th>
				<th>ACTION</th>
			</tr>
			 <tbody>
			 	<?php  foreach ($toutUser as $key => $value) : ?>
					 		 <tr>
					 		       <td><?php echo $value["id"];  ?></td>
					 		        <td><?php echo $value["prenom"];  ?></td>
					 		         <td><?php echo $value["nom"];  ?></td>
					 		          <td><?php echo $value["email"];  ?></td>
					 		           <td><?php echo $value["login"];   ?></td>
					 		           <td>
					 		           		<?php  if(($value["etat"])==false) {?>
					 		           	     <form method="POST" action="../controller/TraitementInscription.php">
					 		           	     
					 		           	     	<input type="hidden" name="id" value=<?= $value["id"]; ?> >
					 		           	     	<button type="submit" class="btn btn-warning" name="valider_ins">valider</button>					 		      </form>
					 		           	  
					 		           	      <?php }else{ ?>
					 		           	      	<a href="#" class="btn btn-success">deja valider</a>	

					 		           	      <?php } ?>




					 		           	       
					 		           	     
					 		           </td>

					 	   </tr>
			<?php 	endforeach;  ?>
			 	
			 </tbody>
		</thead>
	</table>
</div>

<?php
require_once "../application/footer.php";
 
?>