//Input from users
#include<iostream>
using namespace std;

int main()
{
	//Lesson
	char myChar;
	int myNumber;

	cout << "Please enter a character? " << endl;
	cin >> myChar;

	cout << "Please enter a number? " << endl;
	cin >> myNumber;

	cout << "You entered this char:" << myChar << " and this number: " << myNumber << endl;

	// Homework 1
	int myAge;
	string myName ;
	string myCity ;
	string myCountry;
	int myMonthlySalary;
	char myGender ;
	bool IsMarried ;

	cout << "Please enter your name\n?";
	cin >> myName;
	cout << "Please enter your age\n?";
	cin >> myAge;
	cout << "Please enter your city\n?";
	cin >> myCity;
	cout << "Please enter your country\n?";
	cin >> myCountry;
	cout << "Please enter your monthly salary\n?";
	cin >> myMonthlySalary;
	cout << "Please enter you gender [M]Male,[F]Female\n?";
	cin >> myGender;
	cout << "Are you Married?[1]Yes, [0]No\n?";
	cin >> IsMarried;

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
	int num1;
	int num2;
	int num3;
	cout << endl << endl;
	cout << "Please enter num1\n?";
	cin >> num1;
	cout << "Please enter num2\n?";
	cin >> num2;
	cout << "Please enter num3\n?";
	cin >> num3;

	int sum = num1 + num2 + num3;
	cout << num1 << "+\n";
	cout << num2 << "+\n";
	cout << num3 << "\n";
	cout << "-------------------\n";
	cout << "Total = " << sum << endl;

	// Homework 3
	int age ;
	cout << "Please enter your age? ";
	cin >> age;
	cout << "\n\nAfter 5 years you will be " << age + 5 << " years old.";


	system("pause>0");
	return 0;
}