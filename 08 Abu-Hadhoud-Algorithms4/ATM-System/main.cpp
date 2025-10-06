#include <iostream>
#include <vector>
#include <string>
#include <fstream>

using namespace std;

string ClientsFileName = "Client.txt";

struct stClientData
{
	string AcountNumber = "";
	string PinCode = "";
	string Name = "";
	string Phone = "";
	double AccountBalance = 0;
	bool MarkClientToDelete = false;

};

stClientData CurrentClient;

vector<string> SplitString(string Text, string delim)
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
string ConvertRecoredToLine(stClientData ClientData, string Seperator = "/##/")
{
	string stClientRecord = "";

	stClientRecord += ClientData.AcountNumber + Seperator;
	stClientRecord += ClientData.PinCode + Seperator;
	stClientRecord += ClientData.Name + Seperator;
	stClientRecord += ClientData.Phone + Seperator;
	stClientRecord += to_string(ClientData.AccountBalance);

	return stClientRecord;
}

stClientData ConvertLineToRecord(string Line, string Seperator = "/##/")
{
	stClientData ClientData;
	vector<string>vClientRecord;

	vClientRecord = SplitString(Line, Seperator);
	ClientData.AcountNumber = vClientRecord[0];
	ClientData.PinCode = vClientRecord[1];
	ClientData.Name = vClientRecord[2];
	ClientData.Phone = vClientRecord[3];
	ClientData.AccountBalance = stod(vClientRecord[4]); // cast string to double

	return ClientData;
}

vector<stClientData> LoadClientsDataFromFile()
{
	vector<stClientData> vClients;

	fstream myFile;
	myFile.open(ClientsFileName, ios::in);

	if (myFile.is_open())
	{
		string lineData;
		while (getline(myFile,lineData))
		{
			stClientData Client = ConvertLineToRecord(lineData);
			vClients.push_back(Client);
		}
		myFile.close();
	}

	return vClients;

}

bool SaveClientDatToFile(string FileName, vector<stClientData>& vClients)
{
	fstream Client;
	Client.open(FileName, ios::out); // open the file for rewriting 

	string RecordLine;
	if (Client.is_open())
	{
		for (stClientData& C : vClients)
		{
			if (C.MarkClientToDelete == false)
			{
				RecordLine = ConvertRecoredToLine(C);
				Client << RecordLine << endl;

			}

		}
		Client.close();
		return true;
	}

	return false;
}

enum enMainMenueOptions {QuickWithdraw = 1, NormalWithdraw =2,Deposit =3,
						CheckBalance =4,Logout =5};

short ReadOperationOption(short from, short to,string message)
{
	short option = 0;
	do
	{
		cout << message << from << "] - [" << to << "]? ";
		cin >> option;
	} while (option < from || option >to);
	return option;

}

void DepositBalanceFromClientAccount(string AcountNumber, double amount, vector<stClientData> &vClients)
{

	char answer = 'y';
	for (stClientData& C : vClients)
	{
		if (C.AcountNumber == AcountNumber)
		{
			cout << "\n\nAre you sur you wnat to complete this operation?[y/n]? ";
			cin >> answer;
			if (answer == 'y' || answer == 'Y')
			{
				C.AccountBalance += amount;
				SaveClientDatToFile(ClientsFileName, vClients);
				cout << "\n\nDone Successfully Your New Balance Now : " << C.AccountBalance << endl;
				
				break;
			}
			else
			{
				cout << "Process Canseld!";
				break;
			}
		}
		
	}



}

bool  FindClientByAccountNumberAndPassword(string accountNumber,string password,stClientData &Client)
{
	vector <stClientData> vClients = LoadClientsDataFromFile();

	for (stClientData C : vClients)
	{
		if (C.AcountNumber == accountNumber && C.PinCode == password)
		{
			Client = C;
			return true;
		}
	}

	return false;

}

void ShowQuickWithdrawScreen();

void BackToQuickWithdrawScreen()
{
	cout << "\nPress any key to try again!..";
	system("pause>0");
	ShowQuickWithdrawScreen();
}

short getQuickWithDrawAmount(short quickWithdrawOption)
{
	switch (quickWithdrawOption)
	{
	case 1:
		return 20;
	case 2:
		return(50);
	case 3:
		return(100);
	case 4:
		return(200);
	case 5:
		return(500);
	case 6:
		return(600);
	case 7:
		return(800);
	case 8:
		return(1000);
	}
}

void PerformQuickWithdrawOptions(short quickOption)
{
	if (quickOption == 9)
		return;

	short withDrawBalance = getQuickWithDrawAmount(quickOption);

	if (withDrawBalance > CurrentClient.AccountBalance)
	{
		cout << "\nAmount Exceeds the balance, you can withdraw up to: " << CurrentClient.AccountBalance << endl;
		BackToQuickWithdrawScreen();
		return;
	}
	vector<stClientData> vClients = LoadClientsDataFromFile();

	DepositBalanceFromClientAccount(CurrentClient.AcountNumber, withDrawBalance * -1,vClients);
	CurrentClient.AccountBalance -= withDrawBalance;

}


