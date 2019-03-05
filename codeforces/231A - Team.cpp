#include <iostream>
using namespace std;

int main()
{
	short n; cin >> n;

	short sure[3], problems = 0, count;

	for (short i = 0; i < n; i++)
	{
		count = 0;

		for (short j = 0; j < 3; j++)
		{
			cin >> sure[j];
			count += (sure[j] == 1);
		}

		problems += (count >= 2);
	}

	cout << problems;

	return 0;
}