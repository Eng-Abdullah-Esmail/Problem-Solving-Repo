#include<iostream>
using namespace std;

float volume(float radius) {
    return 4 / 3.0 * 3.14 * radius * radius * radius;
}

int main() {
    float radius;
    cout << "Enter radius of sphere: ";
    cin >> radius;
    cout << "Volume of sphere = " << volume(radius) << endl;
    return 0;
}