<?php
bereken(530);

function bereken($sec){
    $min = floor($sec / 60);
    $restseconde = $sec - ($min*60);
    echo("Aantal Minuten: $min  aantal Seconden over: $restseconde");
}
?>