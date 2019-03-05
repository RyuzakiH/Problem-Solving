#include <iostream>
#include <string>
using namespace std;

int main()
{
	string N;
	cin >> N;

	int count = 0;
	bool lucky = false;

	for (size_t i = 0; i < N.length(); i++)
	{
		if (N[i] == '4' || N[i] == '7')
		{
			count++;
			lucky = true;
		}
	}

	cout << ((lucky && (count == 4 || count == 7)) ? "YES" : "NO") << endl;

	return 0;
}
