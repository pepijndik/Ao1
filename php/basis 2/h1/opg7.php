<?php

//Afschrijvingskosten per jaar = aanschafwaarde/verwachte levensduur in jaren./
$aanschaf = $_POST["aanschaf"];
$levensduur = $_POST["levensduur"];
$afschrijv = som($levensduur,$aanschaf);
$som2 = $aanschaf - $afschrijv;

function som($levensduur,$aanschaf)
   {    $afschrijv = $aanschaf / $levensduur;
      return $afschrijv;
    }
  
  


    echo "De jaarlijkse afschrijving is:";echo (floor($afschrijv));
    echo"<table border='1'>";

    echo "<tr><th>jaar</th><th>waarde begin van het jaar</th><th>waarde van het einde van het jaar</th></tr>";
     
   for ($teller=1;$teller<=8;$teller++)         {  
  
            echo "<tr><td>$teller</td><td>";echo (floor($aanschaf)); echo"</td><td>";echo (floor($som2)); echo"</td></tr>";
            $aanschaf -= $afschrijv;
            $som2 = $som2 - $afschrijv;
   }
 



?>