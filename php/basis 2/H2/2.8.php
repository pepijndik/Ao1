<?php

$Biz = array 
(
  		array("Batavus",745,20),
  		array("Peugot",560,24),
 		 array("Gazelle",499,11),
  		array("Rih",550,7)
 	 );

echo "<table border='1'>";
echo "<b><td><b>Merk<b/><td/><b>Prijs<b/><td><b>Vooraad<b/>";
for ($rij = 0; $rij < 4; $rij++){
				   echo "<tr>";
				   
     			 for ($kolom = 0; $kolom < 3; $kolom++){
					
								   echo "<td>".  $Biz[$rij][$kolom]. "</td>";
								   
                		 }
                 		echo "<tr>";
}
echo "</table>";
?>
