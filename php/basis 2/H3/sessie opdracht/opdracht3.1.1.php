<?php
// opslaan als sessie2.php

session_start(); // sessie opstarten
if(isset($_SESSION['mijnid']) )
{
 echo "Bestaande sessie:".$_SESSION['mijnid']."<br/>"; // testen of nummer nog bestaat
 echo "Naar <a href='opdracht3.1.0.php'>Begin</a><br/>";
 echo "<a href='opdracht3.1.2.php'>Meld af</a><br/>";
}
else
{
 echo "Sorry je bent illegaal bezig"; // testen of nummer nog bestaat
}
?>
