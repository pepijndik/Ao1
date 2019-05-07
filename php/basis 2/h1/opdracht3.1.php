<?php

/* cilinder 1*/

$cl1_hoogte = 10;
$cl1_diameter = 5;

$cl1_inhoud = inhoud($cl1_diameter,$cl1_hoogte);
echo"$cl1_inhoud <br/>";


/* cilinder 2*/

$cl2_hoogte = 155;
$cl2_diameter = 5;

$cl2_inhoud = inhoud($cl2_diameter,$cl2_hoogte);
echo"$cl2_inhoud <br/>";


/* cilinder 3*/

$cl3_hoogte = 8;
$cl3_diameter = 7;

$cl3_inhoud = inhoud($cl3_diameter,$cl3_hoogte);
echo"$cl3_inhoud <br/>";

/* functie */
function inhoud($diameter, $hoogte)

{ 
    $straal = $diameter / 2; 

    $opper= pi() * pow($straal,2);
    $inhoud = $opper * $hoogte;

    return $inhoud;
}

?>