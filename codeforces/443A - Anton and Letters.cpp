#include <set>
#include <string>
#include <sstream>
#include <iostream>
using namespace std;

int main()
{
	string str;
	getline(cin, str);
	str = str.substr(1, str.size() - 2);
	stringstream ss(str);

	set<char> chars;
	
	char c;
	while (ss >> c)
	{
		chars.insert(c);
		if (ss.peek() == ',')
			ss.ignore();
	}

	cout << chars.size() << endl;

	return 0;
}
