#include<iostream>
#include "MyDateLib.h"
using namespace std;
using namespace MyDateLib;

enum enDateCompare{Before = -1 ,Equal = 0, After =1};

enDateCompare CompareDates(sDate date1, sDate date2)
{
	if (IsDate1BeforeDate2(date1, date2))
		return enDateCompare::Before;
	if (IsDate1EqualDate2(date1, date2))
		return enDateCompare::Equal;

	return enDateCompare::After;
}


int main()
{
	cout << "Enter Date1:\n";
	sDate date1 = ReadFullDate();
	cout << "\nEnter Date2:\n";
	sDate date2 = ReadFullDate();

	cout <<"\n\ncompare Result is: "<< CompareDates(date1, date2) << endl;

	system("pause>0");
}