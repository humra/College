#include <iostream>
#include "dinamicki_red.h"

using namespace std;

queue::queue() {
    _head = new node;
    _tail = new node;
    
    _head->next = nullptr;
    _tail->next = nullptr;
}

bool queue::isEmpty() {
    if(_head->next == _tail && _tail->next == nullptr) {
        return true;
    }
    return false;
}

bool queue::enqueue(ELTYPE element) {
    POSITION temp = new node;

    temp->element = element;
    temp->next = nullptr;

    if(_head->next == nullptr) {
        _head->next = temp;
    }
    if(_tail->next != nullptr) {
        _tail->next->next = temp;
    }
    _tail->next = temp;
    return true;
}

bool queue::dequeue(ELTYPE& element) {
    if(isEmpty()) {
        return false;
    }

    POSITION first = _head->next;
    if(first->next == nullptr) {
        _head->next = nullptr;
        _tail->next = nullptr;
    }
    else {
        _head->next = first->next;
    }

    element = first->element;
    cout << "Deleted: " << element << endl;
    delete first;
    return true;
}

bool queue::front(ELTYPE& element) {
    if(isEmpty()) {
        return false;
    }

    element = _head->next->element;
    return true;
}