import sys
import keyboard


while True:
    try:
        if keyboard.is_pressed('q'):
            print('pressed q')
            break
    except:
        break
print("hello")

open('recording.txt', 'w').close()
