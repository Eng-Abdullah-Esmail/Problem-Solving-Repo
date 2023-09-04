#include <iostream>
using namespace std;


int ReadNumber() {
	int num;
	cout << "Enter a number to check if it is odd or even: ";
	cin >> num;

	return num;
}

bool Check(int num) {
	if (num % 2 == 0)
		return true;
	else
		return false;
}

void PrintResult(bool result) {
	if (result)
		cout << "It is Event" << endl;
	else
		cout << "It is Odd" << endl;
}

int main() {

	PrintResult(Check(ReadNumber()));
	return 0;
}