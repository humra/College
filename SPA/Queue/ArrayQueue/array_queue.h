#ifndef _ARRAY_QUEUE_H_
#define _ARRAY_QUEUE_H_

using namespace std;

class queue {
private:
	static const unsigned int CAPACITY = 6;
	string _elements[CAPACITY];
	unsigned int _head;
	unsigned int _tail;
	bool _isFull();

public:
	queue();
	bool isEmpty();
	bool enqueue(string element);
	bool dequeue(string& element);
	bool front(string& element);
};

#endif