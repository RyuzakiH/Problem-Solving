#include <iostream>
#include <string>
using namespace std;

bool isVowel(char c)
{
	return c == 'a' || c == 'o' || c == 'u' || c == 'i' || c == 'e';
}

int main()
{
	string s; cin >> s;

	bool berlanese = true;

	for (int i = 0; i < s.length(); i++)
	{
		if (!isVowel(s[i]))
		{
			if (s[i] == 'n')
				continue;
			else if (i < s.length() - 1 && isVowel(s[i + 1]))
				i++;
			else
			{
				berlanese = false;
				break;
			}
		}
	}

	cout << (berlanese ? "YES" : "NO") << endl;

	return 0;
}
