import speech_recognition as sr 

r = sr.Recognizer() 

audio = 'audio.wav' 

with sr.AudioFile(audio) as source: 
  filename = r.listen(source) 

try:
  text = r.recognize_google(filename)
  print(text)

except Exception as e: 
  print(e)
