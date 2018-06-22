#include <Drive.h>

const short MAX_SPEED = 255;

Drive drive(4, 5, 9, 2, 3, 8);

int IC_PIN_1 = 11;
int IC_PIN_2 = 30;
int IC_PIN_3 = 32;
int IC_PIN_4 = 34;

double value;

void setup() {
  Serial.begin(9600);
  pinMode(IC_PIN_1, INPUT);
}

void loop() {
  value = digitalRead(IC_PIN_1);
  if(value == 1) {
    Serial.println("No obstacle");
  }
  else {
    Serial.println("Obstacle");
  }
}
