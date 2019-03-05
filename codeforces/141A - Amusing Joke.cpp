#include <iostream>
#include <string>
using namespace std;

int main()
{
	string guest, host, pile;
	cin >> guest >> host >> pile;

	int i;

	guest.append(host);

	for (i = 0; i < guest.length(); i++)
	{
		int index = pile.find(guest[i]);

		if (index != std::string::npos)
		{
			pile.erase(index, 1);
		}
		else
			break;
	}

	cout << ((pile.empty() && i == guest.length()) ? "YES" : "NO") << endl;

	return 0;
}
