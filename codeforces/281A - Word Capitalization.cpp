#include <iostream>
#include <string>
using namespace std;

int main()
{
	string word;
	getline(cin, word);

	cout << (char)toupper(word[0]) << word.substr(1, word.length() - 1) << endl;

	return 0;
}