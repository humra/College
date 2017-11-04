#include <Drive.h>

const short MAX_SPEED = 255;

Drive drive(4, 5, 9, 2, 3, 8);

int IC_PIN_1 = 11;
int IC_PIN_2 = 30;
int IC_PIN_3 = 32;
int IC_PIN_4 = 34;

double value1, value2, value3, value4;

void setup() {
  Serial.begin(9600);
  pinMode(IC_PIN_1, INPUT);
  pinMode(IC_PIN_2, INPUT);
  pinMode(IC_PIN_3, INPUT);
  pinMode(IC_PIN_4, INPUT);
}

void loop() {
  value1 = digitalRead(IC_PIN_1);
  value2 = digitalRead(IC_PIN_2);
  value3 = digitalRead(IC_PIN_3);
  value4 = digitalRead(IC_PIN_4);
  
  obstacleStatus(value1, 1);
  obstacleStatus(value2, 2);
  obstacleStatus(value3, 3);
  obstacleStatus(value4, 4);

  delay(500);
}

void obstacleStatus(double value, int sensor) {
  String message = "Senzor ";
  message.concat(sensor);

  if(value == 1) {
    message.concat(" - no obstacle");
  }
  else {
    message.concat(" - obstacle");
  }

  Serial.println(message);
}

