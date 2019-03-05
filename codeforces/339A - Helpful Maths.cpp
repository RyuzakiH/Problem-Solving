#include <vector>
#include <string>
#include <sstream>
#include <iterator>
#include <iostream>
#include <algorithm>
using namespace std;

template<typename Out>
void split(const string &s, char delim, Out result)
{
	std::stringstream ss(s);
	std::string item;
	while (getline(ss, item, delim))
	{
		*(result++) = item;
	}
}

vector<std::string> split(const string &s, char delim)
{
	vector<string> elems;
	split(s, delim, back_inserter(elems));
	return elems;
}

vector<int> convertToIntVector(vector<string> v)
{
	vector<int> elems;
	for (int i = 0; i < v.size(); i++)
		elems.push_back(stoi(v[i]));
	return elems;
}

int main()
{
	string s; cin >> s;

	vector<int> numbers = convertToIntVector(split(s, '+'));

	std::sort(numbers.begin(), numbers.end());

	cout << numbers[0];
	for (int i = 1; i < numbers.size(); i++)
		cout << "+" + std::to_string(numbers[i]);

	cout << endl;

	return 0;
}
