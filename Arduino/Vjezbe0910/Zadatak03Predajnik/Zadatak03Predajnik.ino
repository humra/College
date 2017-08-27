#include <VirtualWire.h>

char message;
char messageToSend[3];

void setup() {
  Serial.begin(9600);
  messageToSend[0]= '6';
  messageToSend[1]= '6';
  
  vw_set_ptt_inverted(true);
  vw_set_tx_pin(31);
  vw_setup(1000);
}

void loop() {
  
  if(Serial.available() > 0) {
    message = Serial.read();
    messageToSend[2] = message;
    vw_send((uint8_t*)messageToSend, 3);
    vw_wait_tx();
  }

}

