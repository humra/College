#ifndef _PRIORITY_QUEUE_H_
#define	_PRIORITY_QUEUE_H_

#include <string>

using namespace std;

struct node;
typedef node* POSITION;

struct node {
    string element;
    int priority;
    POSITION next;
};

class queue {
private:
    POSITION _head;
    POSITION _tail;
    
public:
    queue();
    bool isEmpty();
    bool enqueue(string element, int priority);
    bool dequeue(string& element);
    bool front(string& element);
    POSITION lastBeforeLower(int priority);
};

#endif

