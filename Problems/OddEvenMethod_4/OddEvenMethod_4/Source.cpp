#include<iostream>
#include<string>
using namespace std;

int ReadNumber() {
	int num;
	cout << "Enter a number : ";
	cin >> num;

	return num;
}

string IsEven(int number) {


	if (number / 2 * 2 == number)
		return "It is Even";
	else
		return "It is Odd";

}

void PrintResult(string result) {
	cout << "\n" << result << endl;

}

int main() {

	PrintResult(IsEven(ReadNumber()));

	return 0;
}