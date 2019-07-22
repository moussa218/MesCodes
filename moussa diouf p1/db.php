<?php
    
    function getconnection()
    {
    	$host='localhost';
    	$user='root';
    	$pwd='';
    	$db='tp_php';
    	$connect=mysqli_connect($host,$user,$pwd,$db);
    	return $connect;
    }
    function executeSQL($sql){
    	$execute=mysqli_query(getconnection(),$sql);
    	return $execute;
    }


     function ajout_user($nom,$prenom,$telephone,$email,$login,$mdp){
     	$sql="INSERT INTO user values(null,'$nom','$prenom','$telephone','$email','$login','$mdp')";
     	return executeSQL($sql);
     }
     function list_user(){
     	$sql="SELECT * FROM user ";
     	return executeSQL($sql);
     }


      function ajout_admin($nomcomplet,$login_admin,$mdp_admin){
        $sql="INSERT INTO admin values(null,'$nomcomplet','$login_admin','$mdp_admin')";
        return executeSQL($sql);
     }
     function list_admin(){
        $sql="SELECT * FROM admin ";
        return executeSQL($sql);
     }

?>