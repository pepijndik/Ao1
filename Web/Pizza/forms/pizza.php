<?php
$formaat = $_POST['formaat'];
// $topping = $_POST['topping'];
$totaal = 0;

if ($formaat == '25'){
    $totaal=$totaal+7.50;
   
}

if ($formaat == '30'){
    $totaal=$totaal+10 .".-";

}

if ($formaat == '35'){
    $totaal=$totaal+12.50;

}

if ($formaat == '40'){
    $totaal=$totaal+15 .".-";
}

echo $formaat, $totaal;
?>

