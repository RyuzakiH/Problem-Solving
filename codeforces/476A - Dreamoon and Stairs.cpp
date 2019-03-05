#include <iostream>
using namespace std;

int main()
{
	short n, m;
	cin >> n >> m;

	short two = n / 2, one = n % 2;

	for (short i = 0; i < (two + one); i++)
	{
		if ((two + one) % m != 0 && two > 0)
		{
			two--;
			one += 2;
		}
		else
			break;
	}

	cout << (((two + one) % m == 0) ? (two + one) : -1) << endl;

	return 0;
}