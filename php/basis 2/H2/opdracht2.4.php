<?php
$random = array();
for($i = 0; $i <= 100; $i++){
    $random[$i] = rand(1,3)*2;   
}
echo $random[1];
?>