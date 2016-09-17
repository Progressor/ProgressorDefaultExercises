#include <iostream>
#include <string>
#include <regex>
#include <algorithm>

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

char *swapEncrypt(char *toSwap, int length) {
	for (int i = 0; i + 1 < length; i += 2) {
		char tmp = toSwap[i];
		toSwap[i] = toSwap[i + 1];
		toSwap[i + 1] = tmp;
	}
	return toSwap;
}

bool isPalindrome(string palindrome) {
	string clean = regex_replace(palindrome, regex("[^A-Za-z]"), "", regex_constants::format_default);
	transform(clean.begin(), clean.end(), clean.begin(), ::tolower);
	for (int i = 0, j = clean.length() - 1; i < j; i++, j--)
		if (clean[i] != clean[j]) return false;
	return true;
}

int fibonacci(int num) {
	if (num < 1) return 0;
	if (num == 1) return 1;
	return fibonacci(num - 2) + fibonacci(num - 1);
}

int main() {

  cout << helloWorld() << endl;
  cout << alternate("Hlo ol!", "el,Wrd") << endl;
  cout << swapEncrypt(new char[11] {'H','e','l','l','o',' ','W','o','r','l','d'}, 11) << endl;
  cout << swapEncrypt(new char[11] {'e','H','l','l',' ','o','o','W','l','r','d'}, 11) << endl;
  cout << isPalindrome("Hello, World!") << endl;
  cout << isPalindrome("A Santa dog lived as a devil God at NASA.") << endl;
	for (auto i = 0; i < 10; i++)
  	cout << fibonacci(i) << endl;
}
