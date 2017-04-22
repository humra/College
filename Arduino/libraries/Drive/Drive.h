#include <Arduino.h>

#ifndef Drive_h
#define Drive_h

class Drive 
{
	public:
		Drive(byte motor_left_pwr, byte motor_left_gnd, byte motor_left_pwm, byte motor_right_pwr, byte motor_right_gnd, byte motor_right_pwm);
		void driveForward(short speed);
		void driveForward();
		void driveBackwards(short speed);
		void driveBackwards();
		void leftWheelForward(short speed);
		void rightWheelForward(short speed);
		void leftWheelBackwards(short speed);
		void rightWheelBackwards(short speed);
		void stopDriving();
		void easyRight();
		void mediumRight();
		void hardRight();
		void easyLeft();
		void mediumLeft();
		void hardLeft();
		void turnAround();
		
	private:
		byte LEFT_WHEEL[3];
		byte RIGHT_WHEEL[3];
		short DEFAULT_MAX_SPEED;
};

#endif