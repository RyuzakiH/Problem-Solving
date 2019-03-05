#include <iostream>
#include <string>
using namespace std;

int main()
{
	string word;
	getline(cin, word);

	bool invalid = true;

	for (short i = 1; i < word.length(); i++)
	{
		if (islower(word[i]))
		{
			invalid = false;
			break;
		}
	}

	if (invalid)
	{
		for (short i = 0; i < word.length(); i++)
			word[i] = (islower(word[i])) ? toupper(word[i]) : tolower(word[i]);
	}

	cout << word << endl;

	return 0;
}