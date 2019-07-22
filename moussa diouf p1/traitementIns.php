<?php
       require_once 'db.php';
    	$nom=$_POST['nom'];
        $prenom=$_POST['prenom'];
        $telephone=$_POST['telephone'];
        $email=$_POST['email'];
        $login=$_POST['login'];
        $mdp=$_POST['mdp'];

        //if(empty($nom)){
        //header('location/:./inscr.php');
        //}
       // try {
       //     $bdd=new PDO("mysql:dbname=tp_php;host=localhost;port:8889","root","");
       // var_dump($bdd);
    
       // } catch (Exception $e) {
         //   echo "Merci ";
       // }
       ajout_user($nom,$prenom,$telephone,$email,$login,$mdp);
       header('location:./inscription.php?resultat');
       

?>