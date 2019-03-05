#include <iostream>
#include <math.h>
using namespace std;

int main()
{
	int i, j, temp, current_i, current_j;
	
	for (int i = 1; i <= 5; i++)
	{
		for (int j = 1; j <= 5; j++)
		{
			cin >> temp;

			if (temp)
			{
				current_i = i;
				current_j = j;
			}
		}
	}

	cout << (abs(current_i - 3) + abs(current_j - 3)) << endl;

	return 0;
}
