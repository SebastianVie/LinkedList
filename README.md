# Linked Integer List in C#
This repository contains an implementation of a singly linked list data structure for storing integer values. The linked list is implemented in C#.

Code Structure
The code contains three classes: Program, IntNode, and LinkedIntList.

Program: This is the entry point for the program where the LinkedIntList is being tested with various operations.

IntNode: This class represents a node in the linked list. Each IntNode contains an integer value and a reference to the next IntNode in the list.

LinkedIntList: This class implements the linked list and provides several methods for manipulating the list, such as adding and removing elements.

Linked List Operations
The LinkedIntList provides the following operations:

Add(int value): Adds a new integer to the end of the list.

AddAtPosition(int value, int position): Inserts a new integer at a specific position in the list. Positions start at 0 (head of the list).

Remove(): Removes the last element from the list. If the list is empty, no action is performed.

RemoveValue(int value): Searches for the first occurrence of the provided value and removes it from the list. If the value is not found, no action is performed.

Clear(): Clears all elements from the list, making it an empty list.

Contains(int value): Checks if the list contains the provided integer value. Returns true if the value is found, false otherwise.

GetSize(): Returns the number of elements currently in the list.

WriteInformation(): Prints all elements in the list to the console.

Usage Example
Here is a basic example of using the LinkedIntList:

csharp
Copy code
LinkedIntList list = new LinkedIntList();
list.Add(1);
list.Add(2);
list.Add(7);

list.WriteInformation();  // Prints: 1, 2, 7

list.AddAtPosition(12, 1);
list.WriteInformation();  // Prints: 1, 12, 2, 7

int size = list.GetSize();
Console.WriteLine(size);  // Prints: 4

list.Remove();
list.WriteInformation();  // Prints: 1, 12, 2

list.RemoveValue(2);
list.WriteInformation();  // Prints: 1, 12

list.Clear();
list.WriteInformation();  // Prints nothing
This Linked List implementation aims to provide a simple and intuitive way of handling a singly linked list in C#. It is perfect for educational purposes as well as to be used in larger projects. Feel free to clone, explore and experiment with the code!
