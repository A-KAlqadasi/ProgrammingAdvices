#include<iostream>
using namespace std;


class Node
{
public:
	int value;
	Node* next;
};


int main()
{
	Node* head;

	Node* Node1 ;
	Node* Node2 ;
	Node* Node3 ;

	

	// allocates 3 nodes in the heap 
	Node1 = new Node();
	Node2 = new Node();
	Node3 = new Node();

	// assign values 
	Node1->value = 1;
	Node2->value = 2;
	Node3->value = 3;

	// connect nodes 
	Node1->next = Node2;
	Node2->next = Node3;
	Node3->next = NULL;

	head = Node1;

	// print nodes 
	while (head != NULL)
	{
		cout << head->value << endl;
		head = head->next;
	}



	system("pause>0");
	return 0;
}