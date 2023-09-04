#include<iostream>
#include<cmath>
using namespace std;

float compoundInterest(float principal, float rate, int time) {
    return principal * pow(1 + rate / 100, time) - principal;
}

int main() {
    float principal, rate;
    int time;
    cout << "Enter principal amount: ";
    cin >> principal;
    cout << "Enter interest rate: ";
    cin >> rate;
    cout << "Enter time period in years: ";
    cin >> time;
    cout << "Compound interest = " << compoundInterest(principal, rate, time) << endl;
    return 0;
}