#include <Drive.h>

const short MAX_SPEED = 255;

Drive drive(2, 3, 8, 4, 5, 9);

void setup() {
}

void loop() {
  drive.leftWheelBackwards(MAX_SPEED);
  drive.rightWheelForward(MAX_SPEED);
  delay(5000);
  drive.stopDriving();
  drive.leftWheelForward(MAX_SPEED);
  drive.rightWheelBackwards(MAX_SPEED);
  delay(5000);
  drive.stopDriving();
}


