#include <iostream>
#include <string>
#include <sstream>
#include <algorithm>
using namespace std;

int distinct_digits(int value)
{
	std::ostringstream out;
	out << value;	
	std::string digits = out.str();
	std::sort(digits.begin(), digits.end());
	return std::unique(digits.begin(), digits.end()) - digits.begin();
}

int main()
{
	int year;
	cin >> year;

	while (true)
		if (distinct_digits(++year) == 4)
			break;
	
	cout << year << endl;

	return 0;
}
