#pragma once
#include<iostream>
#include<string>
#include<vector>
using namespace std;


namespace MyStringLib
{
	void PrintFirstLetterInString(string Text)
	{

		bool isFirstLetter = true;

		cout << "\nFirst Letter of this String: \n";

		for (int i = 0; i < Text.length(); i++)
		{

			if (Text[i] != ' ' && isFirstLetter)
			{
				cout << Text[i] << endl;
			}
			isFirstLetter = (Text[i] == ' ' ? true : false);

		}

	}

	string UpperEachFirstLetterOfWord(string Text)
	{
		bool isFirstLetter = true;

		for (int i = 0; i < Text.length(); i++)
		{
			if (Text[i] != ' ' && isFirstLetter)
			{
				Text[i] = toupper(Text[i]);
			}
			isFirstLetter = (Text[i] == ' ' ? true : false);

		}
		return Text;

	}

	string LowerEachFirstLetterOfWord(string Text)
	{
		bool isFirstLetter = true;

		for (int i = 0; i < Text.length(); i++)
		{
			if (Text[i] != ' ' && isFirstLetter)
			{
				Text[i] = tolower(Text[i]);
			}
			isFirstLetter = (Text[i] == ' ' ? true : false);

		}

		return Text;
	}

	string UpperAllString(string Text)
	{

		for (int i = 0; i < Text.length(); i++)
		{
			Text[i] = toupper(Text[i]);
		}

		return Text;
	}

	string LowerAllString(string Text)
	{

		for (int i = 0; i < Text.length(); i++)
		{
			Text[i] = tolower(Text[i]);
		}

		return Text;
	}

	char InvertLetterCase(char char1)
	{
		return isupper(char1) ? tolower(char1) : toupper(char1);
	}

	string InvertAllStringLettersCase(string Text)
	{
		for (int i = 0; i < Text.length(); i++)
		{
			Text[i] = InvertLetterCase(Text[i]);
		}
		return Text;
	}

	short CountCapitalLetters(string Text)
	{
		short Counter = 0;
		for (int i = 0; i < Text.length(); i++)
		{
			if (isupper(Text[i]))
				Counter++;

		}

		return Counter;
	}
	short CountSmallLetters(string Text)
	{
		short Counter = 0;
		for (int i = 0; i < Text.length(); i++)
		{
			if (islower(Text[i]))
				Counter++;
		}
		return Counter;
	}

	enum enWhatToCount { SmallLetters = 1, CapitalLetters = 2, Punct = 3, All = 4 };

	short CountLetters(string Text, enWhatToCount WhatToCount = enWhatToCount::All)
	{
		short Counter = 0;

		if (WhatToCount == enWhatToCount::All)
			return Text.length();


		for (int i = 0; i < Text.length(); i++)
		{
			if (isupper(Text[i]) && WhatToCount == enWhatToCount::CapitalLetters)
				Counter++;

			if (islower(Text[i]) && WhatToCount == enWhatToCount::SmallLetters)
				Counter++;

			if (ispunct(Text[i]) && WhatToCount == enWhatToCount::Punct)
				Counter++;

		}

		return Counter;
	}

	short CountLetterInString(string Text, char CharCount)
	{
		short Counter = 0;
		for (int i = 0; i < Text.length(); i++)
		{
			if (Text[i] == CharCount)
				Counter++;
		}
		return Counter;

	}

	short CountLetterMatchCase(string Text, char CharCount, bool MatchCase = true)
	{
		short Counter = 0;
		for (int i = 0; i < Text.length(); i++)
		{
			if (MatchCase) {
				if (Text[i] == CharCount)
					Counter++;
			}
			else
			{
				if (tolower(Text[i]) == tolower(CharCount))
					Counter++;
			}
		}
		return Counter;

	}

	bool IsVowel(char Letter)
	{
		Letter = tolower(Letter);
		return ((Letter == 'a') || (Letter == 'e') || (Letter == 'i')
			|| (Letter == 'o') || (Letter == 'u'));
	}

	short CountVowels(string Text)
	{
		short Counter = 0;
		for (int i = 0; i < Text.length(); i++)
		{
			if (IsVowel(Text[i]))
			{
				Counter++;
			}
		}
		return Counter;
	}

	void PrintAllVowelsInString(string Text)
	{
		cout << "Vowels in string are: ";
		for (int i = 0; i < Text.length(); i++)
		{
			if (IsVowel(Text[i]))
			{
				cout << Text[i] << "   ";
			}
		}

	}

	void PrintEachWordInString(string Text)
	{
		string delim = " ";
		short pos = 0;
		string sWord;

		cout << "\nYour String Words Are\n\n";
		while ((pos = Text.find(delim)) != std::string::npos)
		{
			sWord = Text.substr(0, pos);
			if (sWord != "")
			{
				cout << sWord << endl;
			}
			Text.erase(0, pos + delim.length());

		}
		if (Text != "")
		{
			cout << Text << endl;
		}

	}

	short CountWordsInString(string Text)
	{
		string delim = " ";
		short pos = 0;
		short Counter = 0;
		string sWord;

		while ((pos = Text.find(delim)) != std::string::npos)
		{
			sWord = Text.substr(0, pos);
			if (sWord != "")
			{
				Counter++;
			}
			Text.erase(0, pos + delim.length());

		}

		if (Text != "")
		{
			Counter++;
		}
		return Counter;

	}

	vector<string> SplitStringWordsToVector(string Text, string delim)
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

	string JoinString(vector<string>vString, string delim)
	{
		string sWord;
		for (string& s : vString)
		{
			sWord = sWord + s + delim;
		}

		return sWord.substr(0, sWord.length() - delim.length());
	}
	string JoinString(string arrString[], short length, string delim)
	{
		string sWord = "";
		for (int i = 0; i < length; i++)
		{
			sWord = sWord + arrString[i] + delim;
		}

		return sWord.substr(0, sWord.length() - delim.length());

	}

	string TrimLeft(string Text)
	{
		for (short i = 0; i < Text.length(); i++)
		{
			if (Text[i] != ' ')
			{
				return Text.substr(i, Text.length() - i);
			}
		}
		return "";
	}
	string TrimRight(string Text)
	{
		for (short i = Text.length() - 1; i >= 0; i--)
		{
			if (Text[i] != ' ')
			{
				return Text.substr(0, i + 1);
			}
		}
		return "";
	}
	string Trim(string Text)
	{
		return TrimLeft(TrimRight(Text));
	}

	string ReserveWordsInString(string S1)
	{
		vector <string> vString;
		vString = SplitStringWordsToVector(S1, " ");
		string sWord = "";
		vector<string>::iterator iter = vString.end();

		while (iter != vString.begin())
		{
			iter--;
			sWord += *iter + " ";
		}
		sWord = sWord.substr(0, sWord.length() - 1);

		return sWord;
	}

	string ReplaceWordsInString(string Text, string strToReplace, string strReplaceTo)
	{
		short pos = Text.find(strToReplace);

		while (pos != std::string::npos)
		{
			Text = Text.replace(pos, strToReplace.length(), strReplaceTo);
			pos = Text.find(strToReplace); // find next word
		}

		return Text;

	}

	string RemovePunctuationFromString(string Text)
	{
		string Text2 = "";
		for (int i = 0; i < Text.length(); i++)
		{
			if (!ispunct(Text[i]))
			{
				Text2 += Text[i];
			}
		}

		return Text2;
	}


}