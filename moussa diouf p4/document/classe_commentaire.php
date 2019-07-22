<?php
require_once '../application/Fonction.php';

class  Commentaire {
 public $idcom;
 public $commentaire;
 public $idpub;
    function getAllCommentaire(){
   $db=getDB();
   $allPub=null;
  if (!is_null($db)) {
     $sql="SELECT * from commentaire";
      $result=$db->query($sql);
      $allPub=$result->fetchAll(PDO::FETCH_ASSOC);
     
   }
   return $allPub;
}

  function saveCommmentaire($commentaire,$idpub) :bool
{
    $db=getDB();
    $ret=false;
      if (!is_null($db))
       {
          $sql="INSERT INTO commentaire(commentaire,idpub)values(:commentaire,:idpub)";
          $element=$db->prepare($sql);
          $element->execute(array(
            ':commentaire' => $commentaire,
            ':idpub' => $idpub
             ));
          $ret=true;
  }else{
    echo "erreur de connexion a la basse";
  }
  return $ret;
}
 
function getCommentaireByPub($idpub){
   $db=getDB();
   $allcom=null;
  if (!is_null($db)) {
   $sql="SELECT * from commentaire where idpub=$idpub order by idcom DESC";
      $result=$db->query($sql);
    $allcom=$result->fetchAll(PDO::FETCH_ASSOC);
     
   }
   return $allcom;
}
 
}


?>