#include <stdio.h>
#include <stdlib.h>

void more_space(int** data, int n) {

	*data = realloc(*data, (n + 1)*(sizeof(int)));

	return;
}

int main() {
	int* data;

	data = (int*) calloc(1, sizeof(int));

	int n = 1;
	char more[5];
	int counter = 0;
	do {
		if(counter >= n) {
			more_space(&data, n);
			n++;
		}
		printf("Enter a number: ");
		scanf("%d", &data[counter]);
		counter++;

		printf("Another entry? (y/n) ");
		scanf("\n%s", &more);
		more[0] = tolower(more[0]);
	}while(more[0] == 'y');

	int i;
	for(i = 0; i < counter; i++) {
		printf("%d\n", data[i]);
	}

	printf("\n");
	return 0;
}