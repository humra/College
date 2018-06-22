#include <Drive.h>

const short MAX_SPEED = 255;

Drive drive(2, 3, 8, 4, 5, 9);

void setup() {
}

void loop() {
  drive.leftWheelBackwards(MAX_SPEED);
  drive.rightWheelForward(MAX_SPEED);
  delay(10000);
  drive.stopDriving();
  delay(2000);
}


