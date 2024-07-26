namespace LinkedLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node nodeA = new Node();
            nodeA.Data = 335;
            Node nodeB = new Node();
            nodeB.Data = 989;
            Node nodeC = new Node();
            nodeC.Data = 322;
            Node nodeD = new Node();
            nodeD.Data = 555;

            nodeA.Next = nodeB;
            nodeB.Next = nodeC;
            nodeC.Next = nodeD;
        }
    }
}
