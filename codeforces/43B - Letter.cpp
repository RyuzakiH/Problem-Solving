#include <iostream>
#include <string>
using namespace std;

int main()
{
	string s1, s2;
	getline(cin, s1);
	getline(cin, s2);

	int letters[123]{ 0 };

	for (int i = 0; i < s1.length(); i++)
		letters[s1[i]]++;

	for (int i = 0; i < s2.length(); i++)
	{
		if (s2[i] == ' ')
			continue;

		if (letters[s2[i]] > 0)
			letters[s2[i]]--;
		else
		{
			cout << "NO" << endl;
			return 0;
		}
	}

	cout << "YES" << endl;

	return 0;
}
