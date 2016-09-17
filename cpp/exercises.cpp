#include <iostream>
#include <string>

using namespace std;

string helloWorld() {
	return "Hello, World!";
}

string alternate(string first, string second) {
	string result;
	int i;
	for (i = 0; i < first.length() && i < second.length(); i++)
		result += first.substr(i, 1) + second.substr(i, 1);
	result += first.substr(i) + second.substr(i);
	return result;
}

int main() {

	cout << helloWorld() << endl;
	cout << alternate("Hlo ol!", "el,Wrd") << endl;
}
