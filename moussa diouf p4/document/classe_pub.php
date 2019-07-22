<?php
require '../application/Fonction.php';

class  Publication {
 public $idpub;
 public $pub;
 public $nom;
  public $entour='p';
  public function entour($html){
    
    return  "<{$this->entour}>{$html}</{$this->entour}>";
  }
	function savePublication($pub,$nom) :bool
{
    $db=getDB();
    $ret=false;
      if (!is_null($db))
       {
        	$sql="INSERT INTO Publication(pub,nom)values(:pub,:nom)";
        	$element=$db->prepare($sql);
        	$element->execute(array(
        		':pub' => $pub,
        		':nom' => $nom
        		 ));
          $ret=true;
  }else{
    echo "erreur de connexion a la basse";
  }
  return $ret;
}

function input($vall,$type){
      return $this->entour("<div class='form-group'><label class='contol-label'>"."NOM :".""."</label><br><input type='".$type."' name='".$vall."' placeholder='votre nom...' required='true'>  </div>");
  }

function space_pub($vall){
    return $this->entour("<textarea  name='".$vall."' required='true'>  </textarea>");
  }

  function submit(){
    return "<button type='submit' class='btn btn-primary' name='post_pub'>PUBLIER</button> ";
  }

function getAllPub(){
   $db=getDB();
   $allPub=null;
  if (!is_null($db)) {
   $sql="SELECT * from publication";
      $result=$db->query($sql);
      $allPub=$result->fetchAll(PDO::FETCH_ASSOC);
     
   }
   return $allPub;
}

 

}

?>