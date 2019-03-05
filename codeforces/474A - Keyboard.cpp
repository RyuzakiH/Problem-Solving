#include <iostream>
#include <string>
using namespace std;

int main()
{
	char dir; cin >> dir;

	string word;
	getline(cin, word);
	getline(cin, word);

	string keyboard[3] = {
		"qwertyuiop",
		"asdfghjkl;"
		"zxcvbnm,./"
	};

	short index;
	short dirMark = (dir == 'R') ? -1 : 1;

	for (short i = 0; i < word.length(); i++)
	{
		for (short j = 0; j < 3; j++)
		{
			index = keyboard[j].find(word[i]);
			if (index != std::string::npos)
			{
				word[i] = keyboard[j][index + dirMark];
				break;
			}
		}
	}

	cout << word << endl;

	return 0;
}