#include<iostream>
using namespace std;

class clsPerson
{
private:
	string _FirstName;
	string _LastName;

public:
	// Property Set
	void SetFirstName(string firstName)
	{
		_FirstName = firstName;
	}
	// Property Get
	string GetFirstName()
	{
		return _FirstName;
	}
	// property set
	void SetLastName(string lastName)
	{
		_LastName = lastName;
	}
	// poperty get
	string GetLastName()
	{
		return _LastName;
	}

	string GetFullName()
	{
		return _FirstName + " " + _LastName;
	}

	__declspec(property(get =GetFirstName, put =SetFirstName )) string FirstName;
	__declspec(property(get = GetLastName, put = SetLastName)) string LastName;
	__declspec(property(get = GetFullName)) string FullName; // readonly
};



int main()
{
	clsPerson person;
	person.SetFirstName("Abdulkareem");
	cout << person.GetFirstName() << endl;
	
	// instead of the above we only write this property
	person.FirstName = "Abdulkareem";
	cout << person.FirstName << endl;
	
	person.LastName = "Shawqi";
	
	cout << person.FullName << endl;

	
	return 0;
}