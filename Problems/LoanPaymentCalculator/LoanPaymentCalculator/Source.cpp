#include<iostream>
#include<cmath>
using namespace std;

float calculateMonthlyPayment(float principal, float rate, int time) {
    float r = rate / 1200;
    return (principal * r) / (1 - pow(1 + r, -time));
}

int main() {
    float principal, rate;
    int time;
    cout << "Enter loan amount: ";
    cin >> principal;
    cout << "Enter interest rate: ";
    cin >> rate;
    cout << "Enter time period in months: ";
    cin >> time;
    cout << "Monthly payment = " << calculateMonthlyPayment(principal, rate, time) << endl;
    return 0;
}