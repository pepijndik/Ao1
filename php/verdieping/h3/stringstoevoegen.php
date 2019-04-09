<?php
        $voornaam ="Jan";
        $achternaam ="Cornelissen";
        $naam =$voornaam." ".$achternaam;
        echo "$voornaam <br>"; 
        echo "$achternaam <br>";
        echo  "$naam <br>";
        //second example
        $letter = array('D','i','m','e','n','s','i','e');
        $denaam= '';
        for ($i=0;$i<8;$i++){
                  $denaam=$denaam.$letter[$i];
                }echo $denaam;


?>
