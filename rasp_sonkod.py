import RPi.GPIO as GPIO
from time import sleep
import socket
import threading
from os import popen
import array as arr
import serial

GPIO.setwarnings(False)

#GPIO modu ve output pinleri belirlenir
GPIO.setmode(GPIO.BOARD)

motor1a = 11 #sag ileri
motor1b = 7  #sag geri
motor1e = 22

motor2a = 13 
motor2b = 16
motor2e = 15

aci1 = 90
aci2 = 90
aci3 = 90
aci4 = 90
atlamaAcisi = 13
acilar = arr.array('i', [aci1,aci2,aci3,aci4])

ser = serial.Serial('/dev/ttyUSB0', 9600, timeout=1)
ser.flush()

GPIO.setup(motor1a,GPIO.OUT)
GPIO.setup(motor1b,GPIO.OUT)
GPIO.setup(motor1e,GPIO.OUT)
GPIO.setup(motor2a,GPIO.OUT)
GPIO.setup(motor2b,GPIO.OUT)
GPIO.setup(motor2e,GPIO.OUT)

motor1PWM = GPIO.PWM(motor1e, 100)
motor2PWM = GPIO.PWM(motor2e, 100)

motorHizi = 20

servo1 = 37 #Taban
servo2 = 31 #Agiz
servo3 = 33 #Alt Kol
servo4 = 35 #Ust Kol
GPIO.setup(servo1,GPIO.OUT)
GPIO.setup(servo2,GPIO.OUT)
GPIO.setup(servo3,GPIO.OUT)
GPIO.setup(servo4,GPIO.OUT)
servo1PWM = GPIO.PWM(servo1, 50)
servo2PWM = GPIO.PWM(servo2, 50)
servo3PWM = GPIO.PWM(servo3, 50)
servo4PWM = GPIO.PWM(servo4, 50)

servo1PWM.start(0)
servo2PWM.start(0)
servo3PWM.start(0)
servo4PWM.start(0)


"""def aciAyarlama1(gelenAci):
	duty = float(gelenAci) / 18.0 + 2.5
	GPIO.output(servo1, True)
	servo1PWM.ChangeDutyCycle(duty)
    #sleep(0.2)
	#GPIO.output(servo, False)
	#servoPWM.ChangeDutyCycle(0)
def aciAyarlama2(gelenAci):
	duty = float(gelenAci) / 18.0 + 2.5
	GPIO.output(servo2, True)
	servo2PWM.ChangeDutyCycle(duty)
    #sleep(0.2)
	#GPIO.output(servo, False)
	#servoPWM.ChangeDutyCycle(0)
def aciAyarlama3(gelenAci):
	duty = float(gelenAci) / 18.0 + 2.5
	GPIO.output(servo3, True)
	servo3PWM.ChangeDutyCycle(duty)
    #sleep(0.2)
	#GPIO.output(servo, False)
	#servoPWM.ChangeDutyCycle(0)
def aciAyarlama4(gelenAci):
	duty = float(gelenAci) / 18.0 + 2.5
	GPIO.output(servo4, True)
	servo4PWM.ChangeDutyCycle(duty)
    #sleep(0.2)
	#GPIO.output(servo, False)
	#servoPWM.ChangeDutyCycle(0)"""

bind_ip = "192.168.43.196"
bind_port = 6767
server = socket.socket(socket.AF_INET, socket.SOCK_STREAM)

server.bind((bind_ip,bind_port))

server.listen(5)

print("[*] Listening on %s:%d" % (bind_ip,bind_port))

