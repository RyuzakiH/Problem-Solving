#include <iostream>
using namespace std;

int main()
{
	int a, b;
	cin >> a >> b;

	for (int i = 1; i <= INT_MAX; i++)
	{
		if ((a *= 3) > (b *= 2))
		{
			cout << i << endl;
			break;
		}
	}

	return 0;
}
