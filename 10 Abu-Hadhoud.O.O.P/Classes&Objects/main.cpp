#include<iostream>
using namespace std;

class clsPerson
{
	// members of the class 
	// inside class by default private
private:
	int x;

public:
	string firstName;
	string lastName;

	string FullName()
	{
		return firstName + " " + lastName;
	}
};


int main()
{
	// object / instance of class 
	clsPerson Person1;

	Person1.firstName = "Abdulkareem";
	Person1.lastName = "Shawqi";

	cout << Person1.FullName() << endl;

	string s1;
	s1.length();


	system("pause>0");
	return 0;
}