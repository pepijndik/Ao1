<?php
$woord="script";
for ($t=0;$t<strlen($woord);$t++){
     $ascletter=ord(substr($woord,$t,1));
     echo "$ascletter<br>";
    }
?>
