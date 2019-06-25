<?php
if(!isset($_SESSION['mijnid']) )
{
  ?>
  <!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Document</title>
</head>
<body><center>
<form class="box" action="opdracht3.3.php" method="post">
              <h1>Login</h1>
              <input type="text" name="naam" placeholder="naam">
              <input type="password" name="wachtwoord" placeholder="wachtwoord"><br>
              <input type="submit" name="" value="Login">
            </form>
            </center>
</body>
</html>
<?php
}
else{
  session_destroy();
  echo"destroy";
}
?>
