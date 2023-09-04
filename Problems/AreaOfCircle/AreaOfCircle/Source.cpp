#include<iostream>
using namespace std;

float area(float radius) {
    return 3.14 * radius * radius;
}

int main() {
    float radius;
    cout << "Enter radius of circle: ";
    cin >> radius;
    cout << "Area of circle = " << area(radius) << endl;
    return 0;
}