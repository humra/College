#include <VirtualWire.h>
#include <Drive.h>

uint8_t buff[VW_MAX_MESSAGE_LEN];
uint8_t buffLen = VW_MAX_MESSAGE_LEN;
Drive drive(2, 3, 8, 4, 5, 9);

void setup() {
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
          drive.hardLeft();
          break;
        case '2':
          drive.hardRight();
          break;      
        case '0':
          drive.stopDriving();
          break;
        }
      buffLen = VW_MAX_MESSAGE_LEN;
      memset(buff, 0, buffLen);
    }
  }
}

