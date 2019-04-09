<html>
<head>
<title>home</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="css/styleMenu.css">
    <!-- <link rel="stylesheet" href="css/bootstrap.css"> -->
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.8.1/css/all.css" integrity="sha384-50oBUHEmvpQ+1lW4y57PTFmhCaXp0ML5d60M1M7uH2+nqUivzIebhndOJK28anvf" crossorigin="anonymous">
    <link rel="Icon" href="images/logo2.png">
    <script
    src="http://code.jquery.com/jquery-3.3.1.js"
    integrity="sha256-2Kok7MbOyxpgUVvAk/HJ2jigOSYS2auK4Pfzbm7uH60="
    crossorigin="anonymous"></script>

    <script type="text/javascript">
    var totaal =  document.getElementById("totaal");
    var count1 = document.getElementById("count1");

    var cheeseGroten = document.getElementById("cheese-gr");
    var cheeseTop = document.getElementById("cheese-top");

    var cheeseopt = chopt.options[chopt.selectedIndex].text;
    var cheesegroten = chgroten.options[chgroten.selectedIndex].text;

    var pizzanaam = ["Cheesy steak"];
    var aantal1 = 1;
    var totaalprijs = 0;

    var groote1 = 7.5;
    var groote2 = 10;
    var groote3 = 12.5
    var cal = 15;
    var bezorg = 2;

    if(totaalprijs < 15){
       totaalprijs = totaalprijs + 2;

   }
    //Plus button  cheese 
    document.getElementById('ch-b-plus').onclick = function() {
    count1.innerHTML = aantal1++;
    };
    
    //Min Button  cheese 
    document.getElementById('ch-b-min').onclick = function() {
        if(aantal1 == 0){
            totaal.innerHTML = "Geen Pizza's besteld";
            count1.innerHTML = 0;
            prijs.innerHTML = "Totaal";
            totaalprijs = 0;
    
        }
        
        else{ 
        aantal1--;
        
        count1.innerHTML = aantal1;
        
     }
     };

    </script>
</head>
  
   
<body>
    <div class="container"> 
        <!-- <div class="header"> <img src="images/logo2.png" alt="logo">  -->
        </div>

            <div class="navigation">
                <ul>                        
                <li><a href="home.php">Home</a></li>
                <li><a href="menu.php">Menu</a></li> 
                <li><a href="informatie.php">Contact</a></li> 
                <li class="cart"><a href="#myModal"><i class="fas fa-shopping-cart fa-lg" id="myBtn" > Klaar voor oven!</i></a></li>                  
                </ul>
            </div>
                        <!-- The Modal -->
                        <div id="myModal" class="modal">
                        <!-- Modal content -->
                        <div class="modal-content">
                        <span class="close">&times;</span>
                        <p><i class="fas fa-shopping-cart fa-lg"></i><b> Uw bestelling:</b></p>
                        <div id="winkelmandje"></div>
                        </div>

                        </div>
                        <div class="content">

            <div class="column2">
                <div class="pizza">
                            
                <table class="cheesySteak"> 

                        <tr> 
                            <th><h2 class="pizzaname">🍕Cheesy steak</h2> </th>
                        </tr>
                        <tr>
                            <td><img src="images/cheesysteak.jpg" alt="pizzaImg"></td>
                            <td><select class="groten" name='groten'>
                                <option value='0'>Niet gekozen</option>
                                <option value='7.5'>klein | 25cm | 7,50 euro</option>
                                <option value='10'>medium | 30cm | 10,- euro</option>
                                <option value='12.5'>large | 35cm | 12,50 euro</option>
                                <option value='15'>calzone | 40cm gevouwen | 15,- euro</option>
                                </select>
                                <p>cheddar kaas, bacon, ui , knoflook en provinciale kruiden.</p>
                            </td>
                        </tr>
                        <tr class="checkboxes">              
                            <td><b>Extra toppings:</b> <br>
                                <input type="checkbox" name="topping" value="Extra kaas"> Extra kaas <br> 
                                <input type="checkbox" name="topping" value="Olijven"> Olijven <br>
                                <input type="checkbox" name="topping" value="Jalapeño"> Jalapeño  <br> 
                                <input type="checkbox" name="topping" value="Paprika"> Paprika  <br>
                            </td>
                            <td>
                            <button class="ch-b-plus"> + </button>
                            <button class="ch-b-min"> - </button></td>
                            </tr>
                        
                    </table>
                </div>
            </div>
</body>
</html>
<script>
                // Get the modal
                var modal = document.getElementById('myModal');
                
                // Get the button that opens the modal
                var btn = document.getElementById("myBtn");
                
                // Get the <span> element that closes the modal
                var span = document.getElementsByClassName("close")[0];
                
                // When the user clicks the button, open the modal 
                btn.onclick = function() 
                    {
                        modal.style.display = "block";
                    }
                // When the user clicks on <span> (x), close the modal
                span.onclick = function() 
                    {
                        modal.style.display = "none";
                    }
                // When the user clicks anywhere outside of the modal, close it
                window.onclick = function(event) 
                    {
                        if (event.target == modal) 
                            {
                                modal.style.display = "none";
                            }
                    }
            </script>