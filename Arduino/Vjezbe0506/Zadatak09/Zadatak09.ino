#include <Drive.h>

const short MAX_SPEED = 255;

Drive drive(4, 5, 9, 2, 3, 8);

int IC_PIN_1 = 11;
int IC_PIN_2 = 30;
int IC_PIN_3 = 32;
int IC_PIN_4 = 34;

double value1, value2, value3, value4;

bool moving;

void setup() {
  Serial.begin(9600);
  pinMode(IC_PIN_1, INPUT);
  pinMode(IC_PIN_2, INPUT);
  pinMode(IC_PIN_3, INPUT);
  pinMode(IC_PIN_4, INPUT);

  moving = true;
}

void loop() {
  value1 = digitalRead(IC_PIN_1);
  value4 = digitalRead(IC_PIN_4);
  drive.driveForward();

  if(value1 == 0 || value4 == 0) {
    drive.stopDriving();
    drive.hardRight();
    delay(500);
    drive.driveForward();
  }
}

