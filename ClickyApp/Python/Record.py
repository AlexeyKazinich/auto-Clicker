import sys
import keyboard
import pickle



recorded = keyboard.record(until='tab')

open('recording.txt', 'w').close()

with open("recording.txt", 'wb') as outp:
    pickle.dump(recorded,outp,pickle.HIGHEST_PROTOCOL)
