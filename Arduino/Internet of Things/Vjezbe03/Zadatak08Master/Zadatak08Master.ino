//Master Read
#include <Wire.h>

void setup() {
  Wire.begin();
  Serial.begin(9600);
}

void loop() {
  Wire.requestFrom(8, 1); //address, bytes

  while(Wire.available()) {
    int c = Wire.read();
    Serial.print(c);
  }

  delay(500);
}
