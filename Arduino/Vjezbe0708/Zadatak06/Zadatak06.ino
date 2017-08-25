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
  
  if(distance > CD && distance2 > CD) {
    drive.hardLeft();
    delay(300);
    drive.driveForward();
  }
  else if(distance > CD && distance2 < CD) {
    drive.hardLeft();
    delay(300);
    drive.driveForward();
  }
  else if(distance < CD && distance2 > CD) {
    drive.hardRight();
    delay(300);
    drive.driveForward();
  }
  else if(distance < CD && distance2 < CD {
    drive.hardLeft();
    delay(300);
    drive.forward();
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

