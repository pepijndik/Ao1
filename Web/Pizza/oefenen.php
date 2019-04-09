<head> 
<meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="css/oefenen.css">
    <!-- <link rel="stylesheet" href="css/bootstrap.css"> -->
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.8.1/css/all.css" integrity="sha384-50oBUHEmvpQ+1lW4y57PTFmhCaXp0ML5d60M1M7uH2+nqUivzIebhndOJK28anvf" crossorigin="anonymous">
    <script
    src="http://code.jquery.com/jquery-3.3.1.js"
    integrity="sha256-2Kok7MbOyxpgUVvAk/HJ2jigOSYS2auK4Pfzbm7uH60="
    crossorigin="anonymous"></script>
    </head>
    
    <script type="text/javascript">
    $(function(){

$("#cart-items").slideUp();
$(".cart").on("click", function () {
$("#cart-items").slideToggle();
});

$("#items-basket").text("(" + ($("#list-item").children().length) + ")");

$(".item").on("click", function () {
      $("#cart-items").slideDown();
     setTimeout(function(){
        $("#cart-items").slideUp();
     }, 2000)

     //add items to basket
			$(this).each(function () {
				var name = $(this).children(".item-detail").children("h4").text();
				var remove = "<button class='remove'> X </button>";
				var cena = "<span class='eachPrice'>" + (parseFloat($(this).children(".item-detail").children(".prices").children(".price").text())) + "</span>";
				$("#list-item").append("<li>" + name + "&#09; - &#09;" + cena + "$" + remove + "</li>");

				//number of items in basket
				$("#items-basket").text("(" + ($("#list-item").children().length) + ")");
				$("#items-basket").text();
        
	        //calculate total price
	        var totalPrice = 0;
		        $(".eachPrice").each(function (){ 
		          var cenaEach = parseFloat($(this).text());
		          totalPrice+=cenaEach;
		        });
		        $("#total-price").text(totalPrice + "$");
			});

			//remove items from basket
			$(".remove").on("click", function () {
				$(this).parent().remove();

		        var totalPrice = 0;
		        $(".eachPrice").each(function (){ 
		          var cenaEach = parseFloat($(this).text());
		          totalPrice+=cenaEach;
		        });
		        $("#total-price").text(totalPrice + "$");
				$("#items-basket").text("(" + ($("#list-item").children().length) + ")");
			});
		});
})


</script>
<body>
<div class="header">
		<div class="heading">
			<h1>Shopping Cart</h1>
		</div>
		<div class="cart">
			<i class="fa fa-shopping-basket fa-2x"></i>
      <i class="fa fa-caret-down"></i><br>
			<div class="total-text">
				<p>Items</p>
				<p id="items-basket"></p>
			</div>
		</div>

		<div id="cart-items">
			<ol id="list-item">
			</ol>

			<div class="total-text">
					<p>Total: </p>
					<p id="total-price"></p>
			</div>
		</div>



	</div>

	<div class="items-container">
		<!-- Item 1 -->
		<div class="item">
			<img src="https://assets.razerzone.com/eeimages/products/26727/rzrblade14-04__store_gallery.png">
			<div class="overflow">
				<i class="fa fa-cart-plus fa-5x" id="basket"></i>
			</div>
			<div class="item-detail">
				<h4>RAZER BLADE - FULL HD</h4>
				<div class="prices">
					<p class="price">1899</p>
					<p>$</p>
				</div>
			</div>
		</div>
    </div>
    </body>