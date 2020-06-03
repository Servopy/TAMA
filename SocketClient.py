import socket
import msvcrt

target_host = "192.168.43.196"
target_port = 6767



while True:
    client = socket.socket(socket.AF_INET,socket.SOCK_STREAM)
    client.connect((target_host,target_port))
    req = msvcrt.getch().decode('utf-8')
    client.send(req.encode('utf-8'))
    response = client.recv(1024)
    print(response.decode('utf-8'))
    client.close()
