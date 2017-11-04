int TRIG_PIN = 52;
int ECHO_PIN = A15;
unsigned long duration;

void setup() {
  pinMode(TRIG_PIN, OUTPUT);
  pinMode(ECHO_PIN, INPUT);
  Serial.begin(9600);
}

void loop() {
  digitalWrite(TRIG_PIN, LOW);
  delayMicroseconds(5);
  digitalWrite(TRIG_PIN, HIGH);
  delayMicroseconds(10);
  digitalWrite(TRIG_PIN, LOW);

  duration = pulseIn(ECHO_PIN, HIGH);
  Serial.println(convertToCM(duration));
  delay(10);
}

unsigned long convertToCM(unsigned long t) {
  return (t/2)/29.1;
}

