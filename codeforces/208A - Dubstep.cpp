#include <iostream>
#include <string>
#include <algorithm> 
#include <functional> 
#include <cctype>
#include <locale>
using namespace std;

void replaceAll(std::string& str, const std::string& from, const std::string& to)
{
	if (from.empty())
		return;

	size_t start_pos = 0;
	while ((start_pos = str.find(from, start_pos)) != std::string::npos)
	{
		str.replace(start_pos, from.length(), to);
		start_pos += to.length();
	}
}

// trim from both ends (in place)
static inline void trim(std::string &s)
{
	s.erase(s.begin(), std::find_if(s.begin(), s.end(),
		std::not1(std::ptr_fun<int, int>(std::isspace)))); // trim from start (in place)

	s.erase(std::find_if(s.rbegin(), s.rend(),
		std::not1(std::ptr_fun<int, int>(std::isspace))).base(), s.end()); // trim from end (in place)
}


int main()
{
	string remix;
	cin >> remix;
	
	replaceAll(remix, "WUB", " ");
	
	while (remix.find("  ") != string::npos)
		replaceAll(remix, "  ", " ");
	
	trim(remix);

	cout << remix << endl;

	return 0;
}