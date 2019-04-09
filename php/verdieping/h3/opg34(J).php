<?php
/*
$voetballer= array('Hakim Ziyech','Davor Suker','Diego Maradonna','Mesmet Ozil','Michael Laudrup');



if ($coret!=substr('hakim Ziyech',1))
{
    echo "<br/> hakim Ziyech De voornaam moet met hoofdletter worden geschreven. <br/>";
}




if ($coret!=substr('micheal Laudrup',1))
{
    echo "<br/> micheal Laudrup De voornaam moet met hoofdletter worden geschreven. <br/>";
}
*/

$voetballer= array('hakim ziyech','Davor Suker','Diego Maradonna','Mesmet Ozil','Michael Laudrup');

for($i=0;$i<5;$i++)   
{

$var = substr($voetballer[$i],0,1);

if
(ord($var)>=65 && ord($var)<=95)
{
echo"is goed <br/>";
}

else
{
echo"is niet goed <br/>";

}

}
/*

{
echo $voetballer[$i],"<br/>";
}



if ($voetballer[0]=='hakim Ziyech'){
    echo "<br/> De voornaam moet met hoofdletter worden geschreven.";
  } 

  else{ "  ";}

  if ($voetballer[0]='michael Laudrup'){
    echo "<br/> De voornaam moet met hoofdletter worden geschreven.";
  } 

  else{ "  ";}


substr($voetballer,0,1)

$var = substr($voetballer,0,1)
if(ord($var)==

*/
?>