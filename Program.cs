using LinkedList;

namespace LinkedLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList linkedList = new DoublyLinkedList();
            linkedList.InsertFirst(1);
            linkedList.InsertFirst(2);
            linkedList.InsertFirst(4);
            linkedList.InsertFirst(5);
            linkedList.InsertFirst(8);

            linkedList.DeleteFirst();
            linkedList.DeleteFirst();

            linkedList.InsertLast(32);

            linkedList.InsertLast(42);

            linkedList.DisplayList();


        }
    }
}
