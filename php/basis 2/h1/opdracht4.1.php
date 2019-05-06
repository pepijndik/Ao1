<?php
bereken(120);
/*
Function
*/
function bereken($sec){
    $min = floor($sec / 60);
    $restseconde = $sec - ($min*60);
    echo("Aantal Minuten: $min  aantal Seconden over: $restseconde");
}
?>