#include <iostream>

using namespace std;

class clsPerson
{
private:
	int _Id;
	string _FirstName;
	string _LastName;
	string _FullName;
	string _Email;
	string _Phone;

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
		_FullName  =  fullName;
	}

	string GetFullName()
	{
		return _FirstName + " " + _LastName;
	}

public:
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
	_declspec(property(get = GetFullName,put = SetFullName)) string FullName;
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

class clsEmployee
{
private:
	int _Id;
	string _FirstName;
	string _LastName;
	string _FullName;
	string _Email;
	string _Phone;
	string _Title;
	string _Department;
	double _Salary;

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

	void SetSalary(double salary)
	{
		_Salary = salary;
	}

	double GetSalary()
	{
		return _Salary;
	}


public:
	clsEmployee(int id, string fName, string lName,string department,string title,double salary, string email, string phone)
	{
		_Id = id;
		FirstName = fName;
		LastName = lName;
		Email = email;
		Phone = phone;
		Salary = salary;
		Department = department;
		Title = title;

	}
	// properties 
	_declspec(property(get = GetId)) int Id;
	_declspec(property(get = GetFirstName, put = SetFirstName)) string FirstName;
	_declspec(property(get = GetLastName, put = SetLastName)) string LastName;
	_declspec(property(get = GetEmail, put = SetEmail)) string Email;
	_declspec(property(get = GetFullName, put = SetFullName)) string FullName;
	_declspec(property(get = GetPhone, put = SetPhone)) string Phone;
	_declspec(property(get = GetDepartment, put = SetDepartment)) string Department;
	_declspec(property(get = GetTitle, put = SetTitle)) string Title;
	_declspec(property(get = GetSalary, put = SetSalary)) double Salary;

	void Print()
	{
		cout << "Info: \n";
		cout << "_________________________________\n";
		cout << "ID:       :" << Id << endl;
		cout << "First Name:" << FirstName << endl;
		cout << "Last Name :" << LastName << endl;
		cout << "Full Name :" << FullName << endl;
		cout << "Department:" << Department << endl;
		cout << "Title     :" << Title << endl;
		cout << "Salary    :" << Salary << endl;
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

int main()
{

	clsEmployee Person(10,"Abdulkareem","Abu-Ghaith","CS","Yemen",10000, "Abdulakreem@gmail.com", "736687527");
	

	Person.Print();
	

	Person.SendEmail("Hi", "How Are You?");
	Person.SendSMS("How Are you?");


	system("pause>0");
	return 0;
}