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

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Opdracht 3.3</title>
</head>
<body>
    <p>Dit is een interessante website</p>
    <a href="/toegang.php">
</body>
</html>