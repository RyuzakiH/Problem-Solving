#include <iostream>
#include <string>
#include <algorithm>
using namespace std;

int main()
{
	int N, moves = 0;
	cin >> N;

	string current, password;
	cin >> current >> password;

	for (int i = 0; i < N; i++)
	{
		int sub = abs((int)current[i] - (int)password[i]);

		moves += min(sub, 10 - sub);
	}

	cout << moves << endl;

	return 0;
}
