<html>
<body>

<form name="opdracht1" method="post" 
action="toets-VB-Opdr1-JayBhowmick-145849.php">
<!-- stuurt info naar php bestand met action -->
Welkom bij het Amstelhotel,hoeveel nachten wilt u reserveren?<br/>
aantal nachten:
<!-- de aantal nachten-->
<select name="aantal-N">
<option value="6">6
<option value="3">3
<option value="1">1
</select>
<br/>
<br/>

<!-- keuze voor kamers -->
Welke kamer wilt u reserveren?<br/>
<input type="radio" name="kamer" value="1">Standard Room -&#8364 622,-<br/> 
<input type="radio"  name="kamer" value="2">Presidential Room -&#8364 745,-<br/>  
<input type="radio"  name="kamer" value="3">Suite -&#8364 1.136,-<br/>  
<br/>

<!-- optie voor ontbijt -->
wilt u ook ontbijt?<br/>
<input type="checkbox" name="ontbijt">extra ontbijt -&#8364 55,-<br/>  
<br/>

<!-- het aantal persoonen die je kunt selecteren -->
Voor hoeveel personen wilt u reserveren?<br/>
Aantal personen: <select name="personen">
<option value="6 Per">4
<option value="3 Per">2
<option value="1 Per">1
</select>
<br/>
 <br/> 

 <!--stuurt de berkening op naar php bestand -->
<input type="submit" value="bereken totaalprijs">

</form>
</body>
</html>