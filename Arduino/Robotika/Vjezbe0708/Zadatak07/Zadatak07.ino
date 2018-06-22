#include <Drive.h>

#define CD 30

Drive drive(4, 5, 9, 2, 3, 8);
const short MAX_SPEED = 255;

int TRIG_PIN = 52;
int ECHO_PIN = A15;

int TRIG_PIN2 = 50;
int ECHO_PIN2 = A14;

unsigned long duration;
unsigned long duration2;
long distance;
long distance2;

bool park = false;

void setup() {
  pinMode(TRIG_PIN, OUTPUT);
  pinMode(ECHO_PIN, INPUT);
  pinMode(TRIG_PIN2, OUTPUT);
  pinMode(ECHO_PIN2, INPUT);
  Serial.begin(9600);
}

void loop() {
  duration = getDuration(TRIG_PIN, ECHO_PIN);
  distance = convertToCM(duration);
  duration2 = getDuration(TRIG_PIN2, ECHO_PIN2);
  distance2 = convertToCM(duration);
  
  if(distance > 20 && !parking) {
    drive.driveForward();
  }
  else if(distance > 5 && !parking) {
    drive.driveForward();
    delay(100);
    drive.stopDriving();
    delay(200);
  }
  else if(distance2 > 10) {
    parking = true;
    drive.turnAround();
    delay(100);
    drive.stopDriving();
    delay(200);
  }
  else if(distance2 <= 5) {
    drive.stopDriving();
  }
  
}

unsigned long getDuration(int trig_pin, int echo_pin) {
  digitalWrite(trig_pin, LOW);
  delayMicroseconds(5);
  digitalWrite(trig_pin, HIGH);
  delayMicroseconds(10);
  digitalWrite(trig_pin, LOW);

  return pulseIn(echo_pin, HIGH);
}

unsigned long convertToCM(unsigned long t) {
  return (t/2)/29.1;
}

