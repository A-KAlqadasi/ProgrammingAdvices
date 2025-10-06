#include<iostream>
using namespace std;


class clsPerson
{

private:
	string _FullName;
	class clsAddress
	{
	public:
		 string AddressLine1;
		 string AddressLine2;
		 string City;
		 string Country;
		 clsAddress(string addressLine1,string addressLine2,string city, string country)
		 {
			 this->AddressLine1 = addressLine1;
			 this->AddressLine2 = addressLine2;
			 this->City = city;
			 this->Country = country;

		 }

		 void Print()
		 {
			 cout << "\nAddress:\n";
			 cout << AddressLine1 << endl;
			 cout << AddressLine2 << endl;
			 cout << City << endl;
			 cout << Country << endl;

		 }
	};
public:
	clsAddress Address = clsAddress("", "", "", "");
	clsPerson(string fullName , string addressLine1,string addressLine2 ,string city ,string Country )
	{
		_FullName = fullName;
		Address = clsAddress(addressLine1, addressLine2, city, Country);
	}
	

	
};


int main()
{

	clsPerson Person("Abdulkareem Shawqi","Hasaba","Seha","Sana'a","Yemen");
	Person.Address.Print();

	system("pause>0");
}