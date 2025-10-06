#include<iostream>
using namespace std;


short ReadYear()
{
	short year = 0;
	cout << "\nEnter a year to check? ";
	cin >> year;

	return year;
}

short ReadMonth()
{
	short      month = 0;
	do
	{
		cout << "\nPlease enter a Month to check? ";
		cin >> month;
	} while (month < 1 || month >12);
	return     month;
}

short ReadDay()
{
	short day = 0;
	do 
	{
		cout << "\nEnter Number of Day? ";
		cin >> day;

	} while (day < 1 || day >31);
	
	return day;
}

short DayOfWeekOrder(short year, short month, short day)
{
	short a = (14 - month) / 12;
	short y = year - a;
	short m = month + 12 * a - 2;
	
	return (day + y + (y / 4) - (y / 100) + (y / 400) + ((31 * m) / 12)) % 7;
}

string DayShortName(short dayOfWeekOrder)
{
	string daysArr[] = { "Sun","Mon","Tue","Wed","Thur","Fri","Sat" };
	return daysArr[dayOfWeekOrder];
}

int main()
{
	// Day of week order
	short year = ReadYear();
	short month = ReadMonth();
	short day = ReadDay();
	
	cout << "\nyour Date: " << day << "/" << month << "/" << year << endl;
	cout << "Day Order: " << DayOfWeekOrder(year, month, day) << endl;
	cout << "day Name: " << DayShortName(DayOfWeekOrder(year, month, day)) << endl;

	system("pause>0");
}