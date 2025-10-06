//Datatypes sizes and ranges
#include<iostream>
using namespace std;

int main()
{
	// Note by default everything is signed

	int v1;
	signed int v2;

	unsigned int v3;


	short int v4;
	short v5;

	unsigned short int v6;
	unsigned short v7;


	signed long int v8;
	long int v9;
	long v10;
	unsigned long v11;

	long long int v12;

	unsigned long long v13;

	long double v14;
	signed char v15;
	char v16;

	unsigned char v17;

	// part2
	double distance = 56E12;
	cout << distance << endl;


	// Some compilers gives an error and some give garbage values(like VS) 
	short d = 3434233; // Error! out of range 
	cout << d << endl;

	unsigned int a = -10; //Error! can only store positive number
	cout << a << endl;
	

	//Part3 size of dataType in bytes  
	cout << "The size of bool data type is " << sizeof(bool) << "\n";
	cout << "The size of char data type is " << sizeof(char) << "\n";
	cout << "The size of short data type is " << sizeof(short) << "\n";
	cout << "The size of int data type is " << sizeof(int) << "\n";

	cout << "The size of long data type is " << sizeof(long) << "\n";
	cout << "The size of long long data type is " << sizeof(long long) << "\n";

	cout << "The size of float data type is " << sizeof(float) << "\n";
	cout << "The size of double data type is " << sizeof(double) << "\n";


	system("pause>0");
	return 0;
}