#include<iostream>
using namespace std;

// base class 
class clsPerson
{
private:
	int _Id;
	string _FirstName;
	string _LastName;
	string _FullName;
	string _Email;
	string _Phone;

public:
	int GetId()
	{
		return _Id;
	}

	void SetFirstName(string firstName)
	{
		_FirstName = firstName;
	}

	string GetFirstName()
	{
		return _FirstName;
	}

	void SetLastName(string lastName)
	{
		_LastName = lastName;
	}

	string GetLastName()
	{
		return _LastName;
	}

	void SetEmail(string email)
	{
		_Email = email;
	}

	string GetEmail()
	{
		return _Email;
	}

	void SetPhone(string phone)
	{
		_Phone = phone;
	}

	string GetPhone()
	{
		return _Phone;
	}

	void SetFullName(string fullName)
	{
		_FullName = fullName;
	}

	string GetFullName()
	{
		return _FirstName + " " + _LastName;
	}

	clsPerson(int id, string fName, string lName, string email, string phone)
	{
		_Id = id;
		FirstName = fName;
		LastName = lName;
		Email = email;
		Phone = phone;
	}
	// properties 
	_declspec(property(get = GetId)) int Id;
	_declspec(property(get = GetFirstName, put = SetFirstName)) string FirstName;
	_declspec(property(get = GetLastName, put = SetLastName)) string LastName;
	_declspec(property(get = GetEmail, put = SetEmail)) string Email;
	_declspec(property(get = GetFullName, put = SetFullName)) string FullName;
	_declspec(property(get = GetPhone, put = SetPhone)) string Phone;


	void Print()
	{
		cout << "Info: \n";
		cout << "_________________________________\n";
		cout << "ID:       :" << Id << endl;
		cout << "First Name:" << FirstName << endl;
		cout << "Last Name :" << LastName << endl;
		cout << "Full Name :" << FullName << endl;
		cout << "Email     :" << Email << endl;
		cout << "Phone     :" << Phone << endl;
		cout << "_________________________________\n";
	}

	void SendEmail(string subject, string body)
	{
		cout << "\nThe Following message sent successfully to email : " << Email << endl;
		cout << "Subject: " << subject << endl;
		cout << "Body   : " << body << endl;
	}

	void SendSMS(string message)
	{
		cout << "\nThe Following SMS sent successfully to phone : " << Phone << endl;
		cout << message << endl;
	}

};

// class employee inherit from class person
class clsEmployee :public clsPerson
{
private:
	string _Title;
	string _Department;
	float _Salary;

public:
	clsEmployee(int Id, string firstName,string lastName,string email,string phone , string title ,string department
	,float salary) : clsPerson (Id ,firstName,lastName,email,phone) 
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
// class developer inherit from class Employee
class clsDeveloper:public clsEmployee
{
private:
	string _ProgrammingLanguage;

public:
	clsDeveloper(int id, string firstName, string lastName,string email,string phone ,string title,string department, 
		float salary,string programmingLanguage):clsEmployee(id ,firstName,lastName,email,phone ,title,department,salary)
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

//int main()
//{
//	clsDeveloper Developer(2, "Abdulkareem", "Shawqi", "AK@gmail.com", "736687527", "Sana'a", "CS", 10000, "C#,C++");
//	Developer.Print();
//	Developer.SendSMS("Hi This is Developer");
//
//	system("pause>0");
//}