#include <Drive.h>

const short MAX_SPEED = 255;

Drive drive(4, 5, 9, 2, 3, 8);

int IC_PIN = 11;

double value;
long startTime;
bool driving;

void setup() {
  pinMode(IC_PIN, INPUT);
  startTime = millis();
  driving = true;
}

void loop() {
  value = digitalRead(IC_PIN);
  
  if(driving && value == 1) {
    drive.driveForward();
  }
  else {
    drive.stopDriving();
  }
  
  if(millis() - startTime > 150) {
    driving = !driving;
    startTime = millis();
  }
}
