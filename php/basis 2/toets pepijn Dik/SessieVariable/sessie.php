<?php
//Pepijn dik
session_start();

if(!isset($_SESSION['mijnid'])){
    $_SESSION['mijnid']=uniqid();
    echo"Sessie gegenereerd. <br/>";

}
echo "De sessieVariable heeeft als waarde:" .$_SESSION['mijnid'];
echo "<br/r><a href='https://pdik.nl'>Ga Naar Geheime Pagina</a>";
?>