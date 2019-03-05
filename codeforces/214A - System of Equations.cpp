#include <iostream>
using namespace std;

int main()
{
	int n, m, count(0);
	cin >> n >> m;

	for (int a = 0; a * a <= n; a++)
	{
		for (int b = 0; b * b <= m; b++)
		{
			if (a * a + b == n && a + b * b == m)
				count++;
		}
	}

	cout << count << endl;

	return 0;
}
