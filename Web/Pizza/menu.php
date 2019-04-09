<html>
<head>
    <title>home</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="css/styleMenu.css">
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.8.1/css/all.css" integrity="sha384-50oBUHEmvpQ+1lW4y57PTFmhCaXp0ML5d60M1M7uH2+nqUivzIebhndOJK28anvf" crossorigin="anonymous">
    <link rel="Icon" href="images/logo2.png">

  
    <script
    src="http://code.jquery.com/jquery-3.3.1.js"
    integrity="sha256-2Kok7MbOyxpgUVvAk/HJ2jigOSYS2auK4Pfzbm7uH60="
    crossorigin="anonymous"></script>

    <script type="text/javascript">
    $(document).ready(function() {
   
        $(".button").click(function(e){
            list = [];

////////////////////////////////////////// Pizza 1 \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
            $(".cheesySteak").each(function(){
                var pizzaname = $(this).find(".pizzaname").html();
                toppings = [];
                var size = $(this).find(".formaat").val();
                $(this).find("input").each(function(){
                    if(($(this).is(":checked"))){
                        toppings.push($(this).val());
                    }
                });
                
                if (size > 5) {
                    list.push({"name" : pizzaname, "price" : size, "toppings" : toppings});  
                }
            });

////////////////////////////////////////// Pizza 2 \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
            $(".vegetariana").each(function(){
                var pizzaname = $(this).find(".pizzaname").html();
                toppings = [];
                var size = $(this).find(".formaat").val();
                $(this).find("input").each(function(){
                    if(($(this).is(":checked"))){
                        toppings.push($(this).val());
                    }
                });
                
                if (size > 5) {
                    list.push({"name" : pizzaname, "price" : size, "toppings" : toppings});  
                }
            });
           
////////////////////////////////////////// Pizza 3 \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
            $(".quattroFromaggi").each(function(){
                var pizzaname = $(this).find(".pizzaname").html();
                toppings = [];
                var size = $(this).find(".formaat").val();
                $(this).find("input").each(function(){
                    if(($(this).is(":checked"))){
                        toppings.push($(this).val());
                    }
                });
                
                if (size > 5) {
                    list.push({"name" : pizzaname, "price" : size, "toppings" : toppings});  
                }
            });

////////////////////////////////////////// Pizza 4 \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
            $(".sopranosDeluxe").each(function(){
                var pizzaname = $(this).find(".pizzaname").html();
                toppings = [];
                var size = $(this).find(".formaat").val();
                $(this).find("input").each(function(){
                    if(($(this).is(":checked"))){
                        toppings.push($(this).val());
                    }
                });
                if (size > 5) {
                    list.push({"name" : pizzaname, "price" : size, "toppings" : toppings});  
                }
                
            });

////////////////////////////////////////////\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

            text = "";
            prijs = 0;

            $(list).each(function(e){
               text += "Pizza : " + list[e].name + ", met extra toppings : "
               prijs += parseFloat(list[e].price);
               $(list[e].toppings).each(function(f){
                    text += list[e].toppings[f] + ",";
                    prijs += 1;
               });
               
               text += "<br>";
               
            });

            text += "<br>";
            text += "<br>";
            prijs = prijs.toString();
            
            var split_prijs = prijs.split(".");
            var prijs_len = split_prijs.length;
            console.log(prijs+" | "+split_prijs+ " | " + prijs_len);
            if (prijs_len === 1) {
                var new_prijs = split_prijs[0] + ",00";
            } else {
                var new_prijs = split_prijs[0];
                if (split_prijs[1].length == 1) {
                    var new_prijs = new_prijs + "," + split_prijs[1] + "0";
                } else {
                    var new_prijs = new_prijs + "," + split_prijs[1];
                }
            }
            text += "Totaal prijs : &euro; " + new_prijs;
            $("#winkelmandje").html(text);

        });
    });
    </script>
