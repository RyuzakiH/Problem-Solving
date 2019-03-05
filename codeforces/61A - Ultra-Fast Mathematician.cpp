#include <iostream>
#include <string>
using namespace std;

int main()
{
	string num1, num2, output = "";
	cin >> num1 >> num2;
	
	for (size_t i = 0; i < num1.length(); i++)
		output.append(((num1[i] != num2[i]) ? "1" : "0"));

	cout << output << endl;

	return 0;
}
