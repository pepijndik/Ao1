<?php

if (isset($_COOKIE['username']))
{
echo $_COOKIE['username'];
}
else 
{
echo "de cookie is verlopen";
}

?>