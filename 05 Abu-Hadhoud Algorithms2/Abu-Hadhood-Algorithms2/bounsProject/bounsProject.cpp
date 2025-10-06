#include<iostream>
using namespace std;

enum enQuizLevel{Easy =1, Mid =2, Hard = 3 , Mix = 4 };
enum enOpeType {Add = 1, Sub = 2, Mul = 3, Div = 4, mix = 5};
enum enResults { Pass = 1, Fail = 2};

struct stRoundInf {
	int QuizNumber = 0;
	enQuizLevel QuizLevel =Easy;
	enOpeType OpeType = Add;
	enResults Results = Pass;
};

struct stQuizResult {
	int QuizNumber = 0;
	int RightAnswers = 0;
	int WrongAnswers = 0;
	enQuizLevel QuizLevel = Easy;
	enOpeType OpeType = Add;

};
int RandomNumber(int From, int To) {
	int Number;
	Number = rand() % (To - From + 1) + From;
	return Number;

}

enQuizLevel QuizLevel() {
	short Level = 0;
	do {
		cout << "Enter Question Level [1]Easy, [2]Mid, [3]Hard, [4]Mix ? ";
		cin >> Level;
	} while (Level < 1 || Level>4);
	return (enQuizLevel)Level;
}
enOpeType OpeType() {
	short type = 0;
	do {
		cout << "Enter Operation Type [1]Add, [2]Sub, [3]Mul, [4]Div, [5]Mix ? ";
		cin >> type;
	} while (type < 1 || type>5);
	return (enOpeType)type;

}

int AnswerQuiz( enOpeType opeType, int Num1 , int Num2)
{
	cout << Num1 << endl;
	cout << Num2 <<" ";
	int yourAnswer = 0;

	if (opeType == enOpeType::mix) {
		opeType = (enOpeType)RandomNumber(1, 4);
	}

		if (opeType == Add) {
			cout << "+" << endl;
			cout << "-----------\n";
			cin >> yourAnswer;
			if (yourAnswer == (Num1 + Num2))
			{
				return 1;
			}
			else
				return Num1 + Num2;
		}
		if (opeType == Sub) {
			cout << "-" << endl;
			cout << "-----------\n";
			cin >> yourAnswer;
			if (yourAnswer == (Num1 - Num2))
			{
				return 1;
			}
			else
				return Num1 - Num2;
		}
		if (opeType == Mul) {
			cout << "*" << endl;
			cout << "-----------\n";
			cin >> yourAnswer;
			if (yourAnswer == (Num1 * Num2))
			{
				return 1;
			}
			else
				return Num1 * Num2;
		}
		if (opeType == Div) {
			cout << "/" << endl;
			cout << "-----------\n";
			cin >> yourAnswer;
			if (yourAnswer == (Num1 / Num2))
			{
				return 1;
			}
			else
				return Num1 / Num2;
		}
	return 1;
}
int DetermineLevelandType(enQuizLevel quizLevel,enOpeType type)
{
	int Result = 0;
	int Num1 = 0;
	int Num2 = 0;
	if (quizLevel == enQuizLevel::Mix) {
		quizLevel = (enQuizLevel)RandomNumber(1, 3);
	}

	
		if (quizLevel == Easy) {
			Num1 = RandomNumber(1, 10);
			Num2 = RandomNumber(1, 10);
			 Result = AnswerQuiz(type, Num1, Num2);
			if (Result == 1)
			{
				return 1;
			}
			else
			{
				return Result;
			}
		}
	
		if (quizLevel == Mid) {
			Num1 = RandomNumber(10, 50);
			Num2 = RandomNumber(10, 50);
			Result = AnswerQuiz(type, Num1, Num2);
			if (Result == 1)
			{
				return 1;
			}
			else
			{
				return Result;
			}
		}
	
		if (quizLevel == Hard) {
			Num1 = RandomNumber(50, 100);
			Num2 = RandomNumber(50, 100);
			Result = AnswerQuiz(type, Num1, Num2);
			if (Result == 1)
			{
				return 1;
			}
			else
			{
				return Result;
			}
		}
	
}
void GameResultsColor(enResults result , int Winner)
{
	if (result == Pass) {
		cout << "Right Answer:-)\n";
			system("color 2F");
	}
	if (result == Fail) {
		
		cout << "\a";
		system("color 4F");
		cout << "Wrong Answer:-(\n";
		cout << "The Right answer is: " << Winner << endl;
	}
}
stQuizResult FillResults(short quizNumbers ,enQuizLevel QLevel , enOpeType type , short wrong , short right ) {
	stQuizResult Results;
	Results.QuizNumber = quizNumbers;
	Results.QuizLevel = QLevel;
	Results.OpeType = type;
	Results.RightAnswers = right;
	Results.WrongAnswers = wrong;

	return Results;
}
stQuizResult QuizGame(int QuizNumbers) {
	stRoundInf RoundInfo;
	RoundInfo.QuizNumber = QuizNumbers;
	RoundInfo.QuizLevel = QuizLevel();
	RoundInfo.OpeType = OpeType();
	short RightAnswers = 0, WrongAnswers = 0;


	for (int QuizRound = 1; QuizRound <= QuizNumbers; QuizRound++) {
		cout << "Question[" << QuizRound << "/" << QuizNumbers << "]\n";
		int result = DetermineLevelandType(RoundInfo.QuizLevel , RoundInfo.OpeType);
		
		if (result ==1)
		{
			RightAnswers++;
			GameResultsColor(Pass, result);
		}
		else 
		{
			WrongAnswers++;
			GameResultsColor(Fail, result);
	
		}

	}
	return FillResults(QuizNumbers, RoundInfo.QuizLevel, RoundInfo.OpeType, WrongAnswers, RightAnswers);

}
short ReadHowManyRounds() {
	short QuizNumber;
	do {
		cout << "How Many Questions you want to answer? ";
		cin >> QuizNumber;

	} while (QuizNumber < 1);

	return QuizNumber;
}

