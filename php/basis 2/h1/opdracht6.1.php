<?php

//post om zetten in variables
$aantal = $_POST["aantal"];
$keuze = $_POST["rang"];
$totaal = 0;


//check choise rang
if($keuze == 1) {
  $totaal = 50 * $aantal;

}
elseif($keuze == 2) {
    $totaal = 30 * $aantal;
}


//print out result
echo $totaal;
?>