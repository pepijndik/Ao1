#include <Wire.h>



/*
 * Pdik systems
 * project for MOBOX -- Mobiele Opslag Box
 * Inventaris systeem.
 * Bij houden van de materialen die gebruikt worden voor 8kuup boxen bouwen
 * 
 * www.pdik.nl 
 * 
 * Hardware die nodig is:
 * 12*2 LCD gebruiken + 1*groene led, 1 rode led, 1 oranje led, 4 button's
 * Arduino uno / nano gebruik voor project, Esp 8266
*/ 
#include <LiquidCrystal_I2C.h>
LiquidCrystal_I2C lcd(0x27,12,4);
//LiquidCrystal_I2C lcd(0x27,20,4); 

int lastAantalBox = 0; //laatse status van aantalbox

const int inv = 5;
const int showAantal = 4;


const int bPlus = 2;
const int bMin = 3;


/*nodig  per 8kuup
3x schanier
1X achterwand
1X Dak
2X Front
2X Zijwand
1X vloer
3X Vloerbalk

*/
int gebouwdBoxA = 124;

//Variable voor de  inventory
int doos140 = 1;
int doos90 = 1;
int doos70 = 1;
int doos25 = 1;
int schanieren = 6;


int schroef25stuks = doos25 * 100;
int schroef140stuks = doos140 * 100;
int schroef90stuks = doos90 * 100;
int schroef70stuks = doos70* 100;


/*
 * Dont Edit below this Line 
 * Made By ----Pepijn dik ----
 * Copy right Pdik Systems
 */
 int bStateinv = 0; 
int bStateAantal = 0;
int bStatePlus = 0;
int bStateMin = 0;
void setup(){
  Serial.begin(9600);
  Serial.print("Start Mobox Calc");
  pinMode(inv,INPUT_PULLUP);
  pinMode(showAantal, INPUT);
  pinMode(bPlus, INPUT);
  pinMode(bMin, INPUT);
  lcd.init();                      // initialize the lcd 
  lcd.backlight();
  lcd.setCursor(1,0);
  lcd.print("Mobox  Systeem");
  lcd.setCursor(3,1);
  lcd.print("Booting...");
  //end of setup
  delay(4000);
  lcd.clear();
  lcd.setCursor(0,0);
}
void loop(){
  buttoncheck();
  inventorycheck();
  //end of loop
}


void buttoncheck(){
  
  bStateinv = digitalRead(inv);
  bStateAantal = digitalRead(showAantal);
  bStatePlus = digitalRead(bPlus);
  bStateMin = digitalRead(bMin);
 
  //Show Aantal gebouwde boxen.
  if(bStateAantal == HIGH ) {
    lcd.clear();
    Serial.println("Gebouwde Boxen");
    Serial.println(gebouwdBoxA);
    lcd.setCursor(1,0);
    lcd.print("Gebouwden Boxen");
    lcd.setCursor(6,1);
    lcd.print(gebouwdBoxA);
    delay(500);
  }
  if(bStatePlus == HIGH ) {
    lcd.clear(); 
    gebouwdBoxA++;
    Serial.println("Gebouwde Boxen +1");
    Serial.println(gebouwdBoxA);
    lcd.setCursor(1,0);
    lcd.print("Gebouwden Boxen");
    lcd.setCursor(6,1);
    lcd.print(gebouwdBoxA);
    doos90--;
    doos70--;
    doos140--;
    schanieren--;
    schroef25stuks -=18;
    lastAantalBox= gebouwdBoxA;
    delay(500);
  }
  if(bStateMin == HIGH ) {
    lcd.clear(); 
    gebouwdBoxA--;
    Serial.println("Gebouwde Boxen -1");
    doos90++;
    doos70++;
    doos140++;
    schanieren+=3;
    schroef25stuks+=18;
    lastAantalBox= gebouwdBoxA;
     lcd.setCursor(1,0);
    lcd.print("Gebouwden Boxen");
    lcd.setCursor(6,1);
    Serial.println(gebouwdBoxA);
    lcd.print(gebouwdBoxA);
    delay(500);
    
  }

  
//end of button check
}

void inventorycheck(){
   
   bStateinv = digitalRead(inv);
   //kijk of 140schroeven op zijn
  if(bStateinv == HIGH){lcd.clear();}
  if(bStateinv == HIGH && doos140 <= 0){
    delay(50);
    Serial.println("Schroeven 140mm zijn op");
    lcd.setCursor(0,0);
    lcd.print("140mm");
    
  } 
  //kijk of 90schroeven op zijn
  if(bStateinv == HIGH && doos90 <= 0){
    delay(50);
    
    lcd.setCursor(6,0);
    Serial.println("Schroeven 90mm zijn op"); 
    lcd.print("90mm"); 
    
  }
  //kijk of 70schroeven op zijn
   if(bStateinv == HIGH && doos70 <= 0){
     delay(50);
    
    Serial.println("Schroeven 70mm zijn op");
    
    lcd.setCursor(11,0);
    lcd.print("70mm");
    
  }
  //kijk of schanieren op zijn
  if(bStateinv == HIGH && schanieren <= 3){
    delay(50);
    
    lcd.setCursor(0,1);
    Serial.println("Schanieren zijn op");
    lcd.print("Schanieren");
    
  }
  //kijk of 25schroef op zijn
  if(bStateinv == HIGH && schroef25stuks <= 0){
    delay(50);
    doos25 = 0;
    
    lcd.setCursor(12,1);
    Serial.println("Schroeven 25mm zijn op");
    lcd.println("25mm");
    
  }
  //Alles op voorraad is.
   else if(bStateinv == HIGH && doos70 >= 1 && doos90 >= 1 && doos140 >= 1 && schanieren >= 3 && doos25 >=1 && schroef25stuks >= 18){
     delay(500);
     Serial.println("Alles op voorraad");
    lcd.clear();
    lcd.setCursor(4,0);
    lcd.print("Alles op");
    lcd.setCursor(4,1);
    lcd.print("voorraad");
    
  }
  //end of inventory check
}
