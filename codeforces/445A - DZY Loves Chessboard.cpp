#include <iostream>
using namespace std;

int main()
{
	int n, m;
	cin >> n >> m;

	char chess[100][100], temp[100][100];

	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < m; j++)
		{
			cin >> chess[i][j];
		}
	}

	for (int j = 0; j < m; j++)
		temp[0][j] = (j % 2 == 0) ? 'B' : 'W';

	for (int i = 1; i < n; i++)
	{
		for (int j = 0; j < m; j++)
		{
			if (temp[i - 1][j] == 'B')
				temp[i][j] = 'W';
			else if (temp[i - 1][j] == 'W')
				temp[i][j] = 'B';
		}
	}

	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < m; j++)
		{
			if (chess[i][j] == '-')
				cout << '-';
			else
				cout << temp[i][j];
		}

		cout << endl;
	}

	return 0;
}
