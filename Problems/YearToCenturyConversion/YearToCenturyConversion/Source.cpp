#include<iostream>
#include<math.h>
#include<string>
using namespace std;

int ReadYear(string msg) {
	int year;
	cout << msg << endl;
	cin >> year;

	return year;
}

int ConvertYearToCentury(int year) {
	if (year % 2 == 0) {
		return year / 100;
	}
	else {
		return ceil(year / 100);
	}
}


void PrintNumberOfCentury(int century) {
	cout << "Century: " << century << endl;
}


int main() {

	PrintNumberOfCentury(ConvertYearToCentury(ReadYear("Enter a year:")));

	return 0;
}

