int soundPin = 9;
int ledPin = 10;
int dotLen = 200;
int dashLen = dotLen * 3;
int charPauseLen = dotLen;
int spaceLen = dashLen;
int wordPauseLen = dotLen * 7;
int note = 50;

String sentence;

void setup() {
  pinMode(soundPin, OUTPUT);
  pinMode(ledPin, OUTPUT);
  Serial.begin(9600);
}

void loop() {
  if(Serial.available() > 0) {
    sentence = Serial.readString();
  }

  if(sentence.length() > 0) {
    convertToMorse(sentence);
  }

  sentence = "";
}

void convertToMorse(String sentence) {
  for(int i = 0; i < sentence.length(); i++) {
    convertCharacter(sentence[i]);
  }
}

void morseDot() {
  digitalWrite(ledPin, HIGH);
  tone(soundPin, note, dotLen);
  delay(dotLen);
}

void morseDash() {
  digitalWrite(ledPin, HIGH);
  tone(soundPin, note, dashLen);
  delay(dashLen);
}

void turnOff(int delayTime) {
  digitalWrite(ledPin, LOW);
  noTone(soundPin);
  delay(delayTime);
}

void convertCharacter(char currentChar) {
  switch(currentChar) {
    case 'a':  
      morseDot();
      turnOff(charPauseLen);
      morseDash();
      turnOff(charPauseLen);
      break;
    case 'b':
      morseDash();
      turnOff(charPauseLen);
      morseDot();
      turnOff(charPauseLen);
      morseDot();
      turnOff(charPauseLen);
      morseDot();
      turnOff(charPauseLen);
      break;
    case 'c':
      morseDash();
      turnOff(charPauseLen);
      morseDot();
      turnOff(charPauseLen);
      morseDash();
      turnOff(charPauseLen);
      morseDot();
      turnOff(charPauseLen);
      break;
    case 'd':
      morseDash();
      turnOff(charPauseLen);
      morseDash();
      turnOff(charPauseLen);
      morseDot();
      turnOff(charPauseLen);
      break;
    case 'e':
      morseDot();
      turnOff(charPauseLen);
      break;
    case 'f':
      morseDot();
      turnOff(charPauseLen);
      morseDot();
      turnOff(charPauseLen);
      morseDash();
      turnOff(charPauseLen);
      morseDot();
      turnOff(charPauseLen);
      break;
    case 'g':
      morseDash();
      turnOff(charPauseLen);
      morseDash();
      turnOff(charPauseLen);
      morseDot();
      turnOff(charPauseLen);
      break;
    case 'h':
      morseDot();
      turnOff(charPauseLen);
      morseDot();
      turnOff(charPauseLen);
      morseDot();
      turnOff(charPauseLen);
      morseDot();
      turnOff(charPauseLen);
      break;
    case 'i':
      morseDot();
      turnOff(charPauseLen);
      morseDot();
      turnOff(charPauseLen);
      break;
    case 'j':
      morseDot();
      turnOff(charPauseLen);
      morseDash();
      turnOff(charPauseLen);
      morseDash();
      turnOff(charPauseLen);
      morseDash();
      turnOff(charPauseLen);
      break;
    case 'k':
      morseDash();
      turnOff(charPauseLen);
      morseDot();
      turnOff(charPauseLen);
      morseDash();
      turnOff(charPauseLen);
      break;
    case 'l':
      morseDot();
      turnOff(charPauseLen);
      morseDash();
      turnOff(charPauseLen);
      morseDot();
      turnOff(charPauseLen);
      morseDot();
      turnOff(charPauseLen);
      break;
    case 'm':
      morseDash();
      turnOff(charPauseLen);
      morseDash();
      turnOff(charPauseLen);
      break;
    case 'n':
      morseDash();
      turnOff(charPauseLen);
      morseDot();
      turnOff(charPauseLen);
      break;
    case 'o':
      morseDash();
      turnOff(charPauseLen);
      morseDash();
      turnOff(charPauseLen);
      morseDash();
      turnOff(charPauseLen);
      break;
    case 'p':
      morseDot();
      turnOff(charPauseLen);
      morseDash();
      turnOff(charPauseLen);
      morseDash();
      turnOff(charPauseLen);
      morseDot();
      turnOff(charPauseLen);
      break;
    case 'q':
      morseDash();
      turnOff(charPauseLen);
      morseDash();
      turnOff(charPauseLen);
      morseDot();
      turnOff(charPauseLen);
      morseDash();
      turnOff(charPauseLen);
      break;
    case 'r':
      morseDot();
      turnOff(charPauseLen);
      morseDash();
      turnOff(charPauseLen);
      morseDot();
      turnOff(charPauseLen);
      break;
    case 's':
      morseDot();
      turnOff(charPauseLen);
      morseDot();
      turnOff(charPauseLen);
      morseDot();
      turnOff(charPauseLen);
      break;
    case 't':
      morseDash();
      turnOff(charPauseLen);
      break;
    case 'u':
      morseDot();
      turnOff(charPauseLen);
      morseDot();
      turnOff(charPauseLen);
      morseDash();
      turnOff(charPauseLen);
      break;
    case 'v':
      morseDot();
      turnOff(charPauseLen);
      morseDot();
      turnOff(charPauseLen);
      morseDot();
      turnOff(charPauseLen);
      morseDash();
      turnOff(charPauseLen);
      break;
    case 'w':
      morseDot();
      turnOff(charPauseLen);
      morseDash();
      turnOff(charPauseLen);
      morseDash();
      turnOff(charPauseLen);
      break;
    case 'x':
      morseDash();
      turnOff(charPauseLen);
      morseDot();
      turnOff(charPauseLen);
      morseDot();
      turnOff(charPauseLen);
      morseDash();
      turnOff(charPauseLen);
      break;
    case 'y':
      morseDash();
      turnOff(charPauseLen);
      morseDot();
      turnOff(charPauseLen);
      morseDash();
      turnOff(charPauseLen);
      morseDash();
      turnOff(charPauseLen);
      break;
    case 'z':
      morseDash();
      turnOff(charPauseLen);
      morseDash();
      turnOff(charPauseLen);
      morseDot();
      turnOff(charPauseLen);
      morseDot();
      turnOff(charPauseLen);
      break;
    default:
      turnOff(wordPauseLen);            
  }
}



