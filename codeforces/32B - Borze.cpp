#include <iostream>
#include <string>
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

int main()
{
	string queue;
	cin >> queue;
	
	replaceAll(queue, "--", "2");
	replaceAll(queue, "-.", "1");
	replaceAll(queue, ".", "0");
	
	cout << queue << endl;

	return 0;
}
