#include<iostream>
using namespace std;


class  clsPerson
{
public:
	// accessable for everyone outside/inside/and class inheritence 
	string FirstName;
	string LastName;

	string FullName()
	{
		return FirstName + LastName;
	}

	int Function()
	{
		return 40;
	}


private:
	// only accessable inside the class
	int variable1 = 50;
	int Function()
	{
		return 0;
	}


};

 clsPerson:: clsPerson()
{
}

 clsPerson::~ clsPerson()
{
}




int main()
{


	return 0;
}