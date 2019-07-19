<html>
<head>
<meta charset="utf-8">
<title>Registration | Pdik</title>
<link rel="stylesheet" href="css/register.css" />
</head>
<body>
<?php
//connectie naar mysql database
//simpelen Login HTML forum
require('config.php');
if (isset($_REQUEST['username'])){
	$username = stripslashes($_REQUEST['username']);
	$username = mysqli_real_escape_string($con,$username); 
	$email = stripslashes($_REQUEST['user_email']);
	$email = mysqli_real_escape_string($con,$email);
	$password = stripslashes($_REQUEST['user_password']);
	$password = mysqli_real_escape_string($con,$password);
	$rank = 3;
        $query = "INSERT into `users` (username, user_password, user_email, user_rank)
VALUES ('$username', '".md5($password)."', '$email', '$rank')";
        $result = mysqli_query($con,$query);
        if($result){
            echo "<div class='form'>
<h3>Sucses Vol geregistreert</h3>
<br/>Click here to <a href='login.php'>Login</a></div>";
        }
    }else{
?>
	<form class="login" action="" method="post">
    <h1 class="login-title">Register | Pdik</h1>
		<input type="text" class="login-input" name="username" placeholder="Username" required />
    <input type="text" class="login-input" name="user_email" placeholder="Email Adress">
    <input type="password" class="login-input" name="user_password" placeholder="Password">
    <input type="submit" name="submit" value="Register" class="login-button">
  <p class="login-lost">Al geregistreert? <a href="login.php">Login Hier</a></p>
  </form>
 
<?php } ?>
</body>
</html>