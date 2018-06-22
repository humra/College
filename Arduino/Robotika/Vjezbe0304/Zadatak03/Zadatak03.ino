#include <Drive.h>

const short MAX_SPEED = 255;

Drive drive(2, 3, 8, 4, 5, 9);

void setup() {
}

void loop() {
  drive.driveForward(MAX_SPEED);
  delay(1000);
  drive.stopDriving();
  delay(1000);
}


