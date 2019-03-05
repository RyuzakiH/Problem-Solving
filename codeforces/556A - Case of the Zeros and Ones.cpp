#include <iostream>
#include <string>
#include <algorithm>
using namespace std;

int main()
{
	int n, zeros(0), ones(0);
	cin >> n;

	string str, temp;
	cin >> str;

	for (int i = 0; i < n; i++)
	{
		zeros += (str[i] == '0');
		ones += (str[i] == '1');
	}

	cout << n - 2 * min(zeros, ones) << endl;

	return 0;
}
