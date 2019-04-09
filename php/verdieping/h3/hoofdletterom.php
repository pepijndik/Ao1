<?php

$zin="Mooi Prut";
$nwe_zin="";

for ($t=0;$t<strlen($zin);$t++) {
	$ascletter=ord(substr($zin,$t,1));	//bepaal asciicode
	
	if ($ascletter>=97 && $ascletter<= 122) { 		//als kleine letter?
		$ascletter=$ascletter - 32; 			//maak groot
	} 
	
	elseif ($ascletter>=65 && $ascletter<= 90) { 	//als hoofdletter?
	    $ascletter=$ascletter+32; 			//maak klein
	}  
	
	$nwe_zin = $nwe_zin.chr($ascletter); 		//bouw nieuwe zin
}
    echo "Eerste zin: $zin<br>";
    echo "Nieuwe zin: $nwe_zin"; 
?>
