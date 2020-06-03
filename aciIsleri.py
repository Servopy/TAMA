#curses ve GPIO import edilir.
#bastiktan sonra o yone Allah ne verdiyse
import curses
import RPi.GPIO as GPIO
from time import sleep

def aciAyarlamaTaban(gelenAci):
	duty = float(gelenAci) / 18.0 + 2.5
	GPIO.output(servoTaban, True)
	servoTabanPWM.ChangeDutyCycle(duty)
def aciAyarlamaAlt1(gelenAci):
	duty = float(gelenAci) / 18.0 + 2.5
	GPIO.output(servoAlt1, True)
	servoAlt1PWM.ChangeDutyCycle(duty)
def aciAyarlamaAlt2(gelenAci):
	duty = float(gelenAci) / 18.0 + 2.5
	GPIO.output(servoAlt2, True)
	servoAlt2PWM.ChangeDutyCycle(duty)
def aciAyarlamaAgiz(gelenAci):
	duty = float(gelenAci) / 18.0 + 2.5
	GPIO.output(servoAgiz, True)
	servoAgizPWM.ChangeDutyCycle(duty)

GPIO.setwarnings(False)

#GPIO modu ve output pinleri belirlenir
GPIO.setmode(GPIO.BOARD)

servoTaban = 11
servoAgiz = 12
servoAlt1 = 13
servoAlt2 = 15

GPIO.setup(servoTaban,GPIO.OUT)
GPIO.setup(servoAgiz,GPIO.OUT)
GPIO.setup(servoAlt1,GPIO.OUT)
GPIO.setup(servoAlt2,GPIO.OUT)

servoTabanPWM = GPIO.PWM(servoTaban, 50)
servoAgizPWM = GPIO.PWM(servoAgiz, 50)
servoAlt1PWM = GPIO.PWM(servoAlt1, 50)
servoAlt2PWM = GPIO.PWM(servoAlt2, 50)

servoTabanPWM.start(0)
servoAgizPWM.start(0)
servoAlt1PWM.start(0)
servoAlt2PWM.start(0)

tabanAci = 90
agizAci = 90
alt1Aci = 90
alt2Aci = 90

aciAyarlamaTaban(tabanAci)
aciAyarlamaAlt1(alt1Aci)
aciAyarlamaAlt2(alt2Aci)
aciAyarlamaAgiz(agizAci)

sleep(3)
