
<?php
$aantal = false;
$email = $_POST["mail"];
for($i= 0; $i <= strlen($email); $i++){
    $var = substr($email, $i ,1);
    if($var == "@") {
        $aantal = true;
    }
}
if($aantal == true){
    echo ("Goed gekeurd");
}
?>
