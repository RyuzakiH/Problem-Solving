#include <iostream>
using namespace std;

int main()
{
	int n, points[1000], max, min, count = 0;
	cin >> n;

	cin >> points[0];
	max = min = points[0];

	for (int i = 1; i < n; i++)
	{
		cin >> points[i];

		if (points[i] > max)
		{
			max = points[i];
			count++;
		}
		else if (points[i] < min)
		{
			min = points[i];
			count++;
		}
	}

	cout << count << endl;
	
	return 0;
}
