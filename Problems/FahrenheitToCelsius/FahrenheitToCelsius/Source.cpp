#include<iostream>
using namespace std;

float fahrenheitToCelsius(float fahrenheit) {
    return (fahrenheit - 32) * 5 / 9;
}

int main() {
    float fahrenheit;
    cout << "Enter temperature in Fahrenheit: ";
    cin >> fahrenheit;
    cout << "Temperature in Celsius = " << fahrenheitToCelsius(fahrenheit) << endl;
    return 0;
}