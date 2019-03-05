#include <iostream>
using namespace std;

int main()
{
	int n, m, col[1000] = { 0 }, square, min(INT32_MAX);
	cin >> n >> m;

	for (int i = 0; i < m; i++)
	{
		cin >> square;
		col[square - 1]++;
	}

	for (int i = 0; i < n; i++)
		if (col[i] < min)
			min = col[i];

	cout << min << endl;

	return 0;
}
