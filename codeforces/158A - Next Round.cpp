#include <iostream>
using namespace std;

int main()
{
	short n, k;
	cin >> n >> k;

	short scores[50], count = 0;

	for (short i = 0; i < n; i++)
		cin >> scores[i];

	for (; count < n; count++)
		if ((scores[count] < scores[k - 1] && scores[count] > 0) || scores[count] <= 0)
			break;

	cout << count;

	return 0;
}