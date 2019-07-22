<?php
 
class Inscription
{
	public $nom;
	public $prenom;
	public $email;
	public $login;
	public $mdp;
	public $entour='p';
	public function getLogin(){
		return $this->login;
	}
	public function setLogin($login){
		$this->login=$login;
	}
	public function getMdp(){
		return $this->mdp;
	}
	public function setMdp($mdp){
		$this->mdp=$mdp;
	}
	 
		public function entour($html){
		
		return  "<{$this->entour}>{$html}</{$this->entour}>";
	}
	function input($vall,$type){
			return $this->entour("<div class='form-group'><label class='contol-label'>".$vall."</label><br><input type='".$type."' name='".$vall."' required='true'>  </div>");
	}
	function submit(){
		return "<button type='submit' class='btn btn-primary' name='valider'>Inscrire</button> ";
	}
	function fconn(){
		return  " <a href='Form_Connexion.php' class='btn btn-success'>Connecter</a>";
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
}

 

 
?>