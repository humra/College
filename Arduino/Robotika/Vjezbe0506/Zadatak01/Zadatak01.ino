#include <Drive.h>

const short MAX_SPEED = 255;

Drive drive(4, 5, 9, 2, 3, 8);

int IC_PIN = 11;

double value;
long startTime;

void setup() {
  pinMode(IC_PIN, INPUT);
  Serial.begin(9600);
}

void loop() {
  value = digitalRead(IC_PIN);
  
  if(value == 0) {
    drive.driveBackwards();
  }
  else {
    drive.stopDriving();
  }
}
