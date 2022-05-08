import sys
import mouse
import keyboard
import time

recorded = []

while True:
    if keyboard.is_pressed('n'):
        print("started recording... ")
        mouse.hook(recorded.append)
        keyboard.wait('esc')
        mouse.unhook(recorded.append)
        print("finished recording... ")
        break


print("out of loop 1")
print(recorded)

while True:
    try:
        if keyboard.is_pressed('q'):
            print("started pressing and moving... ")
            mouse.play(recorded, speed_factor=250.0,include_clicks=True, include_moves=True)
            print("finished pressing and moving... ")
            break
    except:
        continue
print("done")
