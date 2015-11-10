#ifndef _DYNAMIC_QUEUE_H_
#define	_DYNAMIC_QUEUE_H_

typedef int ELTYPE;
struct node;
typedef node* POSITION;

struct node {
    ELTYPE element;
    POSITION next;
};

class queue {
private:
    POSITION _head;
    POSITION _tail;
    
public:
    queue();
    bool isEmpty();
    bool enqueue(ELTYPE element);
    bool dequeue(ELTYPE& element);
    bool front(ELTYPE& element);
};

#endif

