<?php 
$voor=$_POST['voornaam'];
$achter=$_POST['achternaam'];
$keuze=isset($_POST['keuze']);
$Keuze='';

if($keuze==1){
	$Keuze='Patatje oorlog';
}

if($keuze==2){
	$Keuze='Kapsalon';
}
echo "Jouw naam is $voor $achter. en je eet graag $Keuze";
?>
