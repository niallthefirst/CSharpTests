using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTests.Associations
{
    /// <summary>
    /// Manager is an employee of XYZ limited corporation - Inheritance, "is a".
    /// Manager uses a swipe card to enter XYZ premises - Association, some method parameter, "uses a".
    /// Manager has workers who work under him - Aggregation - member variable, "has a".
    /// Manager has the responsibility of ensuring that the project is successful - Association, some method parameter, "uses a".
    /// Manager's salary will be judged based on project success - Composition, constructor parameter/member variable, "depends on".
    /// </summary>
    static class Associations
    {
        internal static void Run()
        {
            
            Manager manager = new Manager();//manager has a project. Manager creates the project. Manager depends on a project. Composition.
                                            
            manager.HowisTheManager(true);
            Console.WriteLine("Salary is " + manager._salary);
        }
        
    
    }



    public class Manager
    {
        public Project _project;
        public List<Worker> _workers = new List<Worker>();//has a. Aggregation.
        public double _salary;
        
        public Manager()
        {
            _project = new Project(this);//depends on. Composition. 
        }
        // Aggregation relation
        
        public void Logon(SwipeCard obj)//uses a . Association.
        {
            obj.Swipe(this);
        }
        public string GetManagerName()
        {
            return "Shiv";
        }
        

        public void HowisTheManager(bool Good)
        {
            if (Good)
            {
                _project.Issuccess = true;
            }
            else
            {
                _project.Issuccess = false;
            }
        }
    }

    public class SwipeCard
    {

        public void Swipe(Manager obj)
        {
            // goes and swipes the manager
        }
        public string MakeofSwipecard()
        {
            return "c001";
        }
    }

    public class Worker
    {
        public string WorkerName = "";
    }
    public class Project
    {
        private Manager _manager;
        private bool _isSuccess = false;

        public bool Issuccess
        {
            get { return _isSuccess; }
            set
            {
                _isSuccess = value;
                if (value)
                {
                    _manager._salary++;
                }
                else
                {
                    _manager._salary--;
                }
            }
        }

        public Project(Manager obj)
        {
            _manager = obj;//has a. Association. Project has a manager but does not create the manager.
        }
    }
}
