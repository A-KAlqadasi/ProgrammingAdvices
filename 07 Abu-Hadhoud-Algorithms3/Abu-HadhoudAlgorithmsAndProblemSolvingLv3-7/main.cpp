#include <iostream>
#include<iomanip>
#include<vector>
#include<string>

#include<fstream>
using namespace std;

const string ClientsFileName = "Client.txt";

struct stClientData
{
	string AcountNumber = "";
	string PinCode = "";
	string Name = "";
	string Phone = "";
	double AccountBalance = 0;
	bool MarkClientToDelete = false;

};

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

stClientData ConvertLineToRecord(string Line, string Seperator = "/##/")
{
	stClientData ClientData;
	vector<string>vClientRecord;

	vClientRecord = SplitStringWordsToVector(Line, Seperator);
	ClientData.AcountNumber = vClientRecord[0];
	ClientData.PinCode = vClientRecord[1];
	ClientData.Name = vClientRecord[2];
	ClientData.Phone = vClientRecord[3];
	ClientData.AccountBalance = stod(vClientRecord[4]); // cast string to double

	return ClientData;

}

vector <stClientData> LoadClientsDataFromFile(string FileName)
{
	vector <stClientData> vClients;

	fstream MyFile;
	MyFile.open(FileName, ios::in); // read mode
	if (MyFile.is_open())
	{
		string Line;
		stClientData ClientData;

		while (getline(MyFile, Line))
		{
			ClientData = ConvertLineToRecord(Line);

			vClients.push_back(ClientData);
		}
		MyFile.close();
	}

	return vClients;

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

void PrintClientRecord(stClientData ClientData)
{
	cout << "| " << left << setw(15) << ClientData.AcountNumber;
	cout << "| " << left << setw(10) << ClientData.PinCode;
	cout << "| " << left << setw(30) << ClientData.Name;
	cout << "| " << left << setw(15) << ClientData.Phone;
	cout << "| " << left << setw(15) << ClientData.AccountBalance;
	cout << "\n----------------------------------------------------------";
	cout << "----------------------------------------------\n" << endl;

}
void PrintAllClientsScreen()
{
	
	vector<stClientData> vClients = LoadClientsDataFromFile(ClientsFileName);

	cout << "\n\t\t\t\t\t Clients List (" << vClients.size() << ") Client(s).";
	cout << "\n----------------------------------------------------------";
	cout << "----------------------------------------------\n" << endl;

	cout << "| " << left << setw(15) << "Account Number";
	cout << "| " << left << setw(10) << "Pin Code";
	cout << "| " << left << setw(30) << "Client Name";
	cout << "| " << left << setw(15) << "Phone";
	cout << "| " << left << setw(15) << "Balance";
	cout << "\n----------------------------------------------------------";
	cout << "----------------------------------------------\n" << endl;

	for (stClientData ClientData : vClients)
	{
		PrintClientRecord(ClientData);
	}

}

void ShowMainMenue();
void BackToMainScreen()
{
	cout << "Press any key to back to main menue...";
	system("pause>0");
	ShowMainMenue();
}

bool  ClientExistsByAccountNumber( string AccountNumber , string FileName)
{
	fstream MyFile;
	MyFile.open(FileName, ios::in);// read mode

	if (MyFile.is_open())
	{
		string Line;
		stClientData client;
		while (getline(MyFile, Line))
		{
			client = ConvertLineToRecord(Line);
			if (client.AcountNumber == AccountNumber)
			{
				MyFile.close();
				return true;
			}
			
		}

	}

	MyFile.close();
	return false;
}

stClientData ReadNewClient()
{

	stClientData ClientData;
	cout << "Enter Account Number? ";
	// usage of std::ws will ectract allthe whitespaces character
	getline(cin >> ws, ClientData.AcountNumber);

	while (ClientExistsByAccountNumber(ClientData.AcountNumber, ClientsFileName))
	{
		cout << "Client with [" << ClientData.AcountNumber << "] already exists, Enter another Account Number\n?";
		getline(cin >> ws, ClientData.AcountNumber);
	}

		cout << "Enter PinCode? ";
		getline(cin, ClientData.PinCode);
		cout << "Enter Name? ";
		getline(cin, ClientData.Name);
		cout << "Enter Phone? ";
		getline(cin, ClientData.Phone);
		cout << "Enter AccountBalance? ";
		cin >> ClientData.AccountBalance;

		return ClientData;
	
}
void AddDataLineToFile(string FileName, string stDataLine)
{
	fstream Client;
	Client.open(FileName, ios::out | ios::app);// write mode

	if (Client.is_open())
	{
		Client << stDataLine << endl;
	}
	Client.close();
}
void AddNewClient()
{
	
	stClientData ClientData;
	ClientData = ReadNewClient();

	AddDataLineToFile(ClientsFileName, ConvertRecoredToLine(ClientData));

}
void AddNewClients()
{
	char AddMore = 'Y';
	do {

		AddNewClient();

		cout << "\nClient Added Successfully, Do you want to add more clients?[Y/N]? ";
		cin >> AddMore;

	} while (toupper(AddMore) == 'Y');
}
void ShowAddNewClientsScreen()
{
	cout << "==========================\n";
	cout << "Adding Client..           \n";
	cout << "==========================\n";

	AddNewClients();

}

void PrintClientCard(stClientData client)
{
	cout << "\n\nThe following are the client details:\n";
	cout << "------------------------------------------\n";
	cout << "Account Number: " << client.AcountNumber << endl;
	cout << "Pin Code      : " << client.PinCode << endl;
	cout << "Name          : " << client.Name << endl;
	cout << "Phone         : " << client.Phone << endl;
	cout << "Account Balance: " << client.AccountBalance << endl;
	cout << "------------------------------------------\n";
}
string ReadAccountNumber()
{
	string accountNumber;
	cout << "Please Enter AccountNumber? ";
	cin >> accountNumber;
	return accountNumber;

}

bool  FindClientByAccountNumber(string AccountSearch, vector <stClientData> vClients, stClientData& client)
{

	for (stClientData C : vClients)
	{
		if (C.AcountNumber == AccountSearch)
		{
			client = C;
			return true;
		}
	}

	return false;

}

bool MarkClientForDeleteByAccountNumber(string AccountNumber, vector<stClientData>& vClients)
{
	for (stClientData& C : vClients)
	{
		if (C.AcountNumber == AccountNumber)
		{
			C.MarkClientToDelete = true;
			return true;
		}
	}
	return false;

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

bool DeleteClientByAccountNumber(string AccountNumber, vector<stClientData>& vClients)
{
	stClientData Client;
	char Answer = 'n';

	if (FindClientByAccountNumber(AccountNumber, vClients, Client))
	{
		PrintClientCard(Client);
		cout << "\n\nAre you sure you want delete this client? y/n ? ";
		cin >> Answer;

		if (Answer == 'Y' || Answer == 'y')
		{
			MarkClientForDeleteByAccountNumber(AccountNumber, vClients);
			SaveClientDatToFile(ClientsFileName, vClients);

			// Refresh Clients
			vClients = LoadClientsDataFromFile(ClientsFileName);

			cout << "\n\n Client Deleted Successfully.";
			return true;
		}
		else
		{
			cout << "\n\nDelete Canceled.";
		}

	}
	else
	{
		cout << "\nClient with Account (" << AccountNumber << ") Not Found!" << endl;
	}

	

}
void ShowDeleteClientScreen()
{
	cout << "============================\n";
	cout << "Delete Client..             \n";
	cout << "============================\n";

	vector<stClientData > vClients = LoadClientsDataFromFile(ClientsFileName);
	string AccountNumber = ReadAccountNumber();
	DeleteClientByAccountNumber(AccountNumber, vClients);

}

void ShowfindClientScreen()
{
	
	cout << "============================\n";
	cout << "Search Client..             \n";
	cout << "============================\n";

	string AccountNumber = ReadAccountNumber();
	vector<stClientData> vClients = LoadClientsDataFromFile(ClientsFileName);
	stClientData client;
	if (FindClientByAccountNumber(AccountNumber, vClients, client))
	{
		PrintClientCard(client);
	}
	else
		cout << "Client with Account (" << AccountNumber << ") not Found!" << endl;
}
void UpdateClient(stClientData& client, string AccountNumber)
{
	client.AcountNumber = AccountNumber;
	cout << "Enter the Pin Code? ";
	getline(cin >> ws, client.PinCode);

	cout << "Enter the Name? ";
	getline(cin, client.Name);

	cout << "Enter the Phone? ";
	getline(cin, client.Phone);
	cout << "Enter the Account Balance? ";
	cin >> client.AccountBalance;


}
bool UpdateClientByAccountNumber(string AccountNumber, vector<stClientData>& vClients)
{
	stClientData Client;
	char Answer = 'n';
	if (FindClientByAccountNumber(AccountNumber, vClients, Client))
	{
		PrintClientCard(Client);
		cout << "\n\nAre you sure you want update this client? y/n ? ";
		cin >> Answer;

		if (Answer == 'Y' || Answer == 'y')
		{
			for (stClientData& C : vClients)
			{
				if (C.AcountNumber == AccountNumber)
				{
					UpdateClient(C, AccountNumber);
					break;
				}
			}

			SaveClientDatToFile(ClientsFileName, vClients);

			// Refresh Clients
			vClients = LoadClientsDataFromFile(ClientsFileName);

			cout << "\n\n Client updated Successfully.";
			return true;
		}
		else
		{
			cout << "\n\nUpdate Canceled.";
		}

	}
	else
	{
		cout << "\nClient with Account (" << AccountNumber << ") Not Found!" << endl;
	}


}
void ShowUpdateClientScreen()
{
	
	cout << "============================\n";
	cout << "Update Client..             \n";
	cout << "============================\n";

	vector<stClientData > vClients = LoadClientsDataFromFile(ClientsFileName);
	string AccountNumber = ReadAccountNumber();
	UpdateClientByAccountNumber(AccountNumber, vClients);
}
//------------------------------ Transaction
void ShowTransactionMenueScreen(); // declaration
void BackToTransactionScreen()
{
	cout << "Press any key to back to Transaction menue...";
	system("pause>0");
	ShowTransactionMenueScreen();

}

double ReadBalanceAmount()
{
	double amount = 0;
	do
	{
		cout << "\nPlease enter balance amount? ";
		cin >> amount;
	} while (amount <= 0);
	return amount;
}
void DepositBalanceToClientByAccountNumber( string AcountNumber, double amount ,vector<stClientData> &vClients )
{
	
	char answer = 'y';
	for (stClientData& C : vClients)
	{
		if (C.AcountNumber == AcountNumber)
		{
			cout << "\n\nAre you sur you wnat to deposit For This Client?[y/n]? ";
			cin >> answer;
			if (answer == 'y' || answer == 'Y')
			{
				C.AccountBalance += amount;
				SaveClientDatToFile(ClientsFileName, vClients);
				cout << "Done Successfully Your New Balance Now : " << C.AccountBalance << endl;
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

void ShowDepositeScreen()
{
	cout << "------------------------\n";
	cout << "       Deposit\n";
	cout << "------------------------\n";

	string AccountNumber = ReadAccountNumber();
	vector<stClientData>vClients = LoadClientsDataFromFile(ClientsFileName);;
	stClientData client;

	while (!FindClientByAccountNumber(AccountNumber, vClients, client))
	{
		cout << "Client with [" << AccountNumber << "] is not Found!\n";
		AccountNumber = ReadAccountNumber();

	}

	PrintClientCard(client);

	double amount = ReadBalanceAmount();

	DepositBalanceToClientByAccountNumber(AccountNumber, amount, vClients);

}

void ShowWithdrawScreen()
{
	cout << "------------------------\n";
	cout << "       Withdraw\n";
	cout << "------------------------\n";

	string AccountNumber = ReadAccountNumber();
	vector<stClientData>vClients = LoadClientsDataFromFile(ClientsFileName);;
	stClientData client;

	while (!FindClientByAccountNumber(AccountNumber, vClients, client))
	{
		cout << "Client with [" << AccountNumber << "] is not Found!\n";
		AccountNumber = ReadAccountNumber();

	}

	PrintClientCard(client);

	double amount = ReadBalanceAmount();

	while (amount > client.AccountBalance)
	{
		cout << "\nAmount Exceeds the balance, you can withdraw up to: " << client.AccountBalance << endl;
		amount = ReadBalanceAmount();
	}

	DepositBalanceToClientByAccountNumber(AccountNumber, amount * -1, vClients);

}

void PrintClientBalance(stClientData ClientData)
{
	cout << "| " << left << setw(20) << ClientData.AcountNumber;
	cout << "| " << left << setw(35) << ClientData.Name;
	cout << "| " << left << setw(20) << ClientData.AccountBalance;
	cout << "\n----------------------------------------------------------";
	cout << "----------------------------------------------\n" << endl;



}
void PrintTotalBalance()
{

	vector<stClientData> vClients = LoadClientsDataFromFile(ClientsFileName);

	cout << "\n\t\t\t\t\t Clients List (" << vClients.size() << ") Client(s).";
	cout << "\n----------------------------------------------------------";
	cout << "----------------------------------------------\n" << endl;

	cout << "| " << left << setw(20) << "Account Number";
	cout << "| " << left << setw(35) << "Client Name";
	cout << "| " << left << setw(20) << "Balance";
	cout << "\n----------------------------------------------------------";
	cout << "----------------------------------------------\n" << endl;

	int TotalBalance = 0;

	if (vClients.size() == 0)
	{
		cout << "\n\nNo Clients Available in the system!.\n";
	}
	else
	{
		for (stClientData ClientData : vClients)
		{
			TotalBalance += ClientData.AccountBalance;
			PrintClientBalance(ClientData);
		}
		cout << "\t\t\t\t\t Total Balance : " << TotalBalance << endl << endl;

	}
}

enum enTransactionMenueOptions {Deposit =1 , Withdraw = 2 , TotalBalance =3 , MainMenue = 4};
short ReadTransactionMenueOptions()
{
	short option = 0;
	do
	{
		cout << "Choose what do you want to do? [1 to 4 ]? ";
		cin >> option;
	} while (option < 1 || option >4);
	return option;

}

void PerformTransactionMenueOptions(enTransactionMenueOptions TransactionMenue)
{
	switch (TransactionMenue)
	{
	case Deposit:
		system("cls");
		ShowDepositeScreen();
		BackToTransactionScreen();
		break;
	case Withdraw:
		system("cls");
		ShowWithdrawScreen();
		BackToTransactionScreen();
		break;
	case TotalBalance:
		system("cls");
		PrintTotalBalance();
		BackToTransactionScreen();
		break;
	case MainMenue:
		
		ShowMainMenue();
		break;
	
	}
}

void ShowTransactionMenueScreen()
{
	system("cls");
	cout << "\n=========================================\n";
	cout << "             Transaction Menue Screen    \n";
	cout << "=========================================\n";
	cout << "        [1] Deposite.\n";
	cout << "        [2] Withdraw.\n";
	cout << "        [3] Total Balances.\n";
	cout << "        [4] Main Menue.\n";
	cout << "=========================================\n";

	PerformTransactionMenueOptions((enTransactionMenueOptions)ReadTransactionMenueOptions());
}

//-------------------- Transaction 
void PrintExit()
{
	system("cls");
	cout << "================================\n";
	cout << "Exit The Program :-)            \n";
	cout << "================================\n";
	system("pause>0");
}
enum enMainMenueOptions { showAll = 1, AddNew = 2, Delete = 3, Update = 4, Find = 5, Transaction = 6 , Exit =7 };
short ReadMainMenueOption()
{
	short option;
	do 
	{
		cout << "Choose the option of operation [1 to 7 ]? ";
		cin >> option;
	} while (option < 1 || option >7);
	return option;
}
void PerformMainMenueOption(enMainMenueOptions MainMenueOption)
{
		switch (MainMenueOption)
		{
		case enMainMenueOptions::showAll:
			system("cls");
			PrintAllClientsScreen();
			BackToMainScreen();
			break;
		case enMainMenueOptions::AddNew:
			system("cls");
			ShowAddNewClientsScreen();
			BackToMainScreen();
			break;
		case enMainMenueOptions::Delete:
			system("cls");
			ShowDeleteClientScreen();
			BackToMainScreen();
			break;
		case enMainMenueOptions::Update:
			system("cls");
			ShowUpdateClientScreen();
			BackToMainScreen();
			break;
		case enMainMenueOptions::Find:
			system("cls");
			ShowfindClientScreen();
			BackToMainScreen();
			break;
		case enMainMenueOptions::Transaction:
			system("cls");
			ShowTransactionMenueScreen();
			BackToMainScreen();
			break;
		case enMainMenueOptions::Exit:
			PrintExit();
			break;
		}

}

void ShowMainMenue()
{
	system("cls");
	cout << "===========================================\n";
	cout << "              Main Menue Screen            \n";
	cout << "===========================================\n";
	cout << "         [1] Show Client List.             \n";
	cout << "         [2] Add New Client.               \n";
	cout << "         [3] Delete Client.                \n";
	cout << "         [4] Update Client Info.           \n";
	cout << "         [5] Find Client.                  \n";
	cout << "         [6] Transactions.                 \n";
	cout << "         [7] Exit.                         \n";
	cout << "===========================================\n";

	PerformMainMenueOption((enMainMenueOptions)ReadMainMenueOption());

}

int main()
{

	ShowMainMenue();

	system("pause>0");
}
