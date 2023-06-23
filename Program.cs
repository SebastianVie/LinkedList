internal class Program
{
    private static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");

        LinkedIntList list = new LinkedIntList();
             list.Add(1);
             list.Add(2);
             list.Add(7);

             list.WriteInformation();

             Console.WriteLine("now insert at a position");

                list.AddAtPosition(12, 1);

             list.WriteInformation();
            Console.WriteLine("Getting size");

             int size = list.GetSize();
             Console.WriteLine(size);

             Console.WriteLine("now remove");
              list.Remove();

             list.RemoveValue(2);

             list.WriteInformation();

             Console.WriteLine("now clear");
             list.Clear();
             list.WriteInformation();

             Console.WriteLine("program finished");
    }
}

public class IntNode {

    public int Value;
    public IntNode Next;
}

public class LinkedIntList{
    private IntNode Head;
 
    public void Add(int value){
//at the beginning there is no node and head =null. Therefore we have to create the first node od the LL, assign it the value and appoint it head.
        if (Head == null){
            IntNode NewNode1 = new IntNode();
            NewNode1.Value = value;
            Head = NewNode1;
        }
//after creating the first node we have to create a new node that has to be linked to the previous node. To do so we first find the end of the LL by 
//using a while loop to go to the position before the null value
        else{
        IntNode node = Head;
        while (node.Next != null){
            node = node.Next;
        }
// now we create the ne node, assign the value given to it and link the last position in the LL to the new node.
        IntNode NewNode = new IntNode();
        NewNode.Value = value;
        node.Next = NewNode;}
    }
    public void AddAtPosition(int value, int position) {
// first I set the Head to the first node, then I create the new node and assign the given value to it
        IntNode node = Head;
        IntNode NewNode = new IntNode();
        NewNode.Value = value;
// now I create a new variable currentPos, that will be used in a while loop. The while loop will run until the end of the LL and increase the variable currentPos by 1.
// once we reach the given position -1(-1 because we want to implement the new one in the position behind, so the position of the current node), we first link the new Node
// to the node behind the current node and secondly the current node to the new node. The order of the steps is very important, because if we switch it, the part starting 
// the next node gets "lost".
        int currentPos = 0;
        while(node.Next != null){
            if (currentPos == position-1){
                NewNode.Next = node.Next;
                node.Next = NewNode;
            }
            node = node.Next;
            currentPos ++;
        return;
        }

    }
    public void Remove() {
// I am removing the last node
         IntNode node = Head;
// first we have to create a new variable that is called PreviousNode and is supposed to be the variable that is the position node-1
         IntNode PreviousNode = new IntNode();
         while(node.Next != null){
// now in the while loop we first set the new variable to the position f node and then increase node by 1. The order is important, otherwise both would have the same position
            PreviousNode = node;
            node = node.Next;
         }
// now I just link the previous node to null, the last one gets "lost"
         PreviousNode.Next = null;
    }
   public void RemoveValue(int value) {
// I start like in the remove funktion to remove the first value found
    IntNode node = Head;
    IntNode PreviousNode = new IntNode();
    //here it is important to not use while(node.Next != null), otherwise it would overlook the last node value
     while(node != null){
// but I stop the while loop when the value given is met and set the previous not to the next node. Like this the node in between is "removed"
        if(node.Value == value){
            PreviousNode.Next = node.Next;
            node = PreviousNode.Next;
            return;
        }
        PreviousNode = node;
        node = node.Next;
   }
   }
   public void Clear(){
    // I am setting head=0 so that we "delete" it. Since all the other nodes are linked, the linked list gets cleared)
     Head = null;

  }

    public bool Contains(int value){
// Here I will go through the LL and check if we can find the value. If we find it we return true to the demand. If not we return false
    IntNode node = Head;
     while(node.Next != null){
        if(node.Value == value){
            return true;}
        node= node.Next;
   }
   return false;
    }
    public int GetSize(){
// Here I first check if the LL has any value. If not I return 0 to the demand. In the main I could Write a string saying "It does not contain a value" if it returns 0.
    IntNode node = Head;
    if (Head == null){
        return 0;}
// if its not empty I use a counting function and return the size int variable to the demand. In the main I implemented a Console.WriteLine that prints the outcome
    else{
        int size = 0;
        while(node.Next != null){
        size ++;
        node = node.Next;
        }
//Console.WriteLine("The size of the Linked List is" + size);
    return size;
    }
   }
	public void WriteInformation(){
// here I create a while loop where I write every value, untill we rech the end of the LL
        IntNode node = Head;
        while (node != null)
        {   Console.WriteLine(node.Value);
            node = node.Next;
    }
    }
}