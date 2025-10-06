#include<iostream>
using namespace std;


class clsA
{
public:
	int var;
	// static membe can not be initialized 
	static int counter ;

	clsA()
	{
		counter++;
	}

	void Print()
	{
		cout << "\nvar    = " << var << endl;
		cout << "counter   = " << counter << endl;
	}

	static int Function1()
	{
		
		return 10;
	}

	int Function2()
	{
		return 20;
	}


};

// initializing the static member must be out the class 
int clsA::counter = 0;

int main()
{
	// static member also called 
	// shared member means shared by all the objects
	// of the class. we can call them using object and using class name
	
	cout << clsA::Function1() << endl;
	
	clsA A1;
	cout << A1.Function1() << endl;
	cout << A1.Function2() << endl;

	system("pause>0");
}