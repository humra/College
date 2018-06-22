//Master Write
#include <Wire.h>

void setup() {
  Wire.begin();
}

byte x = 0;

void loop() {
  Wire.beginTransmission(8);
  Wire.write("x is :"); //6
  Wire.write(x);
  Wire.endTransmission();

  x++;
  delay(1000);
}
