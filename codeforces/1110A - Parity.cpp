#include <iostream>
using namespace std;

int main()
{
	int b, k, a, odd = 0;

	cin >> b >> k;

	for (int i = 1; i <= k; i++)
	{
		cin >> a;
		odd += (a % 2);
	}

	cout << ((b % 2 == 0) ? (a % 2 ? "odd" : "even") : (odd % 2 ? "odd" : "even")) << endl;

	return 0;
}
