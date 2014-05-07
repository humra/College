#include <iostream>
#include <string>
#include "priority_queue.h"

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

POSITION queue::lastBeforeLower(int priority) {
    POSITION temp = _head;

    while(temp != nullptr) {
        if(temp->next != nullptr && temp->next->priority < priority) {
            break;
        }
        temp = temp->next;
    }
    return temp;
}

bool queue::enqueue(string element, int priority) {
    POSITION temp = new node;
    temp->element = element;
    temp->priority = priority;
    temp->next = nullptr;

    if(isEmpty()) {
        _head->next = temp;
        _tail->next = temp;
        return true;
    }
    POSITION x = lastBeforeLower(priority);
    if(x != nullptr) {
        temp->next = x->next;
        x->next = temp;
    }
    else {
        _tail->next->next = temp;
        _tail->next = temp;
    }
    return true;
}


bool queue::dequeue(string& element) {
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

bool queue::front(string& element) {
    if(isEmpty()) {
        return false;
    }

    element = _head->next->element;
    return true;
}
