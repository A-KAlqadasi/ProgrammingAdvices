#include<iostream>
using namespace std;



class clsEmployee 
{
public:
	int Id;
	string Name;
	float Salary;

	clsEmployee(int Id , string Name ,float Salary)
	{
		// if we don't use this the compiler will confuse and
		// give not suitable result 
		this->Id = Id;
		this->Name = Name;
		this->Salary = Salary;
	}

	static void Func1(clsEmployee Employee)
	{
		Employee.Print();
	}

	void Func2()
	{
		Func1(*this);
	}

	 void Print()
	{
		cout << Id << "  " << Name << "  " << Salary << endl;
		// cout << this->Id << "  " << this->Name << "  " << this->Salary << endl;

	}
};


int main()
{
	clsEmployee Employee1(10,"Ali",40000);
	Employee1.Print();
	Employee1.Func2();


	system("pause>0");
}