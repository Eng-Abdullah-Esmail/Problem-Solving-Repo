#include<iostream>
using namespace std;

float calculateBMI(float height, float weight) {
    return weight / (height * height);
}

int main() {
    float height, weight;
    cout << "Enter height in meters: ";
    cin >> height;
    cout << "Enter weight in kilograms: ";
    cin >> weight;
    cout << "BMI = " << calculateBMI(height, weight) << endl;
    return 0;
}