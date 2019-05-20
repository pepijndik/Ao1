<?php
$getal = $_POST["getal1"];
$btwtarief = $_POST["rbtarief"];
$totaalbtw = $getal * $btwtarief;
echo "Bedrag met BTW <br/> $totaalbtw";
?>