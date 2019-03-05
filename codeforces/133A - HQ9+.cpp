#include <iostream>
#include <string>
using namespace std;

int main()
{
	string instruction;
	cin >> instruction;

	bool prints = false;

	for (int i = 0; i < instruction.length(); i++)
	{
		if (instruction[i] == 'H' || instruction[i] == 'Q' || instruction[i] == '9')
		{
			prints = true;
		}
	}

	cout << (prints ? "YES" : "NO") << endl;

	return 0;
}
