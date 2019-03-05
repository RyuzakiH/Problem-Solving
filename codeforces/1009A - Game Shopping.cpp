#include <iostream>
using namespace std;

int main()
{
	int n, m, c[1000], a[1000], count(0);
	cin >> n >> m;

	for (int i = 0; i < n; i++)
		cin >> c[i];

	for (int i = 0; i < m; i++)
		cin >> a[i];

	for (int i = 0, j = 0; i < n && j < m; i++)
	{
		if (a[j] >= c[i])
		{
			count++;
			j++;
		}
	}

	cout << count << endl;

	return 0;
}
