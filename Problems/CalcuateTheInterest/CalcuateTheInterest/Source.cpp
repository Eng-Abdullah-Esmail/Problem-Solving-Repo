#include<iostream>
#include<string>
using namespace std;


struct Interest {
	float Principal;
	float Rate;
	int TimePeriod;
};

void Alert(string Message) {
	cout << Message << endl;
}

Interest ReadInput() {
	Interest interest;
	Alert("Enter the principal of interest ");
	cin >> interest.Principal;

	Alert("Enter the rate of Interest,pls");
	cin >> interest.Rate;

	Alert("Enter the Time Period or Years");
	cin >> interest.TimePeriod;

	return interest;
}

float CalcualteSimpleInterest(Interest interest) {

	float Interest = interest.Principal * interest.Rate * interest.TimePeriod;

	return (float)Interest;
}

void PrintResult(float amount, string note = "The Output is ") {
	cout << note << "  :" << amount << endl;

}

int main() {

	PrintResult(CalcualteSimpleInterest(ReadInput()), " The Result is ");

	return 0;
}
