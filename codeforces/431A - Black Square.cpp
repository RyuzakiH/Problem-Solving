#include <iostream>
#include <string>
using namespace std;

int main()
{
	int a[4], calories = 0;

	for (int i = 0; i < 4; i++)
		cin >> a[i];
	
	string strips; cin >> strips;

	for (int i = 0; i < strips.length(); i++)
		calories += a[strips[i] - '0' - 1];

	cout << calories << endl;

	return 0;
}
    