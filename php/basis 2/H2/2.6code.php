<?php

$pizza  = $_POST["N1"];
$pieces = explode(" ", $pizza);

echo $pieces[rand(0,4)];echo"<br/>";
echo $pieces[rand(0,4)];echo"<br/>";
echo $pieces[rand(0,4)];echo"<br/>";


?>