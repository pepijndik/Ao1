<?php
$vak = array("PHP","Webprogrammeren","Procesanalyse","SQL");
foreach($vak as $i){
    echo "$i<br>";
}
array_push($vak,"C#");

foreach($vak as $i){
    echo "$i<br>";
}
$vak[4]="Trends";
foreach($vak as $i){
    echo "$i<br>";
}
?>