#include <iostream>
#include <string>
using namespace std;

int main()
{
	short n, i, count;
	cin >> n;

	string s;
	getline(cin, s);
	getline(cin, s);

	count = s.length();

	for (i = 0; i < s.length() -1; i++)
	{
		if (s[i] == s[i+1])
		{
			s.erase(s.begin() + i);
			i--;
		}
	}

	cout << count - s.length() << endl;

	return 0;
}