void ResetScreen() {
	system("cls");
	system("color 0F");
}
string Type(enOpeType Type) {
	switch (Type)
	{
	case Add:
		return "Add";
		
	case Sub:
		return "Sub";
	case Mul:
		return "Mul";
	case Div:
		return "Div";
	case mix:
		return "Mix";
	default:
		break;
	}
}
string Level(enQuizLevel Level) {
	switch (Level)
	{
	case Easy:
		return "Easy";
	case Mid:
		return "Mid";
	case Hard:
		return "Hard";
	case Mix:
		return "Mix";
	default:
		break;
	}
}
string PassOrFail(short wrongAnswer, short rightAnswer) {
	if (rightAnswer > wrongAnswer)
		return "PASS";
	else
		return "FAIL";
}
void PrintFinalResult(stQuizResult Result) {
	cout << "\n------------------------\n";
	cout << "Final Result is " << PassOrFail(Result.WrongAnswers, Result.RightAnswers) << endl;
	cout << "\n------------------------\n";
	cout << "Number of Questions: " << Result.QuizNumber << endl;
	cout << "Questions Level    : " << Level(Result.QuizLevel) << endl;
	cout << "Operation Type     : " << Type(Result.OpeType) << endl;
	cout << "Number of Right answers: " << Result.RightAnswers << endl;
	cout << "Number of Wrong answers: " << Result.WrongAnswers << endl;

}
void StartQuiz() {
	char KeepPlaying = 'Y';
	do {
		ResetScreen();

		stQuizResult QuizResult =QuizGame(ReadHowManyRounds());
		PrintFinalResult(QuizResult);
		
		cout << "Do you want to play again: Yes[Y]:, No:[N] ?\n";
		cin >> KeepPlaying;
	} while (KeepPlaying == 'Y' || KeepPlaying == 'y');
}

int main() {
	srand((unsigned)time(NULL));

	StartQuiz();

}