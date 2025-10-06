//Relational Operators
#include<iostream>
using namespace std;

int main()
{
	// Lesson
	int A = 10, B = 20;
	
	cout << (A == B) << endl;
	cout << (A != B) << endl;
	cout << (A > B) << endl;
	cout << (A < B) << endl;
	cout << (A >= B) << endl;
	cout << (A <= B) << endl;

	// Homework
	int num1 , num2;
	cout << "Please enter the first number ?\n";
	cin >> num1;
	cout << "Please enter the second number ?\n";
	cin >> num2;

	cout << num1 << " = " << num2 << " is " << (num1 == num2) << endl;
	cout << num1 << " != " << num2 << " is " << (num1 != num2) << endl;
	cout << num1 << " > " << num2 << " is " << (num1 > num2) << endl;
	cout << num1 << " < " << num2 << " is " << (num1 < num2) << endl;
	cout << num1 << " >= " << num2 << " is " << (num1 >= num2) << endl;
	cout << num1 << " <= " << num2 << " is " << (num1 <= num2) << endl;




	system("pause>0");
	return 0;
}