void ShowQuickWithdrawScreen()
{
	//cout << "quick withdraw screen will be here\n";
	system("cls");
	cout << "=========================================\n";
	cout << "            Quick Withdraw \n";
	cout << "=========================================\n";
	cout << "      [1] 20            [2] 50\n";
	cout << "      [3] 100           [4] 200\n";
	cout << "      [5] 500           [6] 600\n";
	cout << "      [7] 800           [8] 1000\n";
	cout << "      [9] Exit\n";
	cout << "=========================================\n";
	cout << "Your Balance is [ " << CurrentClient.AccountBalance << " ] \n";
	PerformQuickWithdrawOptions(ReadOperationOption(1, 9, "Choose what to withdraw from ["));

}

bool isAmountOfMultiple5(int amount)
{
	return (amount % 5) == 0;
}

int ReadAmountForWithdraw()
{
	int amount = 0;
	do
	{
		cout << "\n\nEnter an amount multiple of 5's ? ";
		cin >> amount;

	} while (!isAmountOfMultiple5(amount));

	return amount;
}

int ReadAmountForDeposit()
{
	int amount = 0;
	do
	{
		cout << "\n\nEnter a positive amount for deposit? ";
		cin >> amount;

	} while (amount <= 0);
	return amount;
}

void performNormalWithdrawOption()
{
	int amount = ReadAmountForWithdraw();
	vector<stClientData> vClients = LoadClientsDataFromFile();

	if (amount <= CurrentClient.AccountBalance)
	{
		DepositBalanceFromClientAccount(CurrentClient.AcountNumber, amount * -1, vClients);
		CurrentClient.AccountBalance -= amount;
	}
	else
	{
		cout << "\n\nAmount Exceeds the balance, you can withdraw up to: " << CurrentClient.AccountBalance << endl;
	}
}

void ShowNormalWithdrawScreen()
{
	//cout << "normal withdraw screen will be here\n";
	system("cls");
	cout << "=========================================\n";
	cout << "            Normal Withdraw Screen\n";
	cout << "=========================================\n";
	performNormalWithdrawOption();

}

void performDepositOption()
{
	int amount = ReadAmountForDeposit();
	vector<stClientData> vClients = LoadClientsDataFromFile();

	DepositBalanceFromClientAccount(CurrentClient.AcountNumber, amount, vClients);
	CurrentClient.AccountBalance += amount;
}

void ShowDepositScreen()
{
	system("cls");
	cout << "=========================================\n";
	cout << "             Deposit Screen\n";
	cout << "=========================================\n";
	performDepositOption();
}

void ShowCheckBalanceScreen()
{
	//cout << "check balance screen will be here\n";
	cout << "======================================\n";
	cout << "            Check Balance Screen\n";
	cout << "======================================\n";
	cout << "Your Balance is [ "<< CurrentClient.AccountBalance << " ] \n\n";

}

void ShowATMmainScreen();

void BackToMainMenue()
{
	cout << "\npress any key to back to main menue...";
	system("pause>0");
	ShowATMmainScreen();
}

void PerformMainScreenOptions(enMainMenueOptions option)
{
	switch (option)
	{
	case QuickWithdraw:
		system("cls");
		ShowQuickWithdrawScreen();
		BackToMainMenue();
		break;
	case NormalWithdraw:
		system("cls");
		ShowNormalWithdrawScreen();
		BackToMainMenue();
		break;
	case Deposit:
		system("cls");
		ShowDepositScreen();
		BackToMainMenue();
		break;
	case CheckBalance:
		system("cls");
		ShowCheckBalanceScreen();
		BackToMainMenue();
		break;
	case Logout:
	{
		// here will be nothing ..
	}
	}
}

void ShowATMmainScreen()
{
	system("cls");
	cout << "\n===================================\n";
	cout << "            ATM Main Menue Screen\n";
	cout << "\n===================================\n";
	cout << "       [1] Quick Withdraw\n";
	cout << "       [2] Normal Withdraw\n";
	cout << "       [3] Deposit\n";
	cout << "       [4] Check Balance\n";
	cout << "       [5] Logout\n";
	cout << "\n===================================\n";

	PerformMainScreenOptions((enMainMenueOptions) ReadOperationOption(1,5, "Choose the option of operation ["));

}

bool IsClientExists(string accountNumber, string password)
{
	if (FindClientByAccountNumberAndPassword(accountNumber, password, CurrentClient))
		return true;
	else
		return false;
}

void Login()
{
	bool loginFailed = false;
	string accountNumber, password;
	do
	{
		system("cls");
		cout << "=======================\n";
		cout << "    Login Screen\n";
		cout << "=======================\n";

		if (loginFailed)
		{
			cout << "\nInvalid account number/password!\n";
		}
		cout << "\nAccount number? ";
		cin >> accountNumber;
		cout << "\nPassword? ";
		cin >> password;

		loginFailed = !IsClientExists(accountNumber, password);

	} while (loginFailed);

	ShowATMmainScreen();

}

int main()
{

	Login();

	system("pause>0");

	return 0;
}