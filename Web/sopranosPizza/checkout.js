function kaart() {  
    var totaal =  document.getElementById("totaal");
    var count1 = document.getElementById("count1");
    var count2 = document.getElementById("count2");
    var count3 = document.getElementById("count3");
    var count4 = document.getElementById("count4");
    var count5 = document.getElementById("count5");
    var prijs = document.getElementById("prijs");

  
    //Gebruik de juiste velden bij ID
    var chgroten = document.getElementById("ch-gr");
    var chopt = document.getElementById("ch-opt");
    var chtop = document.getElementById("ch-top");

    var vegagroten = document.getElementById("vega-gr");
    var vegaopt = document.getElementById("vega-opt");
    var vegatop = document.getElementById("vega-top");

    var qgr = document.getElementById("q-gr");
    var qopt = document.getElementById("q-opt");
    var qtop = document.getElementById("q-top");

    var dgr = document.getElementById("d-gr");
    var dopt = document.getElementById("d-opt");
    var dtop = document.getElementById("d-top");
    
    var cgr = document.getElementById("c-gr");
    var copt = document.getElementById("c-opt");
    var ctop = document.getElementById("c-top");

    //alle keuzes.

   //var cheeseopt = chopt.options[chopt.selectedIndex].text;
   //var cheesegroten = chgroten.options[chgroten.selectedIndex].text;

   //var vegagroten = vegagroten.options[vegagroten.selectedIndex].text;
   //var vegaopties = vegaopt.options[vegaopt.selectedIndex].text;

   //var qgroten = qgr.options[qgr.selectedIndex].text;
   //var qopties = qopt.options[qopt.selectedIndex].text;

  //var deluxegroten = dgr.options[dgr.selectedIndex].text;
   //var deluxeopt = dopt.options[dopt.selectedIndex].text;

   //zooi

   var pizzanaam = ["Cheesy steak","Vegetariano","Quattro fromaggi","Deluxe", "Custom"];
   var aantal1 = 1;
   var aantal2 = 1;
   var aantal3 = 1;
   var aantal4 = 1;
   var aantal5 = 1;
   var totaalprijs = 0;
   //prijzen
   var groote1 = 5;
   var groote2 = 10;
   var cal = 15;
   var bezorg = 2;

   if(totaalprijs < 15){
       totaalprijs = totaalprijs + 2;

   }
//----------------------------PIZZA 1 -------------------------------------//
   //Plus button  cheese 
   document.getElementById('B1').onclick = function() {
    count1.innerHTML = aantal1++;
    };
    
    //Min Button  cheese 
    document.getElementById('B2').onclick = function() {
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

     //Add button  cheese 
     document.getElementById('B17').onclick = function() {
         if(aantal1 == 0){
             totaal.innerHTML = "Geen Pizza's besteld"; 
                 }
         else {
        totaal.innerHTML = ""; 
        totaal.innerHTML += "Soort: &nbsp" + pizzanaam[0] + "<br>" + "Groten: &nbsp" + chgroten.options[chgroten.selectedIndex].text + "<br> Extra Optie: &nbsp" + chopt.options[chopt.selectedIndex].text + "<br>Topping: &nbsp" + chtop.options[chtop.selectedIndex].text + "<br>" +(aantal1-1) + "<br>"; 
        
        
    if(chgroten.options.selectedIndex == 0){
        totaalprijs += (aantal1 * groote1) -groote1;
            prijs.innerHTML = "Totaal:<br> &#8364;" + totaalprijs;
            aantal1 +=1;
        }
         if(chgroten.options.selectedIndex == 1){

             totaalprijs += (aantal1 * groote2) -groote2;
           prijs.innerHTML = "Totaal:<br> &#8364;" + totaalprijs;
           aantal1 +=1;
       }
    }
        };
//----------------------------PIZZA 2 -------------------------------------//
    //Plus button  vega  
   document.getElementById('B4').onclick = function() {
    count2.innerHTML = aantal2++;
    };
    
    //Min Button  vega
    document.getElementById('B5').onclick = function() {
        if(aantal2 == 0){
            totaal.innerHTML = "Geen Pizza's besteld";
            count2.innerHTML = 0;
        }

        else{ 
        aantal2--;
        count2.innerHTML = aantal2;
     }
     };

     //Add button  vega 
     document.getElementById('B6').onclick = function() {
         if(aantal2 == 0){
             totaal.innerHTML = "Geen Pizza's besteld";      }
         else {
        totaal.innerHTML += "Soort: &nbsp" + pizzanaam[1] + "<br>" + "Groten: &nbsp" + vegagroten.options[vegagroten.selectedIndex].text + "<br> Extra Optie: &nbsp" + vegaopt.options[vegaopt.selectedIndex].text + "<br>Topping: &nbsp" + vegatop.options[vegatop.selectedIndex].text + "<br>" + (aantal2-1) + "<br>"; 
        if(vegagroten.options.selectedIndex == 0){
            totaalprijs = totaalprijs + (aantal2 * groote1) -groote1;
                prijs.innerHTML = "Totaal<br> &#8364;" + totaalprijs;
                aantal2 +=1;
            }
             if(vegagroten.options.selectedIndex == 1){
    
                 totaalprijs = totaalprijs +(aantal2 * groote2) -groote2;
               prijs.innerHTML = "Totaal<br> &#8364;" + totaalprijs;
               aantal2 +=1;
           }    
    }
        };
//----------------------------PIZZA 3 -------------------------------------//
//Plus button  q  
document.getElementById('B7').onclick = function() {
    count3.innerHTML = aantal3++;
    };
    
    //Min Button  q 
    document.getElementById('B8').onclick = function() {
        if(aantal3 == 0){
            totaal.innerHTML = "Geen Pizza's besteld";
            count3.innerHTML = 0;
        }

        else{ 
        aantal3--;
        count3.innerHTML = aantal; }
     };

     //Add button  q 
     document.getElementById('B9').onclick = function() {
         if(aantal3 == 0){
             totaal.innerHTML = "Geen Pizza's besteld";      }
         else {
        totaal.innerHTML += "Soort: &nbsp" + pizzanaam[2] + "<br>" + "Groten: &nbsp" + qgr.options[qgr.selectedIndex].text + "<br>Extra Optie: &nbsp" + qopt.options[qopt.selectedIndex].text + "<br>Topping: &nbsp" + qtop.options[qtop.selectedIndex].text + "<br>"+ (aantal3-1) + "<br>"; 
        if(qgroten.options.selectedIndex == 0){
            totaalprijs += (aantal1 * groote1) -groote1;
                prijs.innerHTML = "Totaal<br> &#8364;" + totaalprijs;
                aantal3 +=1;
            }
             if(qgroten.options.selectedIndex == 1){
    
                 totaalprijs += (aantal1 * groote2) -groote2;
               prijs.innerHTML = "Totaal<br> &#8364;" + totaalprijs;
               aantal3 +=1;
           }    
    }
        };

//----------------------------PIZZA 4 -------------------------------------//

//Plus button  d  
document.getElementById('B10').onclick = function() {
    count4.innerHTML = aantal4++;
    };
    
    //Min Button  d 
    document.getElementById('B11').onclick = function() {
        if(aantal4 == 0){
            totaal.innerHTML = "Geen Pizza's besteld";
            count4.innerHTML = 0;
        }

        else{ 
        aantal4--;
        count4.innerHTML = aantal4; }
     };

     //Add button  d 
     document.getElementById('B12').onclick = function() {
         if(aantal4 == 0){
             totaal.innerHTML = "Geen Pizza's besteld";      }
         else {
        totaal.innerHTML += "Soort: &nbsp" + pizzanaam[3] + "<br>" + "Groten: &nbsp" + dgr.options[dgr.selectedIndex].text + "<br>Extra optie: &nbsp" + dopt.options[dopt.selectedIndex].text + "<br>Topping: &nbsp" + dtop.options[dtop.selectedIndex].text + "<br>"+ (aantal4-1) + "<br>"; 
        if(dgroten.options.selectedIndex == 0){
            totaalprijs += (aantal1 * groote1) -groote1;
                prijs.innerHTML = "Totaal<br> &#8364;" + totaalprijs;
                aantal4 +=1;
            }
             if(dgroten.options.selectedIndex == 1){
    
                 totaalprijs += (aantal1 * groote2) -groote2;
               prijs.innerHTML = "Totaal<br> &#8364;" + totaalprijs;
               aantal4 +=1;
           }    
    }
        };
     
//----------------------------PIZZA 5 custom! -------------------------------------//   
//Plus button  custom
document.getElementById('B13').onclick = function() {
    count5.innerHTML = aantal5++;
    };
    
    //Min Button  custom
    document.getElementById('B14').onclick = function() {
        if(aantal5 == 0){
            totaal.innerHTML = "Geen Pizza's besteld";
            count5.innerHTML = 0;
        }

        else{ 
        aantal5--;
        count5.innerHTML = aantal5; }
     };

     //Add button custom
     document.getElementById('B15').onclick = function() {
         if(aantal5 == 0){
             totaal.innerHTML = "Geen Pizza's besteld";      }
         else {
        totaal.innerHTML += "Soort: &nbsp" + pizzanaam[4] + "<br>" + "Groten: &nbsp" + c-gr.options[dgr.selectedIndex].text + "<br>Extra Optie: &nbsp" + c-opt.options[dopt.selectedIndex].text + "<br>Topping: &nbsp" + ctop.options[ctop.selectedIndex].text + "<br>" +(aantal5-1) + "<br>"; 
        if(cgroten.options.selectedIndex == 0){
            totaalprijs += (aantal1 * groote1) -groote1;
                prijs.innerHTML = "Totaal<br> &#8364;" + totaalprijs;
                aantal5 +=1;
            }
             if(cgroten.options.selectedIndex == 1){
    
                 totaalprijs += (aantal1 * groote2) -groote2;
               prijs.innerHTML = "Totaal<br> &#8364;" + totaalprijs;
               aantal5 +=1;
           }   
    }
        };

}
