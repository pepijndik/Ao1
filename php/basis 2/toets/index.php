<!--PHP login System by Pdik Systems -->
<?php
include("auth.php");
//Simpelen pagina welke beveilig is 
?>
<!DOCTYPE html>
<html>
<head>
<meta charset="utf-8">
<title>Welcome User</title>
<link rel="stylesheet" href="css/login.css" />
</head>
<body>
<div class="form">
<h1 >Welcome <?php echo $_SESSION['username']; ?>!</h1>
<p >This is your secured index.</p>
<p><a href="dashboard.php">Your Dashboard</a></p>
<a href="logout.php">Logout</a>
</div>
</body>
</html>