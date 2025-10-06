#include <iostream>
using namespace std;
#include<stack>

class Node
{
public:
	int value;
	Node* next;
};


Node* Find(Node* head, int value)
{
	while (head != NULL)
	{
		if (head->value == value)
			return head;
		head = head->next;
	}

	return NULL;
}

void PrintList(Node* head)
{
	cout << "\n";
	while (head != NULL)
	{
		cout << head->value << "  ";
		head = head->next;
	}
}

short CountList(Node* head)
{
	short counter = 0;
	while (head != NULL)
	{
		counter++;
		head = head->next;
	}
	return counter;
}

void InsertAtEnd2(Node*& head, int value)
{
	Node* new_node = new Node();

	new_node->value = value;
	new_node->next = NULL;


	if (head == NULL)
	{
		head = new_node;
		return;
	}

	Node* lastNode = head;

	while (lastNode->next != NULL)
	{
		lastNode = lastNode->next;
	}

	lastNode->next = new_node;
}

void InsertAtEnd(Node*& head, int value)
{
	Node* new_node = new Node();
	new_node->value = value;
	new_node->next = NULL;

	// if there is no nodes yet
	if (head == NULL)
	{
		head = new_node;
		return;
	}

	Node* lastNode = head;
	while (lastNode->next != NULL)
	{
		lastNode = lastNode->next;
	}

	lastNode->next = new_node;
	return;
}

void DivideLinkedList(Node* head, Node* node, Node*& part1, Node*& part2) {
	if (head == nullptr || node == nullptr) {
		return;
	}

	Node* temp = head;
	bool foundNode = false;

	// Traverse the list and divide it into left and right parts
	while (temp != nullptr) {
		if (temp == node) {
			foundNode = true;
		}

		if (!foundNode) {
			InsertAtEnd(part1, temp->value);
		}
		else {
			InsertAtEnd(part2, temp->value);
		}

		temp = temp->next;
	}
}

Node* GroupLinkedLists(Node* leftList, Node* rightList) {
	if (leftList == nullptr) {
		return rightList;
	}
	if (rightList == nullptr) {
		return leftList;
	}

	Node* temp = leftList;
	while (temp->next != nullptr) {
		temp = temp->next;
	}
	temp->next = rightList;

	return leftList;
}

void SmallestAndLargestValues(Node* head, int& smallest, int& largest) {
	if (head == nullptr) {
		return;
	}

	Node* temp = head;
	smallest = INT_MAX;
	largest = INT_MIN;

	while (temp != nullptr) {
		if (temp->value < smallest) {
			smallest = temp->value;
		}
		if (temp->value > largest) {
			largest = temp->value;
		}
		temp = temp->next;
	}
}

Node* ReverseLinkedList(Node* head) {
	if (head == nullptr) {
		return nullptr;
	}

	std::stack<Node*> nodeStack;
	Node* temp = head;

	// Push all nodes onto the stack
	while (temp != nullptr) {
		nodeStack.push(temp);
		temp = temp->next;
	}

	// Create a new head
	Node* newHead = nodeStack.top();
	temp = newHead;
	nodeStack.pop();

	// Pop nodes from the stack and update the next pointers
	while (!nodeStack.empty()) {
		temp->next = nodeStack.top();
		nodeStack.pop();
		temp = temp->next;
	}

	temp->next = nullptr; // Set the next pointer of the last node to nullptr

	return newHead;
}

int main()
{

	Node* head = NULL;
	Node* part2 = NULL;
	Node* part1 = NULL;

	InsertAtEnd(head, 1);
	InsertAtEnd(head, 2);
	InsertAtEnd(head, 3);
	InsertAtEnd(head, 4);
	InsertAtEnd(head, 5);
	InsertAtEnd(head, 6);

	cout << "\nlinked list elements:\n";

	PrintList(head);

	Node* N1 = Find(head, 4);

	DivideLinkedList(head, N1, part1, part2);

	cout << "\nleft part:\n";
	PrintList(part1);

	cout << "\nright part:\n";
	PrintList(part2);

	Node* N2 = GroupLinkedLists(part1, part2);

	cout << "\n\nmerege them again:\n";
	PrintList(N2);

	cout << "\n\nNumber of nodes in linked list: ";
	cout << CountList(N2) << endl;

	int smallest, largest;
	SmallestAndLargestValues(N2, smallest, largest);
	cout << "\nsmallest value in linked list: " << smallest << endl;
	cout << "\nlargest value in linked list: " << largest << endl;

	Node* newHead = ReverseLinkedList(N2);

	cout << "\n\nLinked list in reserve order:\n";
	PrintList(newHead);

	system("pause>0");
	return 0;
}