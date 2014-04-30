#include <iostream>
#include <string>
#include "priority_queue.h" 

using namespace std;

int main() {

	queue people;

	people.enqueue("Suzi", 4);
	people.enqueue("Emili", 4);
	people.enqueue("Humra", 2);
	people.enqueue("Tihana", 5);

	return 0;
}
