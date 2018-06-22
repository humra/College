int redPin = 12;
int greenPin = 11;
int bluePin = 10;
unsigned long state_time;
bool upaljen;

void setup() {
  pinMode(redPin, OUTPUT);
  pinMode(greenPin, OUTPUT);
  pinMode(bluePin, OUTPUT);

  state_time = millis();
  upaljen = true;
}

void loop() {
  if(millis() - state_time >= 1000) {
    upaljen = !upaljen;
    state_time = millis();
  }

  if(upaljen) {
    digitalWrite(greenPin, HIGH);
  }
  else {
    digitalWrite(greenPin, LOW);
  }
  
}
