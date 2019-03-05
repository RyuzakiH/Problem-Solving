#include <iostream>
#include <string>
using namespace std;

int main()
{
	string word, valid = "";
	getline(cin, word);

	for (short i = 0; i < word.length(); i++)
	{
		word[i] = tolower(word[i]);

		if (word[i] == 'a' || word[i] == 'o' || word[i] == 'y' || word[i] == 'e' || word[i] == 'u' || word[i] == 'i')
			continue;

		valid.append(1, '.');
		valid.append(1, word[i]);
	}

	cout << valid;

	return 0;
}