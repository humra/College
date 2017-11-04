int blinkRate = 0;
int value = 1;

void setup() {
  Serial.begin(9600);
  pinMode(LED_BUILTIN, OUTPUT);
}

void loop() {
  if(Serial.available() > 0) {
    char ch = Serial.read();
    
    if( ch >= '0' && ch <= '9') {
      value = (value * 10) + (ch - '0');
    }
    else if(ch == 10)  {
      blinkRate = value;
      Serial.println(blinkRate);
      value = 0;
    }
  }

  blink();
}

void blink() {
  digitalWrite(LED_BUILTIN, HIGH);
  delay(blinkRate);
  digitalWrite(LED_BUILTIN, LOW);
  delay(blinkRate);
}

