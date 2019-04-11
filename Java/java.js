/*
Java voor beginners
Start met Web development.
*/

//Variables outside functions are global

var life = 100; // numbers
var name = "Pdik"; //strings

//rekenmachine++;  will not work because the variable is inside the function

console.log("Hey! pdik"); //View text in debug (google console for example)

function reken() {
  //Variables inside functions can only used inside the function
  life = 101;
  var rekenmachine = 0;
  //end of function
}

//example 2
function rekenen(num1, num2) {
  life = 101;
  var rekenmachine = 0;
  console.log(num1 + num2); //where the hell comes num1 and num2 from?
}

//When calling the function you have to give 2 variables in side the /()\
rekenen(life, rekenmachine);
