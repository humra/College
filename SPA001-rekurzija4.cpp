#include <iostream>
#include <cmath>
#include <string>

using namespace std;

double izracunajPi(int n)
{
	if(n == 0)
	{
		return 4.0;
	}
	else
	{
		return (pow((-1.0), (double)n) * (4.0 / (2*n + 1.0))) + izracunajPi(n-1);

	}
}

int main()
{
	int x;

	cout << "Broj clanova reda: ";
	cin >> x;

	double pi = izracunajPi(x);
	cout << pi;

	cout << endl;
	return 0;
}