<?php
require_once "config.php"

?>
<!doctype html>
<html>
    <head>
        <title>registeer pdik</title>
        <link rel="stylesheet" type="text/css" href="register.css">
    </head>
    <body>
    <center>  
    <div class="header">
            <h2>registeer</h2>
        </div>

        <form action="includes/signup.inc.php" method="POST">
            <div class="input-group">
                <label>Username</label>
                <input type="text" name="uid">
            </div>
            <div class="input-group">
                <label>Email</label>
                <input type="text" name="email">
            </div>
            <div class="input-group">
                <label>Voornaam</label>
                <input type="text" name="first">
            </div>
            <div class="input-group">
                <label>achternaam</label>
                <input type="text" name="last">
            </div>
            <div class="input-group">
                <label>wachtwoord</label>
                <input type="password" name="password">
            </div>
            <div class="input-group">
                <label>verifeer wachtwoord</label>
                <input type="password" name="password2">
            </div>
            <div class="input-group">
                <button type="submit" name="register" class="btn"> registeer </button>


            </div>
            <p> Al een account? <a href="login.php"> Login </a> </p>
        </form>
</center>
</html>