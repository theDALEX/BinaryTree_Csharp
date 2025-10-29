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

            //test
            //rootnode.Left.Left = new Node<int>(41);
            //rootnode.Left.Right = new Node<int>(13);

            BinaryTree<int> mytree = new BinaryTree<int>(rootnode);

            string buffer = "";
            mytree.InOrder(ref buffer);
            Console.WriteLine("The Items in the tree useing InOrder is:{0}", buffer);

            string buffer01 = "";
            mytree.PreOrder(ref buffer01);
            Console.WriteLine("The Items in the tree useing PreOrder is:{0}", buffer01);

            string buffer02 = "";
            mytree.PostOrder(ref buffer02);
            Console.WriteLine("The Items in the tree useing PostOrder is:{0}", buffer02);
            Console.ReadKey();
        }
    }
}
