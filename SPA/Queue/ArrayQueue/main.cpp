#include <iostream>
#include <string>
#include "array_queue.h"

using namespace std;

int main() {
	queue people;
	queue();

	people.enqueue("Emili");
	people.enqueue("Suzi");
	people.enqueue("Humra");
	cout << endl;

	string temp;
	people.dequeue(temp);
	cout << endl;

	return 0;
}