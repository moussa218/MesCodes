<?php

class Connexion
{
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
		return "<button type='submit' name='OK' class='btn btn-primary' >Connexion</button> ";
	}
	function reset(){
		return  " <a href='Form_Inscription.php' class='btn btn-success'>Inscription</a>";
	}
}

 

 
?>