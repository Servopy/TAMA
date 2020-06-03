#curses ve GPIO import edilir.
#bastiktan sonra o yone Allah ne verdiyse
import curses
import RPi.GPIO as GPIO
from time import sleep

def aciAyarlama(gelenAci):
	duty = float(gelenAci) / 18.0 + 2.5
	GPIO.output(servo, True)
	servoPWM.ChangeDutyCycle(duty)
        #sleep(0.2)
	#GPIO.output(servo, False)
	#servoPWM.ChangeDutyCycle(0)

GPIO.setwarnings(False)

#GPIO modu ve output pinleri belirlenir
GPIO.setmode(GPIO.BOARD)

servo = 11

GPIO.setup(servo,GPIO.OUT)

servoPWM = GPIO.PWM(servo, 50)

servoPWM.start(0)
aci = 90
atlamaAcisi = 5

#Curses penceresi acilir, klavyeden ekrana echo modu kapatilir, girilen komutlara hemen cevap verilmesi saglanir.
screen = curses.initscr()
curses.noecho()  
curses.cbreak()
curses.halfdelay(3)
screen.keypad(True)

try:
        while True: 
            char = screen.getch()
            if char == ord('q'):
                break
            elif char == ord('a') or char == ord('A'):
                for i in range(aci, 180, atlamaAcisi):
                        aci = i
                        aciAyarlama(i)
                        char = screen.getch()
                        if char == ord(' ') or char == ord('d') or char == ord('D') or char == ord('q'):
                                break
            elif char == ord('d') or char == ord('D'):
                for i in range(aci, 0, -atlamaAcisi):
                        aci = i
                        aciAyarlama(i)
                        char = screen.getch()
                        if char == ord(' ') or char == ord('a') or char == ord('A') or char == ord('q'):
                                break
            GPIO.output(servo, False)
            servoPWM.ChangeDutyCycle(0)
             
finally:
    curses.nocbreak()
    screen.keypad(0)
    curses.echo()
    curses.endwin()
    GPIO.cleanup()
