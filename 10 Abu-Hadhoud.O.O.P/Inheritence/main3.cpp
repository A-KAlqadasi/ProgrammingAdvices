#include<iostream>
using namespace std;
// using virtual function 
class clsPerson 
{
public:
	virtual void Print()
	{
		cout << "Hi, i'm a person!\n";
	}

};

class clsEmployee :public clsPerson
{
public:
	void Print()
	{
		cout << "Hi, i'm an employee!\n";
	}
};

class clsStudent :public clsPerson
{
public:
	void Print()
	{
		cout << "Hi, i'm a student!\n";
	}
};


int main()
{

	clsEmployee Employee1;
	clsStudent Student1;
	// Early-static Binding
	// means the addrees of the print() function is known for the
	// compiler at the compile time 
	Employee1.Print();
	Student1.Print();

	clsPerson* Person1 = &Employee1;
	clsPerson* Person2 = &Student1;
	// Late-Dynamic Binding
	// means the address of the print() function is known for 
	// the compiler at the run time
	Person1->Print();
	Person2->Print();


	system("pause>0");
}