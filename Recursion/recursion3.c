#include <stdio.h>
#include <string.h>

void strrev(char s[]) {
	int i, j;
	char temp;
	for(i = 0, j = strlen(s) - 1; i < j; i++, j--) {
		temp = s[i];
		s[i] = s[j];
		s[j] = temp;
	}

	return;
}

int main()
{
	char word[50];
	char word2[50];

	printf("Enter word: ");
	scanf("%s", &word);

	strcpy(word2, word);
	strrev(word2);
	if(strcmp(word, word2) == 0) {
		printf("The word is a palindrome\n");
	}
	else {
		printf("The word is not a palindrome\n");
	}

	return 0;
}