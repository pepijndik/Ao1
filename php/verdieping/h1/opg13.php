<?php
$rang = $_POST['rang'];
$aantal = $_POST['aantal']; //aantal kaartjes 
$korting = $_POST['korting']; //korting 20%
$prijs = 0;



if($rang == 80){
    if($korting == 1){
        $prijs = $rang * $aantal / 1.20;
        echo("De prijs is $prijs");
    } else{ $prijs = $rang*$aantal;
        echo("De prijs is $prijs");}
    
}
elseif($rang == 50){
    if($korting == 1){
        $prijs = $rang * $aantal / 1.20;
        echo("De prijs is $prijs");
    } else{ $prijs = $rang*$aantal;
        echo("De prijs is $prijs");}
}
elseif($rang == 40){
    if($korting == 1){
        $prijs = $rang* $aantal / 1.20;
        echo("De prijs is $prijs");
    } else{ $prijs = $rang*$aantal;
        echo("De prijs is $prijs");}
}


?>
2
