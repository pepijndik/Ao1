<?php
$prijs = 0;
$prodcuten = ""

?>

<!DOCTYPE html>
<html lang="NL">
<head>
    <title>🍕 Sopranos pizza menu🍕</title>
    <meta charset="UTF-8">
    <link rel="stylesheet" href="styles.css"  type="text/css">
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.7.1/css/all.css" integrity="sha384-fnmOCqbTlWIlj8LyTjo7mOUStjsKC4pOpQbqyi7RrhN7udi9RwhKkMHpvLbHG9Sr" crossorigin="anonymous">
    <meta content="width=device-width, initial-scale=1" name="viewport">
   

  <style>
    .container {
        display: grid;
        grid-template-columns: repeat(12, 1fr);
        grid-gap: 10px;
    }
   
    .container > * {
        grid-column: 1 / span 12;
    }
    @media (min-width: 600px) {
        
        .ads {
            grid-column: 1 / span 3;
            grid-row: 4;
        }
        .content, .footer {
            grid-column: 4 / span 9;
        }
        nav ul {
            display: flex;
            justify-content: space-between;
            position: sticky;
            width: 100%;
        }
    }
    @media (min-width: 900px) {
        
        .content {
            grid-column: 2 / span 8;
        }
        .ads {
            grid-column: 10 / span 3;
            grid-row: 3;
        }
        .footer {
            grid-column: 1 / span 12;
            width: 100%;
        }
    }
    .container {
        max-width: 1400px;
    }

    /* Center the loader */
#loader {
  position: absolute;
  left: 50%;
  top: 50%;
  z-index: 1;
  width: 150px;
  height: 150px;
  margin: -75px 0 0 -75px;
  border: 16px solid #f3f3f3;
  border-radius: 50%;
  border-top: 16px solid #3498db;
  width: 120px;
  height: 120px;
  -webkit-animation: spin 2s linear infinite;
  animation: spin 2s linear infinite;
}

@-webkit-keyframes spin {
  0% { -webkit-transform: rotate(0deg); }
  100% { -webkit-transform: rotate(360deg); }
}

@keyframes spin {
  0% { transform: rotate(0deg); }
  100% { transform: rotate(360deg); }
}

/* Add animation to "page content" */
.animate-bottom {
  position: relative;
  -webkit-animation-name: animatebottom;
  -webkit-animation-duration: 1s;
  animation-name: animatebottom;
  animation-duration: 1s
}

@-webkit-keyframes animatebottom {
  from { bottom:-100px; opacity:0 } 
  to { bottom:0px; opacity:1 }
}

@keyframes animatebottom { 
  from{ bottom:-100px; opacity:0 } 
  to{ bottom:0; opacity:1 }
}

#myDiv {
  display: none;
  text-align: center;
}
    
    </style>
    
</head>
<body onload="loader()" style="margin:0;">
   <center> <div class="container">
        <header class="header">
           <center><a href="/"><h1>🍕Sopranos pizza🍕</h1></a></center>
        </header>
        
        <div id="nav" class="navi">    
        <div class="header">
            <a class="link" href="/" aria-label="Sopranos Home Page" ><menu class="logo"></menu></a>
    
            <ul class="menuitem">
    
                <a href="#aanbiedingen" class="aanbiedingen-bt link" ><i class="fas fa-pizza-slice"></i>&nbsp;Aanbiedingen</a>&nbsp;&nbsp;&nbsp;
                <a href="/menu.html" class="menu-bt link"><i class="far fa-list-alt"></i>&nbsp;Menu</a>&nbsp;&nbsp;&nbsp;
                <a href="/contact.html" class="menu-bt link"><i class="fas fa-phone"></i>&nbsp;Neem contact op</a>&nbsp;
                        
            </ul>
    
        
        </div>
    </div>
    <div class="kaart ">
    <div class="winkelmand">
      <h4>Kaart 
        <span class="prijs" style="color:black">
          <i class="fa fa-shopping-cart"></i> 
          <b></b>
          
        </span>
      </h4>
      <p><?php //echo("$prodcuten")?></p>
      <hr>
      
      <p>Totaal <span class="price" style="color:black"><b><?php echo("$prijs")?></b></span></p>
    </div>
