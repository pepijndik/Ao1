<?php
session_start(); // sessie opstarten
if(isset($_SESSION['mijnid']) )
{
 echo "Welkom ".$_SESSION['mijnid']."<br/>"; // testen of nummer nog bestaat

 ?>
 
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>geheim</title>
</head>
<body>
    <h1>Geheime Site</h1>
</body>
</html>
<?php
 echo "Naar <a href='opdracht3.3.login.php'>Begin</a><br/>";
 echo "<a href='opdracht3.3.login.php'>Meld af</a><br/>";
}
else
{
 echo "Niet ingelogd"; // testen of nummer nog bestaat
}
?>