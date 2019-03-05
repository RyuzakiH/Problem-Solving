#include <iostream>
#include <string>
#include <algorithm>
using namespace std;

int main()
{
	string s1, s2;
	getline(cin, s1);
	getline(cin, s2);

	std::transform(s1.begin(), s1.end(), s1.begin(), ::tolower);
	std::transform(s2.begin(), s2.end(), s2.begin(), ::tolower);

	cout << s1.compare(s2) << endl;

	return 0;
}