</div> 
<div id="loader"></div>
    <div class="row" style="display:none;" id="menu" class="animate-bottom">
            <div class="menu">
                    <h2>🍕Magarita🍕</h2>
                    <p><a href="/menu" title="🍕Magarita🍕"><img src="/afbeeldingen/pizza/magarita.png" alt="onze pizza's" height="250px"></a></p>
                    <p></p>
                    <form name="keuze-grote">
                            <select name="groten" class="dropdown">
                                    <option value="25" class="dropdown">(25CM) Medium</option>
                                    <option value="30"class="dropdown">(30CM) Normal</option>
                                    <option value="35"class="dropdown">(35CM) Large</option>
                                    <option value="40"class="dropdown">(40CM Famalie XXL)</option>
                                </select>
                    </form> <br>
                    <form name="keuze-soort">
                            <select name="soort" class="dropdown">
                                    <option value="classic" class="dropdown">Classic</option>
                                    <option value="cheesycrust"class="dropdown">Cheesy Crust</option>
                                </select>
                    </form> <br>
                    <form class="toevoegen">
                    <input type="submit" class="red-button" style="width:250px" name="toevoegen" value="toevoegen-magarita" onclick="toevoegen()" />

                    </form>

            </div>
            <div class="menu">
                    <h2>🍕Salami🍕</h2>
                    <p><a href="/menu" title="🍕Salami🍕"><img src="/afbeeldingen/pizza/salami.png" alt="onze pizza's" height="250px"></a></p>
                    <p>Bekijk hier het menu. je krijgt hier een overzicht van alle pizza's op ons menu en alle bijgerechten!</p>
                    <form name="keuze-grote">
                            <select name="groten" class="dropdown">
                                    <option value="25" class="dropdown">(25CM) Medium</option>
                                    <option value="30"class="dropdown">(30CM) Normal</option>
                                    <option value="35"class="dropdown">(35CM) Large</option>
                                    <option value="40"class="dropdown">(40CM Famalie XXL)</option>
                                </select>
                    </form>
                    <br>
                    <form name="keuze-soort">
                            <select name="soort" class="dropdown">
                                    <option value="classic" class="dropdown">Classic</option>
                                    <option value="cheesycrust"class="dropdown">Cheesy Crust</option>
                                </select>
                    </form><br>
                    <form class="toevoegen">
                    <input type="submit" class="red-button" style="width:250px" name="toevoegen" value="toevoegen-salami" onclick="toevoegen()" />

                    </form>
                    

            </div>
            <div class="menu">
                    <h2>🍕Carcazone🍕</h2>
                    <p><a href="/menu" title="Menu"><img src="/afbeeldingen/pizza/niet-beschikbaar.png" alt="onze pizza's" height="250px"></a></p>
                    <p>Bekijk hier het menu. je krijgt hier een overzicht van alle pizza's op ons menu en alle bijgerechten!</p>
                    <form name="keuze-grote">
                            <select name="groten" class="dropdown">
                                    <option value="25" class="dropdown">(25CM) Medium</option>
                                    <option value="30"class="dropdown">(30CM) Normal</option>
                                    <option value="35"class="dropdown">(35CM) Large</option>
                                    <option value="40"class="dropdown">(40CM Famalie XXL)</option>
                                </select>
                    </form>
                    <br>
                    <form name="keuze-soort">
                            <select name="soort" class="dropdown">
                                    <option value="classic" class="dropdown">Classic</option>
                                    <option value="cheesycrust"class="dropdown">Cheesy Crust</option>
                                </select>
                    </form><br>
                    <form class="toevoegen">
                    <input type="submit" class="red-button" style="width:250px" name="toevoegen" value="toevoegen-carcazone" onclick="toevoegen()" />

                    </form>

            </div>
            <div class="menu">
                    <h2>🍕Hawai🍕</h2>
                    <p><a href="/menu" title="Menu"><img src="/afbeeldingen/pizza/niet-beschikbaar.png" alt="onze pizza's" height="250px"></a></p>
                    <p>Tomatensaus, mozzarella, ham, ananas & extra kaas.Onze frisse ananas gaat heel erg goed samen met een pizza.<br> In combinatie met onze smakelijke ham is deze pizza één van onze persoonlijke favorieten. Bij sopranos  is deze variant altijd de moeite waard.</p>
                    <form name="keuze-grote">
                            <select name="groten" class="dropdown">
                                    <option value="25" class="dropdown">(25CM) Medium</option>
                                    <option value="30"class="dropdown">(30CM) Normal</option>
                                    <option value="35"class="dropdown">(35CM) Large</option>
                                    <option value="40"class="dropdown">(40CM Famalie XXL)</option>
                                </select>
                    </form>
                    <br>
                    <form name="keuze-soort">
                            <select name="soort" class="dropdown">
                                    <option value="classic" class="dropdown">Classic</option>
                                    <option value="cheesycrust"class="dropdown">Cheesy Crust</option>
                                </select>
                    </form><br>
                    <form class="toevoegen">
                    <input type="submit" class="red-button" style="width:250px"name="toevoegen" value="toevoegen-hawai" onclick="toevoegen()" />

                    </form>

            </div>
            <div class="menu">
                    <h2>🍕Custom🍕</h2>
                    <p><a href="/menu" title="Menu"><img src="/afbeeldingen/pizza/niet-beschikbaar.png" alt="onze pizza's" height="250px"></a></p>
                    <p>Bekijk hier het menu. je krijgt hier een overzicht van alle pizza's op ons menu en alle bijgerechten!</p>
                    
                    <form name="keuze-grote">
                            <select name="groten" class="dropdown">
                                    <option value="25" class="dropdown">(25CM) Medium</option>
                                    <option value="30"class="dropdown">(30CM) Normal</option>
                                    <option value="35"class="dropdown">(35CM) Large</option>
                                    <option value="40"class="dropdown">(40CM Famalie XXL)</option>
                                </select>
                    </form>
                    <br>
                    <form name="keuze-soort">
                            <select name="soort" class="dropdown">
                                    <option value="classic" class="dropdown">Classic</option>
                                    <option value="cheesycrust"class="dropdown">Cheesy Crust</option>
                                </select>
                    </form>
                    <br>
                    <form class="toevoegen">
                    <input type="submit" class="red-button" style="width:250px" name="Toevoegen" value="toevoegen" onclick="toevoegen()" />

                    </form>
            </div>
          </div>
        
        
    </div>

    <footer class="footer row">
        
                <ul class="footer-links">
                        <a class="link" href="/index.html">🍕Sopranos pizza</a>&nbsp;&nbsp;&nbsp;
                        <a class="link" href="/menu.html">Menu</a>&nbsp;&nbsp;&nbsp;
                        <a class="link" href="/aanbiedingen" >Aanbiedingen🍕</a>&nbsp;&nbsp;&nbsp;
        
                </ul>
                
        
        <ul>
            <img src="/afbeeldingen/contact.icon-footer.png">
            <address>Paxlaan, hoofddorp</address>
        </ul>
        
</footer>
</center>

</body>
<script>
var loadtime;

function loader() {
  loadtime = setTimeout(showPage, 1000);
}

function showPage() {
  document.getElementById("loader").style.display = "none";
  document.getElementById("menu").style.display = "block";
}
</script>

</html>