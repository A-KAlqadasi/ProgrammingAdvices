#include<iostream>
#include"MyDateLib.h"
using namespace std;
using namespace MyDateLib;



bool IsDate1AfterDate2(sDate date1, sDate date2)
{
	return !(IsDate1BeforeDate2(date1, date2) || IsDate1EqualDate2(date1, date2));
}

int main()
{
	// is date1 after date2
	cout << "\nEnter Date1\n";
	sDate date1 = ReadFullDate();
	cout << "\nEnte Date2\n";
	sDate date2 = ReadFullDate();

	if (IsDate1AfterDate2(date1, date2))
	{
		cout << "\n\nYes, Date1 is after Date2\n";
	}
	else
	{
		cout << "\n\nNo, Date1 is not after Date2\n";
	}
	system("pause>0");
}