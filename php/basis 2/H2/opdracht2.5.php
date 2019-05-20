<?php
$random = array();
for($i = 0; $i <= 100; $i++){
    $getal = rand(1,6) * 2;
    
    array_push($random,$getal);
   
}
echo $random[1];
?>