</head>
<body>
    <div class="container"> 
        <div class="header"> 
            <img src="images/logo2.png" alt="logo"> 
        </div>

            <div class="navigation">
                <ul>                        
                <li><a href="home.php">Home</a></li>
                <li><a href="menu.php">Menu</a></li> 
                <li><a href="informatie.php">Contact</a></li> 
                <li class="cart"><a href="#myModal" id="myBtn"><i class="fas fa-shopping-cart fa-lg"></i> Klaar voor oven!</a></li>                  
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
                            <td><select class="formaat" name='formaat'>
                                <option value='0'>geen selectie</option>
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
                        </tr>
                        <tr>
                            <td>
                            
                            </td>
                            </tr>
                    </table>
                   
                </div>

                <div class="pizza">
                    <table class="vegetariana">
                        <tr>
                            <th><h2 class="pizzaname">🍕Vegetariana</h2></th>
                        </tr>
                        <tr>
                            <td><img src="images/vegatariana.jpg" alt="pizzaImg"></td>
                            <td><select class="formaat" name='formaat'>
                                <option value='0'>geen selectie</option>
                                <option value='7.5'>klein | 25cm | 7,50 euro</option>
                                <option value='10'>medium | 30cm | 10,- euro</option>
                                <option value='12.5'>large | 35cm | 12,50 euro</option>
                                <option value='15'>calzone | 40cm gevouwen | 15,- euro</option>
                                </select>
                                <p>mozzarella, verse spinazie, rode ui, paprika, champignons en verse tomaat.</p>
                            </td>
                        </tr>
                        <tr class="checkboxes">   
                        <td><b>Extra toppings:</b> <br>
                                <input type="checkbox" name="topping" value="Extra kaas"> Extra kaas <br> 
                                <input type="checkbox" name="topping" value="Olijven"> Olijven <br>
                                <input type="checkbox" name="topping" value="Jalapeño"> Jalapeño  <br> 
                                <input type="checkbox" name="topping" value="Paprika"> Paprika  <br>
                            </td>
                        </tr>
                        <tr>
                       
                        <tr>                       
                        </td>
                            </tr>
                    </table>
                </div>

                <div class="pizza">
                    <table class="quattroFromaggi">
                        <tr>
                            <th><h2 class="pizzaname">🍕Quattro fromaggi</h2></th>
                        </tr>
                        <tr>
                            <td><img src="images/quattro.jpg" alt="pizzaImg"></td>
                            <td><select class="formaat" name='formaat'>
                                <option value='0'>geen selectie</option>
                                <option value='7.5'>klein | 25cm | 7,50 euro</option>
                                <option value='10'>medium | 30cm | 10,- euro</option>
                                <option value='12.5'>large | 35cm | 12,50 euro</option>
                                <option value='15'>calzone | 40cm gevouwen | 15,- euro</option>
                            </select>
                            <p>gorgonzola, parmezaanse kaas, oregano en basilicum.</p>
                        </td>
                        </tr>
                        <tr class="checkboxes">   
                        <td><b>Extra toppings:</b> <br>
                        <input type="checkbox" name="topping" value="Extra kaas"> Extra kaas <br> 
                                <input type="checkbox" name="topping" value="Olijven"> Olijven <br>
                                <input type="checkbox" name="topping" value="Jalapeño"> Jalapeño  <br> 
                                <input type="checkbox" name="topping" value="Paprika"> Paprika  <br>
                            </td>
                        </tr>
                        <tr>
                            <td>
                              
                            </td>
                            </tr>
                    </table>
                </div>

                <div class="pizza">
                    <table class="sopranosDeluxe">
                        <tr>
                            <th><h2 class="pizzaname">🍕Sopranos deluxe</h2></th>
                        </tr>
                        <tr>
                        <td><img src="images/pesto.jpg" alt="pizzaImg"></td>
                        <td><select class="formaat" name='formaat'>
                                <option value='0'>geen selectie</option>
                                <option value='7.5'>klein | 25cm | 7,50 euro</option>
                                <option value='10'>medium | 30cm | 10,- euro</option>
                                <option value='12.5'>large | 35cm | 12,50 euro</option>
                                <option value='15'>calzone | 40cm gevouwen | 15,- euro</option>
                                </select>
                                <p>verse spinazie, mozzarella, verse tomaat, oregano en pesto.</p>
                        </td>
                        </tr>
                        <tr class="checkboxes">   
                        <td><b>Extra toppings:</b> <br>
                            <input type="checkbox" name="topping" value="Extra kaas"> Extra kaas <br> 
                                <input type="checkbox" name="topping" value="Olijven"> Olijven <br>
                                <input type="checkbox" name="topping" value="Jalapeño"> Jalapeño  <br> 
                                <input type="checkbox" name="topping" value="Paprika"> Paprika  <br>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                
                            </td>
                            </tr>
                    </table>
                    <center><button class="button">Klaarmaken</button> </center>
                </div>
            </div>

            

        </div>
        
            <div class="footer"> 
                    <center><h2> Contact </h2> </center>
                    <center> <p> <h3> <i class="fas fa-phone"></i> Tel: 023-111 111 1111   ||  <i class="fas fa-envelope"></i> Email: contact@sopranospizza.nl  || <i class="fas fa-map-marker-alt"></i> Adres: Almkerkplein 2, 2134DR Hoofddorp </h3> </p> </center>
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