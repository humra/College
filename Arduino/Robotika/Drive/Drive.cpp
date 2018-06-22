#include <Arduino.h>
#include <Drive.h>

Drive::Drive(byte motor_left_pwr, byte motor_left_gnd, byte motor_left_pwm, byte motor_right_pwr, byte motor_right_gnd, byte motor_right_pwm) {
	LEFT_WHEEL[1] = motor_left_pwr;
	LEFT_WHEEL[0] = motor_left_gnd;
	LEFT_WHEEL[2] = motor_left_pwm;
	
	RIGHT_WHEEL[1] = motor_right_pwr;
	RIGHT_WHEEL[0] = motor_right_gnd;
	RIGHT_WHEEL[2] = motor_right_pwm;
	
	DEFAULT_MAX_SPEED = 255;
	
	pinMode(LEFT_WHEEL[0], OUTPUT);
	pinMode(LEFT_WHEEL[1], OUTPUT);
	pinMode(LEFT_WHEEL[2], OUTPUT);
	pinMode(RIGHT_WHEEL[0], OUTPUT);
	pinMode(RIGHT_WHEEL[1], OUTPUT);
	pinMode(RIGHT_WHEEL[2], OUTPUT);
}

void Drive::driveBackwards(short speed) {
	digitalWrite(LEFT_WHEEL[0], HIGH);
	digitalWrite(RIGHT_WHEEL[0], HIGH);
	analogWrite(LEFT_WHEEL[2], speed);
	analogWrite(RIGHT_WHEEL[2], speed);
}

void Drive::driveBackwards() {
	digitalWrite(LEFT_WHEEL[0], HIGH);
	digitalWrite(RIGHT_WHEEL[0], HIGH);
	analogWrite(LEFT_WHEEL[2], DEFAULT_MAX_SPEED);
	analogWrite(RIGHT_WHEEL[2], DEFAULT_MAX_SPEED);
}

void Drive::driveForward(short speed) {
	digitalWrite(LEFT_WHEEL[1], HIGH);
	digitalWrite(RIGHT_WHEEL[1], HIGH);
	analogWrite(LEFT_WHEEL[2], speed);
	analogWrite(RIGHT_WHEEL[2], speed);
}

void Drive::driveForward() {
	digitalWrite(LEFT_WHEEL[1], HIGH);
	digitalWrite(RIGHT_WHEEL[1], HIGH);
	analogWrite(LEFT_WHEEL[2], DEFAULT_MAX_SPEED);
	analogWrite(RIGHT_WHEEL[2], DEFAULT_MAX_SPEED);
}

void Drive::stopDriving() {
	digitalWrite(LEFT_WHEEL[0], LOW);
	digitalWrite(LEFT_WHEEL[1], LOW);
	digitalWrite(RIGHT_WHEEL[0], LOW);
	digitalWrite(RIGHT_WHEEL[1], LOW);
}

void Drive::leftWheelBackwards(short speed) {
	digitalWrite(LEFT_WHEEL[0], HIGH);
	analogWrite(LEFT_WHEEL[2], speed);
}

void Drive::leftWheelForward(short speed) {
	digitalWrite(LEFT_WHEEL[1], HIGH);
	analogWrite(LEFT_WHEEL[2], speed);
}

void Drive::rightWheelBackwards(short speed) {
	digitalWrite(RIGHT_WHEEL[0], HIGH);
	analogWrite(RIGHT_WHEEL[2], speed);
}

void Drive::rightWheelForward(short speed) {
	digitalWrite(RIGHT_WHEEL[1], HIGH);
	analogWrite(RIGHT_WHEEL[2], speed);
}

void Drive::easyRight() {
	digitalWrite(RIGHT_WHEEL[1], HIGH);
	digitalWrite(LEFT_WHEEL[1], HIGH);
	analogWrite(RIGHT_WHEEL[2], DEFAULT_MAX_SPEED * 90 / 100);
	analogWrite(LEFT_WHEEL[2], DEFAULT_MAX_SPEED);
}

void Drive::mediumRight() {
	digitalWrite(RIGHT_WHEEL[1], HIGH);
	digitalWrite(LEFT_WHEEL[1], HIGH);
	analogWrite(RIGHT_WHEEL[2], DEFAULT_MAX_SPEED * 75 / 100);
	analogWrite(LEFT_WHEEL[2], DEFAULT_MAX_SPEED);
}

void Drive::hardRight() {
	digitalWrite(RIGHT_WHEEL[1], LOW);
	digitalWrite(LEFT_WHEEL[1], HIGH);
	analogWrite(LEFT_WHEEL[2], DEFAULT_MAX_SPEED);
}

void Drive::easyLeft() {
	digitalWrite(RIGHT_WHEEL[1], HIGH);
	digitalWrite(LEFT_WHEEL[1], HIGH);
	analogWrite(RIGHT_WHEEL[2], DEFAULT_MAX_SPEED);
	analogWrite(LEFT_WHEEL[2], DEFAULT_MAX_SPEED * 90 / 100);
}

void Drive::mediumLeft() {
	digitalWrite(RIGHT_WHEEL[1], HIGH);
	digitalWrite(LEFT_WHEEL[1], HIGH);
	analogWrite(RIGHT_WHEEL[2], DEFAULT_MAX_SPEED);
	analogWrite(LEFT_WHEEL[2], DEFAULT_MAX_SPEED * 75 / 100);
}

void Drive::hardLeft() {
	digitalWrite(RIGHT_WHEEL[1], HIGH);
	digitalWrite(LEFT_WHEEL[1], LOW);
	analogWrite(RIGHT_WHEEL[2], DEFAULT_MAX_SPEED);
}

void Drive::turnAround() {
	leftWheelBackwards(DEFAULT_MAX_SPEED);
	rightWheelForward(DEFAULT_MAX_SPEED);
}