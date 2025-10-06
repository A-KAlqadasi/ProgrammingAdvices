#pragma once
#include<iostream>
#include"clsPerson.h"
using namespace std;
class clsEmployee :public clsPerson
{
private:
	string _Title;
	string _Department;
	float _Salary;

public:
	clsEmployee(int Id, string firstName, string lastName, string email, string phone, string title, string department
		, float salary) : clsPerson(Id, firstName, lastName, email, phone)
	{
		_Title = title;
		_Department = department;
		_Salary = salary;
	}
	void SetTitle(string title)
	{
		_Title = title;
	}

	string GetTitle()
	{
		return _Title;
	}

	void SetDepartment(string department)
	{
		_Department = department;
	}

	string GetDepartment()
	{
		return _Department;
	}

	void SetSalary(float salary)
	{
		_Salary = salary;
	}

	float GetSalary()
	{
		return _Salary;
	}
	// ----------------
	_declspec(property(get = GetTitle, put = SetTitle)) string Title;
	_declspec(property(get = GetDepartment, put = SetDepartment)) string Department;
	_declspec(property(get = GetSalary, put = SetSalary)) float Salary;

	// override function 
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
		cout << "Title     : " << _Title << endl;
		cout << "Department: " << _Department << endl;
		cout << "Salary    : " << _Salary << endl;
		cout << "_________________________________\n";
	}

};

