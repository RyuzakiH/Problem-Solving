#include <iostream>
using namespace std;

int main()
{
	int n, boards[1000][2], capacity = 0, max_capacity = 0;
	cin >> n;

	for (int i = 0; i < n; i++)
	{
		cin >> boards[i][0] >> boards[i][1];

		capacity -= boards[i][0];
		capacity += boards[i][1];

		if (capacity > max_capacity)
			max_capacity = capacity;
	}

	cout << max_capacity << endl;

	return 0;
}
