int potPin = A1;
int vrijednost;
int bluePin = 10;
int redPin = 9;
int greenPin = 11;
int izlaz;

void setup() {
  pinMode(potPin, INPUT);

  Serial.begin(9600);
}

void loop() {
  vrijednost = analogRead(potPin);
  Serial.println(vrijednost);

  //izlaz = map(vrijednost, 0, 1023, 1000, 5000);
  
  analogWrite(bluePin, 75);
  delay(vrijednost);
  analogWrite(bluePin, 0);
  delay(vrijednost);
  analogWrite(redPin, 75);
  delay(vrijednost);
  analogWrite(redPin, 0);
  delay(vrijednost);
  analogWrite(greenPin, 75);
  delay(vrijednost);
  analogWrite(greenPin, 0);
  delay(vrijednost);
}


