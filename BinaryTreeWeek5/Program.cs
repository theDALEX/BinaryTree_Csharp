using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeWeek5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node<int> rootnode = new Node<int>(10);
            Node<int> leftnode = new Node<int>(45);
            Node<int> rightnode = new Node<int>(90);

            rootnode.Left = leftnode;
            rootnode.Right = rightnode;

            BinaryTree<int> mytree = new BinaryTree<int>(rootnode);

            string buffer = "";
            mytree.InOrder(ref buffer);
            Console.WriteLine("The Items in the tree useing InOrder is:{0}", buffer);
            Console.ReadKey();
        }
    }
}
