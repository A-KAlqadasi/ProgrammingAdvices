#include <iostream>
using namespace std;


class clsAddress
{
private:
	string _AddressLine1;
	string _AddressLine2;
	string _POBox;
	string _ZipCode;

public:

	clsAddress(string addressLine1, string addressLine2,string poBox , string zipCode)
	{
		_AddressLine1 = addressLine1;
		_AddressLine2 = addressLine2;
		_POBox = poBox;
		_ZipCode = zipCode;
	}

	// Copy Constractor the compiler do it automaticly for us
	// we can do it mannualy 
	clsAddress(clsAddress & old_obj)
	{
		_AddressLine1 = old_obj.GetAddressLine1();
		_AddressLine2 = old_obj.GetAddressLine2();
		_POBox = old_obj.GetPOBox();
		_ZipCode = old_obj.GetZipCode();
	}

	void SetAddressLine1(string addressLine1)
	{
		_AddressLine1 = addressLine1;
	}

	string GetAddressLine1()
	{
		return _AddressLine1;
	}

	void SetAddressLine2(string addressLine2)
	{
		_AddressLine2 = addressLine2;
	}

	string GetAddressLine2()
	{
		return _AddressLine2;
	}

	void SetPOBox(string poBox)
	{
		_POBox = poBox;
	}

	string GetPOBox()
	{
		return _POBox;
	}

	void SetZipCode(string zipCode)
	{
		_ZipCode = zipCode;
	}

	string GetZipCode()
	{
		return _ZipCode;
	}

	void PrintAddress()
	{
		cout << "Address Details\n";
		cout << "------------------------------\n";
		cout << "AddressLine1:" << _AddressLine1 << endl;
		cout << "AddressLine2:" << _AddressLine2 << endl;
		cout << "POBox       :" << _POBox << endl;
		cout << "ZipCode     :" << _ZipCode << endl;
	}

};

class clsPerson
{
public:
	clsPerson()
	{
		cout << "Hi, I am constractor\n";
	}

	~clsPerson()
	{
		cout << "Hi, I am Destractor\n";
	}

};

void Fun1()
{
	clsPerson person1;
}

void Fun2()
{
	// every new must have delete after finishing using it.
	clsPerson* person2 = new clsPerson();
	delete person2;
}

int main()
{
	Fun1();
	Fun2();

	system("pause>0");
	return 0;
}