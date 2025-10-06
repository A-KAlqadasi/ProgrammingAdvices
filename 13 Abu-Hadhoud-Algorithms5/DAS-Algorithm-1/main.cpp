#include <iostream>
#include "clsQueueLine.h"

using namespace std;

int main()
{
    clsQueueLine PayBillsQueue("A0", 10);
    clsQueueLine SubscribtionsQueue("B0", 5);
    
    PayBillsQueue.IssueTicket();
    PayBillsQueue.IssueTicket();
    PayBillsQueue.IssueTicket();
    PayBillsQueue.IssueTicket();
    PayBillsQueue.IssueTicket();

    cout << "\nPay Bills Queue info:\n";
    PayBillsQueue.PrintInfo();

    PayBillsQueue.PrintTicketsLineRTL();
    PayBillsQueue.PrintTicketsLineLTR();
    
    PayBillsQueue.PrintAllTickets();

    PayBillsQueue.ServeNextClient();
    PayBillsQueue.ServeNextClient();

    cout << "Pay bills queue after serving two client:\n";
    PayBillsQueue.PrintInfo();
    PayBillsQueue.PrintAllTickets();


    cout << "\n\nSubscribtions Bills Queue info:\n";
    SubscribtionsQueue.IssueTicket();
    SubscribtionsQueue.IssueTicket();
    SubscribtionsQueue.IssueTicket();
    SubscribtionsQueue.IssueTicket();

    SubscribtionsQueue.PrintInfo();

    SubscribtionsQueue.PrintTicketsLineRTL();
    SubscribtionsQueue.PrintTicketsLineLTR();

    SubscribtionsQueue.PrintAllTickets();


    system("pause>0");
    return 0;
}