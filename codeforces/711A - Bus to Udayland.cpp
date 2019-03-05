#include <iostream>
#include <string>
using namespace std;

int main()
{
	short n, index; cin >> n;

	string seat, seats;
	getline(cin, seat);

	bool found = false;

	for (short i = 0; i < n; i++)
	{
		getline(cin, seat);

		index = seat.find("OO");
		if (!found && index != std::string::npos)
		{
			seat.replace(index, 2, "++");
			found = true;
		}

		seats += seat + "\n";
	}

	cout << ((found) ? "YES\n" + seats : "NO") << endl;

	return 0;
}