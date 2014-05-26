#include <stdio.h>

int count(int number, int digit) {
	if(number == 0) {
		return 0;
	}

	if(number % 10 == digit) {
		return 1 + count(number / 10, digit);
	}
	else {
		return count(number / 10, digit);
	}
}

int main() {

	int number, digit;

	printf("Enter a number: ");
	scanf("%d", &number);
	printf("Enter a digit: ");
	scanf("%d", &digit);

	int x = count(number, digit);

	printf("Number %d has %d digits (%d) in it.\n", number, x, digit);
	return 0;
}