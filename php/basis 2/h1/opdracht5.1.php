<?php

rechthoek($_POST["lengte"]);

function rechthoek($lengte){
    $ab = pow(3,2);
    $bc = pow(4,2);
    $ac = sqrt($ab + $bc);
    if($ac == $lengte){
        echo("True");
    } else 
    {
        echo("False");
    }
}
?>