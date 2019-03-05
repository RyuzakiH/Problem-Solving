#include <iostream>
#include <string>
#include <algorithm>
using namespace std;

int main()
{
	int n;
	cin >> n;

	string str;
	cin >> str;

	for (int i = 2; i <= n; i++)
	{
		if (n % i == 0)
			std::reverse(str.begin(), str.begin() + i);
	}

	cout << str << endl;

	return 0;
}
