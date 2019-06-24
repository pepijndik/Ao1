<!--PHP login System by Pepijn dik(www.pdik.nl) -->
<?php
session_start();
//destroy sessie en ga daarna naar login
if(session_destroy())
{
header("Location: login.php");
}
?>