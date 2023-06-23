# Linked List Implementation in C#

This repository contains a simple, but powerful implementation of a singly Linked List in C#.

## Features

### IntNode Class

This class represents a node in the Linked List. Each node has an integer value and a reference to the next node in the list.

### LinkedIntList Class

This class provides the functionality for the Linked List. Below are its methods:

- `Add(int value)`: This method allows you to add a new node with a specified value to the end of the list.

- `AddAtPosition(int value, int position)`: This method allows you to add a new node with a specified value at a specific position in the list.

- `Remove()`: This method removes the last node from the list.

- `RemoveValue(int value)`: This method removes the first node in the list with the specified value.

- `Clear()`: This method clears the list by setting the head to null.

- `Contains(int value)`: This method checks if the list contains a node with the specified value.

- `GetSize()`: This method returns the size of the list (i.e., the number of nodes).

- `WriteInformation()`: This method prints out all the values in the list.

## Usage

To use this Linked List implementation, you just need to create an instance of the `LinkedIntList` class. Then, you can call its methods to manipulate the list.

```csharp
LinkedIntList list = new LinkedIntList();
list.Add(1);
list.Add(2);
list.Add(7);
list.WriteInformation();

This will create a linked list with the values 1, 2, and 7, and then print those values.

You can then insert a new value at a specific position:
list.AddAtPosition(12, 1);
list.WriteInformation();

This inserts the value 12 at the second position of the list and then prints the updated list.

You can also remove nodes from the list:
list.Remove();
list.RemoveValue(2);
list.WriteInformation();

This removes the last node from the list, removes the first node with the value 2, and then prints the updated list.

You can clear the entire list as follows:
list.Clear();
list.WriteInformation();

This will clear the list and then try to print the list (which will now be empty).

Finally, you can retrieve the size of the list:
int size = list.GetSize();
Console.WriteLine(size);

This will print the size of the list.

##Creator
Sebastian Viehhofer
