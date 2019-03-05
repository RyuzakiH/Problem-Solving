#include <iostream>
#include <string>
using namespace std;

int main()
{
	short n, X = 0;
	cin >> n;

	string statement;
	getline(cin, statement); // no-use

	for (short i = 0; i < n; i++)
	{
		getline(cin, statement);
		X += (statement.find("++") != std::string::npos) - (statement.find("--") != std::string::npos);
	}

	cout << X << endl;

	return 0;
}