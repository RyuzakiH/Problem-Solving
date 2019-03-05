#include <iostream>
using namespace std;

int main()
{
	int n, m, clicks = 0;
	cin >> n >> m;

	while (n < m)
	{
		if (m % 2 == 0)
			m /= 2;
		else
			m++;

		clicks++;
	}

	cout << abs(clicks + n - m) << endl;

	return 0;
}
