#include <iostream>
#include <string>
using namespace std;

int main()
{
	string s;
	cin >> s;

	bool hello[5]{ false };

	for (int i = 0; i < s.length(); i++)
	{
		if (!hello[0])
			hello[0] = s[i] == 'h';
		else if (!hello[1])
			hello[1] = s[i] == 'e';
		else if (!hello[2])
			hello[2] = s[i] == 'l';
		else if (!hello[3])
			hello[3] = s[i] == 'l';
		else if (!hello[4])
			hello[4] = s[i] == 'o';
	}

	cout << (hello[4] ? "YES" : "NO") << endl;

	return 0;
}
