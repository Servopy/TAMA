import RPi.GPIO as GPIO

GPIO.setwarnings(False)

#GPIO modu ve output pinleri belirlenir
GPIO.setmode(GPIO.BOARD)

motor1a = 11 #sag ileri
motor1b = 7  #sag geri
motor1e = 22

motor2a = 13 
motor2b = 16
motor2e = 15

GPIO.setup(motor1a,GPIO.OUT)
GPIO.setup(motor1b,GPIO.OUT)
GPIO.setup(motor1e,GPIO.OUT)
GPIO.setup(motor2a,GPIO.OUT)
GPIO.setup(motor2b,GPIO.OUT)
GPIO.setup(motor2e,GPIO.OUT)

motor1PWM = GPIO.PWM(motor1e, 100)
motor2PWM = GPIO.PWM(motor2e, 100)

motorHizi = 20

#Curses penceresi acilir, klavyeden ekrana echo modu kapatilir, girilen komutlara hemen cevap verilmesi saglanir.
import socket
import threading
from os import popen

bind_ip = "192.168.43.196"
bind_port = 9999
server = socket.socket(socket.AF_INET, socket.SOCK_STREAM)

server.bind((bind_ip,bind_port))

server.listen(5)

print("[*] Listening on %s:%d" % (bind_ip,bind_port))

def handle_client(client_socket):
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

while True:
	client, addr = server.accept()
	print("[*] Accepted Connetion From: %s" % addr[0])
	client_handler = threading.Thread(target=handle_client,args=(client,))
	client_handler.start()

