#include <iostream>
using namespace std;

int main()
{
	int t, a;
	cin >> t;

	for (; t > 0; t--)
	{
		cin >> a;

		bool valid = false;
		double angle = 0;

		for (int n = 3; angle <= a; n++)
		{
			angle = (n - 2) * 180.0 / n;
			if (a == angle)
			{
				valid = true;
				break;
			}
		}

		cout << (valid ? "YES" : "NO") << endl;
	}

	return 0;
}
