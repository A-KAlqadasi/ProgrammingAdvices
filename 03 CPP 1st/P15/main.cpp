//Logical Operators(&&, ||, !)
#include<iostream>
using namespace std;

int main()
{
	// Lesson
	bool A = true, B = false;

	cout << (A && B) << endl;
	cout << (A || B) << endl;
	cout << !A << endl;
	cout << !B << endl;
	cout << !(A && B) << endl;
	cout << !(A || B) << endl;

	//Project 2
	bool result;
	// Not(5 > 6 OR 7=7) AND NOT (1 OR false) 

	result = !(5 > 6 || 7 == 7) && !(1 || 0);
	cout << "Result  = " <<  result << endl;

	system("pause>0");
	return 0;
}