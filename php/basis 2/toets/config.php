<!--Config Login SyS -->
<?php
//Config naar MYSQL

//Default user en geen wachtwoord 
$host = "localhost";
$username = "root";
$pass = "";
$db = "mobox";

$con = mysqli_connect($host,$username,$pass,$db);
if (mysqli_connect_errno())
  {
  echo "Failed to connect to MySQL: " . mysqli_connect_error();
  }
?>