#include <Drive.h>

const short MAX_SPEED = 255;

Drive drive(2, 3, 8, 4, 5, 9);

void setup() {
}

void loop() {
  drive.driveForward(MAX_SPEED * 75 / 100);
  delay(2000);
  drive.stopDriving();
  delay(500);
  drive.driveBackwards(MAX_SPEED * 75 / 100);
  delay(2000);
  drive.stopDriving();
  delay(500);
}


