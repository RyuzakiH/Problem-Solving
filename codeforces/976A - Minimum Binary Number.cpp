#include <iostream>
#include <string>
using namespace std;

int main()
{
	int n;
	cin >> n;

	string s;
	cin >> s;

	while (s.find("11") != std::string::npos || s.find("01") != std::string::npos)
	{
		for (int i = s.size() - 1; i > 0; i--)
		{
			if (s[i] == '1' && s[i - 1] == '0')
				swap(s[i], s[i - 1]);
			else if ((s[i] == '1' && s[i - 1] == '1'))
				s.erase(i--, 1);
		}
	}

	cout << s << endl;

	return 0;
}
