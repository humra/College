#include <Drive.h>

const byte MOTOR_LEFT[] = {2, 3, 8};
const byte MOTOR_RIGHT[] = {4, 5, 9};
const short MAX_SPEED = 255;

Drive drive(2, 3, 8, 4, 5, 9);


void setup() {
  pinMode(MOTOR_LEFT[0], OUTPUT);
  pinMode(MOTOR_LEFT[1], OUTPUT);
  pinMode(MOTOR_LEFT[2], OUTPUT);
  pinMode(MOTOR_RIGHT[0], OUTPUT);
  pinMode(MOTOR_RIGHT[1], OUTPUT);
  pinMode(MOTOR_RIGHT[2], OUTPUT);
}

void loop() {
  drive.driveForward(MAX_SPEED);
}


