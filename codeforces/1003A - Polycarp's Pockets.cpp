#include <iostream>
using namespace std;

int main()
{
	int n, coins[101]{ 0 }, temp, max(0);
	cin >> n;

	for (int i = 0; i < n; i++)
	{
		cin >> temp;
		coins[temp]++;
	}
	
	for (int i = 1; i <= 100; i++)
	{
		if (coins[i] > max)
			max = coins[i];
	}

	cout << max << endl;

	return 0;
}
