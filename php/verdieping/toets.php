<?php
/*
                                        Made by ----Pepijn dik ---- 
*/
                                            //Opdracht 1
                                            $aNacht = $_POST["aNacht"];   
                                            $tKamer = $_POST["tKamer"];
                                            $apersoon = $_POST["persoon"];
                                            $ontbijt = $_POST["ontbijt"];

if($tKamer == 622) {
    if($ontbijt == 55){
        pepijn();
    }

    else{
        pepijn();
    }
}

if($tKamer == 745) {
  if($ontbijt == 55){
    pepijn();
    }
    else{
        pepijn();
    }
}
if($tKamer == 1136) {
    if($ontbijt == 55){
        pepijn();
    }
    
    else{
        pepijn();
    }
}

function pepijn(){
    $aNacht = $_POST["aNacht"];   
    $tKamer = $_POST["tKamer"];
    $apersoon = $_POST["persoon"];
    $ontbijt = $_POST["ontbijt"];
    $toerist = 0;
    $BTW = 0;
    $prijs = 0;
    $naam = "AmstelHotel";
    if(empty($apersoon)){
        echo("Voer een aantal personen in om een bestelling te maken");
    } else {
        $prijs = ($tKamer * $apersoon) + $ontbijt * $apersoon;
        $prijs = $prijs * $aNacht;
        $BTW = ($prijs / 100) * 9;
        $toerist = ($prijs / 100 * 7);
        echo("<center> <h1>De totaal prijs is &#8364 $prijs</h1><br>");
        echo("<h3>De prijs is incl 7% ToeristenBelasting &#8364 $toerist</h3><br>");
        echo("En inclusief 9% BTW. &#8364 $BTW <br>");
        echo("We Zien u snel, met Vriendelijke groet, $naam"); }
}
?>