#include <Drive.h>

Drive drive(4, 5, 9, 2, 3, 8);
const short MAX_SPEED = 255;

int TRIG_PIN = 52;
int ECHO_PIN = A15;
unsigned long duration;
long distance;

void setup() {
  pinMode(TRIG_PIN, OUTPUT);
  pinMode(ECHO_PIN, INPUT);
  Serial.begin(9600);
}

void loop() {
  duration = getDuration();
  distance = convertToCM(duration);

  if(distance < 50) {
    drive.turnAround();
    delay(100);
    drive.stopDriving();
  }
  else {
    drive.driveForward();
    delay(100);
    drive.stopDriving();
  }

  Serial.println(distance);
  delay(10);
}

unsigned long getDuration() {
  digitalWrite(TRIG_PIN, LOW);
  delayMicroseconds(5);
  digitalWrite(TRIG_PIN, HIGH);
  delayMicroseconds(10);
  digitalWrite(TRIG_PIN, LOW);

  return pulseIn(ECHO_PIN, HIGH);
}

unsigned long convertToCM(unsigned long t) {
  return (t/2)/29.1;
}
