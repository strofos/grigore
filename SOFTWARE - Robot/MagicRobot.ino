
#define MotorAEnable 4
#define MotorA1 5
#define MotorA2 6

#define MotorBEnable 8
#define MotorB1 9
#define MotorB2 10

void setup(){
  Serial.begin(9600);
  pinMode(MotorAEnable, OUTPUT);
  pinMode(MotorA1, OUTPUT);
  pinMode(MotorA2, OUTPUT);

  pinMode(MotorBEnable, OUTPUT);
  pinMode(MotorB1, OUTPUT);
  pinMode(MotorB2, OUTPUT);
}


void loop() {
  if (Serial.available() > 0) {
    switch(Serial.read()) {
      case 'w': fw(); break;
      case 'd': right(); break;
      case 'a': left(); break;
      case 's': rv(); break;
    }
  }
  
  lock();
}

void lock(){  
  digitalWrite(MotorA1, LOW);
  digitalWrite(MotorA2, LOW);
  digitalWrite(MotorB1, LOW);
  digitalWrite(MotorB2, LOW);
  
  digitalWrite(MotorAEnable, LOW);
  digitalWrite(MotorBEnable, LOW);
}

void fw() {
  analogWrite(MotorB1, 200);
  digitalWrite(MotorB2, LOW);
  
  analogWrite(MotorA1, 200);
  digitalWrite(MotorA2, LOW);
  
  digitalWrite(MotorAEnable, HIGH);
  digitalWrite(MotorBEnable, HIGH);
  
  delay(500);
}

void rv() {
  analogWrite(MotorB2, 200);
  digitalWrite(MotorB1, LOW);
  
  analogWrite(MotorA2, 200);
  digitalWrite(MotorA1, LOW);
  
  digitalWrite(MotorAEnable, HIGH);
  digitalWrite(MotorBEnable, HIGH);
  
  delay(500);
}

void left() {
  analogWrite(MotorA1, 200);
  digitalWrite(MotorA2, LOW);
  analogWrite(MotorB2, 200);
  digitalWrite(MotorB1, LOW);
  
  digitalWrite(MotorAEnable, HIGH);
  digitalWrite(MotorBEnable, HIGH);
  
  delay(500);
}

void right() {  
  analogWrite(MotorA2, 200);
  digitalWrite(MotorA1, LOW);
  analogWrite(MotorB1, 200);
  digitalWrite(MotorB2, LOW);
  
  digitalWrite(MotorAEnable, HIGH);
  digitalWrite(MotorBEnable, HIGH);
  
  delay(500);
}
