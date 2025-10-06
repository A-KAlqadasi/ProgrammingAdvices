#include <iostream>
#include<iomanip>
#include<vector>
#include<string>

#include<fstream>
using namespace std;

const string ClientsFileName = "Client.txt";
const string UsersFileName = "Users.txt";
struct stClientData
{
	string AcountNumber = "";
	string PinCode = "";
	string Name = "";
	string Phone = "";
	double AccountBalance = 0;
	bool MarkClientToDelete = false;

};

struct stUserData
{
	string userName;
	string password;
	short permissions;
	bool MarkForDelete = false;


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
// user
stUserData ConvertUserLineToRecord(string Line, string Seperator = "/##/")
{
	stUserData UserData;
	vector<string>vUserRecord;

	vUserRecord = SplitStringWordsToVector(Line, Seperator);
	UserData.userName = vUserRecord[0];
	UserData.password = vUserRecord[1];
	UserData.permissions =stoi(vUserRecord[2]);


	return UserData;
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
// user
vector <stUserData> LoadUsersDataFromFile(string FileName)
{
	vector<stUserData> vUsers;
	fstream MyFile;

	MyFile.open(FileName, ios::in);
	if (MyFile.is_open())
	{
		string Line;
		stUserData UserDate;

		while (getline(MyFile, Line))
		{
			UserDate = ConvertUserLineToRecord(Line);

			vUsers.push_back(UserDate);
		}
		MyFile.close();
	}

	return vUsers;
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
// user
string ConvertUserRecoredToLine(stUserData UserData, string Seperator = "/##/")
{
	string stUserRecord = "";

	stUserRecord += UserData.userName + Seperator;
	stUserRecord += UserData.password + Seperator;
	stUserRecord += to_string(UserData.permissions);
	

	return stUserRecord;
}

// print all 
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

bool  ClientExistsByAccountNumber(string userName, string FileName)
{
	fstream MyFile;
	MyFile.open(FileName, ios::in);// read mode

	if (MyFile.is_open())
	{
		string Line;
		stUserData userData;
		while (getline(MyFile, Line))
		{
			userData = ConvertUserLineToRecord(Line);
			if (userData.userName == userName)
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
//---
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
void DepositBalanceToClientByAccountNumber(string AcountNumber, double amount, vector<stClientData>& vClients)
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

enum enTransactionMenueOptions { Deposit = 1, Withdraw = 2, TotalBalance = 3, MainMenue = 4 };
short ReadOptions(short from, short to)
{
	short option = 0;
	do
	{
		cout << "Choose the option of operation [" << from << " - " << to << "]? ";
		cin >> option;
	} while (option < from || option >to);
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

	PerformTransactionMenueOptions((enTransactionMenueOptions)ReadOptions(1,4));
}

//-------------------- Transaction 
// ------------------- Manage Usres
void ShowManageUsresMenue();
 // print all 
//  user
void PrintUserCard(stUserData user)
{
	cout << "\n\nThe following are the User details:\n";
	cout << "------------------------------------------\n";
	cout << "UserName    : " << user.userName << endl;
	cout << "Password    : " << user.password << endl;
	cout << "Permissions : " << user.permissions << endl;
	cout << "------------------------------------------\n";
}

void PrintUserRecord(stUserData UserData)
{
	cout << "| " << left << setw(30) << UserData.userName;
	cout << "| " << left << setw(10) << UserData.password;
	cout << "| " << left << setw(15) << UserData.permissions;
	cout << "\n----------------------------------------------------------";
	cout << "----------------------------------------------\n" << endl;

}

void PrintAllUsersScreen()
{
	vector<stUserData> vUsres = LoadUsersDataFromFile(UsersFileName);

	cout << "\n\t\t\t\t\t User List (" << vUsres.size() << ") user(s).";
	cout << "\n----------------------------------------------------------";
	cout << "----------------------------------------------\n" << endl;

	cout << "| " << left << setw(30) << "User Name";
	cout << "| " << left << setw(10) << "Pasword";
	cout << "| " << left << setw(15) << "Permissions";
	cout << "\n----------------------------------------------------------";
	cout << "----------------------------------------------\n" << endl;

	for (stUserData userData : vUsres)
	{
		PrintUserRecord(userData);
	}
}
// add new
stUserData ReadNewUser()
{

	stUserData UserData;
	cout << "Enter User Name? ";
	// usage of std::ws will ectract allthe whitespaces character
	getline(cin >> ws, UserData.userName);

	while (ClientExistsByAccountNumber(UserData.userName, UsersFileName))
	{
		cout << "User with [" << UserData.userName << "] already exists, Enter another user name\n?";
		getline(cin >> ws, UserData.userName);
	}

	cout << "Enter password? ";
	getline(cin, UserData.password);
	char allowPermission = 'Y';
	short permissions = -1;
	cout << "Do you want to give full access? [y/n]? ";
	cin >> allowPermission;

	if (tolower(allowPermission) == 'n')
	{
		cout << "\nDo you want to give access to : \n";
		cout << "Show client List? [y/n]? ";
		cin >> allowPermission;
		permissions = (tolower(allowPermission) == 'y' ? 1  : 0);
		cout << "\nAdd new Client? [y/n]? ";
		cin >> allowPermission;		
		permissions |= (tolower(allowPermission) == 'y' ? 2 : 0);
		cout << "\nDelete Client? [y/n]? ";
		cin >> allowPermission;
		permissions |= (tolower(allowPermission) == 'y' ? 4 : 0);
		cout << "\nUpdate Client? [y/n]? ";
		cin >> allowPermission;
		permissions |= (tolower(allowPermission) == 'y' ? 8 : 0);
		cout << "\nFind Client? [y/n]? ";
		cin >> allowPermission;
		permissions |= (tolower(allowPermission) == 'y' ? 16 : 0);
		cout << "\nTransactions? [y/n]? ";
		cin >> allowPermission;
		permissions |= (tolower(allowPermission) == 'y' ? 32 : 0);
		cout << "\nManage Users? [y/n]? ";
		cin >> allowPermission;
		permissions |= (tolower(allowPermission) == 'y' ? 64 : 0);
	}

	UserData.permissions = permissions;

	return UserData;
}

void AddNewUser()
{
	stUserData UserData;
	UserData = ReadNewUser();

	AddDataLineToFile(UsersFileName, ConvertUserRecoredToLine(UserData));

}

void AddNewUsers()
{
	char AddMore = 'Y';
	do {

		AddNewUser();

		cout << "\nUser Added Successfully, Do you want to add more Users?[Y/N]? ";
		cin >> AddMore;

	} while (toupper(AddMore) == 'Y');
}

void ShowAddNewUsersScreen()
{
	cout << "==========================\n";
	cout << "Adding Usres..            \n";
	cout << "==========================\n";
	AddNewUsers();
}
// delete user

bool  FindUserByUserName(string userSearch, vector <stUserData> vUser, stUserData& user)
{

	for (stUserData C : vUser)
	{
		if (C.userName == userSearch)
		{
			user = C;
			return true;
		}
	}

	return false;

}

bool MarkUserForDeleteByUserName(string UserName, vector<stUserData>& vUsers)
{
	for (stUserData& C : vUsers)
	{
		if (C.userName == UserName)
		{
			C.MarkForDelete = true;
			return true;
		}
	}
	return false;

}

bool SaveUserDatToFile(string FileName, vector<stUserData>& vUsers)
{
	fstream User;
	User.open(FileName, ios::out); // open the file for rewriting 

	string RecordLine;
	if (User.is_open())
	{
		for (stUserData& C : vUsers)
		{
			if (C.MarkForDelete == false)
			{
				RecordLine = ConvertUserRecoredToLine(C);
				User << RecordLine << endl;

			}

		}
		User.close();
		return true;
	}

	return false;
}

bool DeleteUserByUserName(string userName, vector<stUserData>& vUsers)
{
	stUserData user;
	char Answer = 'n';

	if (FindUserByUserName(userName, vUsers, user))
	{
		if (userName == "Admin")
		{
			cout << "\n\nYou can not delete the Admin!.\n";
			return false;
		}
		PrintUserCard(user);
		cout << "\n\nAre you sure you want delete this user? y/n ? ";
		cin >> Answer;

		if (Answer == 'Y' || Answer == 'y')
		{
			MarkUserForDeleteByUserName(userName, vUsers);
			SaveUserDatToFile(UsersFileName, vUsers);

			// Refresh Clients
			vUsers = LoadUsersDataFromFile(UsersFileName);

			cout << "\n\n User Deleted Successfully.\n";
			return true;
		}
		else
		{
			cout << "\n\nDelete Canceled.\n";
		}

	}
	else
	{
		cout << "\nUser with name (" << userName << ") Not Found!" << endl;
	}
}

string ReadUserName()
{
	string userName;
	cout << "Enter User Name ? ";
	cin >> userName;
	return userName;
}

void ShowDeleteUserScreen()
{
	cout << "============================\n";
	cout << "Delete User..             \n";
	cout << "============================\n";

	vector<stUserData > vUsers = LoadUsersDataFromFile(UsersFileName);

	string userName = ReadUserName();

	DeleteUserByUserName(userName, vUsers);

}

// Find user
void ShowfindUserScreen()
{

	cout << "============================\n";
	cout << "Search User..             \n";
	cout << "============================\n";

	string userName = ReadUserName();
	vector<stUserData> vUsres = LoadUsersDataFromFile(UsersFileName);
	stUserData user;
	if (FindUserByUserName(userName, vUsres, user))
	{
		PrintUserCard(user);
	}
	else
		cout << "User with Name (" << userName << ") not Found!" << endl;
}

// update user
void UpdateUsers(stUserData& User, string UserName)
{
	User.userName = UserName;

	cout << "Enter password? ";
	getline(cin >> ws ,User.password);
	char allowPermission = 'Y';
	short permissions = -1;
	cout << "Do you want to give full access? [y/n]? ";
	cin >> allowPermission;

	if (tolower(allowPermission) == 'n')
	{
		cout << "\nDo you want to give access to : \n";
		cout << "Show client List? [y/n]? ";
		cin >> allowPermission;
		permissions = (tolower(allowPermission) == 'y' ? 1 : 0);
		cout << "\nAdd new Client? [y/n]? ";
		cin >> allowPermission;
		permissions += (tolower(allowPermission) == 'y' ? 2 : 0);
		cout << "\nDelete Client? [y/n]? ";
		cin >> allowPermission;
		permissions += (tolower(allowPermission) == 'y' ? 4 : 0);
		cout << "\nUpdate Client? [y/n]? ";
		cin >> allowPermission;
		permissions += (tolower(allowPermission) == 'y' ? 8 : 0);
		cout << "\nFind Client? [y/n]? ";
		cin >> allowPermission;
		permissions += (tolower(allowPermission) == 'y' ? 16 : 0);
		cout << "\nTransactions? [y/n]? ";
		cin >> allowPermission;
		permissions += (tolower(allowPermission) == 'y' ? 32 : 0);
		cout << "\nManage Users? [y/n]? ";
		cin >> allowPermission;
		permissions += (tolower(allowPermission) == 'y' ? 64 : 0);
	}

	User.permissions = permissions;

}

bool UpdateUserByUserName(string UserName, vector<stUserData>& vUsers)
{
	stUserData User;
	char Answer = 'n';
	if (FindUserByUserName(UserName, vUsers, User))
	{
		if (UserName == "Admin")
		{
			cout << "\n\nYou Can't Update Admin!.\n";
			return false;
		}

		PrintUserCard(User);
		cout << "\n\nAre you sure you want update this user? y/n ? ";
		cin >> Answer;

		if (Answer == 'Y' || Answer == 'y')
		{
			for (stUserData& C : vUsers)
			{
				if (C.userName == UserName)
				{
					UpdateUsers(C, UserName);
					break;
				}
			}

			SaveUserDatToFile(UsersFileName, vUsers);

			// Refresh Clients
			vUsers = LoadUsersDataFromFile(UsersFileName);

			cout << "\n\n User updated Successfully.\n";
			return true;
		}
		else
		{
			cout << "\n\nUpdate Canceled.";
		}

	}
	else
	{
		cout << "\nUser with name (" << UserName << ") Not Found!" << endl;
	}


}

void ShowUpdateUserScreen()
{

	cout << "============================\n";
	cout << "Update User..             \n";
	cout << "============================\n";

	vector<stUserData > vUsers = LoadUsersDataFromFile(UsersFileName);
	string userName = ReadUserName();
	UpdateUserByUserName(userName, vUsers);
}

// main 
enum enManageUsersOptions {List =1 , Add =2,DeleteUser =3 , UpdateUser =4 , FindUser =5, Back =6};

void BackToUserScreen()
{
	cout << "Press any key to back to main menue...";
	system("pause>0");
	ShowManageUsresMenue();
}

void PerformManageUsersOptions(enManageUsersOptions manageUsers)
{
	switch (manageUsers)
	{
	case enManageUsersOptions::List:
		system("cls");
		PrintAllUsersScreen();
		BackToUserScreen();
		break;
	case enManageUsersOptions::Add:
		system("cls");
		ShowAddNewUsersScreen();
		BackToUserScreen();
		break;
	case enManageUsersOptions::DeleteUser:
		system("cls");
		ShowDeleteUserScreen();
		BackToUserScreen();
		break;
	case enManageUsersOptions::UpdateUser:
		system("cls");
		ShowUpdateUserScreen();
		BackToUserScreen();
		break;
	case enManageUsersOptions::FindUser:
		system("cls");
		ShowfindUserScreen();
		BackToUserScreen();
		break;
	case enManageUsersOptions::Back:
		ShowMainMenue();
		break;
	}

}

void ShowManageUsresMenue()
{
	system("cls");
	cout << "====================================\n";
	cout << "         Manage Users Screen        \n";
	cout << "====================================\n";
	cout << "         [1] List Users             \n";
	cout << "         [2] Add New User.          \n";
	cout << "         [3] Delete User.           \n";
	cout << "         [4] Update User.           \n";
	cout << "         [5] Find User.             \n";
	cout << "         [6] Main Menue.            \n";
	cout << "====================================\n";
	PerformManageUsersOptions((enManageUsersOptions)ReadOptions(1, 6));

}


//--------------------- ManageUsres
void Login();
void PrintExit()
{
	system("cls");
	cout << "================================\n";
	cout << "Exit The Program :-)            \n";
	cout << "================================\n";
	system("pause>0");
}

enum enMainMenueOptions { showAll = 1, AddNew = 2, Delete = 3, Update = 4, Find = 5 ,Transaction = 6, ManageUsers = 7, Exit = 8 };
void PerformMainMenueOption(enMainMenueOptions MainMenueOption, stUserData User)
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
	case enMainMenueOptions::ManageUsers:
		system("cls");
		ShowManageUsresMenue();
		BackToMainScreen();
		break;
	case enMainMenueOptions::Exit:
		Login();
		break;
	}

}

void ShowMainMenue(stUserData User)
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
	cout << "         [7] Manage Users.                 \n";
	cout << "         [8] Logout.                       \n";
	cout << "===========================================\n";

	PerformMainMenueOption((enMainMenueOptions)ReadOptions(1,8), User);

}

bool FindUserByUsernameAndPassword(string Username, string Password,stUserData& UserData)
{
	vector<stUserData> vUsers = LoadUsersDataFromFile(UsersFileName);
	stUserData user; 
	FindUserByUserName(Username, vUsers, user);
	UserData = user;
	return (user.userName == Username && user.password == Password);

}

void Login()
{
	system("cls");
	cout << "\n--------------------------\n";
	cout << "         Login Screen\n";
	cout << "\n--------------------------\n";
	string userName;
	string password;
	stUserData User;

	do
	{
		cout << "Enter Username? ";
		cin >> userName;
		cout << "Enter Password? ";
		cin >> password;

		if (!FindUserByUsernameAndPassword(userName, password,User))
		{
			cout << "\nInvalid username/password!\n";
		}


	} while (!FindUserByUsernameAndPassword(userName,password ,User));

	ShowMainMenue(User);
}


int main()
{

	Login();


	system("pause>0");
}
