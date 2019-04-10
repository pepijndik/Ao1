<?php
/* haalt woord op uit html */
for($i=0;$i<strlen($woord=$_POST["woord"]);$i++)
{
  /* pakt letter voor letter het woord */
$var = substr($woord[$i],0,1);


/* checkt op klinkers */
    if($var=="a") 
{
  $var="";
       
}

if($var=="e") 
{
  $var="";
       
}

if($var=="i") 
{
  $var="";
       
}

if($var=="o") 
{
  $var="";
       
}

if($var=="u") 
{
  $var="";
       
}

/*laat het resultaat zien */
echo "$var";
}
?>