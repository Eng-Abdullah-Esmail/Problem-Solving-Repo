#include<iostream>
using namespace std;

int ReadNumber() {
	int num;
	cout << "Enter a number : ";
	cin >> num;

	return num;
}

bool IsEven(int number) {
	switch (number % 2) {
	case 0:
		return true;
		break;
	case 1:
		return false;
		break;
		
	}
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