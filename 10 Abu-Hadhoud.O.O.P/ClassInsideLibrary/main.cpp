#include<iostream>
#include"clsPerson.h" ;
#include"clsEmployee.h" ;
#include"clsDeveloper.h" ;

using namespace std;



int main()
{
	clsDeveloper Developer(2, "Abdulkareem", "Shawqi", "AK@gmail.com", "736687527", "Sana'a", "CS", 10000, "C#,C++");
	Developer.Print();
	Developer.SendSMS("Hi This is Developer");
	

	system("pause>0");
}