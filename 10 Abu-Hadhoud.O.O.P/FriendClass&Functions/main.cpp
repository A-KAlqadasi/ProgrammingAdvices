#include<iostream>
using namespace std;


class clsA
{
private:
	int _Var1;

protected:
	int _Var3=0;
public:
	int Var2;
	clsA()
	{
		_Var1 = 10;
		Var2 = 20;
	}

	  // friend class
	// allows every member to be accessed private ,protected ,public 
	friend class clsB;
	// friend function as friend class.
	friend int MySum(clsA);
};

class clsB 
{
	int arr[4] { 1,2,3,4, };
public:
	void Diplay(clsA A1)
	{
		cout << "\nValue of var 1 is : " << A1._Var1 ;
		cout << "\nValue of var 2 is : " << A1.Var2 << endl;
		cout << "\nValue of var 3 is : " << A1._Var3 << endl;

	}
};


int MySum(clsA A1)
{
	return A1.Var2 +A1._Var1 + A1._Var3;
}


int main()
{
	clsA A1;
	clsB B1; 

	cout << MySum(A1) << endl;

	B1.Diplay(A1);
	

	system("pause>0");
	return 0;
}