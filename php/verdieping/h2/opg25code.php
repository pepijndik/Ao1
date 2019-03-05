<?php
 echo"<table border='1'>";
    
    echo "<tr><th>Getal</th><th>Kwadraat</th><th>Derdemacht</th></tr>";

for($i=1;$i<=10;$i++){
    
    $grondtal = rand(1,10);
    
    $kwad= $grondtal*$grondtal;
    
    $derdemacht = pow($grondtal,$grondtal);
    
    echo "<tr><td>$grondtal</td><td>$kwad</td><td>$derdemacht</td></tr>";
    
}


?>
