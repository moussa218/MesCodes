<?php

if(isset($_POST['connect'])){
       require_once 'db.php';
    //	$nomcomplet=$_POST['nomcomplet'];
        $login_admin=$_POST['login'];
        $mdp_admin=$_POST['mdp'];
        
       $profil=$_POST['profil'];
        //if(empty($nom)){
        //header('location/:./inscr.php');
        //}
       // try {
       //     $bdd=new PDO("mysql:dbname=tp_php;host=localhost;port:8889","root","");
       // var_dump($bdd);
    
       // } catch (Exception $e) {
         //   echo "Merci ";
       // 
         if (strcmp($profil,"Administrateur")==0) {
            $liste=list_admin();
            $ok1=0;
            $ok2=0;
         while ($admin=mysqli_fetch_row($liste)) {
              if (strcmp($admin[2],$login_admin)==0) {
                $ok1=1;
              }
               if (strcmp($admin[3],$mdp_admin)==0) {
                $ok2=1;
              }
         }
               if ($ok1==1 && $ok2==1) {

                     header('location:./page_connection/index.php');
                 }else{
              header('location:./connexion.php?erreur');
               }
        
       } 

       //Pour un user 

              if (strcmp($profil,"User")==0) {
            $liste=list_user();
            $ok1=0;
            $ok2=0;
         while ($user=mysqli_fetch_row($liste)) {
              if (strcmp($user[5],$login_admin)==0) {
                $ok1=1;
              }
               if (strcmp($user[6],$mdp_admin)==0) {
                $ok2=1;
              }
         }
               if ($ok1==1 && $ok2==1) {

                    header('location:./page_connection/index.php');
               }else{
                 header('location:./connexion.php?erreur');
               }
        
       } 

     }

?>