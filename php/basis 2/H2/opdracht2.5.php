<?php 

$words = $_POST['5words'];
$thing = explode(" ", $words);
for ($i=0; $i < count($thing); $i++) { 
	echo "$thing[$i]<br>";
	}

?>