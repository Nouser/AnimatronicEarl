#include <Servo.h>
Servo leftShoulder;
int lsPos = 25;
Servo rightShoulder;
int rsPos =0;
Servo leftElbow;
int lePos =0;
Servo rightElbow;
int rePos =0;
Servo leftHand;
int lhPos =0;
Servo rightHand;
int rhPos =0;

int ledBasicRed = 9;
int ledBasicGreen = 8;
int ledAdvancedGreen = 10;
int ledAdvancedRed = 11; 
boolean startingMotion;
void setup()
{
  //Set all the pins as output except the sensor. It's input.
  for(int i=0;i<16;i++)
  pinMode(i, OUTPUT);
  pinMode(1, INPUT);
  //Attach servos to pins
  leftShoulder.attach(7);
  rightShoulder.attach(6);
  leftElbow.attach(5);
  rightElbow.attach(4);
  leftHand.attach(3);
  rightHand.attach(2);
  //Write the appropriate positions for the shoulders and elbows
  leftShoulder.write(lsPos);
  rightShoulder.write(rsPos);
  leftElbow.write(lePos);
  rightElbow.write(rePos);
  //Start it up.
  Serial.begin(9600);
  Serial.print("y");
  digitalWrite(ledBasicRed, HIGH);
  digitalWrite(ledAdvancedRed, HIGH);
}

void loop() 
{/*
    if( Serial.available())
    {
      if(startingMotion==false)
      {
        char ch = Serial.read();
        switch(ch)
        {
            case 'z':
            Serial.print("x");
            break;
            case '1':
            //Move shoulder basically opposite of where it is.
            leftShoulder.write(lsPos+145);
            delay(2500);
            //Move it back.
            leftShoulder.write(lsPos);
            digitalWrite(7, HIGH);
            break;
            case '2':
            break;
            case '3':
            break;
            case '4':
            break;
            case '5':
            break;
            case '6':
            break;
        }
      }
      else
      {
        //Put movement for motion sesnor
        byte senseMotion = LOW;
        senseMotion = digitalRead(1);
        if(senseMotion==HIGH)
        {
          startingMotion = false;
          //Do movement for when he yells "GIMME A HAND!"
          Serial.print("y");
        }
      }
    }
    */
    moveArms();
}

void ledTurnOnForWhat()
{
  digitalWrite(ledBasicRed, LOW);
  digitalWrite(ledAdvancedRed, LOW);
  digitalWrite(ledBasicGreen, HIGH);
  digitalWrite(ledBasicGreen, HIGH);
}

void moveArms()
{
  //Move the shoulders as the biggest movement.
  lsPos+=5;
  leftShoulder.write(lsPos);
  rsPos-=5;
  rightShoulder.write(rsPos);
  //Then move the elbows a bit less
  lePos+=2;
  leftElbow.write(lePos);
  rsPos-=2;
  rightElbow.write(rePos);
}



















