#include<iostream>
using namespace std;

short ReadYear()
{
	short year = 0;
	cout << "Pleaes enter a year? ";
	cin >> year;

	return year;
}
short ReadDay(string message)
{
	short day = 0;
	cout << message;
	cin >> day;

	return day;
}
short ReadMonth()
{
	short      month = 0;
	do
	{
		cout << "Please enter a Month? ";
		cin >> month;
	} while (month < 1 || month >12);
	return     month;
}


struct sDate
{
	short year;
	short month;
	short day;
};

sDate ReadFullDate()
{
	sDate date;
	date.day = ReadDay("Please enter a Day? ");
	date.month = ReadMonth();
	date.year = ReadYear();
	return date;
}

bool IsDate1BeforeDate2(sDate date1 ,sDate date2)
{
	return (date1.year < date2.year) ? true : ((date1.year == date2.year) ? (date1.month < date2.month ? true : (date1.month == date2.month ? date1.day < date2.day : false)) : false);
}

bool IsDate1EqualDate2(sDate date1, sDate date2)
{
	return (date1.year == date2.year) ? ((date1.month == date2.month) ? (date1.day == date2.day?true:false) : false) : false;
}

bool IsDate1BeforeDate2(sDate date1, sDate date2)
{
	return (date1.year < date2.year) ? true : (date1.month < date2.month) ? true : (date1.day < date2.day) ? true : false;
}

int main()
{
	// is date1  before date2 
	// is date1 equal date2
	sDate date1 = ReadFullDate();
	cout << endl<<endl;
	sDate date2 = ReadFullDate();

	if (IsDate1EqualDate2(date1, date2))
	{
		cout << "Yes";
	}
	else
	{
		cout << "No";
	}



	system("pause > 0");
}