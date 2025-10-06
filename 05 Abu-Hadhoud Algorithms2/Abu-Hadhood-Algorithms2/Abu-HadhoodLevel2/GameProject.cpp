#include<iostream>
#include <cstdlib>
using namespace std;

enum enGameChoice {Stone =1 , Paper = 2 , Scissors = 3};
enum enWinner {Player1 =1 , Computer = 2 , Draw = 3 };

struct stRoundInfo 
{
	short RoundNumber = 0;
	enGameChoice Player1Choice;
	enGameChoice ComputerChoice;
	enWinner RoundWinner;
	string WinnerName = "";

};
struct stGameResults{
	short GameRounds = 0;
	short Player1WinTimes = 0;
	short Computer2WinTimes = 0;
	short DrawTimes = 0;
	enWinner GameWinner;
	string WinnerName = "";

};
int RandomNumber(int From, int To) {
	int Number;
	Number = rand() % (To - From + 1) + From;
	return Number;

}
string WinnerName(enWinner Winner)
{
	string arrWinnerName[3] = { "Player1 "," Computer", "No Winner" };
	return arrWinnerName[Winner - 1];
}
enWinner WhoWinTheRound(stRoundInfo RoundInfo)
{
	if (RoundInfo.Player1Choice == RoundInfo.ComputerChoice)
	{
		return enWinner::Draw;
	}
	switch (RoundInfo.Player1Choice)
	{
	case enGameChoice::Stone:
		if (RoundInfo.ComputerChoice == enGameChoice::Paper)
		{
			return enWinner::Computer;
		}
		break;
	case enGameChoice::Paper:
		if (RoundInfo.ComputerChoice == enGameChoice::Scissors)
		{
			return enWinner::Computer;
		}
		break;
	case enGameChoice::Scissors:
		if (RoundInfo.ComputerChoice == enGameChoice::Stone)
		{
			return enWinner::Computer;
		}
		break;

	}

	return enWinner::Player1;


}
string GameChoiceName(enGameChoice GameChoice)
{
	string arrGameChoiceName[3]{ "Stone ","Paper", "Scissor" };
	return arrGameChoiceName[GameChoice - 1];
}
void GameResultsColor(enWinner Winner)
{
	switch (Winner)
	{
	case Player1:
		system("color 2F");
		break;
	case Computer:
		cout << "\a";
		system("color 4F");
		break;
	default:
		system("color 6F");
		break;
	}
}
void PrintRoundResult(stRoundInfo RoundInfo)
{
	cout << "\n---------Round[" << RoundInfo.RoundNumber << "]----------------\n";
	cout << "Computer Choice :" << GameChoiceName(RoundInfo.ComputerChoice) << endl;
	cout << "Player   Choice :" << GameChoiceName(RoundInfo.Player1Choice) << endl;
	cout << "Winner          :[" << RoundInfo.WinnerName << "]" << endl;
	cout << "------------------------------------------------------------------\n";
	GameResultsColor(RoundInfo.RoundWinner);

}
enWinner WhoWinTheGame(short PlayerWinTimes, short ComputerWinTimes)
{
	if (PlayerWinTimes > ComputerWinTimes)
		return enWinner::Player1;
	else if (ComputerWinTimes > PlayerWinTimes)
		return enWinner::Computer;
	else
		return enWinner::Draw;
}
stGameResults FillGameResults(short Rounds, short PlayerWinTimes, short ComputerWinTimes, short drawTimes)
{
	stGameResults GameResults;
	GameResults.GameRounds = Rounds;
	GameResults.Player1WinTimes = PlayerWinTimes;
	GameResults.Computer2WinTimes = ComputerWinTimes;
	GameResults.DrawTimes = drawTimes;
	GameResults.GameWinner = WhoWinTheGame(PlayerWinTimes, ComputerWinTimes);
	GameResults.WinnerName = WinnerName(GameResults.GameWinner);

	return GameResults;
}
enGameChoice ReadPlayer1Choice()
{
	short Choice = 0;
	do
	{
		cout << "Your Choice: Stone:[1], Paper:[2], Scissors:[3]?\n";
		cin >> Choice;

	} while (Choice < 1 || Choice > 3);

	return (enGameChoice)Choice;
}
enGameChoice GetComputerChoice()
{
	return (enGameChoice)RandomNumber(1, 3);
}
stGameResults PlayGame(short HowManyRounds)
{
	stRoundInfo RoundInfo;
	short Player1WinTimes = 0, ComputerWinTimes = 0, DrawTimes = 0;

	for (short GameRound = 1; GameRound <= HowManyRounds; GameRound++)
	{
		cout << "\nRound [" << GameRound << "] begins:\n";
		RoundInfo.RoundNumber = GameRound;
		RoundInfo.Player1Choice = ReadPlayer1Choice();
		RoundInfo.ComputerChoice = GetComputerChoice();
		RoundInfo.RoundWinner = WhoWinTheRound(RoundInfo);
		RoundInfo.WinnerName = WinnerName(RoundInfo.RoundWinner);

		// increse the points of winners
		if (RoundInfo.RoundWinner == enWinner::Player1)
			Player1WinTimes++;
		else if (RoundInfo.RoundWinner == enWinner::Computer)
			ComputerWinTimes++;
		else
			DrawTimes++;

		PrintRoundResult(RoundInfo);

	}

	return FillGameResults(HowManyRounds, Player1WinTimes, ComputerWinTimes, DrawTimes);
}
void PrintGameOverPart() {
	cout << "\t\t\t------------------------------------------------\n";
	cout << "\t\t\t             +++ G a m e O v e r +++            \n";
	cout << "\t\t\t-----------------[Game Results]-----------------\n";
}
void PrintFinalResult(stGameResults GameResults)
{
	cout << "\t\t\tGame Rounds       : " << GameResults.GameRounds << endl;
	cout << "\t\t\tPlayer1 won times : " << GameResults.Player1WinTimes << endl;
	cout << "\t\t\tComputer won times:" << GameResults.Computer2WinTimes << endl;
	cout << "\t\t\tDraw times        :" << GameResults.DrawTimes << endl;
	cout << "\t\t\tFinale Winner     :" << GameResults.WinnerName << endl;
	cout << "\t\t\t------------------------------------------------\n";
	GameResultsColor(GameResults.GameWinner);

}

short ReadHowManyRounds() {
	short GameRound;
	do {
		cout << "How Many Rounds 1 to 10 ?" << endl;
		cin >> GameRound;

	} while (GameRound < 1 || GameRound > 10);
	return GameRound;
}
void ResetScreen() 
{
	system("cls");
	system("color 0F");
}
void StartGame() {
	char KeepPlaying = 'Y';
	do {
		ResetScreen();

		stGameResults GameResults = PlayGame(ReadHowManyRounds());
	
		PrintGameOverPart();
		PrintFinalResult(GameResults);

		cout << "Do you want to play again: Yes[Y]:, No:[N] ?\n";
		cin >> KeepPlaying;
	} while (KeepPlaying == 'Y' || KeepPlaying == 'y');
}
int main() {
	// seeds the random number generator in C++, called only once 
	srand((unsigned)time(NULL));
	
	StartGame();

	return 0;
}