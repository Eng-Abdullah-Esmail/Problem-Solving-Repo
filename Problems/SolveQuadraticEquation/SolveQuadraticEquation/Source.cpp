#include<iostream>
#include<cmath>
using namespace std;

void solveQuadraticEquation(float a, float b, float c, float& x1, float& x2) {
    float D = b * b - 4 * a * c;
    if (D >= 0) {
        x1 = (-b + sqrt(D)) / (2 * a);
        x2 = (-b - sqrt(D)) / (2 * a);
    }
}

int main() {
    float a, b, c, x1, x2;
    cout << "Enter coefficients of quadratic equation (ax^2 + bx + c = 0): ";
    cin >> a >> b >> c;
    solveQuadraticEquation(a, b, c, x1, x2);
    cout << "Solutions: x1 = " << x1 << ",x2 = " << x2 << endl;
    return 0;
}