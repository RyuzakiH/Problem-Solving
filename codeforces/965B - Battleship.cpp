#include <iostream>
#include <algorithm>
#include <map>
using namespace std;

int main()
{
	int n, k, Max(0), max_i(-1), max_j(-1), i, j, l;
	cin >> n >> k;

	char field[100][100], temp;
	map<pair<int, int>, int> locations;

	bool valid;

	for (i = 0; i < n; i++)
	{
		for (j = 0; j < n; j++)
		{
			cin >> field[i][j];
			locations[make_pair(i, j)] = 0;
		}
	}

	for (i = 0; i < n; i++)
	{
		for (j = 0; j < n; j++)
		{
			if (field[i][j] == '#')
				continue;

			// horizental
			valid = true;
			for (l = j; l < j + k; l++)
			{
				if (field[i][l] == '#' || l >= n)
				{
					valid = false;
					break;
				}
			}

			if (valid)
				for (l = j; l < j + k && l <= n; l++)
					locations[make_pair(i, l)]++;

			// vertical
			valid = true;
			for (l = i; l < i + k; l++)
			{
				if (field[l][j] == '#' || l >= n)
				{
					valid = false;
					break;
				}
			}

			if (valid)
				for (l = i; l < i + k && l <= n; l++)
					locations[make_pair(l, j)]++;
		}
	}


	for (i = 0; i < n; i++)
	{
		for (j = 0; j < n; j++)
		{
			if (locations[make_pair(i, j)] > Max)
			{
				Max = locations[make_pair(i, j)];
				max_i = i;
				max_j = j;
			}
		}
	}

	if (max_i >= 0 && max_j >= 0)
		cout << max_i + 1 << " " << max_j + 1 << endl;
	else
		cout << "1 1" << endl;

	return 0;
}
