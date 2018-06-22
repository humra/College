#include <EEPROM.h>

float f = 123.456f;

struct MyObject {
  float field1;
  float field2;
  char polje[10];
};

void setup() {
  int adresa = 0;

  EEPROM.put(adresa, f);

  MyObject customVar = {
    3.14f, 
    65,
    "Hello, world!"
  };

  adresa += sizeof(float);

  EEPROM.put(adresa, customVar);
}

void loop() {

}
