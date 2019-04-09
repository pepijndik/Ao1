<?php 
$woord=$_POST['woord'];

        for($i=strlen($woord);$i>=0;$i--){

            $letter =substr($woord,$i,1);
            echo "$letter";
        }


 ?>