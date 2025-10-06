// Variables 
#include<iostream>
using namespace std;

int main()
{
	
	short MyAge = 45;
	cout << MyAge << endl;
	cout << "My age is " << MyAge << " years old.\n";

	int myNumber = 52;
	float myFloatNumber = 7.84;
	double myDoubleNumber = 21.89822;
	char myLetter = 'A';
	string myText = "Abdulkareem";
	bool myBoolean = true;

	cout << myNumber << endl;
	cout << myFloatNumber << endl;
	cout << myDoubleNumber << endl;
	cout << myLetter << endl;
	cout << myText << endl;
	cout << myBoolean << endl;

	// Homework 1
	short myAge = 20;
	string myName = "Abdulkareem Shawqi";
	string myCity = "Sana'a";
	string myCountry = "Yemen";
	int myMonthlySalary = 5000;
	char myGender = 'M';
	bool IsMarried = false;

	cout << "\n\n*********************************\n";
	cout << "Name : " << myName << endl;
	cout << "Age  : " << myAge << endl;
	cout << "City : " << myCity << endl;
	cout << "Country : " << myCountry << endl;
	cout << "Monthly Salary : " << myMonthlySalary << endl;
	cout << "Yearly Salary: " << myMonthlySalary * 12 << endl;
	cout << "Gender : " << myGender << endl;
	cout << "Married : " << IsMarried << endl;
	cout << "*********************************\n";
	cout << endl; 

	// Homework 2
	short num1 = 20;
	short num2 = 30;
	short num3 = 10;
	short sum = num1 + num2 + num3;
	cout << num1 << "+\n";
	cout << num2 << "+\n";
	cout << num3 << "\n";
	cout << "-------------------\n";
	cout << "Total = " << sum << endl;

	//Homework3
	short age = 25;
	cout << "\n\nAfter 5 years you will be " << age + 5 << " years old.";


	system("Pause>0");
	return 0;
}