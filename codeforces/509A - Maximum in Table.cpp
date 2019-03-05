#include <iostream>
using namespace std;

int main()
{
	int n, table[10][10], max(1);
	cin >> n;

	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < n; j++)
		{
			table[i][j] = 1;
		}
	}

	for (int i = 1; i < n; i++)
	{
		for (int j = 1; j < n; j++)
		{
			table[i][j] = table[i][j - 1] + table[i - 1][j];
			
			if (table[i][j] > max)
				max = table[i][j];
		}
	}

	cout << max << endl;

	return 0;
}
