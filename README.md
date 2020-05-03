# videovoiceconverter

Inspiration

Many schools and universities are currently transitioning towards online classes and online learning, but students may not have the resources to watch easily watch all lectures in a day.

#What it does

V2T allows for professors or students to record an audio file and submit it into our program. The website then is able to translate and produce a script of the speech directly onto the webpage.

#How we built it

The frontend uses an HTML/CSS design with JavaScript to allow the audio file to be transferred to the Python program. We used a python audio library to translate the audio to text and outputted the data to Firebase for storage as a JSON file. Javascript will then read the JSON file and parse the text onto the screen.

#Challenges we ran into

Our biggest issue was being able to connect all the different programs together. We had difficulty using JavaScript to send the files to Python as well as using Python to send the files to Firebase. In the end, we were able to follow some tutorials and have it built nicely.

#Accomplishments that we're proud of

We are proud of the learning we have done this weekend. It was our first time working with Firebase and the python audio libraries.

#What we learned

After this experience, we have learned how to use Python and integrate frontend with backend to create a fully developed web application.

#What's next for V2T
We hope in the future, we can add a video component to V2T to allow for even more accessibility for students and teachers. We also hope to be able to output as a PDF document instead of creating a new webpage with the text.
