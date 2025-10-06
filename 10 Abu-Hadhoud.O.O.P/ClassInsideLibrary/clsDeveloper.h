#pragma once
#include<iostream>
#include"clsEmployee.h" ;
#include"clsPerson.h"
using namespace std;

class clsDeveloper :public clsEmployee
{
private:
	string _ProgrammingLanguage;

public:
	clsDeveloper(int id, string firstName, string lastName, string email, string phone, string title, string department,
		float salary, string programmingLanguage) :clsEmployee(id, firstName, lastName, email, phone, title, department, salary)
	{
		ProgrammingLanguage = programmingLanguage;
	}

	void SetProgrammingLanguage(string programmingLanguage)
	{

		_ProgrammingLanguage = programmingLanguage;
	}
	string GetProgrammingLanguage()
	{
		return _ProgrammingLanguage;
	}
	// property set and get for ProgrammingLanguage
	_declspec(property(get = GetProgrammingLanguage, put = SetProgrammingLanguage)) string ProgrammingLanguage;

	void Print()
	{

		cout << "Info: \n";
		cout << "_________________________________\n";
		cout << "ID:       : " << Id << endl;
		cout << "First Name: " << FirstName << endl;
		cout << "Last Name : " << LastName << endl;
		cout << "Full Name : " << FullName << endl;
		cout << "Email     : " << Email << endl;
		cout << "Phone     : " << Phone << endl;
		cout << "Title     : " << Title << endl;
		cout << "Department: " << Department << endl;
		cout << "Salary    : " << Salary << endl;
		cout << "Programming Languages: " << ProgrammingLanguage << endl;
		cout << "_________________________________\n";
	}

};


