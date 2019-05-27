<?php

for ($x=0; $x<10; $x++){
    for($y=0; $y < 10; $y ++){
        $vlak[$x][$y] = "...";
    }


}
$random_aantal = rand(0,45);

for ($t=1; $t<=$random_aantal; $t++){
    $randomX = rand(0,10);
    $randomY = rand(0,10);
    
    $vlak[$randomX][$randomY] = "..x..";
    
    }

    echo "<table border='1'>";
    for ($x = 0; $x < 10; $x++){
                echo "<tr>";
               for ($y = 0; $y < 10; $y++){
                echo "<td>".$vlak[$x][$y]."</td>";
               }
        echo "</tr>";
    }
   echo "</table>";
       
?>
