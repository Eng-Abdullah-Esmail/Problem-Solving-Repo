#include<iostream>
using namespace std;

int ReadNumber() {
	int number;
	cout << "Enter a number :";
	cin >> number;

	return number;
}

int Factorial(int number) {
	int result = 1;
	for (int i = 1; i <= number; i++) {
		result *= i;
	}

	return result;
}

void DisplayResult(int factorial) {
	cout << " The Factorial of the number is :" << factorial << endl;
}


int main() {
	
	DisplayResult(Factorial(ReadNumber()));

	return 0;
}