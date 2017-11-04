int thisByte = 33;

void setup() {
  Serial.begin(9600);
}

void loop() {
  Serial.write(thisByte);
  Serial.print(", dec: ");
  Serial.print(thisByte, DEC);
  Serial.print(", hex: ");  
  Serial.print(thisByte, HEX);
  Serial.print(", bin: ");
  Serial.print(thisByte, BIN);
  Serial.println();
  delay(500);

  if(thisByte == 126)   {
    while(true) {
      continue;
    }
  }

  thisByte++;
}
