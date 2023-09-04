#include<iostream>
#include<string>
using namespace std;

enum enDivisbleStatus{ Divisible = 1, NotDivisible= 2};

int ReadNumber(string msg) {
	int num;
	cout << msg << endl;
	cin >> num;

	return num;
}

enDivisbleStatus CheckDivisibiliy(int n, int x, int y) {
	if (n % x == 0 && n % y == 0)
	{
		return enDivisbleStatus::Divisible;
	}

	return enDivisbleStatus::NotDivisible;

}

void  PrintResult(enDivisbleStatus divState) {
	if (divState == enDivisbleStatus::Divisible) {
		cout << "The number is Divisble" << endl;
	}
	else {
		cout << "The number is Not Divisble" << endl;
	}
}


int main() {

	PrintResult(CheckDivisibiliy(ReadNumber("Enter n"), ReadNumber("Enter x"), ReadNumber("Enter Y")));

	return 0;
}

