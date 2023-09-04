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
	
	return (number % 2 == 0) ? "It is Even" : "It is Odd";

	
}

void PrintResult(string result) {
	cout << "\n" << result << endl;

}

int main() {

	PrintResult(IsEven(ReadNumber()));

	return 0;
}