<?php
$getal = $_POST["getal1"];
$btwtarief = $_POST["rbtarief"];
$totaalbtw = $getal * $btwtarief;

if($btwtarief == 0) {
    echo "0% Dit product is van BTW vrijgesteld <br/> Prijs = $totaalbtw";

}
elseif($btwtarief == 1.06){
    echo "6% Dit product valt in het lage BTW-Tarief <br/> Prijs = $totaalbtw";
}
else{
    echo "21% Dit product valt in het hoge BTW-Tarief <br/> Prijs = $totaalbtw";
}

?>