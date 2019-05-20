<?php

//post om zetten in variables
$getal1 = $_POST["getal1"];
$getal2 = $_POST["getal2"];

$result = 0;



//kijk welke post is gekozen
if(isset($_POST["aftrekken"]) ) {
    $result = $getal1 - $getal2;

}
elseif(isset($_POST["optrekken"]) ) {
   $result = $getal1 + $getal2;
}

elseif(isset($_POST["delen"]) ) {
   $result = $getal1 / $getal2;

}
elseif(isset($_POST["keer"]) ) {
   $result = $getal1 * $getal2;

}

//print out result
echo $result;
?>