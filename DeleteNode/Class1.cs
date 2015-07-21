using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteNode
{
    /// <summary>
    /// Delete a node from a singly-linked list ↴ , given only a variable pointing to that node.
    /// The input could, for example, be the variable b below:
    /// a = Node('A')
    /// b = Node('B')
    /// c = Node('C')
    /// 
    /// a.next = b
    /// b.next = c
    /// 
    /// delete_node(b)
    /// </summary>
    public class NodeManager
    {
        internal static LinkedList<char> _nodes = new LinkedList<char>();

        public static NodeManager Instance()
        {
            NodeManager nodeManager = new NodeManager();
            NodeManager._nodes.AddLast('A');
            NodeManager._nodes.AddLast('B');
            NodeManager._nodes.AddLast('C');

            return nodeManager;
        }

        public bool DeleteNode(Node node)
        {
            bool result = false;

            if (NodeManager._nodes.Contains(node.Value))
            {
                
                NodeManager._nodes.Remove(node.Value);
                return true;
            }
            return result;
        }
    }

    public class Node
    {
        public char Value { get; set; }    
    }


}
