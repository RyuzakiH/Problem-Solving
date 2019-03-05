#include <iostream>
//#include <string>
using namespace std;

int main()
{
	int n, anton = 0, danik = 0;
	cin >> n;

	char results[100000];

	for (int i = 0; i < n; i++)
	{
		cin >> results[i];
		anton += (results[i] == 'A');
		danik += (results[i] == 'D');
	}

	/*string results; cin >> results;
	anton = count(results.begin(), results.end(), 'A');
	danik = count(results.begin(), results.end(), 'D');*/

	cout << (anton > danik ? "Anton" : (anton == danik ? "Friendship" : "Danik")) << endl;

	return 0;
}
