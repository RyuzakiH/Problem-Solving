#include <iostream>
#include <math.h>
using namespace std;

int main()
{
	int n, temp, positive = 0, negative = 0, lowest;
	cin >> n;

	for (int i = 0; i < n; i++)
	{
		cin >> temp;

		positive += temp > 0;
		negative += temp < 0;
	}

	lowest = ceil((double)n / 2);

	cout << (positive >= lowest ? "1" : (negative >= lowest ? "-1" : "0")) << endl;

	return 0;
}
