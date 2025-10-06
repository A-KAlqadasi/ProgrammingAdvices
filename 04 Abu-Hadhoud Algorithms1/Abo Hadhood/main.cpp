#include <iostream>
#include <string>

using namespace std;

string ReadPinCode()
{
	string PinCode;
	cout << "Please enter PIN code ?\n";
	cin >> PinCode;

	return PinCode;
}

bool Login()
{
	string PinCode;
	int counter = 3;
	do
	{   
		PinCode = ReadPinCode();
		if (PinCode == "1234")
		{
			return 1;
		}
		else
		{
			counter--;
			cout << "\nWrong PIN You have "<< counter<<" times\n";
			system("color 4F");
		}
	} while (PinCode != "1234" && counter >= 1);
	return 0;
}
int main() { 
	if (Login())
	{
		cout << "your Balance is: " << 7500 << endl;
		system("color 2F");
	}
	else
		cout << "Your PIN is locked\n";
		

	return 0;
}
