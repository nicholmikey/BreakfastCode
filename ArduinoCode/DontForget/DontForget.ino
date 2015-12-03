/* BreakfastSweep
  This project uses some SWEEP code by BARRAGAN <http://barraganstudio.com>
*/

//dont you forget about me

#include <Servo.h>
#define BAUD_RATE 9600

Servo myservo;  // create servo object to control a servo
// twelve servo objects can be created on most boards

int pos = 0;    // variable to store the servo position
int message = 0; // This will hold one byte of the serial message
void setup() {
  myservo.attach(9);  // attaches the servo on pin 9 to the servo object
  Serial.begin(BAUD_RATE);
}


void loop() {
  myservo.write(0);
  if (Serial.available() > 0) { // Check to see if there is a new message
    message = Serial.read(); // Put the serial input into the message

    if (message == 'a') { // If a capitol A is received

      for (pos = 0; pos <= 90; pos += 1) { // goes from 0 degrees to 90 degrees
        // in steps of 1 degree
        myservo.write(pos);              // tell servo to go to position in variable 'pos'
        delay(5);                       // waits 5ms for the servo to reach the position
      }

      delay(5000);
      myservo.write(0); //set back to starting position
    }
  }
}



