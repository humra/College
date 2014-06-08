#include <stdio.h>

void quick_sort (int* data, int n) {
    if(n < 2) {
        return;
    }

    int pivot = data[n / 2];
    int* left = data;
    int* right = data + n - 1;
    int temp;

    while(left <= right) {
        if(*left < pivot) {
            left++;
            continue;
        }
        if(*right > pivot) {
            right--;
            continue;
        }

        temp = *left;
        *left = *right;
        *right = temp;
        left++;
        right--;
    }

    quick_sort(data, right - data + 1);
    quick_sort(left, data + n - left);
}

int main () {

    int data[] = {7, 2, 1, 4, 9, 8, 3, 5, 10, 6};
    int n = sizeof(data) / sizeof(data[0]);
    quick_sort(data, n);

    int i;
    for(i = 0; i < n; i++) {
        printf("%d ", data[i]);
    }
    putchar('\n');
    return 0;
}