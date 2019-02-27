<?php
$tel=1;
$totaal=0;
while($tel <= 20) {
    $totaal = $totaal + $tel;
    $tel = $tel += 1;
}
echo "Totaal waarde = $totaal";
?>