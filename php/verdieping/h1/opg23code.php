<?php

for ($i=0;$i<10;$i++)
{ 
$getal[$i]=rand("-21","21");
echo"$getal[$i]<br/>";
}
    
echo "maar nu alles gesorteerd <br/>";



for ($i=0;$i<10;$i++)
{

rsort($getal);
echo"$getal[$i]<br/>";
}

?>
