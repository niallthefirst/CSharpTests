using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetKthNode
{
    /// <summary>
    /// You have a linked list ↴ and want to find the kkth to last node.
    /// Write a function kth_to_last_node() that takes an integer kk and the head_node of a singly linked list, and returns the kkth to last node in the list.
    /// a = Node("Angel Food")
    /// b = Node("Bundt")
    /// c = Node("Cheese")
    /// d = Node("Devil's Food")
    /// e = Node("Eccles")
    /// 
    /// a.next = b
    /// b.next = c
    /// c.next = d
    /// d.next = e
    /// 
    /// kth_to_last_node(2, a)
    /// # returns the node with value "Devil's Food" (the 2nd to last node)
    /// </summary>
    public class GetKthNode
    {
        static LinkedList<Node> _list = new LinkedList<Node>();
        public static void Run()
        {
            var a = new Node("Angel Food");
            _list.AddFirst(a);
            var b = new Node("Bundt");
            _list.AddLast(b);
            var c = new Node("Cheese");
            _list.AddLast(c);
            var d = new Node("Devil's Food");
            _list.AddLast(d);
            var e = new Node("Eccles");
            _list.AddLast(e);
            
            
            kth_to_last_node(2, a);//returns the node with value "Devil's Food" (the 2nd to last node)
        }

        private static void kth_to_last_node(int p, object a)
        {
            var lastCount = _list.Count();
            Node result = _list.ElementAt(lastCount - p);
            var value = result.Value;
            Console.WriteLine(value);
        }

        
    }

    internal class Node
    {
        public string Value { get; private set; }
        public Node(string value)
        {
            Value = value;
        }


        
    }
}
