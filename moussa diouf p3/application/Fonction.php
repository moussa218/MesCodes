<?php

function getDB()
{
	$db=null;
	try{
	$db=new PDO("mysql:dbname=db_tp3;host=127.0.0.1","root","");
		}catch(Exception $e)
		{
			echo $e;
		}
	return $db;
}
function verifieUser($login,$mdp) :bool
{
  $db=getDB();
  $return=false;
  if (!is_null($db)) {
   $sql="SELECT * from user where login=:login and mdp=:mdp";
   $element=$db->prepare($sql);
   $element->execute(array(
    ":login" => $login,
     ":mdp" => $mdp
   ));

   $result=$element->fetchAll(PDO::FETCH_ASSOC);
   $nb_ligne=$element->rowCount();
   if($nb_ligne==1 ) 
   {
      session_start();
    $_SESSION["CURRENT_USER"]=$result;
     $return=true;
    
   }
  }else{
    echo "verie votre connexion a la base de donner";
  }

  return $return;

}
/**
*   cette fonction d inserer un user inscrit dans la base
*/
function saveUser($nom,$prenom,$email,$login,$mdp) :bool
{
    $db=getDB();
    $ret=false;
      if (!is_null($db))
       {
        	$sql="INSERT INTO user(nom,prenom,email,login,mdp)values(:nom,:prenom,:email,:login,:mdp)";
        	$element=$db->prepare($sql);
        	$element->execute(array(
        		':nom' => $nom,
        		':prenom' => $prenom,
        		':email' => $email,
        		':login' => $login,
        		':mdp' => $mdp,
        		 ));
          $ret=true;
  }else{
    echo "erreur de connexion a la basse";
  }
  return $ret;
}
/**
*    cette fonction permet de recuperer tous le utilisateur dans la base de donnee
*/
function getAllUser(){
   $db=getDB();
   $alluser=null;
  if (!is_null($db)) {
   $sql="SELECT * from user";
      $result=$db->query($sql);
      $alluser=$result->fetchAll(PDO::FETCH_ASSOC);
     
   }
   return $alluser;
}
/**
*   cette fonction me permet de valider les inscrits
*/
function valider_inscri($id) :bool
{
  
  $db=getDB();
  $return=false;
  if (!is_null($db)) {
   $sql="UPDATE user set etat=1 where id=:id";
   $element=$db->prepare($sql);
   $element->execute(array(
    ":id" => $id 
   ));
   $nb_ligne=$element->rowCount();
   if($nb_ligne!=0){
    $return=true;
   }

}
 return $return;
}

    
?>