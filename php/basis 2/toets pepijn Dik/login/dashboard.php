<!--PHP login System by Pepijn dik (https://pdik.nl) -->
<?php
require('config.php');
include("auth.php");
//AUth.php kijkt of de user nog ingelogd is.
//Dit is een simpele Pagina welke beveiligd is
?>
<!DOCTYPE html>
<html>
<head>
<meta charset="utf-8">
<title>Dashboard - Secured Page</title>
<link rel="stylesheet" href="css/login.css" />
</head>
<body>
<div class="form">
<p>Dashboard</p>
<p>This is another secured page.</p>
<p><a href="index.php">Index</a></p>
<a href="logout.php">Logout</a>
</div>
</body>
</html>