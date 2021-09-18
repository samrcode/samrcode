#include <stdio.h>

int main() {
	char userInput[100];
	printf("Type something: ");
	scanf("%s", userInput);
	printf("You entered: %s", userInput);
	return 0;
}