int incomingByte = 0;

void setup() {
  Serial.begin(9600);
}


void loop() {
  if(Serial.available() > 0) {
    incomingByte = Serial.read();


    Serial.println("Dolazni podatak: ");
    Serial.println(incomingByte, DEC);
    Serial.write(incomingByte);
    Serial.println();
    Serial.println();
  }
}
