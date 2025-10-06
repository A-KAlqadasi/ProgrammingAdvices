#include<iostream>
using namespace std;

class clsPerson
{
public:
	string FullName = "Abdulakreem";

};

class clsEmployee :public clsPerson
{
public:
	string Title = "Sana'a";
};

//
//int main()
//{
//	clsEmployee Employee1;
//
//	cout << Employee1.FullName << endl;
//
//
//	// upcasting means the base can point to any child 
//	clsPerson* Person = & Employee1;
//	cout << Person->FullName << endl;
//
//	// down casting means we make the child points to the parent 
//	// this is not acceptable it makes error
//
//	/*clsPerson Person2;
//	clsEmployee* Employee2 = &Person2;*/
//
//
//
//
//	system("pause>0");
//}