#include <iostream>
using namespace std;

int main()
{
	int n, boards[10000][2], left_closed = 0, right_closed = 0, seconds = 0;
	cin >> n;

	for (int i = 0; i < n; i++)
	{
		cin >> boards[i][0] >> boards[i][1];

		left_closed += boards[i][0];
		right_closed += boards[i][1];
	}

	seconds += (left_closed > n / 2) ? (n - left_closed) : left_closed;
	seconds += (right_closed > n / 2) ? (n - right_closed) : right_closed;

	cout << seconds << endl;

	return 0;
}
