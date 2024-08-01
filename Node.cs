using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class Node
    {
        public int Data { get; set; }
        public Node? Next { get; set; }
        /// <summary>
        /// This should only be used with Doubly Linked List
        /// </summary>
        public Node? Previous { get; set; }

        public void DisplayNode()
        {
            Console.WriteLine(Data);
        }
    }
}