#include <iostream>
#include <math.h>
#include <string>
using namespace std;

int main()
{
	string s;
	getline(cin, s);

	short lower = 0;
	bool change_to_lower = false;

	for (size_t i = 0; i < s.length(); i++)
		lower += islower(s[i]) ? 1 : 0;

	change_to_lower = lower >= ceil(s.length() / 2.0);

	for (size_t i = 0; i < s.length(); i++)
		s[i] = change_to_lower ? tolower(s[i]) : toupper(s[i]);

	cout << s << endl;

	return 0;
}