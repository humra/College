//Slave Sender
#include <Wire.h>

int value = 0;
int analogPin = 1;
int value_send = 0;

void setup() {
  Serial.begin(9600);
  Wire.begin(8);
  Wire.onRequest(requestEvent);
}

void loop() {
  value = analogRead(analogPin);
  value_send = map(value, 0, 1023, 0, 254);
  Serial.println(value_send);
  delay(100);
}

void requestEvent() {
  Wire.write(value_send);
}

