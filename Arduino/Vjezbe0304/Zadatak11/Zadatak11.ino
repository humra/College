#include <Drive.h>

const short MAX_SPEED = 255;

Drive drive(2, 3, 8, 4, 5, 9);

void setup() {
}

void loop() {
  drive.driveForward();
  delay(1500);
  drive.hardRight();
  delay(750);
  drive.driveForward();
  delay(1500);
  drive.hardRight();
  delay(750);
  drive.driveForward();
  delay(1500);
  drive.hardRight();
  delay(750);
  drive.driveForward();
  delay(1500);
  drive.hardRight();
  delay(750);
}


