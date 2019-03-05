<?php

$getal1=$_POST["getal1"]; 
$getal2=$_POST["getal2"];

$start=$getal1;

$end=$getal2;


if 
    (empty($getal1) || empty($getal2))
    
{
      echo " U hebt het formulier niet correct ingevuld";
}

elseif($getal1==0) {}
    

    else
{
$total = ($getal1  *  $getal2);
        
echo "De oppervlakte is:"; echo (abs($total));
        
}


?>
