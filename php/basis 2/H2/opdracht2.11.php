<?php
$mogelijk = array("...","-x-");


for ($x = 0; $x < 2; $x++){
    $random = rand(0,1);
    
  }
echo "<table border='1'>";
for ($x = 0; $x < 10; $x++){
  
     
       		echo "<tr>";
            echo "<td>".  $mogelijk[$random]. "</td>";

           for ($y = 0; $y < 10; $y++){
            echo "<td>". $mogelijk[$random]. "</td>";
           }
           
                    
                 }
                 echo "</tr>";
                 
                 
echo "</table>";
?>
