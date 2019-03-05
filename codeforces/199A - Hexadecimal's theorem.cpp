#include <iostream>
#include <string>
using namespace std;

int main()
{
	int n, a, b, temp;
	cin >> n;
	
	for (a = 0, b = 1, temp; a + b < n; temp = a, a = b, b = temp + b);

	cout << (n == 0 ? "0 0 0" : ("0 " + std::to_string(a) + " " + std::to_string(b))) << endl;

	return 0;
}
