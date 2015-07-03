using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTests
{
    
    /// <summary>
    ///Exercise: By using C# objected-oriented concept, create a singly linked list.
    ///The singly linked list is a chain of its item. Each item contain two parts--data and a link. 
    ///The data part is to store information and the link part of an item is used to point or to store the address of the next item. 
    /// </summary>
    public class LinkedListMenu
    {
        private LinkedList<Pairs> items = new LinkedList<Pairs>();

        public void Chain() { 
        }

        public void Add(Pairs pair)
        {
            items.AddFirst(pair);
        }

        public void Add(StoreInformation data, StoreInformation link)
        {
            items.AddFirst(new Pairs(data, link));
        }

    }

    public class Pairs
    {
        StoreInformation _data;
        StoreInformation _link;

        public Pairs(StoreInformation data, StoreInformation link)
        {
            _data = data;
            _link = link;
        }
    }

    public class StoreInformation
    {
        string _name;

        public string Name
        {
            get { return _name; }
           
        }
        public StoreInformation(string name)
        {
            _name = name;
        }
    }
}
