#pragma once

#include <iostream>
#include<string>
using namespace std;
 

namespace MyInputLib
{
	float ReadFloatPositiveNumber(string Message)
	{
		float Number = 0;
		do
		{
			cout << Message << endl;

			cin >> Number;
		} while (Number <= 0);

		return Number;
	}

	int ReadIntPositiveNumber(string Message)
	{
		int Number = 0;
		do
		{
			cout << Message << endl;

			cin >> Number;
		} while (Number <= 0);

		return Number;
	}

	int ReadIntNumber(string Message)
	{
		int Number=0;
		cout << Message << endl;
		cin >> Number;
		return Number;
	}
	
	float ReadFloatNumber(string Message)
	{
		float Number = 0;
		cout << Message << endl;
		cin >> Number;
		return Number;
	}

	string ReadText(string Message)
	{
		string text = "";
		cout << Message << endl;
		getline(cin,text);
		return text;
	}

	int RandomNumbersFromTo(int From, int To) {
		int Number;
		Number = rand() % (To - From + 1) + From;
		return Number;
	}
	
	int ReadNumberInRange(int From, int To)
	{
		int Number = 0;
		do {
			cout << "Plz, Enter Number between " << From << " To " << To << " ? ";
			cin >> Number;
		} while (Number <From || Number >To);
		return Number;
	}
	
	void ReadArray(int Array[100], int& arrLength) {
		cout << "Enter Array Length? ";
		cin >> arrLength;

		for (int i = 0; i < arrLength; i++) {
			cout << "Element [" << i + 1 << "] : ";
			cin >> Array[i];
		}
	}
	
	void FillArrayWithRandomNumbers(int Array[100], int& arrLength) {
		cout << "Enter Array Length ?";
		cin >> arrLength;

		for (int i = 0; i < arrLength; i++) {
			Array[i] = RandomNumbersFromTo(1, 100);
		}
	}

	int ValidateNumber(int Number)
	{

		while (cin.fail())
		{
			cin.clear();
			cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
			cout << "Invalid Number, Enter a valid one:" << endl;
			cin >> Number;

		}
		return Number;
	}
}
