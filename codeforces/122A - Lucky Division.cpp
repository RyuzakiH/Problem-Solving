#include <iostream>
using namespace std;

int main()
{
	int n, luckyNums[13] = { 4, 7, 44, 47, 74, 77, 444, 447, 474, 477, 744, 747, 777 };;
	cin >> n;

	bool can = false;
	for (int i = 0; i < 13; i++)
	{
		if (n % luckyNums[i] == 0)
		{
			can = true;
			break;
		}
	}

	cout << (can ? "YES" : "NO") << endl;

	return 0;
}
