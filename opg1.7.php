<?php
$begingetal=$_POST['begingetal'];
$eindgetal=$_POST['eindgetal'];
	echo"<table border='1'>";
	echo "<tr><th>Getal</th><th>Kwadraat</th><th>Derdemacht</th></tr>";
	for($tel=$begingetal;$tel<=$eindgetal;$tel++){
		$kwadraat=$begingetal*$begingetal;
		$derdemacht=$begingetal*$begingetal*$begingetal;
		echo"<tr><td>$begingetal</td><td>$kwadraat</td><td>$derdemacht</td></tr>";
		$begingetal++;
}
?>