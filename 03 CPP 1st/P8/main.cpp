//Arithmetic Operators
#include<iostream>
using namespace std;

int main()
{
	// Program 1
	short A = 10, B = 20;
	cout << "A + B = "  << A + B << endl;
	cout << "A - B = "  << A - B << endl;
	cout << "A * B = "  << A * B << endl;
	cout << "A / B = "  << A / B << endl;
	cout << "A % B = "  << A % B << endl;
	cout << "**********************\n\n";

	//Program 2
	cout << "Please enter the first number A? ";
	cin >> A;
	cout << "Please enter the second number B? ";
	cin >> B;
	cout << A << " + " << B <<  " = " << A + B << endl;
	cout << A << " - " << B << " = " << A - B << endl;
	cout << A << " * " << B << " = " << A * B << endl;
	cout << A << " / " << B << " = " << A / B << endl;
	cout << A << " % " << B << " = " << A % B << endl;
	cout << "**********************\n\n";




	system("pause>0");
	return 0;
}