#include<iostream>
using namespace std;

void DisplayMessage(string mes) {
	cout << "\t " << mes << endl;
}
void DisplayMessage(string mes, int num) {
	cout << "\t " << mes << "\t" << num << endl;
}

int ReadNumber() {
	int number;
	DisplayMessage("Enter a Number");
	cin >> number;

	return number;
}

int sumOfDigits(int num) {
	int sum = 0;
	while (num > 0) {
		sum += num % 10;
		num /= 10;
	}

	return sum;
}

int main() {

	DisplayMessage("Sum of Digits is", sumOfDigits(ReadNumber()));

	return 0;
}