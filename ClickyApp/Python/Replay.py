import sys
import keyboard
import pickle
from multiprocessing import Process
import time


with open("recording.txt", 'rb') as openfile:
    recorded = pickle.load(openfile)

Clicking = True
time.sleep(3)
print(recorded)
keyboard.play(recorded, speed_factor=0.05)

def Clicking_loop():
    while(Clicking):
        print(recorded)
        #keyboard.play(recorded, speed_factor=0.1)

def stop_check():
    while True:
        try:
            if keyboard.is_pressed('q'):
                print('pressed q')
                Clicking = False
                break
        except:
            break
    


#Process(target=Clicking_loop).start()
#stop_check()
