#include <Drive.h>

const short MAX_SPEED = 255;

Drive drive(2, 3, 8, 4, 5, 9);

void setup() {
}

void loop() {
  drive.easyLeft();
  delay(2000);
  drive.stopDriving();
  drive.mediumLeft();
  delay(2000);
  drive.stopDriving();
  drive.hardLeft();
  delay(2000);
  drive.stopDriving();
  drive.easyRight();
  delay(2000);
  drive.stopDriving();
  drive.mediumRight();
  delay(2000);
  drive.stopDriving();
  drive.hardRight();
  delay(2000);
  drive.stopDriving();
}


