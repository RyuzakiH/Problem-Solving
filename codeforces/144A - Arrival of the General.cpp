#include <iostream>
using namespace std;

int main()
{
	int N, soldiers[100], max = 0, max_i = 0, min = 101, min_i = 101;
	cin >> N;

	for (int i = 0; i < N; i++)
	{
		cin >> soldiers[i];

		if (soldiers[i] > max)
		{
			max = soldiers[i];
			max_i = i;
		}
		else if (soldiers[i] == max && i < max_i)
		{
			max_i = i;
		}
		
		if (soldiers[i] < min)
		{
			min = soldiers[i];
			min_i = i;
		}
		else if (soldiers[i] == min && i > min_i)
		{
			min_i = i;
		}
	}

	cout << (max_i + (N - min_i - 1) - (max_i > min_i)) << endl;

	return 0;
}
