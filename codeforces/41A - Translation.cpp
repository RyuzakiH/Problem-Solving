#include <iostream>
#include <string>
using namespace std;

int main()
{
	string s, t;
	getline(cin, s);
	getline(cin, t);

	bool valid = true;

	for (short i = 0; i < s.length(); i++)
	{
		if (s[i] != t[s.length() - i - 1])
		{
			valid = false;
			break;
		}
	}
	cout << ((valid) ? "YES" : "NO") << endl;

	return 0;
}