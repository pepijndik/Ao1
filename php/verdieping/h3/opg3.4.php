<?php

$naam = array('Pep', 'Dope', 'Samir Dope', 'Mesmet ozil', 'Michael Laudrup');


for($i=0; $i<5; $i++){
    $var = substr($naam[$i],0,1);
    if(ord($var)>65 && ord($var) <90){
        echo(" Goed");
    } else{
        echo("Fout lul");
    }
}

?>
