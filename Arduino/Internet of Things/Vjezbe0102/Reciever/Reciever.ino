int ulaz;

void setup() {
  Serial.begin(9600);
  pinMode(LED_BUILTIN, OUTPUT);
}

char stanje = 'n';

void loop() {
  if(Serial.available() > 0) {
    ulaz = Serial.read();

    if(ulaz == 'H') {
      digitalWrite(LED_BUILTIN, HIGH);
      stanje = 'h';
    }
    if(ulaz == 'L') {
      digitalWrite(LED_BUILTIN, LOW);
      stanje = 'l';
    }
  }

  if(stanje == 'l' || stanje == 'h') {
    Serial.print(stanje);
    stanje = 'n';  
  }
}


