<?php
$random = array();
for($i = 0; $i <= 100; $i++){
    $random[$i] = rand(1,3)*2;   
$zes =0;
for($i=1;$i<=100;$i++)
{
    
    $num[$i] = rand(1,3) * 2;
    echo "$num[$i] <br/>"; 
    if($num[$i] == 6)
    {
        
        $zes ++;
    
    }
}

echo("aantal" .$zes);
?>
