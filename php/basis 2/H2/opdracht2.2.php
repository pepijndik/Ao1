<?php
$random = array();
for($i = 0; $i <= 29; $i++){
    array_push($random,rand(1,100));
}
sort($random);
foreach($random as $i){
    echo $i. "<br/>";
}
?>
