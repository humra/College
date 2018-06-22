#include <SoftwareSerial.h>

//RX pin 8, TX pin 9
SoftwareSerial portOne(8, 9);

char slovo;
char stanje; 

void setup() {
  Serial.begin(9600); 
  portOne.begin(9600);
}

void loop() {
  if(Serial.available() > 0) {
    slovo = Serial.read();
    portOne.print(slovo);
  }

  if(portOne.available() > 0) {
    stanje = portOne.read();
    Serial.print("Stanje na arduinu B: ");
    Serial.println(stanje);
  }
}
