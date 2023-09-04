#include<iostream>
#include<string>
using namespace std;

string ReadString(string msg) {
	string str;
	cout << msg << endl;
	getline(cin, str);
	return str;
}

string ReverseString(string str) {
	string reversed = "";

	for (int i = str.length() - 1; i >= 0; i--) {
		reversed += str[i];
	}

	return reversed;

}

void PrintReversedString(string str) {
	cout << "Reversed String: " << str << endl;
}

int main() {

	PrintReversedString(ReverseString(ReadString("Enter aText To Reverse it")));

	return 0;
}