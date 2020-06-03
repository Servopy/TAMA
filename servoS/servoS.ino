#include <Servo.h>
String gelenAci1,
       gelenAci2,
       gelenAci3,
       gelenAci4;
Servo servo1,
      servo2,
      servo3,
      servo4 ;
String gelenDeger = "90,90,90,90";
//25,29,165,81
int ayirmakIcin = 1 ;
void ayirAyirDur() {
  for (int i = 0; i <= gelenDeger.length() + 1; i++) {
    if (ayirmakIcin == 1) {
      if (gelenDeger[i] == ',') {
        ayirmakIcin++;
      }
      else {
        gelenAci1 += gelenDeger.charAt(i);
      }
    }
    else if (ayirmakIcin == 2) {
      if (gelenDeger[i] == ',') {
        ayirmakIcin++;
      }
      else {
        gelenAci2 += gelenDeger.charAt(i);
      }
    }
    else if (ayirmakIcin == 3) {
      if (gelenDeger[i] == ',') {
        ayirmakIcin++;
      }
      else {
        gelenAci3 += gelenDeger.charAt(i);
      }
    }
    else if (ayirmakIcin == 4) {
      if (gelenDeger[i] == '\0') {
        ayirmakIcin++;
      }
      else {
        gelenAci4 += gelenDeger.charAt(i);
      }
    }
    //---------------------------
    else if (ayirmakIcin == 5) {
      int gelenAci1Int = gelenAci1.toInt();
      int gelenAci2Int = gelenAci2.toInt();
      int gelenAci3Int = gelenAci3.toInt();
      int gelenAci4Int = gelenAci4.toInt();
      ayirmakIcin++;
      servo1.attach(A1);
      servo2.attach(A2);
      servo3.attach(A3);
      servo4.attach(A4);
      servo1.write(gelenAci1Int);
      servo2.write(gelenAci2Int);
      servo3.write(gelenAci3Int);
      servo4.write(gelenAci4Int);
      delay(75);
      servo1.detach();
      servo2.detach();
      servo3.detach();
      servo4.detach();
    }
  }
}
void setup() {
  Serial.begin(9600);
  servo1.attach(A1);
  servo2.attach(A2);
  servo3.attach(A3);
  servo4.attach(A4);
}
void loop() {
  if (Serial.available()) {
    gelenDeger = Serial.readString();
    ayirmakIcin = 1 ;
    gelenAci1 = "";
    gelenAci2 = "";
    gelenAci3 = "";
    gelenAci4 = "";
    ayirAyirDur();
  } else {
      servo1.detach();
      servo2.detach();
      servo3.detach();
      servo4.detach();
  }
}
