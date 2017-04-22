#include <Drive.h>

const short MAX_SPEED = 255;

Drive drive(2, 3, 8, 4, 5, 9);

void setup() {
}

void loop() {
  drive.mediumRight();
  delay(3000);
  drive.stopDriving();
  drive.mediumLeft();
  delay(3000);
  drive.stopDriving();
}


