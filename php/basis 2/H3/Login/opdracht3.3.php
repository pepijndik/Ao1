<?php

$enteredName=$_POST['naam'];
$enteredPassword=$_POST['wachtwoord'];

if ($enteredName=="pepijn" && $enteredPassword=="pep"){
   
   		$url="Location: geheim.php";
		   header($url);
		   //opslaan als sessie.php
			session_start(); // sessie starten

			//Testen of de gemaakte sessie nog niet bestaat
			if(!isset($_SESSION['klantnummer']) ){
  			$_SESSION['klantnummer'] = uniqid(); // uniek nummer genereren
			  echo "Sessie gegenereerd.<br/>";
		}
  		 exit;
}
else{
	echo" <center><h1>Wachtwoord of email is niet juist</h1></center>";
}
 
?>