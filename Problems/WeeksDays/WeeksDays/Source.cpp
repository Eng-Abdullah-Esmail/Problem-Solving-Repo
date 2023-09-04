#include<iostream>
using namespace std;

int ReadHours() {
	int Hours;
	cout << "Enter Hours \n";
	cin >> Hours;
	return Hours;
}

float GetDays(int Hours) {
	return Hours / 24;
}

int GetWeeks(int Days) {
	return Days / 7;
}

int main() {

	int days = GetDays(ReadHours());
	int weeks = GetWeeks(days);
	cout << "Days :" << days << endl;
	cout << "Weeks : " << weeks << endl;


}