def handle_client(client_socket):
	global aci1
	global aci2
	global aci3
	global aci4
	global atlamaAcisi
	global acilar
	
	request = client_socket.recv(1024)
	char = request.decode('utf-8')
	client_socket.send("Received: %s" % (request.decode('utf-8')).encode('utf-8'))
	client_socket.close()
	if char == 'q':
		GPIO.cleanup()
	elif char == 'w' or char == 'W':
		GPIO.output(motor1a,GPIO.HIGH)
		GPIO.output(motor1b,GPIO.LOW)
		motor1PWM.start(motorHizi)
		
		GPIO.output(motor2a,GPIO.HIGH)
		GPIO.output(motor2b,GPIO.LOW)
		motor2PWM.start(motorHizi)
	elif char == 'a' or char == 'A':
		GPIO.output(motor1a,GPIO.HIGH)
		GPIO.output(motor1b,GPIO.LOW)
		motor1PWM.start(motorHizi)
		
		GPIO.output(motor2a,GPIO.LOW)
		GPIO.output(motor2b,GPIO.HIGH)
		motor2PWM.start(motorHizi)
	elif char == 'd' or char == 'D':
		GPIO.output(motor1a,GPIO.LOW)
		GPIO.output(motor1b,GPIO.HIGH)
		motor1PWM.start(motorHizi)
		
		GPIO.output(motor2a,GPIO.HIGH)
		GPIO.output(motor2b,GPIO.LOW)
		motor2PWM.start(motorHizi)
	elif char == 's' or char == 'S':
		GPIO.output(motor1a,GPIO.LOW)
		GPIO.output(motor1b,GPIO.HIGH)
		motor1PWM.start(motorHizi)
		
		GPIO.output(motor2a,GPIO.LOW)
		GPIO.output(motor2b,GPIO.HIGH)
		motor2PWM.start(motorHizi)
	elif char == ' ':
		GPIO.output(motor1a,GPIO.LOW)
		GPIO.output(motor1b,GPIO.LOW)
		GPIO.output(motor1e,GPIO.LOW)
		
		GPIO.output(motor2a,GPIO.LOW)
		GPIO.output(motor2b,GPIO.LOW)
		GPIO.output(motor2e,GPIO.LOW)
		
		GPIO.output(servo1, False)
		GPIO.output(servo2, False)
		GPIO.output(servo3, False)
		GPIO.output(servo4, False)
		servo1PWM.ChangeDutyCycle(0)	
		servo2PWM.ChangeDutyCycle(0)
		servo3PWM.ChangeDutyCycle(0)
		servo4PWM.ChangeDutyCycle(0)
		
	elif char == 'v' or char == 'V':
		aci1 += atlamaAcisi
		if aci1 > 180:
			aci1 = 180
		else :
			acilar[0] = aci1
			paket = str(acilar[0]) + ',' + str(acilar[1]) + ',' + str(acilar[2]) + ',' + str(acilar[3])
			print(paket)
			ser.write(paket.encode('utf-8'))
					
	elif char == 'b' or char == 'B':
		aci1 -= atlamaAcisi
		if aci1 < 0:
			aci1 = 0
		else :
			acilar[0] = aci1
			paket = str(acilar[0]) + ',' + str(acilar[1]) + ',' + str(acilar[2]) + ',' + str(acilar[3])
			print(paket)
			ser.write(paket.encode('utf-8'))
					
	
	elif char == 'j' or char == 'J':
		aci2 += atlamaAcisi
		if aci2 > 180:
			aci2 = 180
		else :
			acilar[1] = aci2
			paket = str(acilar[0]) + ',' + str(acilar[1]) + ',' + str(acilar[2]) + ',' + str(acilar[3])
			print(paket)
			ser.write(paket.encode('utf-8'))
					
	elif char == 'k' or char == 'K':
		aci2 -= atlamaAcisi
		if aci2 < 0:
			aci2 = 0
		else :
			acilar[1] = aci2
			paket = str(acilar[0]) + ',' + str(acilar[1]) + ',' + str(acilar[2]) + ',' + str(acilar[3])
			print(paket)
			ser.write(paket.encode('utf-8'))
					
					
	elif char == 'n' or char == 'N':
		aci3 += atlamaAcisi
		if aci3 > 180:
			aci3 = 180
		else :
			acilar[2] = aci3
			paket = str(acilar[0]) + ',' + str(acilar[1]) + ',' + str(acilar[2]) + ',' + str(acilar[3])
			print(paket)
			ser.write(paket.encode('utf-8'))
					
	elif char == 'm' or char == 'M':
		aci3 -= atlamaAcisi
		if aci3 < 0:
			aci3 = 0
		else :
			acilar[2] = aci3
			paket = str(acilar[0]) + ',' + str(acilar[1]) + ',' + str(acilar[2]) + ',' + str(acilar[3])
			print(paket)
			ser.write(paket.encode('utf-8'))

	
	elif char == 'g' or char == 'G':
		aci4 += atlamaAcisi
		if aci4 > 180:
			aci4 = 180
		else :
			acilar[3] = aci4
			paket = str(acilar[0]) + ',' + str(acilar[1]) + ',' + str(acilar[2]) + ',' + str(acilar[3])
			print(paket)
			ser.write(paket.encode('utf-8'))
					
	elif char == 'h' or char == 'H':
		aci4 -= atlamaAcisi
		if aci4 < 0:
			aci4 = 0
		else :
			acilar[3] = aci4
			paket = str(acilar[0]) + ',' + str(acilar[1]) + ',' + str(acilar[2]) + ',' + str(acilar[3])
			print(paket)
			ser.write(paket.encode('utf-8'))
				

while True:
	client, addr = server.accept()
	print("[*] Accepted Connetion From: %s" % addr[0])
	
	client_handler = threading.Thread(target=handle_client,args=(client,))
	client_handler.start()

