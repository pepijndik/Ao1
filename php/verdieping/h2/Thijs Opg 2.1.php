<?php
$getal1=$_POST['getal1'];
$getal2=$_POST['getal2'];

if(is_numeric($getal1)==false){
	echo"U heeft niet correct het furmulier ingevuld";
}
elseif(is_numeric($getal2)==false){
	echo"U heeft niet correct het furmulier ingevuld";
}
 else {
$getal = $getal1+$getal2;
echo "$getal";
 }
?>