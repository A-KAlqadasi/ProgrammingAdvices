#include<iostream>
#include"MyDateLib.h"
#include<vector>
#include<string>
using namespace std;
using namespace MyDateLib;




vector<string> splitString(string Text, string delim)
{
	vector<string> vString;
	short pos = 0;
	string sWord;
	while ((pos = Text.find(delim)) != std::string::npos)
	{
		sWord = Text.substr(0, pos);
		if (sWord != "")
		{
			vString.push_back(sWord);
		}

		Text.erase(0, pos + delim.length());

	}
	if (Text != "")
	{
		vString.push_back(Text);
	}
	return vString;

}


string ReadStringDate(string message)
{
	cout << message;
	string date;
	getline(cin >> ws, date);

	return date;
}

sDate StringToDate(string strdate)
{
	vector<string >vDate = splitString(strdate, "/");
	sDate date;

	date.day = stoi(vDate[0]);
	date.month = stoi(vDate[1]);
	date.year = stoi(vDate[2]);

	return date;
}

string DateToString(sDate date)
{
	return  to_string(date.day)+"/"+to_string(date.month)+"/"+to_string(date.year);
}

int main()
{
	// string to Date
	// date to string
	string strdate = ReadStringDate("\nPlease Enter Date dd/mm/yyyy? ");

	sDate date = StringToDate(strdate);
	cout << "\n\nDay: " << date.day << endl;
	cout << "Month: " << date.month << endl;
	cout << "year: " << date.year << endl;

	cout << "\n\nDate ToString " << DateToString(date) << endl;

	system("pause>0");
	return 0;
}