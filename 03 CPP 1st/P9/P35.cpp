//// Problem 35: Piggy bank calculator
//#include<iostream>
//using namespace std;
//
//int ReadNumber(string message)
//{
//	short number = 0;
//	cout << message << endl;
//	cin >> number;
//	return number;
//}
//
//float TotalPennies(int pennies, int nickels, int dimes, int quarters, int dollars)
//{
//	return (pennies + nickels * 5 + dimes * 10 + quarters * 25 + dollars * 100);
//}
//
//float TotalDollars(int pennies, int nickels, int dimes, int quarters, int dollars)
//{
//	return TotalPennies(pennies,nickels,dimes,quarters,dollars) / 100;
//}
//
//
//int main()
//{
//	int pennies  = ReadNumber("Please enter Pennies?  ");
//	int nickels  = ReadNumber("Please enter Nickels? ");
//	int dimes    = ReadNumber("Please enter Dimes? ");
//	int quarters = ReadNumber("Please enter Quarters? ");
//	int dollars  = ReadNumber("Please enter Dollars?  ");
//
//	int totalPinnes = TotalPennies(pennies, nickels, dimes, quarters, dollars);
//	float totalDollars = TotalDollars(pennies, nickels, dimes, quarters, dollars);
//
//	cout << "Total Pinnes = " << totalPinnes << endl;
//	cout << "Total Dollars = " << totalDollars << endl;
//
//
//	system("pause>0");
//	return 0;
//}