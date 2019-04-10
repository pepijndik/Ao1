<?php
/* het totaal bedrag */

$totaal=0;

$kamer= $_POST["kamer"];

/*radio en checkboxes*/

if ($kamer=="1")
{
    $totaal = $totaal+622;

}

else{echo " ";}



if ($kamer=="2")
{
  $totaal = $totaal+745;

}

else{echo " ";}




if ($kamer=="3")
{
  $totaal = $totaal+1136;

}

else{echo " ";}





if(isset($_POST["ontbijt"]))
{
  $totaal = $totaal+55;
}

else{echo " ";}



/*nachten*/
if($_POST["aantal-N"]=="6")
{$totaal = $totaal * 6;}

if($_POST["aantal-N"]=="3")
{$totaal = $totaal * 3;}

if($_POST["aantal-N"]=="1")
{ $totaal = $totaal;}


else{echo " ";}




/* personen */

if($_POST["personen"]=="4 per")
{$totaal = $totaal * 4;}

if($_POST["personen"]=="2 per")
{$totaal = $totaal * 2;}

if($_POST["personen"]=="1 per")
{$totaal = $totaal;}


else{echo " ";}


/* totaal weergaven */ 


$totaal1 = $totaal / 100 * 7; 
$totaal2 = $totaal / 100 * 9;

echo "De totaalprijs is &#8364 $totaal <br/>";
echo "Deze prijs is inclusief 7% toeristenbelasting: &#8364 $totaal1 <br/>";
echo "En inclusief 9% BTW: &#8364 $totaal2 <br/>";


?>