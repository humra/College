#include <Drive.h>

const short MAX_SPEED = 255;

Drive drive(2, 3, 8, 4, 5, 9);

void setup() {
}

void loop() {
  drive.driveForward();
  delay(5000);
  drive.stopDriving();
  drive.turnAround();
  delay(1500);
  drive.stopDriving();
}


