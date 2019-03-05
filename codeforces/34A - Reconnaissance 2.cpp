#include <iostream>
using namespace std;

int main()
{
	int n, heights[100], min(INT32_MAX);
	cin >> n;

	pair<int, int> soldiers;

	for (int i = 0; i < n; i++)
		cin >> heights[i];

	for (int i = 0; i < n; i++)
	{
		int ti = (i + 1 >= n) ? 0 : i + 1;
		int diff = abs(heights[i] - heights[ti]);
		if (diff < min)
		{
			min = diff;
			soldiers = make_pair(i + 1, ti + 1);
		}
	}

	cout << soldiers.first << " " << soldiers.second << endl;

	return 0;
}
