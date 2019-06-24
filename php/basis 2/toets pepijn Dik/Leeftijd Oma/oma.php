<?PHP
$naam1 = $_POST["naam1"];
$naam1 = $_POST["naam2"];
$leeftijd1 = $_POST["leeftijd1"];
$leeftijd2 = $_POST["leeftijd2"];


if(empty($naam1) || empty($naam2) || empty($leeftijd1) || empty($leeftijd2) ){
echo("Vul De velden in");
}
else {
echo(uitrekenen($leeftijd1,$leeftijd2,$naam1,$naam2));
}
function uitrekenen($leeftijd1,$leeftijd2,$naam1, $naam2)
   {    
       if($leeftijd1 > 122 || $leeftijd2 > 122){
           echo("Fout Melding!");
       }
       
       if($leeftijd1 > $leeftijd2){
        return $naam1;
       }
       else if ($leeftijd1 < $leeftijd2){
           return $naam2;
       }
      
    }

?>