#include <EEPROM.h>

int adresa = 0;
byte value = 222;

void setup() {
  EEPROM.write(adresa, value);
}

void loop() {
  
}
