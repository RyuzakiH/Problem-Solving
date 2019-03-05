#include <iostream>
#include <string>
using namespace std;

int main()
{
	string username, distinct = "";
	cin >> username;

	for (int i = 0; i < username.length(); i++)
	{
		if (distinct.find(username[i]) == std::string::npos)
			distinct.push_back(username[i]);
	}		

	cout << (distinct.length() % 2 == 0 ? "CHAT WITH HER!" : "IGNORE HIM!") << endl;
	
	return 0;
}
