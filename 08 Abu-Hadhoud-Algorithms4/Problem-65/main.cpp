#include<iostream>
#include"MyDateLib.h"
#include<string>
using namespace std;
using namespace MyDateLib;

string ReplaceWordsInStringUsingBuiltInFunc(string Text, string sToReplace, string sReplaceTo)
{
	short pos = Text.find(sToReplace);

	while (pos != std::string::npos)
	{
		Text = Text.replace(pos, sToReplace.length(), sReplaceTo);
		pos = Text.find(sToReplace); // find next word
	}

	return Text;

}

string DateFormat(sDate date, string format ="dd/mm/yyyy")
{
	string newDateFormat = "";
	newDateFormat = ReplaceWordsInStringUsingBuiltInFunc(format, "dd", to_string(date.day));
	newDateFormat = ReplaceWordsInStringUsingBuiltInFunc(newDateFormat, "mm", to_string(date.month));
	newDateFormat = ReplaceWordsInStringUsingBuiltInFunc(newDateFormat, "yyyy", to_string(date.year));

	return newDateFormat;
}


int main()
{
	string strDate = ReadStringDate("\nEnter date dd/mm/yyyy? ");
	sDate date = StringToDate(strDate);
	cout << "\n" <<DateFormat(date) << endl;
	cout << "\n" << DateFormat(date, "yyyy/dd/mm") << endl;
	cout << "\n" << DateFormat(date, "mm/dd/yyyy") << endl;
	cout << "\n" << DateFormat(date, "mm-dd-yyyy") << endl;
	cout << "\n" << DateFormat(date, "dd-mm-yyyy") << endl;
	cout << "\n" << DateFormat(date, "Day:dd , Month:mm , Year:yyyy") << endl;


	system("pause>0");
	return 0;
}