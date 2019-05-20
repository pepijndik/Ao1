<?php

echo "<table border = '1'>";

for($x = 0; $x < 8; $x++){
    echo "<tr>";
    for($y = 0; $y < 8; $y++){ 
        $getal[$x][$y] = rand(0, 1);
        echo "<td>".$getal[$x][$y]."</td>";
    }
}


echo "<tr>";

echo "</table>";
?>