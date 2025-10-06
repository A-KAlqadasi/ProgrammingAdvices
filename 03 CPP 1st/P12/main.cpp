// A++ vs ++A
#include<iostream>
using namespace std;


int main()
{
	int A = 10;
	int B = A++;// B will take the old value of A,then A will increase by 1

	cout << "A = " << A << endl;
	cout << "B = " << B << endl;

	B = ++A;// A will increase by 1, then B will take the new value
	cout << "A = " << A << endl;
	cout << "B = " << B << endl;


	system("pause>0");
	return 0;
}