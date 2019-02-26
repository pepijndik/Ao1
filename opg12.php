<?php


$inkoopprijs = $_POST['inkoopprijs'];
$winst = $_POST["winst"];
$verkoopprijs= $inkoopprijs + ($inkoopprijs/100*$winst);
echo("de verkoop prijs is, $verkoopprijs");



?>