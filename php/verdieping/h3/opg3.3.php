
<?php
$aantal@ =0;
$email = $_POST["mail"];
for($i= 0, $i <= strlen($email); $i++{
    $var = substr($email, $i ,1) ;
    if($var == "@") {
        $aantal@ = 1;
    }
})
if($aantal@ > 0){
    echo "Goed gekeurd"
}
?>