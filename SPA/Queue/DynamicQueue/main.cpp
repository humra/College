#include <iostream>
#include "dynamic_queue.h"

using namespace std;

int main() {
    
    queue numbers;

    numbers.enqueue(4);
    numbers.enqueue(7);
    numbers.enqueue(42);
    numbers.enqueue(12);

    int temp = 999;
    numbers.dequeue(temp);
    
    return 0;
}

