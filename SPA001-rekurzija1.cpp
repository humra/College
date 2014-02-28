#include <iostream>

using namespace std;

void rekurzija1(int d[], int n)
{
	cout << d[n] << " ";
	n++;
	if(n != 5)
	{
		rekurzija1(d, n);
	}
}

void rekurzija2(int d[], int n)
{
	cout << d[n] << " ";
	n--;
	if(n >= 0)
	{
		rekurzija2(d, n);
	}
}

int main()
{
	int d[5] = {1, 2, 3, 4, 5};

	rekurzija1(d, 0);
	cout << endl;
	rekurzija2(d, 4);

	cout << endl;
	return 0;
}