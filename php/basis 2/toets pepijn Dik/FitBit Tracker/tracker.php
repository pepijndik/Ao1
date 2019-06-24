<?php
$dagen = array("maandag","dinsdag","Woensdag","Donderdag","Vrijdag","Zaterdag","Zondag");
$aantal = array("11214","10514","11250","10552","10501","10316","12016");
$totaal = 0;
for($i =0; $i < 7; $i ++){
    $totaal += $aantal[$i];
} 
$gemiddeld = $totaal / 7;
echo"<p>Gemiddeld aantal stappen =</p>".$gemiddeld;
echo"<p>Dagen met meer stappen dan gemiddeld:</p>";
echo "<table border='1'>";

for ($dag = 0; $dag < 7; $dag++){
       		echo "<tr>";
            echo "<td>". $dagen[$dag]. "</td>";
           for ($punten = 0; $punten < 1; $punten++){
            echo "<td>". $aantal[$dag]. "</td>";
           }
           
                    
                 }
                 echo "</tr>";
echo "</table>";


?>