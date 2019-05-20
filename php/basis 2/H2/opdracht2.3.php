<?php
$random = array();
for($i = 0; $i <= 49; $i++){
    array_push($random,rand(1,10));
}
$random = array_filter($random);
$average = array_sum($random)/count($random);
echo $average;
?>