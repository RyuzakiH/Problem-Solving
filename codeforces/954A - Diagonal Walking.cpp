#include <iostream>
#include <string>
using namespace std;

int main()
{
	short n;
	cin >> n;

	string s;
	getline(cin, s);
	getline(cin, s);

	s = s.substr(0, n);

	string s1 = s;
	string s2 = s;

	string temp;
	
	try
	{
		for (size_t i = 0; i < s1.length(); i++)
		{
			temp = s1.substr(i, 2);
			if (temp == "RU" || temp == "UR")
				s1.replace(i, 2, "D");
		}

		for (size_t i = s2.length() - 2; i > 0; i--)
		{
			temp = s2.substr(i, 2);
			if (temp == "RU" || temp == "UR")
				s2.replace(i, 2, "D");
		}
	}
	catch (const std::exception&) { }

	cout << ((s1.length() < s2.length()) ? s1.length() : s2.length()) << endl;

	return 0;
}