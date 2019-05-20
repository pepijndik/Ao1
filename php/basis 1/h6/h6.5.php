<?php
$tel=1;
$telvol=0;
while($tel <= 100){
    $getal = rand(1,10);
    

    if($getal > 5.5) 
    {
        $telvol = $telvol +=1;
    }
    $tel += 1;
}
echo "$telvol <br/>";
?>