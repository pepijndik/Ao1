<?php
//opslaan als sessie.php
session_start(); // sessie starten

//Testen of de gemaakte sessie nog niet bestaat
if(!isset($_SESSION['mijnid']) )
{
  $_SESSION['mijnid'] = "kees"; // uniek nummer genereren
  echo "Sessie gegenereerd.<br/>";
}
echo $_SESSION['mijnid']; // print id
echo "<br/>Naar <a href='opdracht3.1.1.php'>Vervolg</a>";
?>
