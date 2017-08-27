#include <VirtualWire.h>

uint8_t buff[VW_MAX_MESSAGE_LEN];
uint8_t buffLen = VW_MAX_MESSAGE_LEN;

const int redPin = 13;
bool on = false;

void setup() {
  pinMode(redPin, OUTPUT);
  vw_set_ptt_inverted(true);
  vw_set_rx_pin(24);
  vw_setup(1000);
  vw_rx_start();
}

void loop() {
  if(vw_get_message(buff, &buffLen)) {
    if (buff[0]=='6' && buff[1] == '6') {
      switch(buff[2]) {
        case '1':
          on = true;
          break;
        case '0':
          on = false;
          break;
        }
      buffLen = VW_MAX_MESSAGE_LEN;
      memset(buff,0,buffLen);
    }
  }

  if(on) {
    digitalWrite(redPin, HIGH);
  }
  else {
    digitalWrite(redPin, LOW);
  }
}

