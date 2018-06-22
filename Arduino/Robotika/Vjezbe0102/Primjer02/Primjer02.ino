int redPin = 9;
int greenPin = 11;
int bluePin = 10;
unsigned long state_time;
bool upaljen;
int ulaz;

void setup() {
  pinMode(redPin, OUTPUT);
  pinMode(greenPin, OUTPUT);
  pinMode(bluePin, OUTPUT);

  Serial.begin(9600);
}

void loop() {
  if(Serial.available() > 0) {
    ulaz = Serial.read();
    
    if(ulaz == 'R') {
      setColor(255, 0, 0);
    }
    else if(ulaz == 'G') {
      setColor(0, 255, 0);
    }
    else if(ulaz == 'B') {
      setColor(0, 0, 255);
    }
    else if(ulaz == '0') {
      setColor(0, 0, 0);
    }
    else if(ulaz == 'W') {
      setColor(255, 255, 255);
    }
  }
}

void setColor(int r, int g, int b) {
  analogWrite(redPin, r);
  analogWrite(greenPin, g);
  analogWrite(bluePin, b);
}

