import socket
import threading
from os import popen

bind_ip = "192.168.43.196"
bind_port = 9988
server = socket.socket(socket.AF_INET, socket.SOCK_STREAM)

server.bind((bind_ip,bind_port))

server.listen(5)

print("[*] Listening on %s:%d" % (bind_ip,bind_port))

def handle_client(client_socket):
	request = client_socket.recv(1024)
	client_socket.send("Received: %s" % (request.decode('utf-8')).encode('utf-8'))
	client_socket.close()
	
while True:
	client, addr = server.accept()
	print("[*] Accepted Connetion From: %s" % addr[0])
	client_handler = threading.Thread(target=handle_client,args=(client,))
	client_handler.start()
