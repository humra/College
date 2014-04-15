#include <iostream>
#include <string>
#include "red.h"

using namespace std;

int main()
{

	red ispred_stadiona;

	ispred_stadiona.enqueue("Jura");
	ispred_stadiona.enqueue("Miro");
	ispred_stadiona.enqueue("Stef");

	ELTYPE sljedeci;

	while (!ispred_stadiona.is_empty())
	{
		if (ispred_stadiona.dequeue(sljedeci))
		{
			cout << "Prodao kartu: " << sljedeci << endl;
		}
	}

	return 0;
}