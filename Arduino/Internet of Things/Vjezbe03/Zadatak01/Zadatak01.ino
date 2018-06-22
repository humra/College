#include <EEPROM.h>

int adresa = 0;
byte value;

void setup() {
  Serial.begin(9600);
  Serial.print(EEPROM.length());
  Serial.println();
}

void loop() {
  value = EEPROM.read(adresa);
  
  Serial.print(adresa);
  Serial.print("\t");
  Serial.println(value, DEC);
  
  adresa++;

  if(adresa == EEPROM.length()) {
    while(true) {
      continue;
    }
  }
}
