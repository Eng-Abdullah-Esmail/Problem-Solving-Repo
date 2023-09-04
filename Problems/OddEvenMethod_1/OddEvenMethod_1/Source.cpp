#include<iostream>
using namespace std;

int ReadNumber() {
	int num;
	cout << "Enter a number : ";
	cin >> num;

	return num;
}

bool IsEven(int number) {
	if (number & 1)
		return false;
	else
		return true;
}

void PrintResult(bool iseven) {
	if (iseven)
		cout << "It is Even" << endl;
	else
		cout << "It is Odd" << endl;
}

int main() {

	PrintResult(IsEven(ReadNumber()));

	return 0;
}