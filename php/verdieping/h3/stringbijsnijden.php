<?php

$naam ="1.        Jakobus de  Grote        ";
$lengte_naam=strlen($naam);
echo "$naam <br>";
echo  "De lengte van de niet bijgesneden string is: $lengte_naam <br>"; 
    
$kort=trim($naam);
echo "$kort<br>";
$lengte_kort=strlen($kort);
echo "De lengte van de bijgesneden naam is: $lengte_kort <br>";

?>
