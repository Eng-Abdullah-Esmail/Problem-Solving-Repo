#include<iostream>
using namespace std;

void DisplayMessage(string mes) {
	cout << " " << mes << endl;
}

int ReadNumber() {
	int number;
	DisplayMessage("Enter a Number to check wether its prime or not");
	cin >> number;

	return number;

}



bool IsPrime(int number) {
	if (number < 1)
	{
		return false;
	}

	for (int i = 2; i <= number / 2; i++) {
		if (number % i == 0) {
			return false;
		}
	}

	return true;
}

void DisplayMessage(bool isprime) {
	if (isprime)
		cout << "It is prime" << endl;
	else
		cout << "It is not prime" << endl;
}

int main() {

	DisplayMessage(IsPrime(ReadNumber()));

	return 0;
}