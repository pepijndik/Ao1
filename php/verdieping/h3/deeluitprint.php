<?php

        $postcode="1234PR";
        $spatie=substr($postcode,4,1);

        echo "$spatie <br>";

        if ($spatie!=" "){
            echo " De vijfde positie moet een spatie zijn" ;
          }
?>
