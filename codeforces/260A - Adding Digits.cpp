#include <iostream>
using namespace std;

int main()
{
	int a, b, n;
	cin >> a >> b >> n;

	for (int i = 0; i < 10; i++)
	{
		if ((a * 10 + i) % b == 0)
		{
			cout << a << i;
			
			for (; n > 1; n--)
				cout << 0;
			cout << endl;

			return 0;
		}
	}

	cout << -1 << endl;

	return 0;
}
